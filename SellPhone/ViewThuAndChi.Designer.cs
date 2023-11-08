namespace SellPhone
{
    partial class ViewThuAndChi
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
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.checkBoxMonth = new System.Windows.Forms.CheckBox();
            this.checkBoxDay = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxQ = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.yearInp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthInp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dayInp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.refeshBtn = new System.Windows.Forms.Button();
            this.dgViewThu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.sumThu = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sumChi = new System.Windows.Forms.RichTextBox();
            this.dgViewChi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewChi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "XEM DOANH THU";
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
            this.groupBox1.Location = new System.Drawing.Point(17, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
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
            // yearInp
            // 
            this.yearInp.Location = new System.Drawing.Point(670, 39);
            this.yearInp.Name = "yearInp";
            this.yearInp.Size = new System.Drawing.Size(130, 28);
            this.yearInp.TabIndex = 5;
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
            // monthInp
            // 
            this.monthInp.FormattingEnabled = true;
            this.monthInp.Location = new System.Drawing.Point(405, 38);
            this.monthInp.Name = "monthInp";
            this.monthInp.Size = new System.Drawing.Size(121, 30);
            this.monthInp.TabIndex = 3;
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
            // dayInp
            // 
            this.dayInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayInp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayInp.Location = new System.Drawing.Point(97, 36);
            this.dayInp.Name = "dayInp";
            this.dayInp.Size = new System.Drawing.Size(165, 28);
            this.dayInp.TabIndex = 1;
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
            // dgViewThu
            // 
            this.dgViewThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewThu.Location = new System.Drawing.Point(23, 354);
            this.dgViewThu.Name = "dgViewThu";
            this.dgViewThu.RowHeadersWidth = 51;
            this.dgViewThu.RowTemplate.Height = 24;
            this.dgViewThu.Size = new System.Drawing.Size(396, 237);
            this.dgViewThu.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tổng Thu";
            // 
            // sumThu
            // 
            this.sumThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumThu.Location = new System.Drawing.Point(179, 282);
            this.sumThu.Name = "sumThu";
            this.sumThu.Size = new System.Drawing.Size(185, 34);
            this.sumThu.TabIndex = 15;
            this.sumThu.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng Chi";
            // 
            // sumChi
            // 
            this.sumChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumChi.Location = new System.Drawing.Point(605, 277);
            this.sumChi.Name = "sumChi";
            this.sumChi.Size = new System.Drawing.Size(185, 34);
            this.sumChi.TabIndex = 17;
            this.sumChi.Text = "";
            // 
            // dgViewChi
            // 
            this.dgViewChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewChi.Location = new System.Drawing.Point(477, 354);
            this.dgViewChi.Name = "dgViewChi";
            this.dgViewChi.RowHeadersWidth = 51;
            this.dgViewChi.RowTemplate.Height = 24;
            this.dgViewChi.Size = new System.Drawing.Size(396, 237);
            this.dgViewChi.TabIndex = 18;
            // 
            // ViewThuAndChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgViewChi);
            this.Controls.Add(this.sumChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sumThu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgViewThu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ViewThuAndChi";
            this.Size = new System.Drawing.Size(911, 614);
            this.Load += new System.EventHandler(this.ViewThuAndChi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxMonth;
        private System.Windows.Forms.CheckBox checkBoxDay;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button refeshBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxQ;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox yearInp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox monthInp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dayInp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgViewThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox sumThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox sumChi;
        private System.Windows.Forms.DataGridView dgViewChi;
    }
}
