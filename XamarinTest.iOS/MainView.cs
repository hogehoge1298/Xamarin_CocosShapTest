using CocosSharp;
using XamarinTest;
using UIKit;
using CoreGraphics;

namespace XamarinTest.iOS
{
    class MainView : UIViewController
    {
        CCGameView GameView { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            GameView = new CCGameView(new CGRect(0, 20,
                                    UIScreen.MainScreen.ApplicationFrame.Width,
                                    UIScreen.MainScreen.ApplicationFrame.Height));

            GameView.ViewCreated += XamalinTestApplicationDelegate.LoadGame;
            View.AddSubview(GameView);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            if(GameView != null)
            {
                GameView.Paused = true;
            }
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            if (GameView != null)
                GameView.Paused = false;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}