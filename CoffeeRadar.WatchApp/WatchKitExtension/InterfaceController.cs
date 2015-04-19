using System;
using System.Linq;
using WatchKit;
using Foundation;
using CoffeeRadar.Services;
using CoffeeRadar.Core.Services;
using CoffeeRadar.Core.Models;
using System.Threading.Tasks;
using CoreLocation;
using MapKit;

namespace WatchKitExtension
{
	public partial class InterfaceController : WKInterfaceController
	{
		private MKCoordinateSpan _mapSpan;
		private MKCoordinateRegion _mapRegion;

		public InterfaceController (IntPtr handle) : base (handle)
		{
			_mapSpan = new MKCoordinateSpan (1.0, 1.0);
		}

		public override async void Awake (NSObject context)
		{
			base.Awake (context);

			// Configure interface objects here.

			// Add context menu items
			AddMenuItem (WKMenuItemIcon.Repeat, "Refresh", new ObjCRuntime.Selector ("refresh_tapped"));
			AddMenuItem (WKMenuItemIcon.Resume, "Next Closest", new ObjCRuntime.Selector ("next_tapped"));

			await Refresh ();
		}

		public override void WillActivate ()
		{
			// This method is called when the watch view controller is about to be visible to the user.
		}

		public override void DidDeactivate ()
		{
			// This method is called when the watch view controller is no longer visible to the user.
		}

		private async Task Refresh()
		{
			lblDistance.SetText ("searching...");
			lblVenue.SetText ("");

			// Get current location
			var locationService = new LocationService();
			var coords = await locationService.GetGeoCoordinatesAsync ();

			RefreshMap(new CLLocationCoordinate2D(coords.Latitude, coords.Longitude));

			// Find some coffee venues 
			var foursquareService = new FoursquareService ();
			var results = await foursquareService.GetVenues ("coffee", coords);

			// Determine the closest venue
			Venue closest = null;
			if (results.Venues.Count > 0) {
				var ordered = from v in results.Venues
				              orderby v.Address.Distance
				              select v;

				closest = ordered.FirstOrDefault ();

				if (closest != null) {
					lblDistance.SetText (closest.Address.Distance + " meters away");
					lblVenue.SetText (closest.Name);

					AddMapPin(new CLLocationCoordinate2D(closest.Address.Latitude, closest.Address.Longitude));

				} else {
					lblDistance.SetText ("None :(");
					lblVenue.SetText ("");
				}
			} else {
				lblDistance.SetText ("None :(");
				lblVenue.SetText ("");
			}
		}

		private void RefreshMap(CLLocationCoordinate2D centerCoords)
		{
			_mapRegion = new MKCoordinateRegion (centerCoords, _mapSpan);

			var center = MKMapPoint.FromCoordinate (centerCoords);

			map.SetVisible(new MKMapRect(center.X, center.Y, _mapSpan.LatitudeDelta, _mapSpan.LongitudeDelta));

			map.SetRegion (_mapRegion);

			map.AddAnnotation (centerCoords, WKInterfaceMapPinColor.Green);
		}

		private void AddMapPin(CLLocationCoordinate2D coords)
		{
			map.AddAnnotation (coords, WKInterfaceMapPinColor.Red);
		}

		partial void btnZoomIn_Activated (WKInterfaceButton sender)
		{
			var span = new MKCoordinateSpan (_mapSpan.LatitudeDelta * 0.5f, _mapSpan.LongitudeDelta * 0.5f);
			var region = new MKCoordinateRegion (_mapRegion.Center, span);

			_mapSpan = span;
			map.SetRegion (region);
		}

		partial void btnZoomOut_Activated (WKInterfaceButton sender)
		{
			var span = new MKCoordinateSpan (_mapSpan.LatitudeDelta * 2, _mapSpan.LongitudeDelta * 2);
			var region = new MKCoordinateRegion (_mapRegion.Center, span);

			_mapSpan = span;
			map.SetRegion (region);
		}

		#region Context menu tapped handlers
		[Export("refresh_tapped")]
		private async void RefreshMenuItemTapped()
		{
			await Refresh ();
		}

		[Export("next_tapped")]
		private void NextMenuItemTapped()
		{
			// TODO: Add ability to see the next closest venue
		}
		#endregion

		public override void HandleRemoteNotificationAction (string identifier, NSDictionary remoteNotification)
		{
			PushController ("notificationResponseController", (NSString)identifier);
		}
	}
}

