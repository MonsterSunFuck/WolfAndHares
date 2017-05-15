namespace WolfAndHares.BL.GameObjects
{
    using System.Drawing;

    public class Carrot : GameObject
    {
        public Carrot()
        {
            Image = new Bitmap("Content/field/carrot.png");
        }

        public override Image Image { get; }
    }
}