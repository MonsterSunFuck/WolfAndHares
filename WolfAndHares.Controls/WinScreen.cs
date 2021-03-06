﻿namespace WolfAndHares.Controls
{
    using System;
    using System.Drawing;

    public partial class WinScreen : BaseWolfAndHaresControl
    {
        public WinScreen()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, System.EventArgs e)
        {
            InvokeExternalDelegate(nameof(ContinueClick), sender, e);
        }

        private void btnRestart_Click(object sender, System.EventArgs e)
        {
            InvokeExternalDelegate(nameof(RestartClick), sender, e);
        }

        private void btnSelectLevel_Click(object sender, System.EventArgs e)
        {
            InvokeExternalDelegate(nameof(SelectLevelClick), sender, e);
        }

        private void btnMainMenu_Click(object sender, System.EventArgs e)
        {
            InvokeExternalDelegate(nameof(MainMenuClick), sender, e);
        }

        public event EventHandler ContinueClick
        {
            add
            {
                Events.AddHandler(nameof(ContinueClick), value);
            }
            remove
            {
                Events.RemoveHandler(nameof(ContinueClick), value);
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

        public override void SetFont(Font font)
        {
            base.SetFont(font);

            btnSelectLevel.Font = btnContinue.Font = btnMainMenu.Font = btnRestart.Font = lblPoints.Font = font;
        }

        public void Show(int point)
        {
            lblPoints.Text = point.ToString();
            Show();
        }
    }
}
