namespace SOFT152_Coursework2018
{
    partial class frmMonth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonth));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnMonthID = new System.Windows.Forms.Button();
            this.lblMonthID = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpViewData = new System.Windows.Forms.GroupBox();
            this.btnMinTemp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHrsSun = new System.Windows.Forms.Button();
            this.BtnFrostDays = new System.Windows.Forms.Button();
            this.btnAmountRain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpEditData = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpViewData.SuspendLayout();
            this.grpEditData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(250, 16);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(297, 31);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Monthly Observations";
            // 
            // btnMonthID
            // 
            this.btnMonthID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthID.Location = new System.Drawing.Point(325, 35);
            this.btnMonthID.Name = "btnMonthID";
            this.btnMonthID.Size = new System.Drawing.Size(83, 32);
            this.btnMonthID.TabIndex = 2;
            this.btnMonthID.Text = "Select";
            this.btnMonthID.UseVisualStyleBackColor = true;
            this.btnMonthID.Click += new System.EventHandler(this.btnMonthID_Click);
            // 
            // lblMonthID
            // 
            this.lblMonthID.AutoSize = true;
            this.lblMonthID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthID.Location = new System.Drawing.Point(10, 38);
            this.lblMonthID.Name = "lblMonthID";
            this.lblMonthID.Size = new System.Drawing.Size(257, 24);
            this.lblMonthID.TabIndex = 3;
            this.lblMonthID.Text = "View All Data By Month ID:";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(10, 74);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(275, 24);
            this.lblMaxTemp.TabIndex = 4;
            this.lblMaxTemp.Text = "View Highest Temperatures:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "View Monthly Percipitation Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "View Monthly Frost Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "View Monthly Hours of Sun:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(701, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 33);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpViewData
            // 
            this.grpViewData.Controls.Add(this.btnMinTemp);
            this.grpViewData.Controls.Add(this.label1);
            this.grpViewData.Controls.Add(this.btnHrsSun);
            this.grpViewData.Controls.Add(this.BtnFrostDays);
            this.grpViewData.Controls.Add(this.btnAmountRain);
            this.grpViewData.Controls.Add(this.button1);
            this.grpViewData.Controls.Add(this.label4);
            this.grpViewData.Controls.Add(this.btnMonthID);
            this.grpViewData.Controls.Add(this.lblMonthID);
            this.grpViewData.Controls.Add(this.lblMaxTemp);
            this.grpViewData.Controls.Add(this.label2);
            this.grpViewData.Controls.Add(this.label3);
            this.grpViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViewData.Location = new System.Drawing.Point(202, 103);
            this.grpViewData.Name = "grpViewData";
            this.grpViewData.Size = new System.Drawing.Size(421, 254);
            this.grpViewData.TabIndex = 9;
            this.grpViewData.TabStop = false;
            this.grpViewData.Text = "View Data";
            // 
            // btnMinTemp
            // 
            this.btnMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinTemp.Location = new System.Drawing.Point(325, 107);
            this.btnMinTemp.Name = "btnMinTemp";
            this.btnMinTemp.Size = new System.Drawing.Size(83, 32);
            this.btnMinTemp.TabIndex = 13;
            this.btnMinTemp.Text = "Select";
            this.btnMinTemp.UseVisualStyleBackColor = true;
            this.btnMinTemp.Click += new System.EventHandler(this.btnMinTemp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "View Lowest Temperatures:";
            // 
            // btnHrsSun
            // 
            this.btnHrsSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHrsSun.Location = new System.Drawing.Point(325, 215);
            this.btnHrsSun.Name = "btnHrsSun";
            this.btnHrsSun.Size = new System.Drawing.Size(83, 32);
            this.btnHrsSun.TabIndex = 11;
            this.btnHrsSun.Text = "Select";
            this.btnHrsSun.UseVisualStyleBackColor = true;
            this.btnHrsSun.Click += new System.EventHandler(this.btnHrsSun_Click);
            // 
            // BtnFrostDays
            // 
            this.BtnFrostDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFrostDays.Location = new System.Drawing.Point(325, 179);
            this.BtnFrostDays.Name = "BtnFrostDays";
            this.BtnFrostDays.Size = new System.Drawing.Size(83, 32);
            this.BtnFrostDays.TabIndex = 10;
            this.BtnFrostDays.Text = "Select";
            this.BtnFrostDays.UseVisualStyleBackColor = true;
            this.BtnFrostDays.Click += new System.EventHandler(this.BtnFrostDays_Click);
            // 
            // btnAmountRain
            // 
            this.btnAmountRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmountRain.Location = new System.Drawing.Point(325, 143);
            this.btnAmountRain.Name = "btnAmountRain";
            this.btnAmountRain.Size = new System.Drawing.Size(83, 32);
            this.btnAmountRain.TabIndex = 9;
            this.btnAmountRain.Text = "Select";
            this.btnAmountRain.UseVisualStyleBackColor = true;
            this.btnAmountRain.Click += new System.EventHandler(this.btnAmountRain_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpEditData
            // 
            this.grpEditData.Controls.Add(this.btnEdit);
            this.grpEditData.Controls.Add(this.label5);
            this.grpEditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditData.Location = new System.Drawing.Point(202, 363);
            this.grpEditData.Name = "grpEditData";
            this.grpEditData.Size = new System.Drawing.Size(421, 66);
            this.grpEditData.TabIndex = 10;
            this.grpEditData.TabStop = false;
            this.grpEditData.Text = "Edit Data";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(325, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 32);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Edit Monthly Observation:";
            // 
            // frmMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEditData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpViewData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Observation Options";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpViewData.ResumeLayout(false);
            this.grpViewData.PerformLayout();
            this.grpEditData.ResumeLayout(false);
            this.grpEditData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnMonthID;
        private System.Windows.Forms.Label lblMonthID;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpViewData;
        private System.Windows.Forms.Button btnHrsSun;
        private System.Windows.Forms.Button BtnFrostDays;
        private System.Windows.Forms.Button btnAmountRain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpEditData;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinTemp;
    }
}