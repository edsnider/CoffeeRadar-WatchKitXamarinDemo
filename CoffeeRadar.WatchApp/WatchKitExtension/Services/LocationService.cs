using CoffeeRadar.Core.Services;
using System.Threading.Tasks;
using Xamarin.Geolocation;
using CoffeeRadar.Core.Models;
using System;

namespace CoffeeRadar.Services
{
	public class LocationService : ILocationService
	{
		public LocationService ()
		{
		}

		#region ILocationService implementation

		public async Task<CoffeeRadar.Core.Models.GeoCoords> GetGeoCoordinatesAsync ()
		{
			try
			{
				var locator = new Geolocator() {DesiredAccuracy = 30};
				var position = await locator.GetPositionAsync(30000);

				var result = new GeoCoords
				{
					Latitude = position.Latitude,
					Longitude = position.Longitude
				};

				return result;
			}
			catch (Exception e) 
			{

			}

			return null;
		}

		#endregion
	}
}

