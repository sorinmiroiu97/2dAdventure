using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_test
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            //this.KeyDown += new KeyEventHandler(this.Game_KeyDown);
        }

        //int Force;
        //int Gravity;
        //Boolean Jumping;
        //Boolean Grounded;

        Boolean left, right;
        Boolean jump;
        int G = 15;
        int Force;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //side collision
            //(Player.Left + Player.Width= player.right
            if (Player.Right >= block.Left && Player.Top > block.Top && Player.Left < block.Left)
            {
                right = false;
            }
            if (Player.Left <= block.Right && Player.Right > block.Right && Player.Top > block.Top)
            {
                left = false;
            }


            if (right == true) { Player.Left += 5; }
            if (left == true) { Player.Left -= 5; }

            if(jump==true)
            {
                //falling(if player has jumped before)
                Player.Top -= Force;
                Force -= 1;
            }

            if(Player.Top + Player.Height >= screen.Height)
            {
                Player.Top = screen.Height - Player.Height; //Stop falling at bottom 
                jump = false; 
            }
            else
            {
                Player.Top += 5; //Falling
            }

            //top collision 

            if (Player.Left + Player.Width - 1 > block.Left && Player.Left + Player.Width + 5 < block.Left + block.Width + Player.Width && Player.Top + Player.Height >= block.Top && Player.Top < block.Top)
            {
                Player.Top = screen.Height - block.Height - Player.Height;
                Force = 5;
                jump = false;
                Player.Top -= Force;
            }
            //need a better top collision but this should do the trick meanwhile 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.BackColor = Color.Transparent;
            Life.Value = 100;
        }

        private void Game_KeyDown_1(object sender, KeyEventArgs e)
        {
            #region Movement
            if (e.KeyCode == Keys.Left) left = true; //moves left
            if (e.KeyCode == Keys.Right) right = true; //moves right
            if(e.KeyCode==Keys.Escape) { this.Close(); } //Esc-> to exit

            if(jump!=true)
            {
                if(e.KeyCode==Keys.Space)
                {
                    jump = true;
                    Force = G;
                }
            }
            #endregion
            #region Life but needs more work!!!
            //TODO make enemies
            if (e.KeyCode == Keys.H)
            {
                if (Life.Value >= 10)
                    Life.Value -= 10;
            }
            if (e.KeyCode == Keys.J)
            {
                if (Life.Value <= 90)
                    Life.Value += 10;
            }
            #endregion
        }

        private void Game_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) left = false; //moves left
            if (e.KeyCode == Keys.Right) right = false; //moves right
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        //public void Collision_Earth(object key, KeyEventArgs e)
        //{
        //    Earth.SetBounds(Earth.Location.X, Earth.Location.Y + Earth.Height, Earth.Width, 1);
        //    if (Player.Bounds.IntersectsWith(Earth.Bounds)) //return true
        //    {
        //        RaiseKeyEvent(key, Keys.Down);
                  //TODO Implement this kind of collision...more optimized
        //    }
        //}
    }
}
