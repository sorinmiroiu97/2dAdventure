namespace Game
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
            this.screen = new System.Windows.Forms.Panel();
            this.Life = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.platform = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.Controls.Add(this.block4);
            this.screen.Controls.Add(this.block3);
            this.screen.Controls.Add(this.block2);
            this.screen.Controls.Add(this.Life);
            this.screen.Controls.Add(this.platform);
            this.screen.Controls.Add(this.block1);
            this.screen.Controls.Add(this.Player);
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1366, 669);
            this.screen.TabIndex = 0;
            // 
            // Life
            // 
            this.Life.Location = new System.Drawing.Point(62, 33);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(190, 26);
            this.Life.TabIndex = 3;
            this.Life.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.Firebrick;
            this.platform.Location = new System.Drawing.Point(559, 501);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(327, 22);
            this.platform.TabIndex = 2;
            this.platform.TabStop = false;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.DarkKhaki;
            this.block1.Location = new System.Drawing.Point(62, 435);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(397, 25);
            this.block1.TabIndex = 1;
            this.block1.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Game.Properties.Resources.standing_right;
            this.Player.Location = new System.Drawing.Point(12, 591);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(69, 75);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.DarkKhaki;
            this.block2.Location = new System.Drawing.Point(62, 178);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(397, 25);
            this.block2.TabIndex = 6;
            this.block2.TabStop = false;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.DarkKhaki;
            this.block3.Location = new System.Drawing.Point(958, 126);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(359, 25);
            this.block3.TabIndex = 7;
            this.block3.TabStop = false;
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.DarkKhaki;
            this.block4.Location = new System.Drawing.Point(958, 371);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(359, 25);
            this.block4.TabIndex = 8;
            this.block4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 691);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 38);
            this.panel1.TabIndex = 9;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.screen);
            this.Name = "Game";
            this.Text = "2dAdventure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar Life;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.Panel panel1;
    }
}

