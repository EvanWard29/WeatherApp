namespace SOFT152_Coursework2018
{
    partial class frmAddLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLocation));
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAddLoc = new System.Windows.Forms.Label();
            this.lblLocName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCoords = new System.Windows.Forms.GroupBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.grpLocation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCoords.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.lblLocation);
            this.grpLocation.Controls.Add(this.lblAddLoc);
            this.grpLocation.Location = new System.Drawing.Point(268, 12);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(269, 100);
            this.grpLocation.TabIndex = 13;
            this.grpLocation.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(79, 15);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(112, 29);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location";
            // 
            // lblAddLoc
            // 
            this.lblAddLoc.AutoSize = true;
            this.lblAddLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLoc.Location = new System.Drawing.Point(69, 59);
            this.lblAddLoc.Name = "lblAddLoc";
            this.lblAddLoc.Size = new System.Drawing.Size(133, 24);
            this.lblAddLoc.TabIndex = 1;
            this.lblAddLoc.Text = "Add Location";
            // 
            // lblLocName
            // 
            this.lblLocName.AutoSize = true;
            this.lblLocName.Location = new System.Drawing.Point(16, 48);
            this.lblLocName.Name = "lblLocName";
            this.lblLocName.Size = new System.Drawing.Size(156, 24);
            this.lblLocName.TabIndex = 14;
            this.lblLocName.Text = "Location Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpCoords);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblLocName);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 277);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Details";
            // 
            // grpCoords
            // 
            this.grpCoords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCoords.Controls.Add(this.txtLong);
            this.grpCoords.Controls.Add(this.txtLat);
            this.grpCoords.Controls.Add(this.lblLat);
            this.grpCoords.Controls.Add(this.lblLong);
            this.grpCoords.Location = new System.Drawing.Point(502, 99);
            this.grpCoords.Name = "grpCoords";
            this.grpCoords.Size = new System.Drawing.Size(259, 163);
            this.grpCoords.TabIndex = 20;
            this.grpCoords.TabStop = false;
            this.grpCoords.Text = "Coordinates";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(127, 107);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(126, 29);
            this.txtLong.TabIndex = 21;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(127, 48);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(126, 29);
            this.txtLat.TabIndex = 20;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(12, 51);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(89, 24);
            this.lblLat.TabIndex = 17;
            this.lblLat.Text = "Latitude:";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(6, 110);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(109, 24);
            this.lblLong.TabIndex = 15;
            this.lblLong.Text = "Longitude:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 29);
            this.txtName.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPostcode);
            this.groupBox2.Controls.Add(this.txtCounty);
            this.groupBox2.Controls.Add(this.txtStreet);
            this.groupBox2.Controls.Add(this.lblPostcode);
            this.groupBox2.Controls.Add(this.lblCounty);
            this.groupBox2.Controls.Add(this.lblStreet);
            this.groupBox2.Location = new System.Drawing.Point(16, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 163);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(168, 119);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(287, 29);
            this.txtPostcode.TabIndex = 19;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(168, 76);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(287, 29);
            this.txtCounty.TabIndex = 18;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(168, 28);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(287, 29);
            this.txtStreet.TabIndex = 17;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(26, 122);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(103, 24);
            this.lblPostcode.TabIndex = 17;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(37, 81);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(81, 24);
            this.lblCounty.TabIndex = 16;
            this.lblCounty.Text = "County:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(42, 37);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(70, 24);
            this.lblStreet.TabIndex = 15;
            this.lblStreet.Text = "Street:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(353, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 35);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(690, 412);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 35);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // selectFile
            // 
            this.selectFile.FileName = "SelectFile";
            // 
            // frmAddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpLocation);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Location";
            this.Load += new System.EventHandler(this.frmAddLocation_Load);
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCoords.ResumeLayout(false);
            this.grpCoords.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAddLoc;
        private System.Windows.Forms.Label lblLocName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpCoords;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog selectFile;
    }
}