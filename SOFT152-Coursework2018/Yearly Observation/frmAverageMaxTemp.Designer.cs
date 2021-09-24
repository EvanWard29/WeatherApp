namespace SOFT152_Coursework2018
{
    partial class frmAverageMaxTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAverageMaxTemp));
            this.drpLocation = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSelectLocation = new System.Windows.Forms.Label();
            this.lblTotalYears = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTotalYears = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtMaxYear = new System.Windows.Forms.RichTextBox();
            this.xAxis = new System.Windows.Forms.Panel();
            this.grpMaxTempGraph = new System.Windows.Forms.GroupBox();
            this.yAxis = new System.Windows.Forms.Panel();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpMaxTempGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // drpLocation
            // 
            this.drpLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpLocation.FormattingEnabled = true;
            this.drpLocation.Location = new System.Drawing.Point(174, 16);
            this.drpLocation.Name = "drpLocation";
            this.drpLocation.Size = new System.Drawing.Size(234, 32);
            this.drpLocation.TabIndex = 3;
            this.drpLocation.SelectedIndexChanged += new System.EventHandler(this.drpLocation_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.drpLocation);
            this.groupBox2.Controls.Add(this.lblSelectLocation);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(606, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 55);
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
            // lblTotalYears
            // 
            this.lblTotalYears.AutoSize = true;
            this.lblTotalYears.Location = new System.Drawing.Point(59, 221);
            this.lblTotalYears.Name = "lblTotalYears";
            this.lblTotalYears.Size = new System.Drawing.Size(61, 20);
            this.lblTotalYears.TabIndex = 23;
            this.lblTotalYears.Text = "Years:";
            this.lblTotalYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(40, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 28);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTotalYears
            // 
            this.txtTotalYears.Location = new System.Drawing.Point(5, 247);
            this.txtTotalYears.Name = "txtTotalYears";
            this.txtTotalYears.ReadOnly = true;
            this.txtTotalYears.Size = new System.Drawing.Size(163, 26);
            this.txtTotalYears.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(18, 199);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 20);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total Number of";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(28, 117);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(117, 20);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Hottest Year:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(5, 70);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(163, 26);
            this.txtLocation.TabIndex = 1;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(45, 44);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(83, 20);
            this.lblLocationName.TabIndex = 0;
            this.lblLocationName.Text = "Location:";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDetails.Controls.Add(this.txtMaxYear);
            this.grpDetails.Controls.Add(this.lblTotalYears);
            this.grpDetails.Controls.Add(this.btnBack);
            this.grpDetails.Controls.Add(this.txtTotalYears);
            this.grpDetails.Controls.Add(this.lblTotal);
            this.grpDetails.Controls.Add(this.lblYear);
            this.grpDetails.Controls.Add(this.txtLocation);
            this.grpDetails.Controls.Add(this.lblLocationName);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(10, 73);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(175, 474);
            this.grpDetails.TabIndex = 14;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details:";
            // 
            // txtMaxYear
            // 
            this.txtMaxYear.Location = new System.Drawing.Point(5, 145);
            this.txtMaxYear.Name = "txtMaxYear";
            this.txtMaxYear.ReadOnly = true;
            this.txtMaxYear.Size = new System.Drawing.Size(163, 51);
            this.txtMaxYear.TabIndex = 24;
            this.txtMaxYear.Text = "";
            // 
            // xAxis
            // 
            this.xAxis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xAxis.Location = new System.Drawing.Point(44, 436);
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(784, 32);
            this.xAxis.TabIndex = 3;
            this.xAxis.Paint += new System.Windows.Forms.PaintEventHandler(this.xAxis_Paint);
            // 
            // grpMaxTempGraph
            // 
            this.grpMaxTempGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMaxTempGraph.Controls.Add(this.yAxis);
            this.grpMaxTempGraph.Controls.Add(this.xAxis);
            this.grpMaxTempGraph.Controls.Add(this.pnlGraph);
            this.grpMaxTempGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaxTempGraph.Location = new System.Drawing.Point(191, 73);
            this.grpMaxTempGraph.Name = "grpMaxTempGraph";
            this.grpMaxTempGraph.Size = new System.Drawing.Size(834, 474);
            this.grpMaxTempGraph.TabIndex = 13;
            this.grpMaxTempGraph.TabStop = false;
            this.grpMaxTempGraph.Text = "Average Maximium Temperature By Location";
            // 
            // yAxis
            // 
            this.yAxis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.yAxis.Location = new System.Drawing.Point(7, 25);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(31, 405);
            this.yAxis.TabIndex = 1;
            this.yAxis.Paint += new System.Windows.Forms.PaintEventHandler(this.yAxis_Paint);
            // 
            // pnlGraph
            // 
            this.pnlGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraph.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Location = new System.Drawing.Point(44, 26);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(784, 405);
            this.pnlGraph.TabIndex = 2;
            // 
            // frmAverageMaxTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1037, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpMaxTempGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAverageMaxTemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Maximum Temperature";
            this.Load += new System.EventHandler(this.frmAverageMaxTemp_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpMaxTempGraph.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox drpLocation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSelectLocation;
        private System.Windows.Forms.Label lblTotalYears;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTotalYears;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Panel xAxis;
        private System.Windows.Forms.GroupBox grpMaxTempGraph;
        private System.Windows.Forms.Panel yAxis;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.RichTextBox txtMaxYear;
    }
}