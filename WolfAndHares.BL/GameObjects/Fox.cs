namespace WolfAndHares.BL.GameObjects
{
    using System.Drawing;

    public class Fox : GameObject
    {
        public Fox()
        {
            Image = new Bitmap("Content/field/fox.png");
        }

        public override Image Image { get; }
    }
}