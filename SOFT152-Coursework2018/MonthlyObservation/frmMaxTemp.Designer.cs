namespace SOFT152_Coursework2018
{
    partial class frmMaxTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaxTemp));
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.yAxis = new System.Windows.Forms.Panel();
            this.xAxis = new System.Windows.Forms.Panel();
            this.grpMaxTempGraph = new System.Windows.Forms.GroupBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.lblLowTemp = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.txtYearID = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.txtHotMonth = new System.Windows.Forms.TextBox();
            this.lblHotMonth = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.drpLocation = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblSelectLocation = new System.Windows.Forms.Label();
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.grpMaxTempGraph.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Location = new System.Drawing.Point(44, 22);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(592, 405);
            this.pnlGraph.TabIndex = 2;
            // 
            // yAxis
            // 
            this.yAxis.Location = new System.Drawing.Point(7, 21);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(31, 405);
            this.yAxis.TabIndex = 1;
            this.yAxis.Paint += new System.Windows.Forms.PaintEventHandler(this.yAxis_Paint);
            // 
            // xAxis
            // 
            this.xAxis.Location = new System.Drawing.Point(44, 432);
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(592, 32);
            this.xAxis.TabIndex = 3;
            this.xAxis.Paint += new System.Windows.Forms.PaintEventHandler(this.xAxis_Paint);
            // 
            // grpMaxTempGraph
            // 
            this.grpMaxTempGraph.Controls.Add(this.yAxis);
            this.grpMaxTempGraph.Controls.Add(this.xAxis);
            this.grpMaxTempGraph.Controls.Add(this.pnlGraph);
            this.grpMaxTempGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaxTempGraph.Location = new System.Drawing.Point(193, 54);
            this.grpMaxTempGraph.Name = "grpMaxTempGraph";
            this.grpMaxTempGraph.Size = new System.Drawing.Size(645, 474);
            this.grpMaxTempGraph.TabIndex = 4;
            this.grpMaxTempGraph.TabStop = false;
            this.grpMaxTempGraph.Text = "Max Temperature Each Month";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnBack);
            this.grpDetails.Controls.Add(this.txtMinTemp);
            this.grpDetails.Controls.Add(this.lblLowTemp);
            this.grpDetails.Controls.Add(this.lblLowest);
            this.grpDetails.Controls.Add(this.txtYearID);
            this.grpDetails.Controls.Add(this.lblYear);
            this.grpDetails.Controls.Add(this.txtMaxTemp);
            this.grpDetails.Controls.Add(this.lblTemp);
            this.grpDetails.Controls.Add(this.lblHighest);
            this.grpDetails.Controls.Add(this.txtHotMonth);
            this.grpDetails.Controls.Add(this.lblHotMonth);
            this.grpDetails.Controls.Add(this.txtLocation);
            this.grpDetails.Controls.Add(this.lblLocationName);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(12, 54);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(175, 474);
            this.grpDetails.TabIndex = 5;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(40, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 28);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(5, 368);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.ReadOnly = true;
            this.txtMinTemp.Size = new System.Drawing.Size(163, 26);
            this.txtMinTemp.TabIndex = 11;
            // 
            // lblLowTemp
            // 
            this.lblLowTemp.AutoSize = true;
            this.lblLowTemp.Location = new System.Drawing.Point(5, 339);
            this.lblLowTemp.Name = "lblLowTemp";
            this.lblLowTemp.Size = new System.Drawing.Size(116, 20);
            this.lblLowTemp.TabIndex = 10;
            this.lblLowTemp.Text = "Temperature:";
            // 
            // lblLowest
            // 
            this.lblLowest.AutoSize = true;
            this.lblLowest.Location = new System.Drawing.Point(5, 318);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(66, 20);
            this.lblLowest.TabIndex = 9;
            this.lblLowest.Text = "Lowest";
            // 
            // txtYearID
            // 
            this.txtYearID.Location = new System.Drawing.Point(5, 130);
            this.txtYearID.Name = "txtYearID";
            this.txtYearID.ReadOnly = true;
            this.txtYearID.Size = new System.Drawing.Size(163, 26);
            this.txtYearID.TabIndex = 8;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(5, 101);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 20);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year:";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(5, 281);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.ReadOnly = true;
            this.txtMaxTemp.Size = new System.Drawing.Size(163, 26);
            this.txtMaxTemp.TabIndex = 6;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(5, 252);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(116, 20);
            this.lblTemp.TabIndex = 5;
            this.lblTemp.Text = "Temperature:";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Location = new System.Drawing.Point(5, 232);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(71, 20);
            this.lblHighest.TabIndex = 4;
            this.lblHighest.Text = "Highest";
            // 
            // txtHotMonth
            // 
            this.txtHotMonth.Location = new System.Drawing.Point(5, 194);
            this.txtHotMonth.Name = "txtHotMonth";
            this.txtHotMonth.ReadOnly = true;
            this.txtHotMonth.Size = new System.Drawing.Size(163, 26);
            this.txtHotMonth.TabIndex = 3;
            // 
            // lblHotMonth
            // 
            this.lblHotMonth.AutoSize = true;
            this.lblHotMonth.Location = new System.Drawing.Point(5, 165);
            this.lblHotMonth.Name = "lblHotMonth";
            this.lblHotMonth.Size = new System.Drawing.Size(129, 20);
            this.lblHotMonth.TabIndex = 2;
            this.lblHotMonth.Text = "Hottest Month:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(5, 66);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(163, 26);
            this.txtLocation.TabIndex = 1;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(5, 37);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(83, 20);
            this.lblLocationName.TabIndex = 0;
            this.lblLocationName.Text = "Location:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.drpLocation);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.lblSelectLocation);
            this.groupBox2.Controls.Add(this.lblSelectYear);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(121, -7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(614, 20);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(79, 25);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // drpLocation
            // 
            this.drpLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpLocation.FormattingEnabled = true;
            this.drpLocation.Location = new System.Drawing.Point(174, 16);
            this.drpLocation.Name = "drpLocation";
            this.drpLocation.Size = new System.Drawing.Size(182, 32);
            this.drpLocation.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(483, 18);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 29);
            this.txtYear.TabIndex = 2;
            // 
            // lblSelectLocation
            // 
            this.lblSelectLocation.AutoSize = true;
            this.lblSelectLocation.Location = new System.Drawing.Point(9, 19);
            this.lblSelectLocation.Name = "lblSelectLocation";
            this.lblSelectLocation.Size = new System.Drawing.Size(159, 24);
            this.lblSelectLocation.TabIndex = 1;
            this.lblSelectLocation.Text = "Select Location:";
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Location = new System.Drawing.Point(362, 21);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(115, 24);
            this.lblSelectYear.TabIndex = 0;
            this.lblSelectYear.Text = "Enter Year:";
            // 
            // frmMaxTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(850, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpMaxTempGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMaxTemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maximum Temperature";
            this.Load += new System.EventHandler(this.frmMaxTemp_Load);
            this.grpMaxTempGraph.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Panel yAxis;
        private System.Windows.Forms.Panel xAxis;
        private System.Windows.Forms.GroupBox grpMaxTempGraph;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox drpLocation;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblSelectLocation;
        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.Label lblLowTemp;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.TextBox txtYearID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.TextBox txtHotMonth;
        private System.Windows.Forms.Label lblHotMonth;
    }
}