namespace SOFT152_Coursework2018
{
    partial class frmLocationEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocationEdit));
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.lblMonthlyObsv = new System.Windows.Forms.Label();
            this.lblEditMonth = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.grpLocSelect = new System.Windows.Forms.GroupBox();
            this.drpLocation = new System.Windows.Forms.ComboBox();
            this.grpLocationDets = new System.Windows.Forms.GroupBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.grpCoords = new System.Windows.Forms.GroupBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.grpLocation.SuspendLayout();
            this.grpLocSelect.SuspendLayout();
            this.grpLocationDets.SuspendLayout();
            this.grpCoords.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.lblMonthlyObsv);
            this.grpLocation.Controls.Add(this.lblEditMonth);
            this.grpLocation.Location = new System.Drawing.Point(12, 12);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(269, 100);
            this.grpLocation.TabIndex = 12;
            this.grpLocation.TabStop = false;
            // 
            // lblMonthlyObsv
            // 
            this.lblMonthlyObsv.AutoSize = true;
            this.lblMonthlyObsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyObsv.Location = new System.Drawing.Point(79, 15);
            this.lblMonthlyObsv.Name = "lblMonthlyObsv";
            this.lblMonthlyObsv.Size = new System.Drawing.Size(112, 29);
            this.lblMonthlyObsv.TabIndex = 0;
            this.lblMonthlyObsv.Text = "Location";
            // 
            // lblEditMonth
            // 
            this.lblEditMonth.AutoSize = true;
            this.lblEditMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMonth.Location = new System.Drawing.Point(36, 59);
            this.lblEditMonth.Name = "lblEditMonth";
            this.lblEditMonth.Size = new System.Drawing.Size(199, 24);
            this.lblEditMonth.TabIndex = 1;
            this.lblEditMonth.Text = "Edit Location Details";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(66, 45);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(159, 24);
            this.lblLocation.TabIndex = 13;
            this.lblLocation.Text = "Select Location:";
            // 
            // grpLocSelect
            // 
            this.grpLocSelect.Controls.Add(this.drpLocation);
            this.grpLocSelect.Controls.Add(this.lblLocation);
            this.grpLocSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLocSelect.Location = new System.Drawing.Point(304, 12);
            this.grpLocSelect.Name = "grpLocSelect";
            this.grpLocSelect.Size = new System.Drawing.Size(484, 100);
            this.grpLocSelect.TabIndex = 14;
            this.grpLocSelect.TabStop = false;
            this.grpLocSelect.Text = "Locations";
            // 
            // drpLocation
            // 
            this.drpLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpLocation.FormattingEnabled = true;
            this.drpLocation.Location = new System.Drawing.Point(231, 42);
            this.drpLocation.Name = "drpLocation";
            this.drpLocation.Size = new System.Drawing.Size(196, 32);
            this.drpLocation.TabIndex = 15;
            this.drpLocation.SelectedIndexChanged += new System.EventHandler(this.drpLocation_SelectedIndexChanged);
            // 
            // grpLocationDets
            // 
            this.grpLocationDets.Controls.Add(this.txtLocationName);
            this.grpLocationDets.Controls.Add(this.grpCoords);
            this.grpLocationDets.Controls.Add(this.grpAddress);
            this.grpLocationDets.Controls.Add(this.lblLocationName);
            this.grpLocationDets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLocationDets.Location = new System.Drawing.Point(12, 142);
            this.grpLocationDets.Name = "grpLocationDets";
            this.grpLocationDets.Size = new System.Drawing.Size(653, 246);
            this.grpLocationDets.TabIndex = 15;
            this.grpLocationDets.TabStop = false;
            this.grpLocationDets.Text = "Location Details";
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(168, 37);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.ReadOnly = true;
            this.txtLocationName.Size = new System.Drawing.Size(262, 29);
            this.txtLocationName.TabIndex = 19;
            // 
            // grpCoords
            // 
            this.grpCoords.Controls.Add(this.txtLat);
            this.grpCoords.Controls.Add(this.txtLong);
            this.grpCoords.Controls.Add(this.lblLatitude);
            this.grpCoords.Controls.Add(this.lblLongitude);
            this.grpCoords.Location = new System.Drawing.Point(395, 80);
            this.grpCoords.Name = "grpCoords";
            this.grpCoords.Size = new System.Drawing.Size(252, 157);
            this.grpCoords.TabIndex = 5;
            this.grpCoords.TabStop = false;
            this.grpCoords.Text = "Coordinates";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(140, 41);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 29);
            this.txtLat.TabIndex = 20;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(140, 96);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 29);
            this.txtLong.TabIndex = 19;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(13, 44);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(101, 24);
            this.lblLatitude.TabIndex = 3;
            this.lblLatitude.Text = "Latidtude:";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(9, 99);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(109, 24);
            this.lblLongitude.TabIndex = 2;
            this.lblLongitude.Text = "Longitude:";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtPostcode);
            this.grpAddress.Controls.Add(this.txtCounty);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.lblPostcode);
            this.grpAddress.Controls.Add(this.lblCounty);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Location = new System.Drawing.Point(6, 80);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(383, 157);
            this.grpAddress.TabIndex = 1;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(115, 118);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(262, 29);
            this.txtPostcode.TabIndex = 18;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(115, 78);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(262, 29);
            this.txtCounty.TabIndex = 17;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(115, 38);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(262, 29);
            this.txtStreet.TabIndex = 16;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(6, 121);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(103, 24);
            this.lblPostcode.TabIndex = 4;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(17, 81);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(81, 24);
            this.lblCounty.TabIndex = 3;
            this.lblCounty.Text = "County:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(22, 41);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(70, 24);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street:";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(6, 40);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(156, 24);
            this.lblLocationName.TabIndex = 0;
            this.lblLocationName.Text = "Location Name:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(304, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(685, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 34);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // selectFile
            // 
            this.selectFile.FileName = "SelectFile";
            // 
            // frmLocationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpLocationDets);
            this.Controls.Add(this.grpLocation);
            this.Controls.Add(this.grpLocSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLocationEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Location Details";
            this.Load += new System.EventHandler(this.frmLocationEdit_Load);
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.grpLocSelect.ResumeLayout(false);
            this.grpLocSelect.PerformLayout();
            this.grpLocationDets.ResumeLayout(false);
            this.grpLocationDets.PerformLayout();
            this.grpCoords.ResumeLayout(false);
            this.grpCoords.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Label lblMonthlyObsv;
        private System.Windows.Forms.Label lblEditMonth;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.GroupBox grpLocSelect;
        private System.Windows.Forms.ComboBox drpLocation;
        private System.Windows.Forms.GroupBox grpLocationDets;
        private System.Windows.Forms.GroupBox grpCoords;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog selectFile;
    }
}