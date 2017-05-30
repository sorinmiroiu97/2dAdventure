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
            
            ground_02 = player_02.Top;

            //player_02.Hide();
            //if (player_02_exist == true) { Controls.Add(player_02); player_02.Show(); player_02.BringToFront(); }

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
        int velocity = 5; //=miscare
        int G = 25;
        int Force;
        int move = 3;
        int miscare_02 = 3, miscare_03 = 3;


        int platform_up = 200, platform_down = 650;
        int ticket_inventory = 0, tick = 0;
        bool finish = false;

        //PictureBox inventory_01_player_01 = new PictureBox();
        //PictureBox inventory_02_player_01 = new PictureBox();
        //PictureBox inventory_03_player_01 = new PictureBox();
        //PictureBox inventory_04_player_01 = new PictureBox();


        int miscare = 3, enemy = 0, lovit = 50, inchide = 1000; // deplasare inamic
        int dieonce = 0; //TODO implement these
        int enemy1left = 1000, enemy1right = 1300; 
        int enemy2left = 1000, enemy2right = 1300;
        int enemy3left = 100, enemy3right = 300;
        int enemy4left = 100, enemy4right = 300;
        int enemy_hittime;

        int enemy_hittime_02, lovit_02=50, inchide_02=1000, dieonce_02=0;


        //const int capacity = 10000; TODO later for array-s with arraylist
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



        //PLAYER 2

        #region PLAYER 2

        //ProgressBar Lifebar_player_02 = new ProgressBar();
        //PictureBox player_02 = new PictureBox();
        bool player_02_exist = false;
        bool left_02, right_02, jump_02;
        int Force_02, G_02 = 25;
        int ground_02;

        //const int capacity = 10000; TODO later for array-s with arraylist
        PictureBox[] bullet_02 = new PictureBox[10000];
        int bullet_number_02 = 0;
        bool bullet_active_02 = false;
        int direction_02 = 0;
        int[] bullet_direction_02 = new int[10000];

        //int ticket_inventory_02 = 0;
        //PictureBox inventory_01_player_02 = new PictureBox();
        //PictureBox inventory_02_player_02 = new PictureBox();
        //PictureBox inventory_03_player_02 = new PictureBox();
        //PictureBox inventory_04_player_02 = new PictureBox();
        #endregion



        void limits(PictureBox person)
        {
            if (person.Right > limit_right) person.Left = limit_right - person.Width;
            if (person.Left < 0) person.Left = 0;
        }
        //done

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
        //done

        void if_resolution_differs()
        {
            //G = y_ax * G / y_ax_original;
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

            block2.Height = y_ax * block2.Height / y_ax_original;
            block2.Width = x_ax * block2.Width / x_ax_original;
            block2.Top = y_ax * block2.Top / y_ax_original;
            block2.Left = x_ax * block2.Left / x_ax_original;
            block2.SizeMode = PictureBoxSizeMode.StretchImage;

            block3.Height = y_ax * block3.Height / y_ax_original;
            block3.Width = x_ax * block3.Width / x_ax_original;
            block3.Top = y_ax * block3.Top / y_ax_original;
            block3.Left = x_ax * block3.Left / x_ax_original;
            block3.SizeMode = PictureBoxSizeMode.StretchImage;

            block4.Height = y_ax * block4.Height / y_ax_original;
            block4.Width = x_ax * block4.Width / x_ax_original;
            block4.Top = y_ax * block4.Top / y_ax_original;
            block4.Left = x_ax * block4.Left / x_ax_original;
            block4.SizeMode = PictureBoxSizeMode.StretchImage;

            platform.Height = y_ax * platform.Height / y_ax_original;
            platform.Width = x_ax * platform.Width / x_ax_original;
            platform.Top = y_ax * platform.Top / y_ax_original;
            platform.Left = x_ax * platform.Left / x_ax_original;
            platform.SizeMode = PictureBoxSizeMode.StretchImage;
            platform_up = y_ax * platform_up / y_ax_original;
            platform_down = y_ax * platform_down / y_ax_original;

            Life.Height = y_ax * Life.Height / y_ax_original;
            Life.Width = x_ax * Life.Width / x_ax_original;
            Life.Top = y_ax * Life.Top / y_ax_original;
            Life.Left = x_ax * Life.Left / x_ax_original;

            //inventory_1.Height = y_ax * inventory_1.Height / y_ax_original;
            //inventory_1.Width = x_ax * inventory_1.Width / x_ax_original;
            //inventory_1.Top = y_ax * inventory_1.Top / y_ax_original;
            //inventory_1.Left = x_ax * inventory_1.Left / x_ax_original;
            //inventory_1.SizeMode = PictureBoxSizeMode.StretchImage;

            //inventory_2.Height = y_ax * inventory_2.Height / y_ax_original;
            //inventory_2.Width = x_ax * inventory_2.Width / x_ax_original;
            //inventory_2.Top = y_ax * inventory_2.Top / y_ax_original;
            //inventory_2.Left = x_ax * inventory_2.Left / x_ax_original;
            //inventory_2.SizeMode = PictureBoxSizeMode.StretchImage;

            //inventory_3.Height = y_ax * inventory_3.Height / y_ax_original;
            //inventory_3.Width = x_ax * inventory_3.Width / x_ax_original;
            //inventory_3.Top = y_ax * inventory_3.Top / y_ax_original;
            //inventory_3.Left = x_ax * inventory_3.Left / x_ax_original;
            //inventory_3.SizeMode = PictureBoxSizeMode.StretchImage;

            //inventory_4.Height = y_ax * inventory_4.Height / y_ax_original;
            //inventory_4.Width = x_ax * inventory_4.Width / x_ax_original;
            //inventory_4.Top = y_ax * inventory_4.Top / y_ax_original;
            //inventory_4.Left = x_ax * inventory_4.Left / x_ax_original;
            //inventory_4.SizeMode = PictureBoxSizeMode.StretchImage;

            //food_1.Height = y_ax * food_1.Height / y_ax_original;
            //food_1.Width = x_ax * food_1.Width / x_ax_original;
            //food_1.Top = y_ax * food_1.Top / y_ax_original;
            //food_1.Left = x_ax * food_1.Left / x_ax_original;
            //food_1.SizeMode = PictureBoxSizeMode.StretchImage;

            //food_2.Height = y_ax * food_2.Height / y_ax_original;
            //food_2.Width = x_ax * food_2.Width / x_ax_original;
            //food_2.Top = y_ax * food_2.Top / y_ax_original;
            //food_2.Left = x_ax * food_2.Left / x_ax_original;
            //food_2.SizeMode = PictureBoxSizeMode.StretchImage;

            //food_3.Height = y_ax * food_3.Height / y_ax_original;
            //food_3.Width = x_ax * food_3.Width / x_ax_original;
            //food_3.Top = y_ax * food_3.Top / y_ax_original;
            //food_3.Left = x_ax * food_3.Left / x_ax_original;
            //food_3.SizeMode = PictureBoxSizeMode.StretchImage;

            //food_4.Height = y_ax * food_4.Height / y_ax_original;
            //food_4.Width = x_ax * food_4.Width / x_ax_original;
            //food_4.Top = y_ax * food_4.Top / y_ax_original;
            //food_4.Left = x_ax * food_4.Left / x_ax_original;
            //food_4.SizeMode = PictureBoxSizeMode.StretchImage;

            //solid_ground.Height = y_ax * solid_ground.Height / y_ax_original;
            //solid_ground.Width = x_ax * solid_ground.Width / x_ax_original;
            //solid_ground.Top = y_ax * solid_ground.Top / y_ax_original;
            //solid_ground.Left = x_ax * solid_ground.Left / x_ax_original;
            //solid_ground.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //work

        void if_resolution_differs_add_player_02()
        {
            G_02 = G;

            player_02.Height = y_ax * player_02.Height / y_ax_original;
            player_02.Width = x_ax * player_02.Width / x_ax_original;
            player_02.Top = y_ax * player_02.Top / y_ax_original;
            player_02.Left = x_ax * player_02.Left / x_ax_original;
            player_02.SizeMode = PictureBoxSizeMode.StretchImage;
            //ground_02 = solid_ground.Top - player_02.Height;

            //Lifebar_player_02.Height = y_ax * Lifebar_player_02.Height / y_ax_original;
            //Lifebar_player_02.Width = x_ax * Lifebar_player_02.Width / x_ax_original;
            //Lifebar_player_02.Top = y_ax * Lifebar_player_02.Top / y_ax_original;
            //Lifebar_player_02.Left = x_ax * Lifebar_player_02.Left / x_ax_original;

            //inventory_01_player_02.Height = y_ax * inventory_01_player_02.Height / y_ax_original;
            //inventory_01_player_02.Width = x_ax * inventory_01_player_02.Width / x_ax_original;
            //inventory_01_player_02.Top = y_ax * inventory_01_player_02.Top / y_ax_original;
            //inventory_01_player_02.Left = x_ax * inventory_01_player_02.Left / x_ax_original;
            //inventory_01_player_02.SizeMode = PictureBoxSizeMode.StretchImage;

            //inventory_02_player_02.Height = y_ax * inventory_02_player_02.Height / y_ax_original;
            //inventory_02_player_02.Width = x_ax * inventory_02_player_02.Width / x_ax_original;
            //inventory_02_player_02.Top = y_ax * inventory_02_player_02.Top / y_ax_original;
            //inventory_02_player_02.Left = x_ax * inventory_02_player_02.Left / x_ax_original;
            //inventory_02_player_02.SizeMode = PictureBoxSizeMode.StretchImage;

            //inventory_03_player_02.Height = y_ax * inventory_03_player_02.Height / y_ax_original;
            //inventory_03_player_02.Width = x_ax * inventory_03_player_02.Width / x_ax_original;
            //inventory_03_player_02.Top = y_ax * inventory_03_player_02.Top / y_ax_original;
            //inventory_03_player_02.Left = x_ax * inventory_03_player_02.Left / x_ax_original;
            //inventory_03_player_02.SizeMode = PictureBoxSizeMode.StretchImage;

            //inventory_04_player_02.Height = y_ax * inventory_04_player_02.Height / y_ax_original;
            //inventory_04_player_02.Width = x_ax * inventory_04_player_02.Width / x_ax_original;
            //inventory_04_player_02.Top = y_ax * inventory_04_player_02.Top / y_ax_original;
            //inventory_04_player_02.Left = x_ax * inventory_04_player_02.Left / x_ax_original;
            //inventory_04_player_02.SizeMode = PictureBoxSizeMode.StretchImage;

            player_02.Left = x_ax * player_02.Left / x_ax_original;
            player_02.Height = y_ax * player_02.Height / y_ax_original;

        }
        //work

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            #region PLAYER 1
            move_left_right();

            if (bullet_active == true) bullet_moving(enemy1);
            if (bullet_active == true) bullet_moving(enemy2);
            if (bullet_active == true) bullet_moving(enemy3);
            if (bullet_active == true) bullet_moving(enemy4);

            limits(Player);

            collision_01(block1);
            collision_01(block2);
            collision_01(block3);
            collision_01(block4);

            jumping();

            collision_02(block1);
            collision_02(block2);
            collision_02(block3);
            collision_02(block4);

            platform_move(platform, platform_up, platform_down);

            enemy_move(enemy1, enemy1left, enemy1right);
            enemy_move(enemy2, enemy2left, enemy2right);
            enemy_move(enemy3, enemy3left, enemy3right);
            enemy_move(enemy4, enemy4left, enemy4right);

            collect(fly1);
            collect(fly2);
            collect(fly3);
            collect(fly4);

            #endregion

            #region PLAYER 2

            if (player_02_exist == true)
            {
                right_left_move_player_02();
                if (bullet_active_02 == true) bullet_moving_player_02(enemy1);
                if (bullet_active_02 == true) bullet_moving_player_02(enemy2);
                if (bullet_active_02 == true) bullet_moving_player_02(enemy3);
                if (bullet_active_02 == true) bullet_moving_player_02(enemy4);

                limits(player_02);

                collision_01_player_02(block1);
                collision_01_player_02(block2);
                collision_01_player_02(block3);
                collision_01_player_02(block4);

                jumping_player_02();

                collision_02_player_02(block1);
                collision_02_player_02(block2);
                collision_02_player_02(block3);
                collision_02_player_02(block4);

                //player_02 platform collision
                collision_01_player_02(platform);
                collision_02_player_02(platform);

                enemy_collision_p2(enemy1);
                enemy_collision_p2(enemy2);
                enemy_collision_p2(enemy3);
                enemy_collision_p2(enemy4);

                collect_player_02(fly1);
                collect_player_02(fly2);
                collect_player_02(fly3);
                collect_player_02(fly4);

            }

            #endregion


        }
        //TODO add all the methods(or what's left..check before finish)

        private void bullet_moving(PictureBox enemy)
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
                if (player_02_exist == true)
                {
                    if (bullet[i].Bounds.IntersectsWith(player_02.Bounds))
                    {
                        bullet[i].Left = 3000;
                        if (Lifebar_player_02.Value > 30)
                        {
                            Lifebar_player_02.Value -= 30;
                            
                        }
                        else
                        {
                            Lifebar_player_02.Value = 0;
                            
                            timer1.Stop();
                            MessageBox.Show("P1 castiga !");
                            Cursor.Show();
                            this.Close();
                            //menu main_menu = new menu();
                            //main_menu.Show();
                        }
                    }
                }
                if(bullet[i].Bounds.IntersectsWith(enemy.Bounds))
                {
                    enemy.Dispose();
                }
            }
            if (k == 0) bullet_active = false;
        }
        //this is player1's method for the bullet movement
        //add collisions with all blocks and with player2!!!

        private void platform_move(PictureBox floating, int up, int down)
        {
            if (floating.Top <= up) move = 3;
            if (floating.Top >= down) move = -3;
            floating.Top += move;

            collision_01(platform);
            collision_02(platform);
        }
        //done

        private void jumping()
        {
            if (jump == true)
            {
                //falling(if player has jumped before)
                Player.Top -= Force;
                Force -= 1;
            }
            if (Player.Top >= ground)
            {
                Player.Top = ground;
                jump = false;
            }

            else Player.Top += 5;
        }
        //done

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
        //done

        private void collision_01(PictureBox block)
        {
            

                #region collision_01

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
            //k = 1;
            #region side collision
            if (Player.Right > block.Left &&
                Player.Left < block.Right - Player.Width / 2 &&
                Player.Top < block.Bottom &&
                Player.Bottom > block.Top + 25)
                if (k == 0)
                {
                    right = false;
                    Player.Left = block.Left - Player.Width;
                }
            if (Player.Left < block.Right &&
                Player.Right > block.Left + Player.Width / 2 &&
                Player.Top < block.Bottom &&
                Player.Bottom > block.Top + 25)
                if (k == 0)
                {
                    left = false;
                    Player.Left = block.Right;
                }
            #endregion

            k = 0;

            //#region simple fall
            //if (!(Player.Left + Player.Width > block.Left
            //    && Player.Left + Player.Width < block.Left + block.Width + Player.Width) &&
            //    Player.Top + Player.Height >= block.Top && Player.Top < block.Top)
            //{
            //    jump = false;
            //}
            //#endregion

            //#region Stop falling at bottom
            //if (Player.Top + Player.Height >= screen.Height)
            //{
            //    Player.Top = screen.Height - Player.Height; //Stop falling at bottom 
            //    jump = false;
            //}
            //else
            //{
            //    Player.Top += 5; //Falling
            //}
            //#endregion

                #endregion

            

        }
        //done

        private void collision_02(PictureBox block)
        {
            #region Top collision ->collision_02

            if (Player.Left + Player.Width - 5 > block.Left &&
                Player.Left + Player.Width + 5 < block.Left + block.Width + Player.Width &&
                Player.Top + Player.Height >= block.Top &&
                Player.Top < block.Top)
            {
                //Force = 0;
                //Player.Top = block.Location.Y - Player.Height;
                Player.Top = block.Top - Player.Height;
                jump = false;
                //if (right == true) { Player.Left += velocity; }
                //if (left == true) { Player.Left -= velocity; }

            }
            #endregion
            //TODO implement a better collision here 
            //ok now
        }
        //done

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {

            #region PLAYER1 
            if (e.KeyCode == Keys.A)
            {
                left = false; //moves left
                Player.Image = Properties.Resources.standing_left;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false; //moves right
                Player.Image = Properties.Resources.standing_right;
            }

            if (e.KeyCode == Keys.W)
            {
                //jump = false;
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

                if (e.KeyCode == Keys.S) //crouch
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

            #endregion

            #region PLAYER2
            if (e.KeyCode == Keys.Right)
            {
                right_02 = false;

            }
            if (e.KeyCode == Keys.Left)
            {
                left_02 = false;

            }
            #endregion
        }
        //done

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); } //Esc-> to exit

            #region Movement PLAYER 1
            if (e.KeyCode == Keys.A) //moves left
            {
                Player.Image = Properties.Resources.walk_left;
                direction = 0;
                walkleft = true;
                left = true;
            }
            if (e.KeyCode == Keys.D) //moves right
            {
                Player.Image = Properties.Resources.walk_right;
                direction = 1;
                walkright = true;
                right = true;
            }

            if(e.KeyCode==Keys.S) //crouch
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
                if (e.KeyCode == Keys.W)
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



            //player_02
            if (e.KeyCode == Keys.D2)
            {
                if (player_02_exist == false)
                {
                    //add_player_02();
                    player_02_exist = true;
                }

                if (player_02_exist == true)
                {
                    Controls.Add(player_02); player_02.Show(); player_02.BringToFront();
                    Controls.Add(Lifebar_player_02); Lifebar_player_02.Show(); Lifebar_player_02.BringToFront();
                    
                    if (e.KeyCode == Keys.Right)
                    {
                        right_02 = true;
                        direction_02 = 1;
                    }

                    if (e.KeyCode == Keys.Left)
                    {
                        left_02 = true;
                        direction_02 = 0;
                    }

                    if (e.KeyCode == Keys.Up)                    // SARITURA

                        if (jump_02 == false)
                        {
                            jump_02 = true;
                            Force_02 = G_02;
                        }

                    if (e.KeyCode == Keys.NumPad5)
                    {
                        bullet_number_02++;
                        bullet_02[bullet_number_02] = new PictureBox();
                        bullet_02[bullet_number_02].Top = player_02.Top + player_02.Height / 3;
                        bullet_02[bullet_number_02].Left = player_02.Left;
                        bullet_02[bullet_number_02].Height = 80;
                        bullet_02[bullet_number_02].Width = 38;

                        bullet_02[bullet_number_02].Image = Properties.Resources.bullet;
                        bullet_02[bullet_number].SizeMode = PictureBoxSizeMode.AutoSize;

                        Controls.Add(bullet_02[bullet_number_02]);
                        bullet[bullet_number].BringToFront();
                        bullet[bullet_number].Show();
                        bullet_active_02 = true;

                        bullet_direction_02[bullet_number_02] = new int();
                        bullet_direction_02[bullet_number_02] = direction_02;


                        //Resolution changed
                        if (x_ax != 1 || y_ax != 1)
                        {
                            bullet_02[bullet_number_02].Height = y_ax * bullet_02[bullet_number_02].Height / y_ax_original;
                            bullet_02[bullet_number_02].Width = x_ax * bullet_02[bullet_number_02].Width / x_ax_original;
                            bullet_02[bullet_number_02].Top = player_02.Top + player_02.Height / 3;
                            bullet_02[bullet_number_02].Left = player_02.Left;
                            bullet_02[bullet_number_02].SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }

            }

            void add_player_02() //ADD P2 IMAGES
            {
                //player_02.Show();
                //player_02 = new PictureBox();
                //player_02.Height = 75;
                //player_02.Width = 69;
                //player_02.Top = 607; //376;
                //player_02.Left = 1269;
                //player_02.Image = Properties.Resources.p2standright; //to be implemented
                //player_02.SizeMode = PictureBoxSizeMode.StretchImage;
                //Controls.Add(player_02);
                //player_02.Show();
                //player_02.BringToFront();

                //ground_02 = solid_ground.Top - player_02.Height;
                //int solid_ground;
                //solid_ground.Location = new Point(1269, 604);
                //ground_02 = new Point(1269, 604);
                player_02.SendToBack();

                // lifebar
                //Lifebar_player_02 = new ProgressBar();
                //Lifebar_player_02.Height = 30;
                //Lifebar_player_02.Width = 280;
                //Lifebar_player_02.Top = 13;
                //Lifebar_player_02.Left = 190;
                //Lifebar_player_02.Value = 100;
                //Controls.Add(Lifebar_player_02);


                //inventory creation
                //inventory_01_player_02 = new PictureBox();
                //inventory_02_player_02 = new PictureBox();
                //inventory_03_player_02 = new PictureBox();
                //inventory_04_player_02 = new PictureBox();

                //inventory_01_player_02.Top = 13;
                //inventory_01_player_02.Left = 13;
                //inventory_01_player_02.Height = 32;
                //inventory_01_player_02.Width = 32;
                //inventory_01_player_02.Image = Properties.Resources.inventory_slot;
                //Controls.Add(inventory_01_player_02);

                //inventory_02_player_02.Top = 13;
                //inventory_02_player_02.Left = 51;
                //inventory_02_player_02.Height = 32;
                //inventory_02_player_02.Width = 32;
                ////inventory_02_player_02.Image = Properties.Resources.inventory_slot;
                //Controls.Add(inventory_02_player_02);

                //inventory_03_player_02.Top = 13;
                //inventory_03_player_02.Left = 89;
                //inventory_03_player_02.Height = 32;
                //inventory_03_player_02.Width = 32;
                //inventory_03_player_02.Image = Properties.Resources.inventory_slot;
                //Controls.Add(inventory_03_player_02);

                //inventory_04_player_02.Top = 13;
                //inventory_04_player_02.Left = 127;
                //inventory_04_player_02.Height = 32;
                //inventory_04_player_02.Width = 32;
                //inventory_04_player_02.Image = Properties.Resources.inventory_slot;
                //Controls.Add(inventory_04_player_02);

                
                Player.Show();
                player_02.Show();


                if (x_ax != 1 || y_ax != 1) if_resolution_differs_add_player_02();
            }
            //ADD P2 IMAGES

            
        }
        //add player2's images 


        private void right_left_move_player_02()
        {
            if (right_02 == true)      //move right
            {
                player_02.Left += velocity;
                //player_02.Image = Properties.Resources.player2_right;
            }
            else if (left_02 == true)      //move left
            {
                player_02.Left -= velocity;
                //player_02.Image = Properties.Resources.player2_left;
            }
        }
        //add player2's images

        private void jumping_player_02()
        {
            if (jump_02 == true)
            {
                player_02.Top -= Force_02;
                Force_02 -= 1;
            }

            if (player_02.Top >= ground_02)
            {
                player_02.Top = ground_02;
                jump_02 = false;
            }

            else player_02.Top += 5;
        }
        //done

        private void collision_01_player_02(PictureBox block)
        {
            int k = 0;// resetare, daca sari la block.bottom atunci se reseteaza in stanga / dreapta

            if (player_02.Left + player_02.Width - 5 > block.Left) // blocked. bottom - limita
                if (player_02.Left + player_02.Width + 5 < block.Left + block.Width + player_02.Width)
                    if (player_02.Top <= block.Bottom)  // or k = 1;
                        if (player_02.Top > block.Top)
                        {
                            k = 1;  // or  if (player.Top <= block.Bottom+10);
                            //player_02.Image = Image.FromFile("chowder_small.png");
                            jump_02 = false;
                            Force_02 = 0;
                            jump_02 = true;
                        }

            if (player_02.Right > block.Left)  // blocked. left - limita
                if (player_02.Left < block.Right - player_02.Width / 2)
                    if (player_02.Bottom > block.Top + 20)   // +20 pentru platforma (sa nu se reseteze in stanga)
                        if (player_02.Top < block.Bottom)
                            if (k == 0)
                            {
                                right_02 = false;
                                player_02.Left = block.Left - player_02.Width;
                            }

            if (player_02.Left < block.Right) // blocked. right - limita
                if (player_02.Right > block.Left + player_02.Width / 2)
                    if (player_02.Bottom > block.Top + 20)   // +20 pentru platforma (sa nu se reseteze in dreapta)
                        if (player_02.Top < block.Bottom)
                            if (k == 0)
                            {
                                left_02 = false;
                                player_02.Left = block.Right;
                            }
            k = 0;
            //if (!(player.Left + player.Width > block.Left &&
            // player.Left + player.Width < block.Left + block.Width + player.Width) && 
            // player.Top + player.Height >= block.Top && player.Top < block.Top) 
            // jump = true;
        }
        //done

        private void collision_02_player_02(PictureBox block) //top collision
        {
            if (player_02.Left + player_02.Width - 5 > block.Left) // blocked. top - limita
                if (player_02.Left + player_02.Width + 5 < block.Left + block.Width + player_02.Width)
                    if (player_02.Top + player_02.Height >= block.Top)
                        if (player_02.Top < block.Top)
                        {
                            player_02.Top = block.Top - player_02.Height; // block.top = block.location.Y
                            jump_02 = false;
                            // Force = 0;
                        }
        }
        //done


        private void bullet_moving_player_02(PictureBox enemy)
        {
            int k = 0;
            for (int i = 1; i <= bullet_number; i++)
            {
                //if (bullet_direction[i] == 1)
                if (bullet_direction_02[i] == 0)
                {
                    if (bullet_02[i].Bounds.IntersectsWith(block1.Bounds)) bullet_02[i].Dispose(); //bullet[i].Left = 3000;
                    else if (bullet_02[i].Bounds.IntersectsWith(platform.Bounds)) bullet_02[i].Dispose();//bullet[i].Left = 3000;
                }
                else if (bullet_02[i].Left < 2000) { bullet_02[i].Left += 15; k++; }
                //else if (bullet_direction[i] == 0)
                if (bullet_direction_02[i] == 1)
                {
                    if (bullet_02[i].Bounds.IntersectsWith(block1.Bounds)) bullet_02[i].Dispose();//bullet[i].Left = -200;
                    else if (bullet_02[i].Bounds.IntersectsWith(platform.Bounds)) bullet_02[i].Dispose(); //bullet[i].Left = -200;
                }
                else if (bullet_02[i].Left > -100) { bullet_02[i].Left -= 15; k++; }

                else if (bullet_02[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    bullet_02[i].Left = -200;
                    if (Life.Value > 30)
                    {
                        Life.Value -= 30;
                        
                    }
                    else
                    {
                        Life.Value = 0;
                        
                        timer1.Stop();
                        MessageBox.Show("P2 castiga !");
                        Cursor.Show();
                        this.Close();
                        //menu main_menu = new menu();
                        //main_menu.Show();
                    }
                }
                if (bullet_02[i].Bounds.IntersectsWith(enemy.Bounds))
                {
                    enemy.Dispose();
                }
            }
            if (k == 0) bullet_active_02 = false;
        }
        //add collisions with all blocks!!


        private void collect(PictureBox item)
        {
            if (Player.Bounds.IntersectsWith(item.Bounds))
                
                    ticket_inventory++;

                    if (ticket_inventory == 1)
                    {
                //slot1.Image = Properties.Resources.fly;     //sau * = item.Image;
                slot1.Image = item.Image;
                fly1.Dispose();
                        if (Life.Value + 20 < 100) Life.Value += 20;         //life increases
                        else Life.Value = 100;

                    }

                    else if (ticket_inventory == 2)
                    {
                        slot2.Image = Properties.Resources.fly;     //sau * = item.Image;
                        fly2.Dispose();
                if (Life.Value + 20 < 100) Life.Value += 20;         //life increases
                        else Life.Value = 100;

                    }
                    else if (ticket_inventory == 3)
                    {
                      slot3.Image = Properties.Resources.fly;     //sau * = item.Image;
                        fly3.Dispose();
                if (Life.Value + 20 < 100) Life.Value += 20;         //life increases
                       else Life.Value = 100;

                   }
                   else if (ticket_inventory == 4)
                   {
                     slot4.Image = Properties.Resources.fly;     //sau * = item.Image;
                        fly4.Dispose();
                if (Life.Value + 20 < 100) Life.Value += 20;         //life increases
                     else Life.Value = 100;

                    }
                    
                
        }
        //done

        private void collect_player_02(PictureBox item)
        {
            if (player_02.Bounds.IntersectsWith(item.Bounds))

                ticket_inventory++;

            if (ticket_inventory == 1)
            {
                slot5.Image = Properties.Resources.fly;     //sau * = item.Image;
                fly1.Dispose();
                if (Lifebar_player_02.Value + 20 < 100) Lifebar_player_02.Value += 20;         //life increases
                else Lifebar_player_02.Value = 100;

            }

            else if (ticket_inventory == 2)
            {
                slot6.Image = Properties.Resources.fly;     //sau * = item.Image;
                fly2.Dispose();
                if (Lifebar_player_02.Value + 20 < 100) Lifebar_player_02.Value += 20;         //life increases
                else Lifebar_player_02.Value = 100;

            }
            else if (ticket_inventory == 3)
            {
                slot7.Image = Properties.Resources.fly;     //sau * = item.Image;
                fly3.Dispose();
                if (Lifebar_player_02.Value + 20 < 100) Lifebar_player_02.Value += 20;         //life increases
                else Lifebar_player_02.Value = 100;

            }
            else if (ticket_inventory == 4)
            {
                slot8.Image = Properties.Resources.fly;     //sau * = item.Image;
                fly4.Dispose();
                if (Lifebar_player_02.Value + 20 < 100) Lifebar_player_02.Value += 20;         //life increases
                else Lifebar_player_02.Value = 100;

            }
        }
        //done

       
        private void enemy_move(PictureBox enemy, int lft, int rgt)     
        {
            if (enemy.Left <= lft) miscare = 3;
            if (enemy.Right >= rgt) miscare = -3;
            enemy.Left += miscare;
            

            if (miscare == 3) enemy.Image = Properties.Resources.enemyright;
            if (miscare == -3) enemy.Image = Properties.Resources.enemyleft;

            if (Player.Bounds.IntersectsWith(enemy.Bounds))
            {
                
                enemy_hittime = 1;

                if (lovit > 100)
                {
                    lovit = 0;
                    if (Life.Value - 25 > 0)
                    {
                        Life.Value -= 25;
                    }
                    else
                    {
                        Life.Value = 0;
                        jump = true;
                        Force = G;
                        ground += 2000;
                        inchide = 150;
                        dieonce++;
                        if (dieonce == 1 && direction == 0)
                        {
                            Player.Image = Properties.Resources.faintleft;
                        }
                        else if (dieonce == 1 && direction == 1)
                        {
                            Player.Image = Properties.Resources.faintright;
                        }
                        if (dieonce == 1) MessageBox.Show("Player 1 a pierdut");
                        Cursor.Show();
                        this.Close();
                        //menu main_menu = new menu();
                        //main_menu.Show();
                    }
                }
            }
            
            if (enemy_hittime != 0) enemy_hittime++;
            if (enemy_hittime > 200)
            {
                enemy_hittime = 0;
                
            }

            if (lovit < 210) lovit++;
            if (inchide <= lovit) Application.Exit();
        }

        private void enemy_collision_p2(PictureBox enemy)
        {
            if (player_02.Bounds.IntersectsWith(enemy.Bounds))
            {
                
                enemy_hittime_02 = 1;

                if (lovit_02 > 100)
                {
                    lovit_02 = 0;
                    if (Lifebar_player_02.Value - 25 > 0)
                    {
                        Lifebar_player_02.Value -= 25;
                    }
                    else
                    {
                        Lifebar_player_02.Value = 0;
                        jump_02 = true;
                        Force_02 = G_02;
                        ground_02 += 2000;
                        inchide_02 = 150;
                        dieonce_02++;
                        if (dieonce_02 == 1) MessageBox.Show("Player 2 a pierdut");
                        Cursor.Show();
                        this.Close();
                        //menu main_menu = new menu();
                        //main_menu.Show();
                    }
                }
            }

            if (enemy_hittime != 0) enemy_hittime++;
            if (enemy_hittime > 200)
            {
                enemy_hittime = 0;

            }

            if (lovit < 210) lovit++;
            if (inchide <= lovit) Application.Exit();
        }



        private void Level_finish()
        {
            //TODO
        }












            //END!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


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


    }
}