namespace Game_test
{
    partial class Game
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.Life = new System.Windows.Forms.ProgressBar();
            this.Player = new System.Windows.Forms.PictureBox();
            this.block = new System.Windows.Forms.PictureBox();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.Controls.Add(this.block);
            this.screen.Controls.Add(this.Life);
            this.screen.Controls.Add(this.Player);
            this.screen.ForeColor = System.Drawing.Color.Transparent;
            this.screen.Location = new System.Drawing.Point(0, -2);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(665, 317);
            this.screen.TabIndex = 3;
            // 
            // Life
            // 
            this.Life.Location = new System.Drawing.Point(12, 14);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(129, 23);
            this.Life.TabIndex = 3;
            this.Life.Value = 100;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player.Image = global::Game_test.Properties.Resources.staticchar_png;
            this.Player.Location = new System.Drawing.Point(54, 251);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(47, 63);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.Gray;
            this.block.Location = new System.Drawing.Point(282, 262);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(106, 55);
            this.block.TabIndex = 4;
            this.block.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Game_test.Properties.Resources.bckgrnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 316);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Game";
            this.Text = "2dAdventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp_1);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.ProgressBar Life;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox block;
    }
}

