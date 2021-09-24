namespace SOFT152_Coursework2018
{
    partial class frmEditYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditYear));
            this.lblYealryObsv = new System.Windows.Forms.Label();
            this.lblEditYear = new System.Windows.Forms.Label();
            this.grpAllYearData = new System.Windows.Forms.GroupBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSelectYear = new System.Windows.Forms.TextBox();
            this.drpLocation = new System.Windows.Forms.ComboBox();
            this.lblYearID = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtYearID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.grpAllYearData.SuspendLayout();
            this.grpYear.SuspendLayout();
            this.grpDetails.SuspendLayout();
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
            // lblEditYear
            // 
            this.lblEditYear.AutoSize = true;
            this.lblEditYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditYear.Location = new System.Drawing.Point(30, 59);
            this.lblEditYear.Name = "lblEditYear";
            this.lblEditYear.Size = new System.Drawing.Size(206, 24);
            this.lblEditYear.TabIndex = 1;
            this.lblEditYear.Text = "Edit Year Description";
            // 
            // grpAllYearData
            // 
            this.grpAllYearData.Controls.Add(this.lblYealryObsv);
            this.grpAllYearData.Controls.Add(this.lblEditYear);
            this.grpAllYearData.Location = new System.Drawing.Point(12, 12);
            this.grpAllYearData.Name = "grpAllYearData";
            this.grpAllYearData.Size = new System.Drawing.Size(269, 100);
            this.grpAllYearData.TabIndex = 8;
            this.grpAllYearData.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(6, 30);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(159, 24);
            this.lblLocation.TabIndex = 9;
            this.lblLocation.Text = "Select Location:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(30, 64);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(115, 24);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Enter Year:";
            // 
            // grpYear
            // 
            this.grpYear.Controls.Add(this.btnSearch);
            this.grpYear.Controls.Add(this.txtSelectYear);
            this.grpYear.Controls.Add(this.drpLocation);
            this.grpYear.Controls.Add(this.lblYear);
            this.grpYear.Controls.Add(this.lblLocation);
            this.grpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpYear.Location = new System.Drawing.Point(287, 12);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(501, 100);
            this.grpYear.TabIndex = 11;
            this.grpYear.TabStop = false;
            this.grpYear.Text = "Select Year";
            this.grpYear.Enter += new System.EventHandler(this.grpYear_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(312, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 27);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSelectYear
            // 
            this.txtSelectYear.Location = new System.Drawing.Point(179, 64);
            this.txtSelectYear.Name = "txtSelectYear";
            this.txtSelectYear.Size = new System.Drawing.Size(108, 26);
            this.txtSelectYear.TabIndex = 12;
            // 
            // drpLocation
            // 
            this.drpLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpLocation.FormattingEnabled = true;
            this.drpLocation.Location = new System.Drawing.Point(173, 30);
            this.drpLocation.Name = "drpLocation";
            this.drpLocation.Size = new System.Drawing.Size(316, 28);
            this.drpLocation.TabIndex = 11;
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearID.Location = new System.Drawing.Point(40, 69);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(59, 24);
            this.lblYearID.TabIndex = 12;
            this.lblYearID.Text = "Year:";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnSave);
            this.grpDetails.Controls.Add(this.txtLocationID);
            this.grpDetails.Controls.Add(this.lblLocationName);
            this.grpDetails.Controls.Add(this.rtxtDescription);
            this.grpDetails.Controls.Add(this.txtYearID);
            this.grpDetails.Controls.Add(this.lblDescription);
            this.grpDetails.Controls.Add(this.lblYearID);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(12, 118);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(776, 288);
            this.grpDetails.TabIndex = 13;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Year Details:";
            this.grpDetails.Enter += new System.EventHandler(this.grpDetails_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(681, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 27);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLocationID
            // 
            this.txtLocationID.Location = new System.Drawing.Point(135, 31);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.ReadOnly = true;
            this.txtLocationID.Size = new System.Drawing.Size(285, 26);
            this.txtLocationID.TabIndex = 17;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(22, 31);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(95, 24);
            this.lblLocationName.TabIndex = 16;
            this.lblLocationName.Text = "Location:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(13, 137);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(751, 141);
            this.rtxtDescription.TabIndex = 15;
            this.rtxtDescription.Text = "";
            // 
            // txtYearID
            // 
            this.txtYearID.Location = new System.Drawing.Point(135, 69);
            this.txtYearID.Name = "txtYearID";
            this.txtYearID.ReadOnly = true;
            this.txtYearID.Size = new System.Drawing.Size(100, 26);
            this.txtYearID.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(10, 104);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(121, 24);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(693, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 27);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // selectFile
            // 
            this.selectFile.FileName = "SelectFile";
            // 
            // frmEditYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpAllYearData);
            this.Controls.Add(this.grpYear);
            this.Controls.Add(this.grpDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Year Description";
            this.Load += new System.EventHandler(this.frmEditYear_Load);
            this.grpAllYearData.ResumeLayout(false);
            this.grpAllYearData.PerformLayout();
            this.grpYear.ResumeLayout(false);
            this.grpYear.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYealryObsv;
        private System.Windows.Forms.Label lblEditYear;
        private System.Windows.Forms.GroupBox grpAllYearData;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSelectYear;
        private System.Windows.Forms.ComboBox drpLocation;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtYearID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog selectFile;
    }
}