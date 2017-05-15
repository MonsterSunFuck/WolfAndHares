namespace WolfAndHares.Controls
{
    using System;
    using System.Drawing;

    public partial class FullWinScreen : BaseWolfAndHaresControl
    {
        public FullWinScreen()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, System.EventArgs e)
        {
            InvokeExternalDelegate(nameof(MainMenuClick), sender, e);
        }

        public event EventHandler MainMenuClick
        {
            add
            {
                Events.AddHandler(nameof(MainMenuClick), value);
            }
            remove
            {
                Events.RemoveHandler(nameof(MainMenuClick), value);
            }
        }

        public override void SetFont(Font font)
        {
            base.SetFont(font);

            btnMainMenu.Font = lblPoint.Font = font;
        }

        public void Show(int point)
        {
            lblPoint.Text = point.ToString();
            Show();
        }
    }
}
