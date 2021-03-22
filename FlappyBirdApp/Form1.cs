using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace FlappyBirdApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        // oyun içeriği :
        int sayaczaman = 0;
        int sayacskor = 0;
        string skorum = "";

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
                     
            timer1.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            
        }
        private void fbKus_Click(object sender, EventArgs e)
        {
            

            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                fbKus.Top -= 50;
            }
        }
        void frmGameOver()
        {
            frmGameOver fr = new frmGameOver();
            fr.Show();
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            int a = 1237;
            fbKus.Top += 8;

            fbAlt.Left -= 5;
            fbUst.Left -= 5;

            fbAlt2.Left -= 5;
            fbUst2.Left -= 5;

            fbAlt3.Left -= 5;
            fbUst3.Left -= 5;

            fbAlt4.Left -= 5;
            fbUst4.Left -= 5;

            fbAlt5.Left -= 5;
            fbUst5.Left -= 5;

            if (fbAlt.Left<=0 && fbUst.Left<=0)
            {
                if (fbAlt.Left <= 50 && fbUst.Left <= 50)
                {
                    sayacskor += 1;
                    lblSkor.Text = sayacskor.ToString();
                }

                fbAlt.Left = a;
                fbUst.Left = a;
            }
            else if (fbAlt2.Left <= 0 && fbUst2.Left <= 0)
            {
                if (fbAlt2.Left <= 50 && fbUst2.Left <= 50)
                {
                    sayacskor += 1;
                    lblSkor.Text = sayacskor.ToString();
                }

                fbAlt2.Left = a;
                fbUst2.Left = a;
            }
            else if (fbAlt3.Left <= 0 && fbUst3.Left <= 0)
            {
                if (fbAlt3.Left <= 50 && fbUst3.Left <= 50)
                {
                    sayacskor += 1;
                    lblSkor.Text = sayacskor.ToString();
                }

                fbAlt3.Left = a;
                fbUst3.Left = a;
            }
            else if (fbAlt4.Left <= 0 && fbUst4.Left <= 0)
            {
                if (fbAlt4.Left <= 50 && fbUst4.Left <= 50)
                {
                    sayacskor += 1;
                    lblSkor.Text = sayacskor.ToString();
                }

                fbAlt4.Left = a;
                fbUst4.Left = a;
            }
            else if (fbAlt5.Left <= 0 && fbUst5.Left <= 0)
            {
                if (fbAlt5.Left <= 50 && fbUst5.Left <= 50)
                {
                    sayacskor += 1;
                    lblSkor.Text = sayacskor.ToString();
                }    

                fbAlt5.Left = a;  
                fbUst5.Left = a;
            }

            if (fbKus.Top <= 0 || fbKus.Bottom>=549)
            {
                if (fbKus.Bottom >= 549)
                {
                    fbKus.Parent = fbButtom   ;
                    fbKus.BackColor = Color.Transparent;  
                }  
                frmGameOver();               
            }

            if (fbKus.Top<=fbUst.Bottom && fbKus.Left>=fbUst.Left)
            {
                frmGameOver();
            }
            else if (fbKus.Top <= fbUst2.Bottom && fbKus.Left >= fbUst2.Left)
            {
                frmGameOver();
            }
            else if (fbKus.Top <= fbUst3.Bottom && fbKus.Left >= fbUst3.Left)
            {
                frmGameOver();
            }
            else if (fbKus.Top <= fbUst4.Bottom && fbKus.Left >= fbUst4.Left)
            {  
                frmGameOver();
            }
            else if (fbKus.Top <= fbUst5.Bottom && fbKus.Left >= fbUst5.Left)
            {
                frmGameOver();
            }

            if (fbKus.Bottom >= fbAlt.Top && fbKus.Left >= fbAlt.Left)
            {
                frmGameOver();
            }
            else if (fbKus.Bottom >= fbAlt2.Top && fbKus.Left >= fbAlt2.Left)
            {  
                frmGameOver();
            }
            else if (fbKus.Bottom >= fbAlt3.Top && fbKus.Left >= fbAlt3.Left)
            {
                frmGameOver();
            }
            else if (fbKus.Bottom >= fbAlt4.Top && fbKus.Left >= fbAlt4.Left)
            {
                frmGameOver();
            }
            else if (fbKus.Bottom >= fbAlt5.Top && fbKus.Left >= fbAlt5.Left)
            {
                frmGameOver();
            }
        }
        private void fbAlt_Click(object sender, EventArgs e)
        {
            

            
            


        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                fbKus.Top -= 70;
            }
        }
        private void fbKus_Click_1(object sender, EventArgs e)
        {

        }
    }
}

