namespace BaketballGameSimulator2._0
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.backButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.hostTeamComboBox = new System.Windows.Forms.ComboBox();
            this.gameButton = new System.Windows.Forms.Button();
            this.guestCoachTextBox = new System.Windows.Forms.TextBox();
            this.hostCoachTextBox = new System.Windows.Forms.TextBox();
            this.guestTeamComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.hostTeamDataGridView = new System.Windows.Forms.DataGridView();
            this.guestTeamDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.resultOfGuestTexttBox = new System.Windows.Forms.TextBox();
            this.resultOfHostTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hostTeamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestTeamDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Tomato;
            this.backButton.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 538);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 39);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(576, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Guest Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(200, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Host Team";
            // 
            // gameTimePicker2
            // 
            this.gameTimePicker2.CalendarFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTimePicker2.Checked = false;
            this.gameTimePicker2.CustomFormat = "hh:mm";
            this.gameTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gameTimePicker2.Location = new System.Drawing.Point(442, 104);
            this.gameTimePicker2.Name = "gameTimePicker2";
            this.gameTimePicker2.Size = new System.Drawing.Size(102, 20);
            this.gameTimePicker2.TabIndex = 27;
            // 
            // hostTeamComboBox
            // 
            this.hostTeamComboBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hostTeamComboBox.FormattingEnabled = true;
            this.hostTeamComboBox.Location = new System.Drawing.Point(165, 48);
            this.hostTeamComboBox.Name = "hostTeamComboBox";
            this.hostTeamComboBox.Size = new System.Drawing.Size(160, 24);
            this.hostTeamComboBox.TabIndex = 17;
            this.hostTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.hostTeamComboBox_SelectedIndexChanged_1);
            // 
            // gameButton
            // 
            this.gameButton.BackColor = System.Drawing.Color.Tomato;
            this.gameButton.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton.Location = new System.Drawing.Point(395, 538);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(84, 39);
            this.gameButton.TabIndex = 24;
            this.gameButton.Text = "GAME";
            this.gameButton.UseVisualStyleBackColor = false;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click_1);
            // 
            // guestCoachTextBox
            // 
            this.guestCoachTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestCoachTextBox.Location = new System.Drawing.Point(596, 165);
            this.guestCoachTextBox.Name = "guestCoachTextBox";
            this.guestCoachTextBox.Size = new System.Drawing.Size(100, 22);
            this.guestCoachTextBox.TabIndex = 26;
            // 
            // hostCoachTextBox
            // 
            this.hostCoachTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hostCoachTextBox.Location = new System.Drawing.Point(170, 169);
            this.hostCoachTextBox.Name = "hostCoachTextBox";
            this.hostCoachTextBox.Size = new System.Drawing.Size(100, 22);
            this.hostCoachTextBox.TabIndex = 25;
            // 
            // guestTeamComboBox
            // 
            this.guestTeamComboBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestTeamComboBox.FormattingEnabled = true;
            this.guestTeamComboBox.Location = new System.Drawing.Point(545, 48);
            this.guestTeamComboBox.Name = "guestTeamComboBox";
            this.guestTeamComboBox.Size = new System.Drawing.Size(160, 24);
            this.guestTeamComboBox.TabIndex = 18;
            this.guestTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.guestTeamComboBox_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(556, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Guest Team Coach";
            // 
            // gameTimePicker1
            // 
            this.gameTimePicker1.CalendarFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.gameTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gameTimePicker1.Location = new System.Drawing.Point(328, 104);
            this.gameTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.gameTimePicker1.Name = "gameTimePicker1";
            this.gameTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.gameTimePicker1.TabIndex = 19;
            this.gameTimePicker1.Value = new System.DateTime(2024, 6, 13, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(143, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Host Team Coach";
            // 
            // hostTeamDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Violet;
            this.hostTeamDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hostTeamDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hostTeamDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hostTeamDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.hostTeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hostTeamDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.hostTeamDataGridView.Location = new System.Drawing.Point(138, 289);
            this.hostTeamDataGridView.Name = "hostTeamDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hostTeamDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.hostTeamDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostTeamDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.hostTeamDataGridView.Size = new System.Drawing.Size(273, 238);
            this.hostTeamDataGridView.TabIndex = 20;
            // 
            // guestTeamDataGridView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Violet;
            this.guestTeamDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.guestTeamDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guestTeamDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guestTeamDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.guestTeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guestTeamDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.guestTeamDataGridView.Location = new System.Drawing.Point(462, 289);
            this.guestTeamDataGridView.Name = "guestTeamDataGridView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guestTeamDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.guestTeamDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestTeamDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guestTeamDataGridView.Size = new System.Drawing.Size(273, 238);
            this.guestTeamDataGridView.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.resultOfGuestTexttBox);
            this.panel1.Controls.Add(this.resultOfHostTextBox);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(138, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 278);
            this.panel1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(565, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 71);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "ESC";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultOfGuestTexttBox
            // 
            this.resultOfGuestTexttBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resultOfGuestTexttBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultOfGuestTexttBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultOfGuestTexttBox.ForeColor = System.Drawing.Color.Red;
            this.resultOfGuestTexttBox.Location = new System.Drawing.Point(454, 122);
            this.resultOfGuestTexttBox.Name = "resultOfGuestTexttBox";
            this.resultOfGuestTexttBox.Size = new System.Drawing.Size(112, 76);
            this.resultOfGuestTexttBox.TabIndex = 12;
            this.resultOfGuestTexttBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultOfHostTextBox
            // 
            this.resultOfHostTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resultOfHostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultOfHostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultOfHostTextBox.ForeColor = System.Drawing.Color.Red;
            this.resultOfHostTextBox.Location = new System.Drawing.Point(33, 122);
            this.resultOfHostTextBox.Name = "resultOfHostTextBox";
            this.resultOfHostTextBox.Size = new System.Drawing.Size(113, 76);
            this.resultOfHostTextBox.TabIndex = 8;
            this.resultOfHostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guestTeamDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gameTimePicker2);
            this.Controls.Add(this.hostTeamComboBox);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.guestCoachTextBox);
            this.Controls.Add(this.hostCoachTextBox);
            this.Controls.Add(this.guestTeamComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostTeamDataGridView);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostTeamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestTeamDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker gameTimePicker2;
        private System.Windows.Forms.ComboBox hostTeamComboBox;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.TextBox guestCoachTextBox;
        private System.Windows.Forms.TextBox hostCoachTextBox;
        private System.Windows.Forms.ComboBox guestTeamComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker gameTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView hostTeamDataGridView;
        private System.Windows.Forms.DataGridView guestTeamDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultOfGuestTexttBox;
        private System.Windows.Forms.TextBox resultOfHostTextBox;
    }
}