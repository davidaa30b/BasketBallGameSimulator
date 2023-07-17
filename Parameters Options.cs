using BaketballGameSimulator2._0.Controllers;
using BaketballGameSimulator2._0.Views;
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
    public partial class Parameters_Options : Form,Iparametars_table
    {
        public Parameters_Options()
        {
            
            InitializeComponent();
            dataGridView1.Visible = true;
            new Presentor().RetriveForParametarsSettings(dataGridView1);
        }

        public string EfficiancyRaiseMinimum 
        { 
            get => minRaiseEfficiancyTextBox.Text;
            set => minRaiseEfficiancyTextBox.Text=value;
        }
        public string EfficiancyRaiseMaximum 
        { 
            get => maxRaiseEfficiancyTextBox.Text;
            set => maxRaiseEfficiancyTextBox.Text=value; 
        }
        public string EfficiancyDeclineMinimum 
        { 
            get => minDeclineEfficiancyTextBox.Text;
            set => minDeclineEfficiancyTextBox.Text=value;
        }
        public string EfficiancyDeclineMaximum 
        { 
            get => maxDeclineEfficiancyTextBox.Text; 
            set => maxDeclineEfficiancyTextBox.Text=value;
        }
        public string MinimalAgeForDraft
        { 
            get => minAgeDraftTextBox.Text; 
            set => minAgeDraftTextBox.Text=value;
        }
        public string MinimalAllowedEfficiancy 
        { 
            get => minAllowedEfficiancyTextBox.Text;
            set => minAllowedEfficiancyTextBox.Text=value; 
        }
        public string MaximumAllowedEfficiancy
        { 
            get => maxAllowedEfficiancyTextBox.Text;
            set => maxAllowedEfficiancyTextBox.Text=value;
        }
        public string EmotionalConst
        { 
            get => emotionalTextBox.Text; 
            set => emotionalTextBox.Text=value; 
        }
        public string PhysicalConst 
        { 
            get => physicalTextBox.Text; 
            set => physicalTextBox.Text=value;
        }
        public string IntellectuallConst 
        { 
            get => IntellectualTextBox.Text; 
            set => IntellectualTextBox.Text=value;
        }
        public string DailyStatus
        { 
            get => dailyStatusTextBox.Text;
            set => dailyStatusTextBox.Text=value; 
        }
        private void ClearInformation()
        {
            minRaiseEfficiancyTextBox.Text = "";
            maxRaiseEfficiancyTextBox.Text = "";
            minDeclineEfficiancyTextBox.Text = "";
            maxDeclineEfficiancyTextBox.Text = "";
            minAgeDraftTextBox.Text = "";
            minAllowedEfficiancyTextBox.Text = "";
            maxAllowedEfficiancyTextBox.Text = "";
            emotionalTextBox.Text = "";
            physicalTextBox.Text = "";
            IntellectualTextBox.Text = "";
            dailyStatusTextBox.Text = "";
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            new Presentor().RetriveForParametarsSettings(dataGridView1);
        }

        private void Parameters_Options_Load(object sender, EventArgs e)
        {
            minRaiseEfficiancyTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            maxRaiseEfficiancyTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            minDeclineEfficiancyTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maxDeclineEfficiancyTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            minAgeDraftTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            minAllowedEfficiancyTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            maxAllowedEfficiancyTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            emotionalTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            physicalTextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            IntellectualTextBox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dailyStatusTextBox.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearInformation();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            new Presentor(this).UpdateForParametarsSettings(1);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            new Presentor(this).UpdateForParametarsSettings(1);
            this.Hide();
            new MainMenu().Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

       
    } 
}
