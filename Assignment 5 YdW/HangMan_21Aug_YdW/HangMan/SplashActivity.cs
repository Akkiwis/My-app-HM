namespace SplashScreen
{
    using System.Threading;

    using Android.App;
    using Android.OS;
    using HangMan;

    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Thread.Sleep(2500); // Simulate a long loading process on app startup.
            StartActivity(typeof(MainActivity));
        }
    }
}