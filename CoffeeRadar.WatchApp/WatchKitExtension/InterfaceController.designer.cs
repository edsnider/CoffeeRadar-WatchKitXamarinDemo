// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WatchKitExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		WatchKit.WKInterfaceButton btnNext { get; set; }

		[Outlet]
		WatchKit.WKInterfaceButton btnRefresh { get; set; }

		[Outlet]
		WatchKit.WKInterfaceLabel lblDistance { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton btnZoomIn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton btnZoomOut { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel lblVenue { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceMap map { get; set; }

		[Action ("btnZoomIn_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnZoomIn_Activated (WatchKit.WKInterfaceButton sender);

		[Action ("btnZoomOut_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnZoomOut_Activated (WatchKit.WKInterfaceButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnZoomIn != null) {
				btnZoomIn.Dispose ();
				btnZoomIn = null;
			}
			if (btnZoomOut != null) {
				btnZoomOut.Dispose ();
				btnZoomOut = null;
			}
			if (lblVenue != null) {
				lblVenue.Dispose ();
				lblVenue = null;
			}
			if (map != null) {
				map.Dispose ();
				map = null;
			}
		}
	}
}
