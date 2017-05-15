namespace WolfAndHares.BL.GameObjects
{
    using System.Drawing;

    public class Glade : GameObject
    {
        public Glade()
        {
            Image = null;
            // Image = new Bitmap("Content/glade.png");
        }

        public override Image Image { get; }
    }
}