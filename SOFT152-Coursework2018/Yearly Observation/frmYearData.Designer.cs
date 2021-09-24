namespace SOFT152_Coursework2018
{
    partial class frmYearData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearData));
            this.lblYealryObsv = new System.Windows.Forms.Label();
            this.lblAllData = new System.Windows.Forms.Label();
            this.tabYears = new System.Windows.Forms.TabControl();
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.txtSelectYear = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpAllYearData = new System.Windows.Forms.GroupBox();
            this.grpSelectYear = new System.Windows.Forms.GroupBox();
            this.grpAllYearData.SuspendLayout();
            this.grpSelectYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYealryObsv
            // 
            this.lblYealryObsv.AutoSize = true;
            this.lblYealryObsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYealryObsv.Location = new System.Drawing.Point(15, 16);
            this.lblYealryObsv.Name = "lblYealryObsv";
            this.lblYealryObsv.Size = new System.Drawing.Size(248, 29);
            this.lblYealryObsv.TabIndex = 0;
            this.lblYealryObsv.Text = "Yearly Observations";
            // 
            // lblAllData
            // 
            this.lblAllData.AutoSize = true;
            this.lblAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllData.Location = new System.Drawing.Point(58, 60);
            this.lblAllData.Name = "lblAllData";
            this.lblAllData.Size = new System.Drawing.Size(162, 24);
            this.lblAllData.TabIndex = 1;
            this.lblAllData.Text = "Viewing All Data";
            // 
            // tabYears
            // 
            this.tabYears.Location = new System.Drawing.Point(12, 120);
            this.tabYears.Name = "tabYears";
            this.tabYears.SelectedIndex = 0;
            this.tabYears.Size = new System.Drawing.Size(776, 350);
            this.tabYears.TabIndex = 2;
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYear.Location = new System.Drawing.Point(17, 26);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(190, 24);
            this.lblSelectYear.TabIndex = 3;
            this.lblSelectYear.Text = "Enter Year to View:";
            // 
            // txtSelectYear
            // 
            this.txtSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectYear.Location = new System.Drawing.Point(230, 23);
            this.txtSelectYear.Name = "txtSelectYear";
            this.txtSelectYear.Size = new System.Drawing.Size(150, 29);
            this.txtSelectYear.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(154, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(713, 476);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpAllYearData
            // 
            this.grpAllYearData.Controls.Add(this.lblYealryObsv);
            this.grpAllYearData.Controls.Add(this.lblAllData);
            this.grpAllYearData.Location = new System.Drawing.Point(12, 12);
            this.grpAllYearData.Name = "grpAllYearData";
            this.grpAllYearData.Size = new System.Drawing.Size(269, 100);
            this.grpAllYearData.TabIndex = 7;
            this.grpAllYearData.TabStop = false;
            // 
            // grpSelectYear
            // 
            this.grpSelectYear.Controls.Add(this.lblSelectYear);
            this.grpSelectYear.Controls.Add(this.btnSearch);
            this.grpSelectYear.Controls.Add(this.txtSelectYear);
            this.grpSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectYear.Location = new System.Drawing.Point(345, 12);
            this.grpSelectYear.Name = "grpSelectYear";
            this.grpSelectYear.Size = new System.Drawing.Size(400, 100);
            this.grpSelectYear.TabIndex = 8;
            this.grpSelectYear.TabStop = false;
            // 
            // frmYearData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabYears);
            this.Controls.Add(this.grpAllYearData);
            this.Controls.Add(this.grpSelectYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmYearData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Yearly Observation Data";
            this.Load += new System.EventHandler(this.frmYearData_Load);
            this.grpAllYearData.ResumeLayout(false);
            this.grpAllYearData.PerformLayout();
            this.grpSelectYear.ResumeLayout(false);
            this.grpSelectYear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYealryObsv;
        private System.Windows.Forms.Label lblAllData;
        private System.Windows.Forms.TabControl tabYears;
        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.TextBox txtSelectYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpAllYearData;
        private System.Windows.Forms.GroupBox grpSelectYear;
    }
}