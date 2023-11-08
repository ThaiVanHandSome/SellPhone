namespace SellPhone
{
    partial class FindImportControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.dayInp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.monthInp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearInp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.dgImport = new System.Windows.Forms.DataGridView();
            this.checkBoxDay = new System.Windows.Forms.CheckBox();
            this.checkBoxMonth = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.checkBoxQ = new System.Windows.Forms.CheckBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.refeshBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÌM KIẾM PHIẾU NHẬP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxYear);
            this.groupBox1.Controls.Add(this.checkBoxMonth);
            this.groupBox1.Controls.Add(this.checkBoxDay);
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.refeshBtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.yearInp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.monthInp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dayInp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày: ";
            // 
            // dayInp
            // 
            this.dayInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayInp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayInp.Location = new System.Drawing.Point(97, 36);
            this.dayInp.Name = "dayInp";
            this.dayInp.Size = new System.Drawing.Size(165, 28);
            this.dayInp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng: ";
            // 
            // monthInp
            // 
            this.monthInp.FormattingEnabled = true;
            this.monthInp.Location = new System.Drawing.Point(405, 38);
            this.monthInp.Name = "monthInp";
            this.monthInp.Size = new System.Drawing.Size(121, 30);
            this.monthInp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm: ";
            // 
            // yearInp
            // 
            this.yearInp.Location = new System.Drawing.Point(670, 39);
            this.yearInp.Name = "yearInp";
            this.yearInp.Size = new System.Drawing.Size(130, 28);
            this.yearInp.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxQ);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quý";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(48, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Quý 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(149, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 26);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quý 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(252, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 26);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Quý 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(347, 37);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(79, 26);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Quý 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // dgImport
            // 
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Location = new System.Drawing.Point(19, 273);
            this.dgImport.Name = "dgImport";
            this.dgImport.RowHeadersWidth = 51;
            this.dgImport.RowTemplate.Height = 24;
            this.dgImport.Size = new System.Drawing.Size(873, 237);
            this.dgImport.TabIndex = 3;
            // 
            // checkBoxDay
            // 
            this.checkBoxDay.AutoSize = true;
            this.checkBoxDay.Location = new System.Drawing.Point(6, 42);
            this.checkBoxDay.Name = "checkBoxDay";
            this.checkBoxDay.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDay.TabIndex = 10;
            this.checkBoxDay.UseVisualStyleBackColor = true;
            this.checkBoxDay.CheckedChanged += new System.EventHandler(this.checkBoxDay_CheckedChanged);
            // 
            // checkBoxMonth
            // 
            this.checkBoxMonth.AutoSize = true;
            this.checkBoxMonth.Location = new System.Drawing.Point(303, 43);
            this.checkBoxMonth.Name = "checkBoxMonth";
            this.checkBoxMonth.Size = new System.Drawing.Size(18, 17);
            this.checkBoxMonth.TabIndex = 11;
            this.checkBoxMonth.UseVisualStyleBackColor = true;
            this.checkBoxMonth.CheckedChanged += new System.EventHandler(this.checkBoxMonth_CheckedChanged);
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Location = new System.Drawing.Point(583, 45);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(18, 17);
            this.checkBoxYear.TabIndex = 12;
            this.checkBoxYear.UseVisualStyleBackColor = true;
            this.checkBoxYear.CheckedChanged += new System.EventHandler(this.checkBoxYear_CheckedChanged);
            // 
            // checkBoxQ
            // 
            this.checkBoxQ.AutoSize = true;
            this.checkBoxQ.Location = new System.Drawing.Point(10, 26);
            this.checkBoxQ.Name = "checkBoxQ";
            this.checkBoxQ.Size = new System.Drawing.Size(18, 17);
            this.checkBoxQ.TabIndex = 13;
            this.checkBoxQ.UseVisualStyleBackColor = true;
            this.checkBoxQ.CheckedChanged += new System.EventHandler(this.checkBoxQ_CheckedChanged);
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Image = global::SellPhone.Properties.Resources.zoom_in;
            this.findBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBtn.Location = new System.Drawing.Point(701, 107);
            this.findBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findBtn.Name = "findBtn";
            this.findBtn.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.findBtn.Size = new System.Drawing.Size(155, 46);
            this.findBtn.TabIndex = 9;
            this.findBtn.Text = "    Tìm Kiếm";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // refeshBtn
            // 
            this.refeshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refeshBtn.Image = global::SellPhone.Properties.Resources.edit;
            this.refeshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refeshBtn.Location = new System.Drawing.Point(509, 106);
            this.refeshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refeshBtn.Name = "refeshBtn";
            this.refeshBtn.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refeshBtn.Size = new System.Drawing.Size(155, 47);
            this.refeshBtn.TabIndex = 7;
            this.refeshBtn.Text = "    Làm Mới";
            this.refeshBtn.UseVisualStyleBackColor = true;
            this.refeshBtn.Click += new System.EventHandler(this.refeshBtn_Click);
            // 
            // FindImportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgImport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FindImportControl";
            this.Size = new System.Drawing.Size(911, 614);
            this.Load += new System.EventHandler(this.FindImportControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox monthInp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dayInp;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox yearInp;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button refeshBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.DataGridView dgImport;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxMonth;
        private System.Windows.Forms.CheckBox checkBoxDay;
        private System.Windows.Forms.CheckBox checkBoxQ;
    }
}
