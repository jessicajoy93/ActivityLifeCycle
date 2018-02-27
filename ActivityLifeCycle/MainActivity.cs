using Android.App;
using Android.Widget;
using Android.OS;

namespace ActivityLifeCycle
{
    [Activity(Label = "ActivityLifeCycle", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Toast.MakeText(this, "On Create", ToastLength.Short).Show();
        }

        protected override void OnStart()
        {
            base.OnStart();
            Toast.MakeText(this, "On Start", ToastLength.Short).Show();
        }

        protected override void OnRestart()
        {
            base.OnStart();
            Toast.MakeText(this, "On Restart", ToastLength.Short).Show();
        }

        protected override void OnPause()
        {
            base.OnStart();
            Toast.MakeText(this, "On Pause", ToastLength.Short).Show();
        }

        protected override void OnStop()
        {
            base.OnStart();
            Toast.MakeText(this, "On Stop", ToastLength.Short).Show();
        }

        protected override void OnDestroy()
        {
            base.OnStart();
            Toast.MakeText(this, "On Destroy", ToastLength.Short).Show();
        }
    }
}

