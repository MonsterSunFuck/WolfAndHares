namespace WolfAndHares.Controls
{
    partial class LoseScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnSelectLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Image = global::WolfAndHares.Controls.Properties.Resources.restart_win;
            this.btnRestart.Location = new System.Drawing.Point(75, 185);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(209, 55);
            this.btnRestart.TabIndex = 12;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Image = global::WolfAndHares.Controls.Properties.Resources.menu_pause;
            this.btnMainMenu.Location = new System.Drawing.Point(82, 294);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(196, 55);
            this.btnMainMenu.TabIndex = 11;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnSelectLevel
            // 
            this.btnSelectLevel.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectLevel.BackgroundImage = global::WolfAndHares.Controls.Properties.Resources.contine_pause;
            this.btnSelectLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectLevel.FlatAppearance.BorderSize = 0;
            this.btnSelectLevel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelectLevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelectLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectLevel.ForeColor = System.Drawing.Color.White;
            this.btnSelectLevel.Location = new System.Drawing.Point(86, 240);
            this.btnSelectLevel.Name = "btnSelectLevel";
            this.btnSelectLevel.Size = new System.Drawing.Size(191, 55);
            this.btnSelectLevel.TabIndex = 13;
            this.btnSelectLevel.Text = "Уровни";
            this.btnSelectLevel.UseVisualStyleBackColor = false;
            this.btnSelectLevel.Click += new System.EventHandler(this.btnSelectLevel_Click);
            // 
            // LoseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::WolfAndHares.Controls.Properties.Resources.lose_window;
            this.Controls.Add(this.btnSelectLevel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnMainMenu);
            this.Name = "LoseScreen";
            this.Size = new System.Drawing.Size(360, 380);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnSelectLevel;
    }
}
