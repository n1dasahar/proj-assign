using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        bool jumping = true;
        int pipespeed =5;
       int gravity=5;
        int Inscore = 0;
        
        

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Game Over";
            label3.Text = "Your Final Score is:"+Inscore;
            label4.Text = "Game Design By Your Name Here";

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            flappyBird.Top+=gravity;
            label1.Text = ""+Inscore;
            if (pipebottom.Left < -80)
            {
                pipebottom.Left = 1000;
                Inscore += 1;
            }
           else if (pipetop.Left < -95)
            {
                pipetop.Left = 1100;
                Inscore += 1;
            }
         if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
               EndGame();
               
            }
          else  if (flappyBird.Bounds.IntersectsWith(pipebottom.Bounds))
            {
               EndGame();
            }
           else if (flappyBird.Bounds.IntersectsWith(pipetop.Bounds))
            {
                EndGame();
            }
            
        }
        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                {
                jumping = true;
                gravity = -5;
            }
           
           
        }
        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
               jumping = false;
                gravity = 5;
            }
          /*  else
           {
               gravity =- 5;
           }*/
        }
        public void EndGame()
        {
            gametimer.Stop();
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

