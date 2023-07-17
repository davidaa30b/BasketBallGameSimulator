using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaketballGameSimulator2._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }
        private void MainMenu_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.HomeScreen;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {

            pictureBox1.Image = Properties.Resources.teamPicture;                     
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.playersPicture; 
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.parametarsPicturesss;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gamePictures;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Team_Options().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Player_Menu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Parameters_Options().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game().Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FormAnimation.AnimateWindow(this.Handle, 2000, FormAnimation.BLEND);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
