
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaketballGameSimulator2._0.Controllers;
using BaketballGameSimulator2._0.Views;

namespace BaketballGameSimulator2._0
{
    public partial class Team_Options : Form, Iteamsinfo
    {
        
        public Team_Options()
        {
            InitializeComponent();
            

            
        }

        string Iteamsinfo.Name 
        { 
            get => teamNameTextBox.Text; 
            set => teamNameTextBox.Text=value; 
        }
        string Iteamsinfo.Location 
        { 
            get => teamLocationTextBox.Text; 
            set => teamLocationTextBox.Text=value; 
        }
        string Iteamsinfo.Coach 
        { 
            get => teamCoachTextBox.Text; 
            set => teamCoachTextBox.Text=value;
        }
        string Iteamsinfo.Manager
        {
            get => teamManagerTextBox.Text;
            set => teamManagerTextBox.Text = value;
        }
        string Iteamsinfo.Owner 
        { 
            get => teamOwnerTextBox.Text;
            set => teamOwnerTextBox.Text=value; 
        }
        string Iteamsinfo.EstablishmentDate
        { 
            get => teamDateTextBox.Text; 
            set => teamDateTextBox.Text=value; 
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Presentor presentor = new Presentor(this);
            presentor.AddFunctionForTeamOptions();
            presentor.RetrieveForTeamOptions(dataGridView1);
            ClearInformation();
        }
        
        

        private void retriveButton_Click(object sender, EventArgs e)
        {
            new Presentor().RetrieveForTeamOptions(dataGridView1);
            ClearInformation();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            new Presentor().DeleteForTeamOptions(id);
            new Presentor().RetrieveForTeamOptions(dataGridView1);
            ClearInformation();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            new Presentor().RetrieveForTeamOptions(dataGridView1);
            ClearInformation();
        }
        private void updateButtom_Click(object sender, EventArgs e)
        {
           
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            new Presentor(this).UpdateForTeamOptions(id);
            new Presentor().RetrieveForTeamOptions(dataGridView1);
            ClearInformation();
        }

        
        private void ClearInformation()
        {
            teamNameTextBox.Text = "";
            teamLocationTextBox.Text = "";
            teamCoachTextBox.Text = "";
            teamManagerTextBox.Text = "";
            teamOwnerTextBox.Text = "";
            teamDateTextBox.Text = "";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

       
        private void Team_Options_Load(object sender, EventArgs e)
        {
            new Presentor().RetrieveForTeamOptions(dataGridView1);
            dataGridView1.Columns[0].Visible = false;
          
        }           

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            teamNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            teamLocationTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            teamCoachTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            teamManagerTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            teamOwnerTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            teamDateTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        
    }
}
