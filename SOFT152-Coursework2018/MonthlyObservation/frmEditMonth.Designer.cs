namespace SOFT152_Coursework2018
{
    partial class frmEditMonth
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditMonth));
            this.lblMonthlyObsv = new System.Windows.Forms.Label();
            this.lblEditMonth = new System.Windows.Forms.Label();
            this.grpMonth = new System.Windows.Forms.GroupBox();
            this.grpSelectMonth = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.drpLocation = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.grpMonthDet = new System.Windows.Forms.GroupBox();
            this.dgvMonthlyObsv = new System.Windows.Forms.DataGridView();
            this.MonthID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrostDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountRain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrsSun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.grpMonth.SuspendLayout();
            this.grpSelectMonth.SuspendLayout();
            this.grpMonthDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyObsv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonthlyObsv
            // 
            this.lblMonthlyObsv.AutoSize = true;
            this.lblMonthlyObsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyObsv.Location = new System.Drawing.Point(3, 15);
            this.lblMonthlyObsv.Name = "lblMonthlyObsv";
            this.lblMonthlyObsv.Size = new System.Drawing.Size(264, 29);
            this.lblMonthlyObsv.TabIndex = 0;
            this.lblMonthlyObsv.Text = "Monthly Observations";
            // 
            // lblEditMonth
            // 
            this.lblEditMonth.AutoSize = true;
            this.lblEditMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMonth.Location = new System.Drawing.Point(14, 59);
            this.lblEditMonth.Name = "lblEditMonth";
            this.lblEditMonth.Size = new System.Drawing.Size(243, 24);
            this.lblEditMonth.TabIndex = 1;
            this.lblEditMonth.Text = "Edit Monthly Observation";
            // 
            // grpMonth
            // 
            this.grpMonth.Controls.Add(this.lblMonthlyObsv);
            this.grpMonth.Controls.Add(this.lblEditMonth);
            this.grpMonth.Location = new System.Drawing.Point(12, 12);
            this.grpMonth.Name = "grpMonth";
            this.grpMonth.Size = new System.Drawing.Size(269, 100);
            this.grpMonth.TabIndex = 9;
            this.grpMonth.TabStop = false;
            // 
            // grpSelectMonth
            // 
            this.grpSelectMonth.Controls.Add(this.btnSearch);
            this.grpSelectMonth.Controls.Add(this.txtYear);
            this.grpSelectMonth.Controls.Add(this.lblYear);
            this.grpSelectMonth.Controls.Add(this.drpLocation);
            this.grpSelectMonth.Controls.Add(this.lblLocation);
            this.grpSelectMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectMonth.Location = new System.Drawing.Point(298, 12);
            this.grpSelectMonth.Name = "grpSelectMonth";
            this.grpSelectMonth.Size = new System.Drawing.Size(490, 100);
            this.grpSelectMonth.TabIndex = 10;
            this.grpSelectMonth.TabStop = false;
            this.grpSelectMonth.Text = "Select Month";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(373, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 27);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(166, 60);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(166, 26);
            this.txtYear.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(33, 63);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(101, 20);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Enter Year:";
            // 
            // drpLocation
            // 
            this.drpLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpLocation.FormattingEnabled = true;
            this.drpLocation.Location = new System.Drawing.Point(166, 28);
            this.drpLocation.Name = "drpLocation";
            this.drpLocation.Size = new System.Drawing.Size(166, 28);
            this.drpLocation.TabIndex = 11;
            this.drpLocation.SelectedIndexChanged += new System.EventHandler(this.drpLocation_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(14, 31);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(139, 20);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Select Location:";
            // 
            // grpMonthDet
            // 
            this.grpMonthDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMonthDet.Controls.Add(this.dgvMonthlyObsv);
            this.grpMonthDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonthDet.Location = new System.Drawing.Point(12, 118);
            this.grpMonthDet.Name = "grpMonthDet";
            this.grpMonthDet.Size = new System.Drawing.Size(776, 320);
            this.grpMonthDet.TabIndex = 13;
            this.grpMonthDet.TabStop = false;
            this.grpMonthDet.Text = "Months Observation:";
            // 
            // dgvMonthlyObsv
            // 
            this.dgvMonthlyObsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlyObsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyObsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonthID,
            this.MaxTemp,
            this.MinTemp,
            this.FrostDays,
            this.AmountRain,
            this.HrsSun});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlyObsv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlyObsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonthlyObsv.Location = new System.Drawing.Point(3, 22);
            this.dgvMonthlyObsv.Name = "dgvMonthlyObsv";
            this.dgvMonthlyObsv.Size = new System.Drawing.Size(770, 295);
            this.dgvMonthlyObsv.TabIndex = 0;
            // 
            // MonthID
            // 
            this.MonthID.HeaderText = "Month ID";
            this.MonthID.Name = "MonthID";
            this.MonthID.ReadOnly = true;
            // 
            // MaxTemp
            // 
            this.MaxTemp.HeaderText = "Maximum Temperature (°C)";
            this.MaxTemp.Name = "MaxTemp";
            // 
            // MinTemp
            // 
            this.MinTemp.HeaderText = "Minimum Temperature (°C)";
            this.MinTemp.Name = "MinTemp";
            // 
            // FrostDays
            // 
            this.FrostDays.HeaderText = "Number of Frosty Days";
            this.FrostDays.Name = "FrostDays";
            // 
            // AmountRain
            // 
            this.AmountRain.HeaderText = "Milimetres of Rain (mm)";
            this.AmountRain.Name = "AmountRain";
            // 
            // HrsSun
            // 
            this.HrsSun.HeaderText = "Hours of Sun";
            this.HrsSun.Name = "HrsSun";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(671, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 27);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(363, 441);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // selectFile
            // 
            this.selectFile.FileName = "SelectFile";
            // 
            // frmEditMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpMonthDet);
            this.Controls.Add(this.grpSelectMonth);
            this.Controls.Add(this.grpMonth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Monthly Observations";
            this.Load += new System.EventHandler(this.frmEditMonth_Load);
            this.grpMonth.ResumeLayout(false);
            this.grpMonth.PerformLayout();
            this.grpSelectMonth.ResumeLayout(false);
            this.grpSelectMonth.PerformLayout();
            this.grpMonthDet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyObsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMonthlyObsv;
        private System.Windows.Forms.Label lblEditMonth;
        private System.Windows.Forms.GroupBox grpMonth;
        private System.Windows.Forms.GroupBox grpSelectMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox drpLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpMonthDet;
        private System.Windows.Forms.DataGridView dgvMonthlyObsv;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrostDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountRain;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrsSun;
        private System.Windows.Forms.OpenFileDialog selectFile;
    }
}