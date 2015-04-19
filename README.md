# CoffeeRadar-WatchKitXamarinDemo
======================
This is the demo WatchKit app I built as *part* of my Apple Watch talks at the [NoVA Mobile C# Dev Group on 4/8/15](http://www.meetup.com/novamobiledev/events/220913256/) and [NoVA Spring 2015 CodeCamp on 4/18/15](http://www.novacodecamp.org)

**Ed Snider** [@edsnider](http://www.twitter.com/edsnider) | [www.edsnider.net](http://www.edsnider.net)

###About this demo app
This is a very simple app that shows how to use Xamarin and C# to build WatchKit apps.  The app uses your current location to show you the closet coffee shop to you.  
The app demonstrates the following WatchKit app dev concepts:

- Using [Xamarin's support for WatchKit](http://developer.xamarin.com/guides/ios/watch/)
- Using WatchKit extensions
- Using the interface builder in Xamarin Studio and/or Xcode to build the WatchKit app storyboard
- Using the Watchkit Map control
- Using a Context Menu
- Using the Xamarin.Mobile component with WatchKit extensions
- Using System.Net.Http to get data from an API - the [Foursquare Venues Search API](https://developer.foursquare.com/docs/venues/search) was used in this demo
- Updating the WatchKit app UI from the WatchKit extension view controllers
- Using a sample notification JSON payload to test the WatchKit notification controller functionality

![](https://raw.githubusercontent.com/edsnider/CoffeeRadar-WatchKitXamarinDemo/master/Screenshots/coffeeradar_mainscreen.png)
![](https://raw.githubusercontent.com/edsnider/CoffeeRadar-WatchKitXamarinDemo/master/Screenshots/coffeeradar_contextmenu.png)

###Running the code
If you want to download or fork this code you'll need to get a Foursquare API Client ID and Client Secret and drop them into the `CoffeeRadar.Core.Services.FoursquareService` class.  You can get what you need here: [https://developer.foursquare.com/start](https://developer.foursquare.com/start). ####Apple Watch Simulator
In order to run the WatchKit app in the iOS simulator you must set the WatchKit extension project as the start up project and use an iPhone 5 or greater simulator.  To see the Apple Watch simulator, select it from the **Hardware > Extneral Displays** iOS Simulator menu.####Debugging Notifications
In order to test the notification controller functionality in the iOS simulator you need to run with custom parameters and supply the sample JSON payload.  In order to do this, simply select **Run > Run With > Custom Parameters** and then to to the WatchKit tab and select "Notification" in the Watch Interface dropdown and select your the sample JSON payload (there is one provided in the WatchKit extension project of this demo app).========
Apple Watch frame via [http://infinitapps.com/bezel/](http://infinitapps.com/bezel/)