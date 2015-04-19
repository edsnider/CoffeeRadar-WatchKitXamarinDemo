using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WatchKitExtension
{
	partial class NotificationResponseController : WatchKit.WKInterfaceController
	{
		public NotificationResponseController (IntPtr handle) : base (handle)
		{
		}

		public override void Awake (NSObject context)
		{
			string responseAction = context as NSString;

			if (responseAction.Contains ("no"))
				lblResponseMsg.SetText ("Sorry you didn't like that coffee venue");
			else if (responseAction.Contains ("yes"))
				lblResponseMsg.SetText ("Awesome, we'll keep it on the Radar!");
		}
	}
}
