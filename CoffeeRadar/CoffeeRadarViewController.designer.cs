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

namespace CoffeeRadar
{
	[Register ("CoffeeRadarViewController")]
	partial class CoffeeRadarViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblDistance { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblVenue { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblDistance != null) {
				lblDistance.Dispose ();
				lblDistance = null;
			}
			if (lblVenue != null) {
				lblVenue.Dispose ();
				lblVenue = null;
			}
		}
	}
}
