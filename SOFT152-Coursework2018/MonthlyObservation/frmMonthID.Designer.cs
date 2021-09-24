namespace SOFT152_Coursework2018
{
    partial class frmMonthID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonthID));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectMonth = new System.Windows.Forms.Label();
            this.drpMonthID = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabLocation = new System.Windows.Forms.TabControl();
            this.grpMonthlyObsv = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Observations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Viewing Data by Month ID";
            // 
            // lblSelectMonth
            // 
            this.lblSelectMonth.AutoSize = true;
            this.lblSelectMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMonth.Location = new System.Drawing.Point(440, 58);
            this.lblSelectMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectMonth.Name = "lblSelectMonth";
            this.lblSelectMonth.Size = new System.Drawing.Size(157, 25);
            this.lblSelectMonth.TabIndex = 2;
            this.lblSelectMonth.Text = "Select Month ID:";
            this.lblSelectMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drpMonthID
            // 
            this.drpMonthID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpMonthID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpMonthID.FormattingEnabled = true;
            this.drpMonthID.Location = new System.Drawing.Point(635, 54);
            this.drpMonthID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drpMonthID.Name = "drpMonthID";
            this.drpMonthID.Size = new System.Drawing.Size(199, 33);
            this.drpMonthID.TabIndex = 3;
            this.drpMonthID.SelectedIndexChanged += new System.EventHandler(this.drpMonthID_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(913, 48);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabLocation
            // 
            this.tabLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocation.Location = new System.Drawing.Point(16, 117);
            this.tabLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLocation.Multiline = true;
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.SelectedIndex = 0;
            this.tabLocation.Size = new System.Drawing.Size(1035, 422);
            this.tabLocation.TabIndex = 7;
            // 
            // grpMonthlyObsv
            // 
            this.grpMonthlyObsv.Location = new System.Drawing.Point(16, 15);
            this.grpMonthlyObsv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMonthlyObsv.Name = "grpMonthlyObsv";
            this.grpMonthlyObsv.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMonthlyObsv.Size = new System.Drawing.Size(369, 95);
            this.grpMonthlyObsv.TabIndex = 8;
            this.grpMonthlyObsv.TabStop = false;
            // 
            // frmMonthID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.drpMonthID);
            this.Controls.Add(this.lblSelectMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabLocation);
            this.Controls.Add(this.grpMonthlyObsv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMonthID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Monthly Observation Data";
            this.Load += new System.EventHandler(this.frmMonthID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectMonth;
        private System.Windows.Forms.ComboBox drpMonthID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabLocation;
        private System.Windows.Forms.GroupBox grpMonthlyObsv;
    }
}