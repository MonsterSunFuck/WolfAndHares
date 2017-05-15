namespace test_four
{
    using System.Drawing;

    public class Rabbit : IGameObject
    {
        public Rabbit()
        {
            Image = new Bitmap("Icons/rabbit.png");
        }

        public Image Image { get; private set; }
    }
}