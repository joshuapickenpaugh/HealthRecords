namespace HealthRecords
{
    partial class frmMain
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblMaxHeartRate = new System.Windows.Forms.Label();
            this.lblTargetHeartRate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.cmbLBS = new System.Windows.Forms.ComboBox();
            this.cmbHeight = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(76, 16);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(199, 20);
            this.txtFName.TabIndex = 0;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(76, 42);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(199, 20);
            this.txtLName.TabIndex = 1;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(13, 19);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(47, 13);
            this.lblFName.TabIndex = 8;
            this.lblFName.Text = "F Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "L Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DOB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "H (inches):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "LBS:";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Lime;
            this.btnCalc.Location = new System.Drawing.Point(7, 356);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(270, 23);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblAge
            // 
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAge.Location = new System.Drawing.Point(6, 223);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(269, 23);
            this.lblAge.TabIndex = 15;
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBMI.Location = new System.Drawing.Point(7, 255);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(269, 23);
            this.lblBMI.TabIndex = 16;
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxHeartRate
            // 
            this.lblMaxHeartRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaxHeartRate.Location = new System.Drawing.Point(6, 287);
            this.lblMaxHeartRate.Name = "lblMaxHeartRate";
            this.lblMaxHeartRate.Size = new System.Drawing.Size(269, 23);
            this.lblMaxHeartRate.TabIndex = 17;
            this.lblMaxHeartRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTargetHeartRate
            // 
            this.lblTargetHeartRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetHeartRate.Location = new System.Drawing.Point(7, 319);
            this.lblTargetHeartRate.Name = "lblTargetHeartRate";
            this.lblTargetHeartRate.Size = new System.Drawing.Size(269, 23);
            this.lblTargetHeartRate.TabIndex = 18;
            this.lblTargetHeartRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(7, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.Location = new System.Drawing.Point(176, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Location = new System.Drawing.Point(76, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 55);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(123, 19);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(34, 19);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // cmbLBS
            // 
            this.cmbLBS.FormattingEnabled = true;
            this.cmbLBS.Location = new System.Drawing.Point(76, 183);
            this.cmbLBS.Name = "cmbLBS";
            this.cmbLBS.Size = new System.Drawing.Size(200, 21);
            this.cmbLBS.TabIndex = 25;
            // 
            // cmbHeight
            // 
            this.cmbHeight.FormattingEnabled = true;
            this.cmbHeight.Location = new System.Drawing.Point(76, 156);
            this.cmbHeight.Name = "cmbHeight";
            this.cmbHeight.Size = new System.Drawing.Size(199, 21);
            this.cmbHeight.TabIndex = 24;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 413);
            this.Controls.Add(this.cmbLBS);
            this.Controls.Add(this.cmbHeight);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTargetHeartRate);
            this.Controls.Add(this.lblMaxHeartRate);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Records";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblMaxHeartRate;
        private System.Windows.Forms.Label lblTargetHeartRate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.ComboBox cmbLBS;
        private System.Windows.Forms.ComboBox cmbHeight;
    }
}

