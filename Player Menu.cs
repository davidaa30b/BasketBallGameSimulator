using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BaketballGameSimulator2._0.Controllers;
using BaketballGameSimulator2._0.Views;

namespace BaketballGameSimulator2._0
{
    public partial class Player_Menu : Form,Iplayer_character
    {
        public Player_Menu()
        {
            InitializeComponent();
            new Presentor().RetrieveForPlayerOptions(dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            playerFirstNameTextBox.MaxLength = 10;
            playerLastNameTextBox.MaxLength = 10;          
            playerDraftShapeTextBox.MaxLength = 2;
            playerMaxOverallTextBox.MaxLength = 2;
            playerRiseTextBox.MaxLength = 3;
            playerDeclineTextBox.MaxLength = 4;
            emotionalConstTextBox.MaxLength = 3;
            physicallityTextBox.MaxLength = 3;
            intellectTextBox.MaxLength = 3;
            dailyStatusTextBox.MaxLength = 3;

        }

       
        public string Firstname
        { 
            get => playerFirstNameTextBox.Text; 
            set => playerFirstNameTextBox.Text=value; 
        }
        public string Lastname
        {
            get => playerLastNameTextBox.Text; 
            set => playerLastNameTextBox.Text=value;
        }
        public string Positon 
        { 
            get => listOfPositionsComboBox.Text; 
            set => listOfPositionsComboBox.Text=value; 
        }
        public string Team 
        { 
            get => listOfTeamsComboBox.Text; 
            set => listOfTeamsComboBox.Text=value;
        }
        public string DateOfBirth 
        { 
            get => dateBirthTimePicker.Text;
            set => dateBirthTimePicker.Text=value; 
        }
        public string DateOfDraft
        {
            get => dateDraftTimePicker.Text;
            set => dateDraftTimePicker.Text=value;
        }
        public string DeclineDate
        { 
            get => dateDeclineTimePicker.Text; 
            set => dateDeclineTimePicker.Text=value;
        }
        public string RetireDate 
        { 
            get => dateRetirementTimePicker.Text;
            set => dateRetirementTimePicker.Text=value; 
        }
        public string DraftOverall
        { 
            get => playerDraftShapeTextBox.Text; 
            set => playerDraftShapeTextBox.Text=value;
        }
        public string MaximumOverall
        { 
            get => playerMaxOverallTextBox.Text; 
            set => playerMaxOverallTextBox.Text=value; 
        }
        public string DeclineFactor
        { 
            get => playerDeclineTextBox.Text; 
            set => playerDeclineTextBox.Text=value;
        }
        public string RaiseFactor 
        { 
            get => playerRiseTextBox.Text;
            set => playerRiseTextBox.Text=value;
        }
        public string EmotionalConst 
        { 
            get => emotionalConstTextBox.Text; 
            set => emotionalConstTextBox.Text=value;
        }
        public string PhysicalConst 
        { 
            get => physicallityTextBox.Text; 
            set => physicallityTextBox.Text=value; 
        }
        public string IntellectualConst 
        { 
            get => intellectTextBox.Text;
            set => intellectTextBox.Text=value;
        }
        public string DailyStatus 
        { 
            get => dailyStatusTextBox.Text;
            set => dailyStatusTextBox.Text=value;
        }
        public string PeakTimeDay 
        { 
            get => dateTimePickerHourAndMinutesOnly.Text;
            set => dateTimePickerHourAndMinutesOnly.Text=value;
        }
        private void ClearInfo()
        {
            playerFirstNameTextBox.Text = "";
            playerLastNameTextBox.Text = "";
            listOfPositionsComboBox.Text = "";
            listOfTeamsComboBox.Text = "";
            dateBirthTimePicker.Text = "";
            dateDraftTimePicker.Text = "";
            dateDeclineTimePicker.Text = "";
            dateRetirementTimePicker.Text = "";
            playerDraftShapeTextBox.Text = "";
            playerMaxOverallTextBox.Text = "";
            playerDeclineTextBox.Text = "";
            playerRiseTextBox.Text = "";
            emotionalConstTextBox.Text = "";
            physicallityTextBox.Text = "";
            intellectTextBox.Text = "";
            dailyStatusTextBox.Text = "";
            dateTimePickerHourAndMinutesOnly.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new Presentor(this).AddFunctionForPlayerOptions();
            new Presentor().RetrieveForPlayerOptions(dataGridView1);
            ClearInfo();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            new Presentor().DeleteForPlayerOptions(id);
            new Presentor().RetrieveForPlayerOptions(dataGridView1);
            ClearInfo();
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            new Presentor().RetrieveForPlayerOptions(dataGridView1);
            ClearInfo();
        }

        private void clearButton_Click(object sender, EventArgs e)
        { 
            ClearInfo();
        }

        private void updateButtom_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            new Presentor(this).UpdateForPlayerOptions(id);
            new Presentor().RetrieveForPlayerOptions(dataGridView1);
            ClearInfo();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        

        private void filerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                new Presentor(this).FilterMethod(filerTextBox.Text, dataGridView1);
            }
        }
        private void ShowInTextBoxes()
        {
            if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[2].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[3].Value.ToString() == ""
             || dataGridView1.CurrentRow.Cells[4].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[5].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[6].Value.ToString() == ""
             || dataGridView1.CurrentRow.Cells[7].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[8].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[9].Value.ToString() == ""
             || dataGridView1.CurrentRow.Cells[10].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[11].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[12].Value.ToString() == ""
             || dataGridView1.CurrentRow.Cells[13].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[14].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[15].Value.ToString() == ""
             || dataGridView1.CurrentRow.Cells[16].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[17].Value.ToString() == "")
            {
                playerFirstNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                playerLastNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                listOfPositionsComboBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                listOfTeamsComboBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                MessageBox.Show("The player " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString() + " is lacking data");
            }
            else
            {
                playerFirstNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                playerLastNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                listOfPositionsComboBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                listOfTeamsComboBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


                dateBirthTimePicker.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dateDraftTimePicker.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dateDeclineTimePicker.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dateRetirementTimePicker.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                playerDraftShapeTextBox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                playerMaxOverallTextBox.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                playerDeclineTextBox.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                playerRiseTextBox.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                emotionalConstTextBox.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                physicallityTextBox.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();

                intellectTextBox.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                dailyStatusTextBox.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                dateTimePickerHourAndMinutesOnly.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowInTextBoxes();
        }
       
        private void Player_Menu_Load(object sender, EventArgs e)
        {
            ShowInTextBoxes();
            dateTimePickerHourAndMinutesOnly.Format = DateTimePickerFormat.Time;
            dateTimePickerHourAndMinutesOnly.ShowUpDown = true;
            new Presentor(this).FillingComboBox(listOfPositionsComboBox, listOfTeamsComboBox);
        }
        private void dateDraftTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            dateDraftTimePicker.CustomFormat = "dd-MM-yyyy";
            int minimalDraftAge;

            minimalDraftAge = new Presentor().RetrieveRestrictionsForPlayer("age");

            TimeSpan timeSpan = dateDraftTimePicker.Value - dateBirthTimePicker.Value;
            int timediff = timeSpan.Days + 1;
            int yeardiff = timediff / 365;

            if (dateBirthTimePicker.Value == dateBirthTimePicker.MinDate && dateDraftTimePicker.Value != dateDraftTimePicker.MinDate)
            {
                updateButtom.Enabled = false;
                addButton.Enabled = false;
                MessageBox.Show("Do no enter Draft date without Birth date");
            }
            else
                 if (yeardiff < minimalDraftAge)
            {
                updateButtom.Enabled = false;
                addButton.Enabled = false;
                MessageBox.Show("Invalid Draft date (Earliest Draft day is : " + dateBirthTimePicker.Value.AddYears(minimalDraftAge).ToString() + ")");
            }
            else
            {
                updateButtom.Enabled = true;
                addButton.Enabled = true;
            }
        }
        private void dateDeclineTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            dateDeclineTimePicker.CustomFormat = "dd-MM-yyyy";
            TimeSpan timeSpan2 = dateDeclineTimePicker.Value - dateDraftTimePicker.Value;
            int timediff2 = timeSpan2.Days + 1;

            if (dateDraftTimePicker.Value == dateDraftTimePicker.MinDate && dateDeclineTimePicker.Value != dateDeclineTimePicker.MinDate)
            {
                updateButtom.Enabled = false;
                addButton.Enabled = false;
                MessageBox.Show("Do no enter Decline date without Peak date");
            }
            else
                if (timediff2 < 0)
            {
                updateButtom.Enabled = false;
                addButton.Enabled = false;
                MessageBox.Show("Invalid Decline date ");
            }
            else
            {
                updateButtom.Enabled = true;
                addButton.Enabled = true;
            }
        }

        private void dateRetirementTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            dateRetirementTimePicker.CustomFormat = "dd-MM-yyyy";
            TimeSpan timeSpan3 = dateRetirementTimePicker.Value - dateDeclineTimePicker.Value;
            int timediff3 = timeSpan3.Days + 1;



            if (dateDeclineTimePicker.Value == dateDeclineTimePicker.MinDate && dateRetirementTimePicker.Value != dateRetirementTimePicker.MinDate)
            {
                updateButtom.Enabled = false;
                addButton.Enabled = false;
                MessageBox.Show("Do no enter Retirement date without Decline date");
            }
            else
               if (timediff3 < 0)
            {
                updateButtom.Enabled = false;
                addButton.Enabled = false;
                MessageBox.Show("Invalid Retirement date ");
            }
            else
            {
                updateButtom.Enabled = true;
                addButton.Enabled = true;
            }
        }

        private void dateBirthTimePicker_KeyDown_1(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateBirthTimePicker.CustomFormat = " ";
            }
        }

        private void dateDraftTimePicker_KeyDown_1(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateDraftTimePicker.CustomFormat = " ";
            }
        }

        private void dateDeclineTimePicker_KeyDown_1(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateDeclineTimePicker.CustomFormat = " ";
            }
        }
        private void dateRetirementTimePicker_KeyDown_1(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateRetirementTimePicker.CustomFormat = " ";
            }
        }
        private void playerMaxOverallTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void playerDraftShapeTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void playerRiseTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void playerDeclineTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void playerDraftShapeTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {

            double maximumAllowedEfficiency;
            double minimumAllowedEfficiency;

            minimumAllowedEfficiency = new Presentor().RetrieveRestrictionsForPlayer("minEff");
            maximumAllowedEfficiency = new Presentor().RetrieveRestrictionsForPlayer("maxEff");

            if (playerDraftShapeTextBox.Text != "" && (e.KeyCode == Keys.Enter))
            {
                if (int.Parse(playerDraftShapeTextBox.Text) < minimumAllowedEfficiency || int.Parse(playerDraftShapeTextBox.Text) > maximumAllowedEfficiency)
                {
                    updateButtom.Enabled = false;
                    addButton.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Draft shape between :" + minimumAllowedEfficiency + " and " + maximumAllowedEfficiency);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }

        private void playerDraftShapeTextBox_Leave_1(object sender, EventArgs e)
        {
            double maximumAllowedEfficiency;
            double minimumAllowedEfficiency;

            minimumAllowedEfficiency = new Presentor().RetrieveRestrictionsForPlayer("minEff");
            maximumAllowedEfficiency = new Presentor().RetrieveRestrictionsForPlayer("maxEff");


            if (playerDraftShapeTextBox.Text != "")
            {
                if (int.Parse(playerDraftShapeTextBox.Text) < minimumAllowedEfficiency || int.Parse(playerDraftShapeTextBox.Text) > maximumAllowedEfficiency)
                {
                    updateButtom.Enabled = false;
                    addButton.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Draft shape between :" + minimumAllowedEfficiency + " and " + maximumAllowedEfficiency);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }
        private void playerMaxOverallTextBox_Leave(object sender, EventArgs e)
        {
            double maximumAllowedEfficiency;
            double minimumAllowedEfficiency;

            minimumAllowedEfficiency = new Presentor().RetrieveRestrictionsForPlayer("minEff");
            maximumAllowedEfficiency = new Presentor().RetrieveRestrictionsForPlayer("maxEff");


            if (playerMaxOverallTextBox.Text != "")
            {
                if (float.Parse(playerMaxOverallTextBox.Text) < minimumAllowedEfficiency || float.Parse(playerMaxOverallTextBox.Text) > maximumAllowedEfficiency)
                {
                    updateButtom.Enabled = false;
                    addButton.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Max OverAll shape between :" + minimumAllowedEfficiency + " and " + maximumAllowedEfficiency);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }

        private void playerMaxOverallTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            double maximumAllowedEfficiency;
            double minimumAllowedEfficiency;

            minimumAllowedEfficiency = new Presentor().RetrieveRestrictionsForPlayer("minEff");
            maximumAllowedEfficiency = new Presentor().RetrieveRestrictionsForPlayer("maxEff");

            if (playerMaxOverallTextBox.Text != "" && (e.KeyCode == Keys.Enter))
            {
                if (float.Parse(playerMaxOverallTextBox.Text) < minimumAllowedEfficiency || float.Parse(playerMaxOverallTextBox.Text) > maximumAllowedEfficiency)
                {
                    updateButtom.Enabled = false;
                    addButton.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter MaxOverAll shape between :" + minimumAllowedEfficiency + " and " + maximumAllowedEfficiency);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }
        private void playerRiseTextBox_Leave(object sender, EventArgs e)
        {
            double maximumRaiseEfficiency;
            double minimumRaiseEfficiency;


            minimumRaiseEfficiency = new Presentor().RetrieveRestrictionsForPlayer("minRaiseEff");
            maximumRaiseEfficiency = new Presentor().RetrieveRestrictionsForPlayer("maxRaiseEff");


            if (playerRiseTextBox.Text != "")
            {
                if (float.Parse(playerRiseTextBox.Text) < minimumRaiseEfficiency || float.Parse(playerRiseTextBox.Text) > maximumRaiseEfficiency)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Draft shape between :" + minimumRaiseEfficiency + " and " + maximumRaiseEfficiency);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }
        private void playerRiseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            double maximumRaiseEfficiency;
            double minimumRaiseEfficiency;


            minimumRaiseEfficiency = new Presentor().RetrieveRestrictionsForPlayer("minRaiseEff");
            maximumRaiseEfficiency = new Presentor().RetrieveRestrictionsForPlayer("maxRaiseEff");

            if (playerRiseTextBox.Text != "" && (e.KeyCode == Keys.Enter))
            {
                if (float.Parse(playerRiseTextBox.Text) < minimumRaiseEfficiency || float.Parse(playerRiseTextBox.Text) > maximumRaiseEfficiency)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Draft shape between :" + minimumRaiseEfficiency + " and " + maximumRaiseEfficiency);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }

        private void playerDeclineTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            double maximumDeclineEfficiency;
            double minimumDeclineEfficiency;


            minimumDeclineEfficiency = new Presentor().RetrieveRestrictionsForPlayer("minDeclineEff");
            maximumDeclineEfficiency = new Presentor().RetrieveRestrictionsForPlayer("maxDeclineEff");



            if (playerDeclineTextBox.Text != "" && (e.KeyCode == Keys.Enter) && playerDeclineTextBox.Text != "--")
            {
                if (float.Parse(playerDeclineTextBox.Text) < minimumDeclineEfficiency || float.Parse(playerDeclineTextBox.Text) > maximumDeclineEfficiency)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Draft shape between :" + minimumDeclineEfficiency + " and " + maximumDeclineEfficiency);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }
        private void playerDeclineTextBox_Leave_1(object sender, EventArgs e)
        {
            double maximumDeclineEfficiency;
            double minimumDeclineEfficiency;


            minimumDeclineEfficiency = new Presentor().RetrieveRestrictionsForPlayer("minDeclineEff");
            maximumDeclineEfficiency = new Presentor().RetrieveRestrictionsForPlayer("maxDeclineEff");

            if (playerDeclineTextBox.Text != "" && playerDeclineTextBox.Text != "--")
            {
                if (float.Parse(playerDeclineTextBox.Text) < minimumDeclineEfficiency || float.Parse(playerDeclineTextBox.Text) > maximumDeclineEfficiency)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Draft shape between :" + minimumDeclineEfficiency + " and " + maximumDeclineEfficiency);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }

        private void emotionalConstTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void physicallityTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void intellectTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dailyStatusTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void emotionalConstTextBox_Leave_1(object sender, EventArgs e)
        {
            double maxemotionalconst;
            maxemotionalconst = new Presentor().RetrieveRestrictionsForPlayer("emotion");


            if (emotionalConstTextBox.Text != "")
            {
                if (float.Parse(emotionalConstTextBox.Text) < 0.0 || float.Parse(emotionalConstTextBox.Text) > maxemotionalconst)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Emotional State Value between : 0,0  and " + maxemotionalconst);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }

        private void physicallityTextBox_Leave_1(object sender, EventArgs e)
        {
            double maxphysicallconst;
            maxphysicallconst = new Presentor().RetrieveRestrictionsForPlayer("physics");



            if (physicallityTextBox.Text != "")
            {
                if (float.Parse(physicallityTextBox.Text) < 0.0 || float.Parse(physicallityTextBox.Text) > maxphysicallconst)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Physiscal State Value between : 0,0  and " + maxphysicallconst);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }

        private void intellectTextBox_Leave_1(object sender, EventArgs e)
        {
            double maxintelectualconst;
            maxintelectualconst = new Presentor().RetrieveRestrictionsForPlayer("intellect");



            if (intellectTextBox.Text != "")
            {
                if (float.Parse(intellectTextBox.Text) < 0.0 || float.Parse(intellectTextBox.Text) > maxintelectualconst)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Intellectual State Value between : 0,0  and " + maxintelectualconst);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }
        private void dailyStatusTextBox_Leave_1(object sender, EventArgs e)
        {
            double constvalue;
            constvalue = new Presentor().RetrieveRestrictionsForPlayer("dailystatus");



            if (dailyStatusTextBox.Text != "")
            {
                if (float.Parse(dailyStatusTextBox.Text) < 0.0 || float.Parse(dailyStatusTextBox.Text) > constvalue)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Daily Status Value between : 0,0  and " + constvalue);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }
        private void emotionalConstTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            double maxemotionalconst;
            maxemotionalconst = new Presentor().RetrieveRestrictionsForPlayer("emotion");


            if (emotionalConstTextBox.Text != "" && (e.KeyCode == Keys.Enter))
            {
                if (float.Parse(emotionalConstTextBox.Text) < 0.0 || float.Parse(emotionalConstTextBox.Text) > maxemotionalconst)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please Emotional State Value between : 0.0 and " + maxemotionalconst);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }
        private void physicallityTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            double maxphysicallconst;
            maxphysicallconst = new Presentor().RetrieveRestrictionsForPlayer("physics");


            if (physicallityTextBox.Text != "" && (e.KeyCode == Keys.Enter))
            {
                if (float.Parse(physicallityTextBox.Text) < 0.0 || float.Parse(physicallityTextBox.Text) > maxphysicallconst)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Physical State Value between : 0.0 and " + maxphysicallconst);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }

        private void intellectTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            double maxintelectualconst;
            maxintelectualconst = new Presentor().RetrieveRestrictionsForPlayer("intellect");


            if (intellectTextBox.Text != "" && (e.KeyCode == Keys.Enter))
            {
                if (float.Parse(intellectTextBox.Text) < 0.0 || float.Parse(intellectTextBox.Text) > maxintelectualconst)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Intellect State Value between : 0.0 and " + maxintelectualconst);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }

        private void dailyStatusTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            double constvalue;
            constvalue = new Presentor().RetrieveRestrictionsForPlayer("dailystatus");


            if (dailyStatusTextBox.Text != "" && (e.KeyCode == Keys.Enter))
            {
                if (float.Parse(dailyStatusTextBox.Text) < 0.0 || float.Parse(dailyStatusTextBox.Text) > constvalue)
                {

                    addButton.Enabled = false;
                    updateButtom.Enabled = false;
                    MessageBox.Show("Incorrect data was implicated.Please enter Daily Status Value between : 0.0 and " + constvalue);
                }
                else
                {
                    updateButtom.Enabled = true;
                    addButton.Enabled = true;
                }
            }
        }

       
        private void dateTimePickerHourAndMinutesOnly_KeyDown_1(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateBirthTimePicker.CustomFormat = " ";
            }
        }

        private void dateBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateBirthTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        
    }
}
