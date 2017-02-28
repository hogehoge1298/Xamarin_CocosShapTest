using System;
using CocosDenshion;
using CocosSharp;
using System.Collections.Generic;

namespace XamarinTest
{
    public class XamalinTestApplicationDelegate
    {
        public static void LoadGame(object sender, EventArgs e)
        {
            var gameView = sender as CCGameView;
            if(gameView == null) { return; }

            //デザイン改造と
            gameView.DesignResolution = new CCSizeI(224, 380);
            gameView.ResolutionPolicy = CCViewResolutionPolicy.ShowAll;

            //コンテンツパス設定
            var contentSearchPaths = new List<string>() { "Images", "Sounds" };
            gameView.ContentManager.SearchPaths = contentSearchPaths;

            //タイトル画面のシーン作成、セット
            var gameScene = new CCScene(gameView);
            gameScene.AddLayer(new TitleLayer());

            //ゲーム開始
            gameView.RunWithScene(gameScene);
        }

    }
}
