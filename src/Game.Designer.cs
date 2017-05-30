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
            this.Lifebar_player_02 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fly4 = new System.Windows.Forms.PictureBox();
            this.fly3 = new System.Windows.Forms.PictureBox();
            this.fly2 = new System.Windows.Forms.PictureBox();
            this.fly1 = new System.Windows.Forms.PictureBox();
            this.slot5 = new System.Windows.Forms.PictureBox();
            this.slot6 = new System.Windows.Forms.PictureBox();
            this.slot7 = new System.Windows.Forms.PictureBox();
            this.slot8 = new System.Windows.Forms.PictureBox();
            this.slot4 = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.player_02 = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.Controls.Add(this.fly4);
            this.screen.Controls.Add(this.fly3);
            this.screen.Controls.Add(this.fly2);
            this.screen.Controls.Add(this.fly1);
            this.screen.Controls.Add(this.slot5);
            this.screen.Controls.Add(this.slot6);
            this.screen.Controls.Add(this.slot7);
            this.screen.Controls.Add(this.slot8);
            this.screen.Controls.Add(this.slot4);
            this.screen.Controls.Add(this.slot3);
            this.screen.Controls.Add(this.slot2);
            this.screen.Controls.Add(this.slot1);
            this.screen.Controls.Add(this.enemy4);
            this.screen.Controls.Add(this.enemy3);
            this.screen.Controls.Add(this.enemy2);
            this.screen.Controls.Add(this.enemy1);
            this.screen.Controls.Add(this.Lifebar_player_02);
            this.screen.Controls.Add(this.player_02);
            this.screen.Controls.Add(this.block4);
            this.screen.Controls.Add(this.block3);
            this.screen.Controls.Add(this.block2);
            this.screen.Controls.Add(this.Life);
            this.screen.Controls.Add(this.platform);
            this.screen.Controls.Add(this.block1);
            this.screen.Controls.Add(this.Player);
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1366, 682);
            this.screen.TabIndex = 0;
            // 
            // Life
            // 
            this.Life.Location = new System.Drawing.Point(12, 12);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(190, 26);
            this.Life.TabIndex = 3;
            this.Life.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Lifebar_player_02
            // 
            this.Lifebar_player_02.Location = new System.Drawing.Point(1148, 12);
            this.Lifebar_player_02.Name = "Lifebar_player_02";
            this.Lifebar_player_02.Size = new System.Drawing.Size(190, 26);
            this.Lifebar_player_02.TabIndex = 10;
            this.Lifebar_player_02.Value = 100;
            this.Lifebar_player_02.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game.Properties.Resources.ground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 678);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // fly4
            // 
            this.fly4.Image = global::Game.Properties.Resources.fly;
            this.fly4.Location = new System.Drawing.Point(1277, 80);
            this.fly4.Name = "fly4";
            this.fly4.Size = new System.Drawing.Size(40, 40);
            this.fly4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fly4.TabIndex = 26;
            this.fly4.TabStop = false;
            // 
            // fly3
            // 
            this.fly3.Image = global::Game.Properties.Resources.fly;
            this.fly3.Location = new System.Drawing.Point(1148, 194);
            this.fly3.Name = "fly3";
            this.fly3.Size = new System.Drawing.Size(40, 40);
            this.fly3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fly3.TabIndex = 25;
            this.fly3.TabStop = false;
            // 
            // fly2
            // 
            this.fly2.Image = global::Game.Properties.Resources.fly;
            this.fly2.Location = new System.Drawing.Point(72, 120);
            this.fly2.Name = "fly2";
            this.fly2.Size = new System.Drawing.Size(40, 40);
            this.fly2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fly2.TabIndex = 24;
            this.fly2.TabStop = false;
            // 
            // fly1
            // 
            this.fly1.Image = global::Game.Properties.Resources.fly;
            this.fly1.Location = new System.Drawing.Point(238, 325);
            this.fly1.Name = "fly1";
            this.fly1.Size = new System.Drawing.Size(40, 40);
            this.fly1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fly1.TabIndex = 23;
            this.fly1.TabStop = false;
            // 
            // slot5
            // 
            this.slot5.Image = global::Game.Properties.Resources.inventoryslot;
            this.slot5.Location = new System.Drawing.Point(1102, 0);
            this.slot5.Name = "slot5";
            this.slot5.Size = new System.Drawing.Size(40, 40);
            this.slot5.TabIndex = 22;
            this.slot5.TabStop = false;
            // 
            // slot6
            // 
            this.slot6.Image = global::Game.Properties.Resources.inventoryslot;
            this.slot6.Location = new System.Drawing.Point(1056, 0);
            this.slot6.Name = "slot6";
            this.slot6.Size = new System.Drawing.Size(40, 40);
            this.slot6.TabIndex = 21;
            this.slot6.TabStop = false;
            // 
            // slot7
            // 
            this.slot7.Image = global::Game.Properties.Resources.inventoryslot;
            this.slot7.Location = new System.Drawing.Point(1010, 0);
            this.slot7.Name = "slot7";
            this.slot7.Size = new System.Drawing.Size(40, 40);
            this.slot7.TabIndex = 20;
            this.slot7.TabStop = false;
            // 
            // slot8
            // 
            this.slot8.Image = global::Game.Properties.Resources.inventoryslot;
            this.slot8.Location = new System.Drawing.Point(964, 0);
            this.slot8.Name = "slot8";
            this.slot8.Size = new System.Drawing.Size(40, 40);
            this.slot8.TabIndex = 19;
            this.slot8.TabStop = false;
            // 
            // slot4
            // 
            this.slot4.Image = global::Game.Properties.Resources.inventoryslot;
            this.slot4.Location = new System.Drawing.Point(346, 3);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(40, 40);
            this.slot4.TabIndex = 18;
            this.slot4.TabStop = false;
            // 
            // slot3
            // 
            this.slot3.Image = global::Game.Properties.Resources.inventoryslot;
            this.slot3.Location = new System.Drawing.Point(300, 3);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(40, 40);
            this.slot3.TabIndex = 17;
            this.slot3.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.Image = global::Game.Properties.Resources.inventoryslot;
            this.slot2.Location = new System.Drawing.Point(254, 3);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(40, 40);
            this.slot2.TabIndex = 16;
            this.slot2.TabStop = false;
            // 
            // slot1
            // 
            this.slot1.Image = global::Game.Properties.Resources.inventoryslot;
            this.slot1.Location = new System.Drawing.Point(208, 3);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(40, 40);
            this.slot1.TabIndex = 15;
            this.slot1.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.Image = global::Game.Properties.Resources.enemyleft;
            this.enemy4.Location = new System.Drawing.Point(383, 377);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(29, 52);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy4.TabIndex = 14;
            this.enemy4.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::Game.Properties.Resources.enemyleft;
            this.enemy3.Location = new System.Drawing.Point(383, 120);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(29, 52);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy3.TabIndex = 13;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::Game.Properties.Resources.enemyleft;
            this.enemy2.Location = new System.Drawing.Point(1203, 68);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(29, 52);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy2.TabIndex = 12;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = global::Game.Properties.Resources.enemyleft;
            this.enemy1.Location = new System.Drawing.Point(1203, 313);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(29, 52);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy1.TabIndex = 11;
            this.enemy1.TabStop = false;
            // 
            // player_02
            // 
            this.player_02.Image = global::Game.Properties.Resources.p2standright;
            this.player_02.Location = new System.Drawing.Point(1287, 588);
            this.player_02.Name = "player_02";
            this.player_02.Size = new System.Drawing.Size(51, 91);
            this.player_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_02.TabIndex = 9;
            this.player_02.TabStop = false;
            this.player_02.Visible = false;
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.DarkKhaki;
            this.block4.Image = global::Game.Properties.Resources.block;
            this.block4.Location = new System.Drawing.Point(958, 371);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(359, 25);
            this.block4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block4.TabIndex = 8;
            this.block4.TabStop = false;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.DarkKhaki;
            this.block3.Image = global::Game.Properties.Resources.block;
            this.block3.Location = new System.Drawing.Point(958, 126);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(359, 25);
            this.block3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block3.TabIndex = 7;
            this.block3.TabStop = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.DarkKhaki;
            this.block2.Image = global::Game.Properties.Resources.block;
            this.block2.Location = new System.Drawing.Point(62, 178);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(397, 25);
            this.block2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block2.TabIndex = 6;
            this.block2.TabStop = false;
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.Transparent;
            this.platform.Image = global::Game.Properties.Resources.platform;
            this.platform.Location = new System.Drawing.Point(536, 501);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(350, 22);
            this.platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform.TabIndex = 2;
            this.platform.TabStop = false;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.DarkKhaki;
            this.block1.Image = global::Game.Properties.Resources.block;
            this.block1.Location = new System.Drawing.Point(62, 435);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(397, 25);
            this.block1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block1.TabIndex = 1;
            this.block1.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Game.Properties.Resources.standing_right;
            this.Player.Location = new System.Drawing.Point(3, 604);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(69, 75);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "2dAdventure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
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
        private System.Windows.Forms.PictureBox player_02;
        private System.Windows.Forms.ProgressBar Lifebar_player_02;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.PictureBox slot4;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.PictureBox slot5;
        private System.Windows.Forms.PictureBox slot6;
        private System.Windows.Forms.PictureBox slot7;
        private System.Windows.Forms.PictureBox slot8;
        private System.Windows.Forms.PictureBox fly1;
        private System.Windows.Forms.PictureBox fly4;
        private System.Windows.Forms.PictureBox fly3;
        private System.Windows.Forms.PictureBox fly2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

