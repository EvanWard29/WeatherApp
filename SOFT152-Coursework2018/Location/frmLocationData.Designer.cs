namespace SOFT152_Coursework2018
{
    partial class frmLocationData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocationData));
            this.grpMonth = new System.Windows.Forms.GroupBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.drpLocation = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.tabLocationData = new System.Windows.Forms.TabControl();
            this.tabByYear = new System.Windows.Forms.TabPage();
            this.drpYearID = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.dgvByYear = new System.Windows.Forms.DataGridView();
            this.MonthID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrostDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountRain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrsSun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabByAverages = new System.Windows.Forms.TabPage();
            this.dgvByAverages = new System.Windows.Forms.DataGridView();
            this.YearID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpMonth.SuspendLayout();
            this.grpSelect.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.tabLocationData.SuspendLayout();
            this.tabByYear.SuspendLayout();
            this.grpYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByYear)).BeginInit();
            this.tabByAverages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByAverages)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMonth
            // 
            this.grpMonth.Controls.Add(this.lblLocation);
            this.grpMonth.Controls.Add(this.lblView);
            this.grpMonth.Location = new System.Drawing.Point(12, 12);
            this.grpMonth.Name = "grpMonth";
            this.grpMonth.Size = new System.Drawing.Size(269, 100);
            this.grpMonth.TabIndex = 12;
            this.grpMonth.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(77, 15);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(112, 29);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location";
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(39, 59);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(188, 24);
            this.lblView.TabIndex = 1;
            this.lblView.Text = "View Location Data";
            // 
            // grpSelect
            // 
            this.grpSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelect.Controls.Add(this.lblMsg);
            this.grpSelect.Controls.Add(this.drpLocation);
            this.grpSelect.Controls.Add(this.lblSelect);
            this.grpSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelect.Location = new System.Drawing.Point(325, 12);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(501, 100);
            this.grpSelect.TabIndex = 13;
            this.grpSelect.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(70, 20);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(349, 24);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "Select a Location to view All it\'s Data";
            // 
            // drpLocation
            // 
            this.drpLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpLocation.FormattingEnabled = true;
            this.drpLocation.Location = new System.Drawing.Point(225, 56);
            this.drpLocation.Name = "drpLocation";
            this.drpLocation.Size = new System.Drawing.Size(253, 32);
            this.drpLocation.TabIndex = 2;
            this.drpLocation.SelectedIndexChanged += new System.EventHandler(this.drpLocation_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(36, 59);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(159, 24);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select Location:";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.tabLocationData);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(12, 129);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(850, 484);
            this.grpDetails.TabIndex = 14;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Location Data";
            // 
            // tabLocationData
            // 
            this.tabLocationData.Controls.Add(this.tabByYear);
            this.tabLocationData.Controls.Add(this.tabByAverages);
            this.tabLocationData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLocationData.Location = new System.Drawing.Point(3, 25);
            this.tabLocationData.Name = "tabLocationData";
            this.tabLocationData.SelectedIndex = 0;
            this.tabLocationData.Size = new System.Drawing.Size(844, 456);
            this.tabLocationData.TabIndex = 0;
            // 
            // tabByYear
            // 
            this.tabByYear.Controls.Add(this.drpYearID);
            this.tabByYear.Controls.Add(this.lblYear);
            this.tabByYear.Controls.Add(this.grpYear);
            this.tabByYear.Location = new System.Drawing.Point(4, 33);
            this.tabByYear.Name = "tabByYear";
            this.tabByYear.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabByYear.Size = new System.Drawing.Size(836, 419);
            this.tabByYear.TabIndex = 0;
            this.tabByYear.Text = "By Year";
            this.tabByYear.UseVisualStyleBackColor = true;
            // 
            // drpYearID
            // 
            this.drpYearID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpYearID.FormattingEnabled = true;
            this.drpYearID.Location = new System.Drawing.Point(135, 6);
            this.drpYearID.Name = "drpYearID";
            this.drpYearID.Size = new System.Drawing.Size(138, 32);
            this.drpYearID.TabIndex = 3;
            this.drpYearID.SelectedIndexChanged += new System.EventHandler(this.drpYearID_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 9);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(123, 24);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Select Year:";
            // 
            // grpYear
            // 
            this.grpYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpYear.Controls.Add(this.dgvByYear);
            this.grpYear.Location = new System.Drawing.Point(0, 36);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(836, 383);
            this.grpYear.TabIndex = 1;
            this.grpYear.TabStop = false;
            // 
            // dgvByYear
            // 
            this.dgvByYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvByYear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvByYear.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvByYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvByYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonthID,
            this.MaxTemp,
            this.MinTemp,
            this.FrostDays,
            this.AmountRain,
            this.HrsSun});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvByYear.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvByYear.Location = new System.Drawing.Point(3, 21);
            this.dgvByYear.Name = "dgvByYear";
            this.dgvByYear.ReadOnly = true;
            this.dgvByYear.Size = new System.Drawing.Size(830, 358);
            this.dgvByYear.TabIndex = 0;
            // 
            // MonthID
            // 
            this.MonthID.HeaderText = "Month ID";
            this.MonthID.Name = "MonthID";
            this.MonthID.ReadOnly = true;
            // 
            // MaxTemp
            // 
            this.MaxTemp.HeaderText = "Maximum Temperature";
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.ReadOnly = true;
            // 
            // MinTemp
            // 
            this.MinTemp.HeaderText = "Minimum Temperature";
            this.MinTemp.Name = "MinTemp";
            this.MinTemp.ReadOnly = true;
            // 
            // FrostDays
            // 
            this.FrostDays.HeaderText = "Number of Frosty Days";
            this.FrostDays.Name = "FrostDays";
            this.FrostDays.ReadOnly = true;
            // 
            // AmountRain
            // 
            this.AmountRain.HeaderText = "Millimetres of Rain";
            this.AmountRain.Name = "AmountRain";
            this.AmountRain.ReadOnly = true;
            // 
            // HrsSun
            // 
            this.HrsSun.HeaderText = "Hours of Sun";
            this.HrsSun.Name = "HrsSun";
            this.HrsSun.ReadOnly = true;
            // 
            // tabByAverages
            // 
            this.tabByAverages.Controls.Add(this.dgvByAverages);
            this.tabByAverages.Location = new System.Drawing.Point(4, 33);
            this.tabByAverages.Name = "tabByAverages";
            this.tabByAverages.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabByAverages.Size = new System.Drawing.Size(836, 423);
            this.tabByAverages.TabIndex = 1;
            this.tabByAverages.Text = "By Averages";
            this.tabByAverages.UseVisualStyleBackColor = true;
            // 
            // dgvByAverages
            // 
            this.dgvByAverages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvByAverages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvByAverages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YearID,
            this.Max,
            this.Min,
            this.Frost,
            this.Rain,
            this.Sun});
            this.dgvByAverages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvByAverages.Location = new System.Drawing.Point(3, 3);
            this.dgvByAverages.Name = "dgvByAverages";
            this.dgvByAverages.Size = new System.Drawing.Size(830, 417);
            this.dgvByAverages.TabIndex = 0;
            // 
            // YearID
            // 
            this.YearID.HeaderText = "Year";
            this.YearID.Name = "YearID";
            this.YearID.ReadOnly = true;
            // 
            // Max
            // 
            this.Max.HeaderText = "Average Maximum Temperature";
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            // 
            // Min
            // 
            this.Min.HeaderText = "Average Minimum Temperature";
            this.Min.Name = "Min";
            this.Min.ReadOnly = true;
            // 
            // Frost
            // 
            this.Frost.HeaderText = "Average Frosty Days";
            this.Frost.Name = "Frost";
            this.Frost.ReadOnly = true;
            // 
            // Rain
            // 
            this.Rain.HeaderText = "Average Millimetres of Rain";
            this.Rain.Name = "Rain";
            this.Rain.ReadOnly = true;
            // 
            // Sun
            // 
            this.Sun.HeaderText = "Average Hours of Sun";
            this.Sun.Name = "Sun";
            this.Sun.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(767, 619);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 33);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmLocationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(874, 664);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpSelect);
            this.Controls.Add(this.grpMonth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocationData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Location Data";
            this.Load += new System.EventHandler(this.frmLocationData_Load);
            this.grpMonth.ResumeLayout(false);
            this.grpMonth.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.tabLocationData.ResumeLayout(false);
            this.tabByYear.ResumeLayout(false);
            this.tabByYear.PerformLayout();
            this.grpYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvByYear)).EndInit();
            this.tabByAverages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvByAverages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMonth;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ComboBox drpLocation;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TabControl tabLocationData;
        private System.Windows.Forms.TabPage tabByYear;
        private System.Windows.Forms.DataGridView dgvByYear;
        private System.Windows.Forms.TabPage tabByAverages;
        private System.Windows.Forms.DataGridView dgvByAverages;
        private System.Windows.Forms.ComboBox drpYearID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrostDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountRain;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrsSun;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sun;
    }
}