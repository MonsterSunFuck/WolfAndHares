namespace WolfAndHares.Controls
{
    using System.Drawing;

    public partial class AboutScreen : BaseWolfAndHaresControl
    {
        public AboutScreen()
        {
            InitializeComponent();
        }

        public override void SetFont(Font font)
        {
            base.SetFont(font);

            lblAbout.Font = btnOk.Font = font;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Hide();
        }
    }
}
