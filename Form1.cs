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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
        }

        public void IsKeyPressed(Keys Up)
        {
           // PictureBox model = new PictureBox();
           // model.Top += 200;
        }

        public void move(object sender, KeyEventArgs e)
        {
            //PictureBox model = new PictureBox();
            //if (Keyboard.IsKeyDown(Key.Up))
            //if (e.KeyCode == Keys.Up)
              //  pictureBox1.Top += 200;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) //jumping
            {
                pictureBox1.Top -= 10;
            }
            
            if (e.KeyCode == Keys.Left) 
            {
                pictureBox1.Left -= 10; //moving left
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 10; //moving right
            }

            //if (e.KeyCode == Keys.Down)
            //{
            //    pictureBox1.Top += 10; //moving down but not needed
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
