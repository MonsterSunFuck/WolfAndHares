namespace WolfAndHares.BL.GameObjects
{
    using System.Drawing;

    public class Wolf : GameObject
    {
        public Wolf()
        {
            PickUpCarrot();
        }

        private Image _image;

        public override Image Image => _image;

        public void GiveCarrot()
        {
            _image = new Bitmap("Content/field/wolf_with_carrot.png");
        }

        public void PickUpCarrot()
        {
            _image = new Bitmap("Content/field/wolf.png");
        }
    }
}