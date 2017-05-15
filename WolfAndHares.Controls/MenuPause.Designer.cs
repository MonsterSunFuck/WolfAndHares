namespace WolfAndHares.Controls
{
    partial class MenuPause
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSelectLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btnMainMenu.Location = new System.Drawing.Point(30, 243);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(196, 55);
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackgroundImage = global::WolfAndHares.Controls.Properties.Resources.contine_pause;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(30, 70);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(191, 55);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BackgroundImage = global::WolfAndHares.Controls.Properties.Resources.contine_pause;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(31, 130);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(191, 55);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Переиграть";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
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
            this.btnSelectLevel.Location = new System.Drawing.Point(31, 189);
            this.btnSelectLevel.Name = "btnSelectLevel";
            this.btnSelectLevel.Size = new System.Drawing.Size(191, 55);
            this.btnSelectLevel.TabIndex = 12;
            this.btnSelectLevel.Text = "Уровни";
            this.btnSelectLevel.UseVisualStyleBackColor = false;
            this.btnSelectLevel.Click += new System.EventHandler(this.btnSelectLevel_Click);
            // 
            // MenuPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WolfAndHares.Controls.Properties.Resources.pause_window;
            this.Controls.Add(this.btnSelectLevel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnContinue);
            this.Name = "MenuPause";
            this.Size = new System.Drawing.Size(251, 332);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSelectLevel;
    }
}
