namespace SOFT152_Coursework2018
{
    partial class frmSearchLoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchLoc));
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpSearchBox = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtLocName = new System.Windows.Forms.TextBox();
            this.grpLongLat = new System.Windows.Forms.GroupBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLocName = new System.Windows.Forms.Label();
            this.grpMonth = new System.Windows.Forms.GroupBox();
            this.lblMonthlyObsv = new System.Windows.Forms.Label();
            this.lblEditMonth = new System.Windows.Forms.Label();
            this.grpSearchBox.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpLongLat.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(38, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(212, 24);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Enter Location Name:";
            // 
            // grpSearchBox
            // 
            this.grpSearchBox.Controls.Add(this.txtLocation);
            this.grpSearchBox.Controls.Add(this.btnSearch);
            this.grpSearchBox.Controls.Add(this.lblSearch);
            this.grpSearchBox.Location = new System.Drawing.Point(285, 12);
            this.grpSearchBox.Name = "grpSearchBox";
            this.grpSearchBox.Size = new System.Drawing.Size(505, 100);
            this.grpSearchBox.TabIndex = 3;
            this.grpSearchBox.TabStop = false;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(43, 44);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(321, 29);
            this.txtLocation.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(379, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 39);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(681, 458);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 31);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtLocName);
            this.grpDetails.Controls.Add(this.grpLongLat);
            this.grpDetails.Controls.Add(this.grpAddress);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.lblLocName);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(8, 118);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(509, 371);
            this.grpDetails.TabIndex = 10;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Location Details";
            // 
            // txtLocName
            // 
            this.txtLocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocName.Location = new System.Drawing.Point(175, 39);
            this.txtLocName.Name = "txtLocName";
            this.txtLocName.ReadOnly = true;
            this.txtLocName.Size = new System.Drawing.Size(321, 29);
            this.txtLocName.TabIndex = 5;
            // 
            // grpLongLat
            // 
            this.grpLongLat.Controls.Add(this.txtLongitude);
            this.grpLongLat.Controls.Add(this.txtLatitude);
            this.grpLongLat.Controls.Add(this.lblLat);
            this.grpLongLat.Controls.Add(this.lblLong);
            this.grpLongLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLongLat.Location = new System.Drawing.Point(17, 262);
            this.grpLongLat.Name = "grpLongLat";
            this.grpLongLat.Size = new System.Drawing.Size(479, 100);
            this.grpLongLat.TabIndex = 8;
            this.grpLongLat.TabStop = false;
            this.grpLongLat.Text = "Coordinates";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.Location = new System.Drawing.Point(104, 57);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.ReadOnly = true;
            this.txtLongitude.Size = new System.Drawing.Size(357, 27);
            this.txtLongitude.TabIndex = 13;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(104, 25);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.ReadOnly = true;
            this.txtLatitude.Size = new System.Drawing.Size(357, 27);
            this.txtLatitude.TabIndex = 12;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(14, 30);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(83, 20);
            this.lblLat.TabIndex = 5;
            this.lblLat.Text = "Latitude:";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.Location = new System.Drawing.Point(8, 59);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(97, 20);
            this.lblLong.TabIndex = 4;
            this.lblLong.Text = "Longitude:";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtPostcode);
            this.grpAddress.Controls.Add(this.txtCounty);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.lblPostcode);
            this.grpAddress.Controls.Add(this.lblCounty);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddress.Location = new System.Drawing.Point(17, 92);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(479, 139);
            this.grpAddress.TabIndex = 7;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(116, 87);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.ReadOnly = true;
            this.txtPostcode.Size = new System.Drawing.Size(357, 27);
            this.txtPostcode.TabIndex = 11;
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(116, 55);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
            this.txtCounty.Size = new System.Drawing.Size(357, 27);
            this.txtCounty.TabIndex = 10;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(116, 23);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(357, 27);
            this.txtStreet.TabIndex = 9;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(5, 90);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(93, 20);
            this.lblPostcode.TabIndex = 3;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(15, 58);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(73, 20);
            this.lblCounty.TabIndex = 2;
            this.lblCounty.Text = "County:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(18, 26);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(66, 20);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "Street:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 6;
            // 
            // lblLocName
            // 
            this.lblLocName.AutoSize = true;
            this.lblLocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocName.Location = new System.Drawing.Point(13, 42);
            this.lblLocName.Name = "lblLocName";
            this.lblLocName.Size = new System.Drawing.Size(156, 24);
            this.lblLocName.TabIndex = 5;
            this.lblLocName.Text = "Location Name:";
            // 
            // grpMonth
            // 
            this.grpMonth.Controls.Add(this.lblMonthlyObsv);
            this.grpMonth.Controls.Add(this.lblEditMonth);
            this.grpMonth.Location = new System.Drawing.Point(12, 12);
            this.grpMonth.Name = "grpMonth";
            this.grpMonth.Size = new System.Drawing.Size(269, 100);
            this.grpMonth.TabIndex = 11;
            this.grpMonth.TabStop = false;
            // 
            // lblMonthlyObsv
            // 
            this.lblMonthlyObsv.AutoSize = true;
            this.lblMonthlyObsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyObsv.Location = new System.Drawing.Point(77, 15);
            this.lblMonthlyObsv.Name = "lblMonthlyObsv";
            this.lblMonthlyObsv.Size = new System.Drawing.Size(112, 29);
            this.lblMonthlyObsv.TabIndex = 0;
            this.lblMonthlyObsv.Text = "Location";
            // 
            // lblEditMonth
            // 
            this.lblEditMonth.AutoSize = true;
            this.lblEditMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMonth.Location = new System.Drawing.Point(53, 59);
            this.lblEditMonth.Name = "lblEditMonth";
            this.lblEditMonth.Size = new System.Drawing.Size(161, 24);
            this.lblEditMonth.TabIndex = 1;
            this.lblEditMonth.Text = "Search Location";
            // 
            // frmSearchLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.grpMonth);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpSearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearchLoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Location";
            this.Load += new System.EventHandler(this.frmSearchLoc_Load);
            this.grpSearchBox.ResumeLayout(false);
            this.grpSearchBox.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpLongLat.ResumeLayout(false);
            this.grpLongLat.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpMonth.ResumeLayout(false);
            this.grpMonth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtLocName;
        private System.Windows.Forms.GroupBox grpLongLat;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLocName;
        private System.Windows.Forms.GroupBox grpMonth;
        private System.Windows.Forms.Label lblMonthlyObsv;
        private System.Windows.Forms.Label lblEditMonth;
        private System.Windows.Forms.TextBox txtLocation;
    }
}