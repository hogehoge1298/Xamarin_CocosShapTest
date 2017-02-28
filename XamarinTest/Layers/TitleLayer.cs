using CocosSharp;

namespace XamarinTest
{
    class TitleLayer : CCLayerColor
    {
        public TitleLayer() : base() { }

        protected override void AddedToScene()
        {
            base.AddedToScene();

            //タイトル画像を配置
            var title = new CCSprite("/Resources/Images/Background/Title/Title.png");
            title.Position = new CCPoint(this.ContentSize.Center.X, this.ContentSize.Center.Y);
            AddChild(title);
        }
    }
}
