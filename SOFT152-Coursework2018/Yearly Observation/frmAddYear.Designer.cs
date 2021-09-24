namespace SOFT152_Coursework2018
{
    partial class frmAddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddData));
            this.lblYealryObsv = new System.Windows.Forms.Label();
            this.lblAddYear = new System.Windows.Forms.Label();
            this.grpAllYearData = new System.Windows.Forms.GroupBox();
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.drpLocations = new System.Windows.Forms.ComboBox();
            this.txtYearID = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpMonthDetails = new System.Windows.Forms.GroupBox();
            this.txtHrsSun = new System.Windows.Forms.TextBox();
            this.txtAmountRain = new System.Windows.Forms.TextBox();
            this.txtFrostyDays = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.txtMonthID = new System.Windows.Forms.TextBox();
            this.lblHrsSun = new System.Windows.Forms.Label();
            this.lblAmountRain = new System.Windows.Forms.Label();
            this.lblFrostDays = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMonthID = new System.Windows.Forms.Label();
            this.btnAddMonth = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.grpAllYearData.SuspendLayout();
            this.grpYear.SuspendLayout();
            this.grpMonthDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYealryObsv
            // 
            this.lblYealryObsv.AutoSize = true;
            this.lblYealryObsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYealryObsv.Location = new System.Drawing.Point(9, 15);
            this.lblYealryObsv.Name = "lblYealryObsv";
            this.lblYealryObsv.Size = new System.Drawing.Size(248, 29);
            this.lblYealryObsv.TabIndex = 0;
            this.lblYealryObsv.Text = "Yearly Observations";
            // 
            // lblAddYear
            // 
            this.lblAddYear.AutoSize = true;
            this.lblAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddYear.Location = new System.Drawing.Point(62, 59);
            this.lblAddYear.Name = "lblAddYear";
            this.lblAddYear.Size = new System.Drawing.Size(143, 24);
            this.lblAddYear.TabIndex = 1;
            this.lblAddYear.Text = "Add New Data";
            // 
            // grpAllYearData
            // 
            this.grpAllYearData.Controls.Add(this.lblYealryObsv);
            this.grpAllYearData.Controls.Add(this.lblAddYear);
            this.grpAllYearData.Location = new System.Drawing.Point(12, 12);
            this.grpAllYearData.Name = "grpAllYearData";
            this.grpAllYearData.Size = new System.Drawing.Size(269, 100);
            this.grpAllYearData.TabIndex = 9;
            this.grpAllYearData.TabStop = false;
            // 
            // grpYear
            // 
            this.grpYear.Controls.Add(this.btnAddYear);
            this.grpYear.Controls.Add(this.rtxtComment);
            this.grpYear.Controls.Add(this.drpLocations);
            this.grpYear.Controls.Add(this.txtYearID);
            this.grpYear.Controls.Add(this.lblLocation);
            this.grpYear.Controls.Add(this.lblComment);
            this.grpYear.Controls.Add(this.lblYear);
            this.grpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpYear.Location = new System.Drawing.Point(12, 118);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(776, 145);
            this.grpYear.TabIndex = 10;
            this.grpYear.TabStop = false;
            this.grpYear.Text = "Year Details";
            // 
            // btnAddYear
            // 
            this.btnAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.Location = new System.Drawing.Point(666, 22);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(86, 32);
            this.btnAddYear.TabIndex = 28;
            this.btnAddYear.Text = "Add Year";
            this.btnAddYear.UseVisualStyleBackColor = true;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
            // 
            // rtxtComment
            // 
            this.rtxtComment.Location = new System.Drawing.Point(194, 67);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(576, 66);
            this.rtxtComment.TabIndex = 11;
            this.rtxtComment.Text = "";
            // 
            // drpLocations
            // 
            this.drpLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpLocations.FormattingEnabled = true;
            this.drpLocations.Location = new System.Drawing.Point(96, 19);
            this.drpLocations.Name = "drpLocations";
            this.drpLocations.Size = new System.Drawing.Size(189, 28);
            this.drpLocations.TabIndex = 14;
            // 
            // txtYearID
            // 
            this.txtYearID.Location = new System.Drawing.Point(77, 52);
            this.txtYearID.Name = "txtYearID";
            this.txtYearID.Size = new System.Drawing.Size(100, 26);
            this.txtYearID.TabIndex = 13;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(7, 22);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 20);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(7, 90);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(186, 20);
            this.lblComment.TabIndex = 11;
            this.lblComment.Text = "Description/Comment:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(7, 56);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 20);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year:";
            // 
            // grpMonthDetails
            // 
            this.grpMonthDetails.Controls.Add(this.txtHrsSun);
            this.grpMonthDetails.Controls.Add(this.txtAmountRain);
            this.grpMonthDetails.Controls.Add(this.txtFrostyDays);
            this.grpMonthDetails.Controls.Add(this.txtMinTemp);
            this.grpMonthDetails.Controls.Add(this.txtMaxTemp);
            this.grpMonthDetails.Controls.Add(this.txtMonthID);
            this.grpMonthDetails.Controls.Add(this.lblHrsSun);
            this.grpMonthDetails.Controls.Add(this.lblAmountRain);
            this.grpMonthDetails.Controls.Add(this.lblFrostDays);
            this.grpMonthDetails.Controls.Add(this.lblMinTemp);
            this.grpMonthDetails.Controls.Add(this.lblMaxTemp);
            this.grpMonthDetails.Controls.Add(this.lblMonthID);
            this.grpMonthDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonthDetails.Location = new System.Drawing.Point(12, 269);
            this.grpMonthDetails.Name = "grpMonthDetails";
            this.grpMonthDetails.Size = new System.Drawing.Size(776, 137);
            this.grpMonthDetails.TabIndex = 11;
            this.grpMonthDetails.TabStop = false;
            this.grpMonthDetails.Text = "Month Details";
            // 
            // txtHrsSun
            // 
            this.txtHrsSun.Location = new System.Drawing.Point(573, 97);
            this.txtHrsSun.Name = "txtHrsSun";
            this.txtHrsSun.Size = new System.Drawing.Size(133, 26);
            this.txtHrsSun.TabIndex = 25;
            // 
            // txtAmountRain
            // 
            this.txtAmountRain.Location = new System.Drawing.Point(573, 64);
            this.txtAmountRain.Name = "txtAmountRain";
            this.txtAmountRain.Size = new System.Drawing.Size(133, 26);
            this.txtAmountRain.TabIndex = 24;
            // 
            // txtFrostyDays
            // 
            this.txtFrostyDays.Location = new System.Drawing.Point(573, 31);
            this.txtFrostyDays.Name = "txtFrostyDays";
            this.txtFrostyDays.Size = new System.Drawing.Size(133, 26);
            this.txtFrostyDays.TabIndex = 23;
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(211, 97);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(133, 26);
            this.txtMinTemp.TabIndex = 22;
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(209, 64);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(133, 26);
            this.txtMaxTemp.TabIndex = 21;
            // 
            // txtMonthID
            // 
            this.txtMonthID.Location = new System.Drawing.Point(211, 31);
            this.txtMonthID.Name = "txtMonthID";
            this.txtMonthID.Size = new System.Drawing.Size(133, 26);
            this.txtMonthID.TabIndex = 15;
            // 
            // lblHrsSun
            // 
            this.lblHrsSun.AutoSize = true;
            this.lblHrsSun.Location = new System.Drawing.Point(398, 100);
            this.lblHrsSun.Name = "lblHrsSun";
            this.lblHrsSun.Size = new System.Drawing.Size(120, 20);
            this.lblHrsSun.TabIndex = 20;
            this.lblHrsSun.Text = "Hours of Sun:";
            // 
            // lblAmountRain
            // 
            this.lblAmountRain.AutoSize = true;
            this.lblAmountRain.Location = new System.Drawing.Point(379, 67);
            this.lblAmountRain.Name = "lblAmountRain";
            this.lblAmountRain.Size = new System.Drawing.Size(158, 20);
            this.lblAmountRain.TabIndex = 19;
            this.lblAmountRain.Text = "Milimetres of Rain:";
            // 
            // lblFrostDays
            // 
            this.lblFrostDays.AutoSize = true;
            this.lblFrostDays.Location = new System.Drawing.Point(360, 34);
            this.lblFrostDays.Name = "lblFrostDays";
            this.lblFrostDays.Size = new System.Drawing.Size(197, 20);
            this.lblFrostDays.TabIndex = 18;
            this.lblFrostDays.Text = "Number of Frosty Days:";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Location = new System.Drawing.Point(10, 100);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(191, 20);
            this.lblMinTemp.TabIndex = 17;
            this.lblMinTemp.Text = "Minimum Temperature:";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Location = new System.Drawing.Point(8, 67);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(195, 20);
            this.lblMaxTemp.TabIndex = 16;
            this.lblMaxTemp.Text = "Maximum Temperature:";
            // 
            // lblMonthID
            // 
            this.lblMonthID.AutoSize = true;
            this.lblMonthID.Location = new System.Drawing.Point(61, 34);
            this.lblMonthID.Name = "lblMonthID";
            this.lblMonthID.Size = new System.Drawing.Size(88, 20);
            this.lblMonthID.TabIndex = 15;
            this.lblMonthID.Text = "Month ID:";
            // 
            // btnAddMonth
            // 
            this.btnAddMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMonth.Location = new System.Drawing.Point(366, 412);
            this.btnAddMonth.Name = "btnAddMonth";
            this.btnAddMonth.Size = new System.Drawing.Size(97, 32);
            this.btnAddMonth.TabIndex = 26;
            this.btnAddMonth.Text = "Add Month";
            this.btnAddMonth.UseVisualStyleBackColor = true;
            this.btnAddMonth.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(696, 412);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 32);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // selectFile
            // 
            this.selectFile.FileName = "Select File";
            // 
            // frmAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddMonth);
            this.Controls.Add(this.grpMonthDetails);
            this.Controls.Add(this.grpYear);
            this.Controls.Add(this.grpAllYearData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Yearly Observation";
            this.Load += new System.EventHandler(this.frmAddData_Load);
            this.grpAllYearData.ResumeLayout(false);
            this.grpAllYearData.PerformLayout();
            this.grpYear.ResumeLayout(false);
            this.grpYear.PerformLayout();
            this.grpMonthDetails.ResumeLayout(false);
            this.grpMonthDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYealryObsv;
        private System.Windows.Forms.Label lblAddYear;
        private System.Windows.Forms.GroupBox grpAllYearData;
        private System.Windows.Forms.GroupBox grpYear;
        private System.Windows.Forms.RichTextBox rtxtComment;
        private System.Windows.Forms.ComboBox drpLocations;
        private System.Windows.Forms.TextBox txtYearID;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpMonthDetails;
        private System.Windows.Forms.TextBox txtHrsSun;
        private System.Windows.Forms.TextBox txtAmountRain;
        private System.Windows.Forms.TextBox txtFrostyDays;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.TextBox txtMonthID;
        private System.Windows.Forms.Label lblHrsSun;
        private System.Windows.Forms.Label lblAmountRain;
        private System.Windows.Forms.Label lblFrostDays;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMonthID;
        private System.Windows.Forms.Button btnAddMonth;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddYear;
        private System.Windows.Forms.OpenFileDialog selectFile;
    }
}