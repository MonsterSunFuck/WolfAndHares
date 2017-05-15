using System;

namespace WolfAndHares.Controls
{
    using System.Drawing;

    public partial class LoseScreen : BaseWolfAndHaresControl
    {
        public LoseScreen()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            InvokeExternalDelegate(nameof(RestartClick), sender, e);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            InvokeExternalDelegate(nameof(MainMenuClick), sender, e);
        }

        private void btnSelectLevel_Click(object sender, EventArgs e)
        {
            InvokeExternalDelegate(nameof(SelectLevelClick), sender, e);
        }

        public override void SetFont(Font font)
        {
            base.SetFont(font);

            btnSelectLevel.Font = btnMainMenu.Font = btnRestart.Font = font;
        }

        public event EventHandler RestartClick
        {
            add
            {
                Events.AddHandler(nameof(RestartClick), value);
            }
            remove
            {
                Events.RemoveHandler(nameof(RestartClick), value);
            }
        }

        public event EventHandler SelectLevelClick
        {
            add
            {
                Events.AddHandler(nameof(SelectLevelClick), value);
            }
            remove
            {
                Events.RemoveHandler(nameof(SelectLevelClick), value);
            }
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
    }
}
