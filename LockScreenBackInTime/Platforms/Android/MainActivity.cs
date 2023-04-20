using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace LockScreenBackInTime;
[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, Label = "LockScreen",
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize, ScreenOrientation = ScreenOrientation.Portrait)]
public class MainActivity : MauiAppCompatActivity
{

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Platform.Init(this, savedInstanceState);
        this.Window.AddFlags(WindowManagerFlags.Fullscreen);
    }
}


