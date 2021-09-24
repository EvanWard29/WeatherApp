namespace SOFT152_Coursework2018
{
    partial class frmHrsSun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHrsSun));
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblHrsSun = new System.Windows.Forms.Label();
            this.grpMaxTempGraph = new System.Windows.Forms.GroupBox();
            this.yAxis = new System.Windows.Forms.Panel();
            this.xAxis = new System.Windows.Forms.Panel();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtMinSun = new System.Windows.Forms.RichTextBox();
            this.lblMinMonth = new System.Windows.Forms.Label();
            this.lblMinSun = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtYearID = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtMaxSun = new System.Windows.Forms.RichTextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.drpLocation = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSelectLocation = new System.Windows.Forms.Label();
            this.grpMaxTempGraph.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(6, 167);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(163, 20);
            this.lblMonth.TabIndex = 17;
            this.lblMonth.Text = "Month with Highest";
            // 
            // lblHrsSun
            // 
            this.lblHrsSun.AutoSize = true;
            this.lblHrsSun.Location = new System.Drawing.Point(27, 187);
            this.lblHrsSun.Name = "lblHrsSun";
            this.lblHrsSun.Size = new System.Drawing.Size(120, 20);
            this.lblHrsSun.TabIndex = 19;
            this.lblHrsSun.Text = "Hours of Sun:";
            // 
            // grpMaxTempGraph
            // 
            this.grpMaxTempGraph.Controls.Add(this.yAxis);
            this.grpMaxTempGraph.Controls.Add(this.xAxis);
            this.grpMaxTempGraph.Controls.Add(this.pnlGraph);
            this.grpMaxTempGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaxTempGraph.Location = new System.Drawing.Point(193, 64);
            this.grpMaxTempGraph.Name = "grpMaxTempGraph";
            this.grpMaxTempGraph.Size = new System.Drawing.Size(645, 474);
            this.grpMaxTempGraph.TabIndex = 13;
            this.grpMaxTempGraph.TabStop = false;
            this.grpMaxTempGraph.Text = "Millimetres of Rain Each Month";
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
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Location = new System.Drawing.Point(44, 22);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(592, 405);
            this.pnlGraph.TabIndex = 2;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtMinSun);
            this.grpDetails.Controls.Add(this.lblMinMonth);
            this.grpDetails.Controls.Add(this.lblMinSun);
            this.grpDetails.Controls.Add(this.btnBack);
            this.grpDetails.Controls.Add(this.txtTotal);
            this.grpDetails.Controls.Add(this.lblMonth);
            this.grpDetails.Controls.Add(this.txtYearID);
            this.grpDetails.Controls.Add(this.lblTotal);
            this.grpDetails.Controls.Add(this.lblYear);
            this.grpDetails.Controls.Add(this.txtMaxSun);
            this.grpDetails.Controls.Add(this.txtLocation);
            this.grpDetails.Controls.Add(this.lblLocationName);
            this.grpDetails.Controls.Add(this.lblHrsSun);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(12, 64);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(175, 474);
            this.grpDetails.TabIndex = 14;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details:";
            // 
            // txtMinSun
            // 
            this.txtMinSun.Location = new System.Drawing.Point(5, 303);
            this.txtMinSun.Name = "txtMinSun";
            this.txtMinSun.ReadOnly = true;
            this.txtMinSun.Size = new System.Drawing.Size(163, 47);
            this.txtMinSun.TabIndex = 26;
            this.txtMinSun.Text = "";
            // 
            // lblMinMonth
            // 
            this.lblMinMonth.AutoSize = true;
            this.lblMinMonth.Location = new System.Drawing.Point(5, 260);
            this.lblMinMonth.Name = "lblMinMonth";
            this.lblMinMonth.Size = new System.Drawing.Size(163, 20);
            this.lblMinMonth.TabIndex = 24;
            this.lblMinMonth.Text = "Month with Highest";
            // 
            // lblMinSun
            // 
            this.lblMinSun.AutoSize = true;
            this.lblMinSun.Location = new System.Drawing.Point(26, 280);
            this.lblMinSun.Name = "lblMinSun";
            this.lblMinSun.Size = new System.Drawing.Size(120, 20);
            this.lblMinSun.TabIndex = 25;
            this.lblMinSun.Text = "Hours of Sun:";
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
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(5, 386);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(163, 26);
            this.txtTotal.TabIndex = 22;
            // 
            // txtYearID
            // 
            this.txtYearID.Location = new System.Drawing.Point(5, 130);
            this.txtYearID.Name = "txtYearID";
            this.txtYearID.ReadOnly = true;
            this.txtYearID.Size = new System.Drawing.Size(163, 26);
            this.txtYearID.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(4, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(165, 20);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total Hours of Sun:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // txtMaxSun
            // 
            this.txtMaxSun.Location = new System.Drawing.Point(6, 210);
            this.txtMaxSun.Name = "txtMaxSun";
            this.txtMaxSun.ReadOnly = true;
            this.txtMaxSun.Size = new System.Drawing.Size(163, 47);
            this.txtMaxSun.TabIndex = 18;
            this.txtMaxSun.Text = "";
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
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Location = new System.Drawing.Point(362, 21);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(115, 24);
            this.lblSelectYear.TabIndex = 0;
            this.lblSelectYear.Text = "Enter Year:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.drpLocation);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.lblSelectLocation);
            this.groupBox2.Controls.Add(this.lblSelectYear);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(121, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 55);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
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
            // frmHrsSun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(850, 540);
            this.Controls.Add(this.grpMaxTempGraph);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHrsSun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hours of Sun";
            this.Load += new System.EventHandler(this.frmHrsSun_Load);
            this.grpMaxTempGraph.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblHrsSun;
        private System.Windows.Forms.GroupBox grpMaxTempGraph;
        private System.Windows.Forms.Panel yAxis;
        private System.Windows.Forms.Panel xAxis;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtYearID;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.RichTextBox txtMaxSun;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox drpLocation;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSelectLocation;
        private System.Windows.Forms.RichTextBox txtMinSun;
        private System.Windows.Forms.Label lblMinMonth;
        private System.Windows.Forms.Label lblMinSun;
    }
}