//Copyright 2017 Sorin Miroiu
//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            //this.KeyDown += new KeyEventHandler(this.Game_KeyDown); not needed anymore but won't delete it for now

            //Cursor.Hide(); TODO la sfarsit

            //TODO set those two below when I feel like to...
            //SetDesktopLocation(0,0); //set the start locations of the form
            //SetClientSizeCore(x_ax_original, y_ax_original); //set the resolution of the form

            //Player.Location = new Point(12, 217);
            Player.SendToBack();

            ground = Player.Top;

            //Resolution
            x_ax = Screen.PrimaryScreen.Bounds.Width;
            y_ax = Screen.PrimaryScreen.Bounds.Height;
            limit_right = x_ax; //pentru bordare, sa nu iasa de pe ecran

            resolution(x_ax_original, x_ax);

            x_ax_original = numar1;
            x_ax = numar2;

            resolution(y_ax_original, y_ax);
            y_ax_original = numar1;
            y_ax = numar2;

            if (x_ax != 1 || y_ax != 1) if_resolution_differs();
        }


        //initialization
        Boolean left, right, jump, down;
        int ground;
        int velocity = 6; //=miscare
        int G = 20;
        int Force;
        int move = 3;


        int platform_up = 400, platform_down = 600;
        int ticket_inventory = 0, tick = 0;


        //int miscare = 3, enemy = 0, lovit = 50, inchide = 1000; // deplasare inamic
        //int dieonce = 0; //TODO implement these
        //int enemy1.left = 730, enemy1.right = 1200, enemy2.left = 210, enemy2.right = 540; pt inamici


        //const int capacity = 10000; TODO later for array-s
        PictureBox[] bullet = new PictureBox[10000];
        int bullet_number = 0;
        bool bullet_active = false;
        int direction = 1;
        int[] bullet_direction = new int[10000];


        //Resolution
        int x_ax, y_ax;
        int x_ax_original = 1366;
        int y_ax_original = 768;
        int numar1, numar2;
        int limit_right;


        //Animations!
        Boolean walkleft, crouchleft, shootleft;
        Boolean walkright, crouchright, shootright;
        Boolean crouch, shooting;



        void limits(PictureBox person)
        {
            if (person.Right > limit_right) person.Left = limit_right - person.Width;
            if (person.Left < 0) person.Left = 0;
        }

        void resolution(int x, int y)
        {
            int contor, a, b;
            contor = x;
            a = x;
            b = y;

            while (contor != 1)
            {
                while (a != b) if (a > b) a -= b; else b -= a;
                if (a > 1) { x /= a; y /= a; }
                contor = a;
                a = x; b = y;
            }
            numar1 = x;
            numar2 = y;
        }

        void if_resolution_differs()
        {
            G = y_ax * G / y_ax_original;
            G = x_ax * G / x_ax_original;

            Player.Height = y_ax * Player.Height / y_ax_original;
            Player.Width = x_ax * Player.Width / x_ax_original;
            Player.Top = y_ax * Player.Top / y_ax_original;
            Player.Left = x_ax * Player.Left / x_ax_original;
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            ground = Player.Top;

            block1.Height = y_ax * block1.Height / y_ax_original;
            block1.Width = x_ax * block1.Width / x_ax_original;
            block1.Top = y_ax * block1.Top / y_ax_original;
            block1.Left = x_ax * block1.Left / x_ax_original;
            block1.SizeMode = PictureBoxSizeMode.StretchImage;

            platform.Height = y_ax * platform.Height / y_ax_original;
            platform.Width = x_ax * platform.Width / x_ax_original;
            platform.Top = y_ax * platform.Top / y_ax_original;
            platform.Left = x_ax * platform.Left / x_ax_original;
            platform.SizeMode = PictureBoxSizeMode.StretchImage;
            platform_up = y_ax * platform_up / y_ax_original;
            platform_down = y_ax * platform_down / y_ax_original;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            limits(Player);

            Collisions(block1);
            Collisions(block2);
            Collisions(block3);

            platform_move(platform, platform_up, platform_down);

            jumping();
            move_left_right();

            if (bullet_active == true) bullet_moving();
        }

        private void bullet_moving()
        {
            int k = 0;
            for (int i = 1; i <= bullet_number; i++)
            {
                //if (bullet_direction[i] == 1)
                if (bullet_direction[i] == 0)
                {
                    if (bullet[i].Bounds.IntersectsWith(block1.Bounds)) bullet[i].Dispose(); //bullet[i].Left = 3000;
                    else if (bullet[i].Bounds.IntersectsWith(platform.Bounds)) bullet[i].Dispose();//bullet[i].Left = 3000;
                }
                else if (bullet[i].Left < 2000) { bullet[i].Left += 15; k++; }
                //else if (bullet_direction[i] == 0)
                if (bullet_direction[i] == 1)
                {
                    if (bullet[i].Bounds.IntersectsWith(block1.Bounds)) bullet[i].Dispose();//bullet[i].Left = -200;
                    else if (bullet[i].Bounds.IntersectsWith(platform.Bounds)) bullet[i].Dispose(); //bullet[i].Left = -200;
                }
                else if (bullet[i].Left > -100) { bullet[i].Left -= 15; k++; }
            }
            if (k == 0) bullet_active = false;
        }

        private void platform_move(PictureBox floating, int up, int down)
        {
            if (floating.Top <= up) move = 3;
            if (floating.Top >= down) move = -3;
            floating.Top += move;

            Collisions(platform);
            
            //collision_01(platform); TODO pt player 1
            //collision_02(platform); TODO pt player 2
        }

        private void jumping()
        {
            if (jump == true)
            {
                //falling(if player has jumped before)
                Player.Top -= Force;
                Force -= 1;
            }
        }

        private void move_left_right()
        {
            if (left == true)
            {
                Player.Left -= velocity;
                walkleft = true;
            }
            if (right == true)
            {
                Player.Left += velocity;
                walkright = true;
            }
        }

        private void Collisions(PictureBox block)
        {
            jumping();

            #region Head/Bottom of an object collision
            int k = 0;// reset, if jumped at block.bottom it resets in left/right 

            if (Player.Left + Player.Width - 5 > block.Left) // blocked. bottom - limita
                if (Player.Left + Player.Width + 5 < block.Left + block.Width + Player.Width)
                    if (Player.Top <= block.Bottom)  // or k = 1;
                        if (Player.Top > block.Top)
                        {
                            k = 1;  // or  if (player.Top <= block.Bottom+10);
                            jump = false;
                            Force = 0;
                            jump = true;
                        }
            #endregion

            #region side collision
            if (Player.Right > block.Left &&
                Player.Left < block.Right - Player.Width / 2 &&
                Player.Top < block.Bottom &&
                Player.Bottom > block.Top + 20)
                if (k == 0)
                {
                    right = false;
                    Player.Left = block.Left - Player.Width;
                }
            if (Player.Left < block.Right &&
                Player.Right > block.Left + Player.Width / 2 &&
                Player.Top < block.Bottom &&
                Player.Bottom > block.Top + 20)
                if (k == 0)
                {
                    left = false;
                    Player.Left = block.Right;
                }
            #endregion

            k = 0;

            #region simple fall
            if (!(Player.Left + Player.Width > block.Left
                && Player.Left + Player.Width < block.Left + block.Width + Player.Width) &&
                Player.Top + Player.Height >= block.Top && Player.Top < block.Top)
            {
                jump = true;
            }
            #endregion

            #region Stop falling at bottom
            if (Player.Top + Player.Height >= screen.Height)
            {
                Player.Top = screen.Height - Player.Height; //Stop falling at bottom 
                jump = false;
            }
            else
            {
                Player.Top += 5; //Falling
            }
            #endregion

            #region Top collision 

            if (Player.Left + Player.Width > block.Left &&
                Player.Left + Player.Width < block.Left + block.Width + Player.Width &&
                Player.Top + Player.Height >= block.Top &&
                Player.Top < block.Top)
            {
                jump = false;
                Force = 0;
                Player.Top = block.Location.Y - Player.Height;
                if (right == true) { Player.Left += velocity; }
                if (left == true) { Player.Left -= velocity; }

            }
            #endregion
            //TODO implement a better collision here 

        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false; //moves left
                Player.Image = Properties.Resources.standing_left;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false; //moves right
                Player.Image = Properties.Resources.standing_right;
            }

            if (e.KeyCode == Keys.Up)
            {
                jump = false;
                //Force = G;
                if (direction == 0)
                {
                    Player.Image = Properties.Resources.standing_left;
                }
                if (direction == 1)
                {
                    Player.Image = Properties.Resources.standing_right;
                }
            }

            if (e.KeyCode == Keys.Space) //shooting
            {
                shooting = false;
                if (direction == 0)
                {
                    //shootleft = true;
                    Player.Image = Properties.Resources.standing_left;
                }
                if (direction == 1)
                {
                    //shootright = true;
                    Player.Image = Properties.Resources.standing_right;
                }
            }

                if (e.KeyCode == Keys.Down) //crouch
            {
                crouch = false;
                if (direction == 0)
                {
                    Player.Image = Properties.Resources.standing_left;
                }
                if (direction == 1)
                {
                    Player.Image = Properties.Resources.standing_right;
                }
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); } //Esc-> to exit

            #region Movement
            if (e.KeyCode == Keys.Left) //moves left
            {
                Player.Image = Properties.Resources.walk_left;
                direction = 0;
                walkleft = true;
                left = true;
            }
            if (e.KeyCode == Keys.Right) //moves right
            {
                Player.Image = Properties.Resources.walk_right;
                direction = 1;
                walkright = true;
                right = true;
            }

            if(e.KeyCode==Keys.Down) //crouch
            {
                crouch = true;
                if(direction==0)
                {
                    Player.Image = Properties.Resources.crouchleft;
                }
                if(direction == 1)
                {
                    Player.Image = Properties.Resources.crouchright;
                }
            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    jump = true;
                    Force = G;
                    if(direction==0)
                    {
                        Player.Image = Properties.Resources.jumpleft;
                    }
                    if(direction == 1)
                    {
                        Player.Image = Properties.Resources.jumpright;
                    }
                }
            }

            if (e.KeyCode == Keys.Space) //shooting
            {
                //animation-->
                shooting = true;
                if (direction == 0)
                {
                    shootleft = true;
                    Player.Image = Properties.Resources.standshootleft;
                }
                if (direction == 1)
                {
                    shootright = true;
                    Player.Image = Properties.Resources.standshootright;
                }
                if (walkleft==true && direction == 0)
                {
                    shootleft = true;
                    Player.Image = Properties.Resources.walk_shootleft;
                }
                if (walkright==true && direction == 1)
                {
                    shootright = true;
                    Player.Image = Properties.Resources.walk_shoot_right;
                }
                //-->'till here


                bullet_number++;
                bullet[bullet_number] = new PictureBox();
                bullet[bullet_number].Top = Player.Top + Player.Height / 3;
                bullet[bullet_number].Left = Player.Left;
                bullet[bullet_number].Height = 80;//original =14
                bullet[bullet_number].Width = 38;//original=20
                bullet[bullet_number].Image = Properties.Resources.bullet;
                bullet[bullet_number].SizeMode = PictureBoxSizeMode.AutoSize;
                
                //bullet[bullet_number].
                //shaorma,bulletcrop.image, trebuie adus in front ca nu se vede in panel
                //ASTA ERA BAIUL TOT TIMPUL
                //insfarsit..bou is!

                Controls.Add(bullet[bullet_number]);
                bullet[bullet_number].BringToFront();
                bullet[bullet_number].Show();
                bullet_active = true;

                bullet_direction[bullet_number] = new int();
                bullet_direction[bullet_number] = direction;

                //Resolution changed
                if (x_ax != 1 || y_ax != 1)
                {
                    bullet[bullet_number].Height = y_ax * bullet[bullet_number].Height / y_ax_original;
                    bullet[bullet_number].Width = x_ax * bullet[bullet_number].Width / x_ax_original;
                    bullet[bullet_number].Top = Player.Top + Player.Height / 3;
                    bullet[bullet_number].Left = Player.Left;
                    bullet[bullet_number].SizeMode = PictureBoxSizeMode.AutoSize;
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

        private void Game_Load(object sender, EventArgs e)
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



        // pana aici ii clasa fmm da clasa
    }
}