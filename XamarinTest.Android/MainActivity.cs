using Android.App;
using Android.Content.PM;
using Android.Widget;
using Android.OS;
using Android.Views;
using CocosSharp;
using XamarinTest;

namespace XamarinTest.Android
{
    [Activity(Label = "XamarinTest.Android"
                    , MainLauncher = true
                    , Icon = "@drawable/icon"
                    , AlwaysRetainTaskState = true
                    , LaunchMode =LaunchMode.SingleInstance
                    , ConfigurationChanges =ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden
    )]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //タイトルを非表示にする
            RequestWindowFeature(WindowFeatures.NoTitle);

            var linerLayout = new LinearLayout(this)
            {
                Orientation = Orientation.Vertical
            };

            //ゲーム表示用コントロール作成
            var gameView = new CCGameView(this);

            //ゲーム起動
            if(gameView != null)
            {
                gameView.ViewCreated += XamalinTestApplicationDelegate.LoadGame;
            }

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

