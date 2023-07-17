using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaketballGameSimulator2._0.Controllers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BaketballGameSimulator2._0
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            
            panel1.Visible = false;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            gameTimePicker2.Format = DateTimePickerFormat.Time;
            gameTimePicker2.ShowUpDown = true;
            new Presentor().FillingForGameComboBox(hostTeamComboBox);
            new Presentor().FillingForGameComboBox(guestTeamComboBox);
            
        }
        private void hostTeamComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            new Presentor().RetrieveForGameTableS(hostTeamDataGridView, hostTeamComboBox.Text);
            new Presentor().RetriveCoach(hostCoachTextBox, hostTeamComboBox.Text);
            hostTeamDataGridView.Columns[18].Visible = false;
            hostTeamDataGridView.Columns[0].Visible = false;
            hostTeamDataGridView.Columns[4].Visible = false;
            hostTeamDataGridView.Columns[5].Visible = false;
            hostTeamDataGridView.Columns[6].Visible = false;
            hostTeamDataGridView.Columns[7].Visible = false;
            hostTeamDataGridView.Columns[8].Visible = false;
            hostTeamDataGridView.Columns[9].Visible = false;
            hostTeamDataGridView.Columns[10].Visible = false;
            hostTeamDataGridView.Columns[11].Visible = false;
            hostTeamDataGridView.Columns[12].Visible = false;
            hostTeamDataGridView.Columns[13].Visible = false;
            hostTeamDataGridView.Columns[14].Visible = false;
            hostTeamDataGridView.Columns[15].Visible = false;
            hostTeamDataGridView.Columns[16].Visible = false;
            hostTeamDataGridView.Columns[17].Visible = false;
        }
        private void guestTeamComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            new Presentor().RetrieveForGameTableS(guestTeamDataGridView, guestTeamComboBox.Text);
            new Presentor().RetriveCoach(guestCoachTextBox, guestTeamComboBox.Text);
            guestTeamDataGridView.Columns[18].Visible = false;
            guestTeamDataGridView.Columns[0].Visible = false;
            guestTeamDataGridView.Columns[4].Visible = false;
            guestTeamDataGridView.Columns[5].Visible = false;
            guestTeamDataGridView.Columns[6].Visible = false;
            guestTeamDataGridView.Columns[7].Visible = false;
            guestTeamDataGridView.Columns[8].Visible = false;
            guestTeamDataGridView.Columns[9].Visible = false;
            guestTeamDataGridView.Columns[10].Visible = false;
            guestTeamDataGridView.Columns[11].Visible = false;
            guestTeamDataGridView.Columns[12].Visible = false;
            guestTeamDataGridView.Columns[13].Visible = false;
            guestTeamDataGridView.Columns[14].Visible = false;
            guestTeamDataGridView.Columns[15].Visible = false;
            guestTeamDataGridView.Columns[16].Visible = false;
            guestTeamDataGridView.Columns[17].Visible = false;
        }




        private void gameButton_Click_1(object sender, EventArgs e)
        {
            int countplayershost = hostTeamDataGridView.Rows.Count;

            int countplayersguest = guestTeamDataGridView.Rows.Count;
            if (countplayershost >= 6 && countplayersguest >= 6)

            {

                new Presentor().UpdatePlayerEfficiancyForHost(hostTeamDataGridView, gameTimePicker1, gameButton, gameTimePicker2, countplayershost);
                new Presentor().UpdatePlayerEfficiancyForGuest(guestTeamDataGridView, gameTimePicker1, gameButton, gameTimePicker2, countplayersguest);

                new Presentor().GameFunction(resultOfGuestTexttBox, resultOfHostTextBox);
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Team illegible to play!Not enough players!");
            }

        }        
        
       

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}

