using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaketballGameSimulator2._0
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 7;
           
            if(panel2.Width>=panel1.Width)
            { 
                timer1.Stop();
                this.Hide();
                new MainMenu().FormClosed += (s, args) => this.Close();
                new MainMenu().Show();
                new MainMenu().Focus();

            }
        }
        
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
           // MovingObjectTimer.Start();
        }

        private void MovingObjectTimer_Tick(object sender, EventArgs e)
        {
            //if( panel2.Width >= panel1.Width)
            //    {
            //    if (pictureBox1.Location.X <= 263)
            //    {
            //        pictureBox1.Location = new Point(pictureBox1.Location.X + 13, pictureBox1.Location.Y);
            //    }
            //    else
            //    {
            //        MovingObjectTimer.Stop();
                    

            //    }
            //}                    
        }
    }
}
