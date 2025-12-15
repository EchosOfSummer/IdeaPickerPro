using UIKit;
using Foundation;

namespace IdeaPickerPro;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    //
    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
        // Nave bar style (page titles
        UINavigationBar.Appearance.BackgroundColor = UIColor.Black;
        UINavigationBar.Appearance.TintColor = UIColor.Cyan;
        UINavigationBar.Appearance.TitleTextAttributes = new UIStringAttributes
        {
            ForegroundColor = UIColor.White
        };

        //Tab bar style
        UITabBar.Appearance.BackgroundColor = UIColor.Black;
        UITabBar.Appearance.TintColor = UIColor.Cyan;
        UITabBar.Appearance.UnselectedItemTintColor = UIColor.LightGray;
        
        return base.FinishedLaunching(app, options);
    }
}