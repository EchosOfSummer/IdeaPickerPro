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
            ForegroundColor = UIColor.Cyan
        };

        //Tab bar style
        UITabBar.Appearance.BackgroundColor = UIColor.Black;
        UITabBar.Appearance.TintColor = UIColor.Cyan;
        UITabBar.Appearance.UnselectedItemTintColor = UIColor.Cyan;

        var attributes = new UIStringAttributes
        {
            Font = UIFont.SystemFontOfSize(18,UIFontWeight.Bold)
        };
        UITabBarItem.Appearance.SetTitleTextAttributes(attributes, UIControlState.Normal);

        var selectedAttributes = new UIStringAttributes
        {
            Font = UIFont.SystemFontOfSize(24, UIFontWeight.Bold),
            ForegroundColor = UIColor.Red
        };
        UITabBarItem.Appearance.SetTitleTextAttributes(selectedAttributes, UIControlState.Selected);
        
        return base.FinishedLaunching(app, options);
    }
}