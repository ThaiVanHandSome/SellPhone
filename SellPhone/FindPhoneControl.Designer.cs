namespace SellPhone
{
    partial class FindPhoneControl
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
            this.findBtn = new System.Windows.Forms.Button();
            this.refeshBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxPrice_3 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice_2 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice_4 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice_5 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice_1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxBlack = new System.Windows.Forms.CheckBox();
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.checkBoxOrgane = new System.Windows.Forms.CheckBox();
            this.checkBoxPink = new System.Windows.Forms.CheckBox();
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox512GB = new System.Windows.Forms.CheckBox();
            this.checkBox128GB = new System.Windows.Forms.CheckBox();
            this.checkBox256GB = new System.Windows.Forms.CheckBox();
            this.checkBox64GB = new System.Windows.Forms.CheckBox();
            this.checkBox32GB = new System.Windows.Forms.CheckBox();
            this.phoneManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.typePhoneComboBox = new System.Windows.Forms.ComboBox();
            this.idPhoneInp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dgPhone = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM ĐIỆN THOẠI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.refeshBtn);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.phoneManufacturerComboBox);
            this.groupBox1.Controls.Add(this.typePhoneComboBox);
            this.groupBox1.Controls.Add(this.idPhoneInp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Image = global::SellPhone.Properties.Resources.zoom_in;
            this.findBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBtn.Location = new System.Drawing.Point(759, 240);
            this.findBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findBtn.Name = "findBtn";
            this.findBtn.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.findBtn.Size = new System.Drawing.Size(155, 67);
            this.findBtn.TabIndex = 8;
            this.findBtn.Text = "    Tìm Kiếm";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // refeshBtn
            // 
            this.refeshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refeshBtn.Image = global::SellPhone.Properties.Resources.edit;
            this.refeshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refeshBtn.Location = new System.Drawing.Point(584, 240);
            this.refeshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refeshBtn.Name = "refeshBtn";
            this.refeshBtn.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refeshBtn.Size = new System.Drawing.Size(155, 67);
            this.refeshBtn.TabIndex = 5;
            this.refeshBtn.Text = "    Làm Mới";
            this.refeshBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxPrice_3);
            this.groupBox4.Controls.Add(this.checkBoxPrice_2);
            this.groupBox4.Controls.Add(this.checkBoxPrice_4);
            this.groupBox4.Controls.Add(this.checkBoxPrice_5);
            this.groupBox4.Controls.Add(this.checkBoxPrice_1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 112);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giá Bán: ";
            // 
            // checkBoxPrice_3
            // 
            this.checkBoxPrice_3.AutoSize = true;
            this.checkBoxPrice_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrice_3.Location = new System.Drawing.Point(383, 26);
            this.checkBoxPrice_3.Name = "checkBoxPrice_3";
            this.checkBoxPrice_3.Size = new System.Drawing.Size(141, 24);
            this.checkBoxPrice_3.TabIndex = 4;
            this.checkBoxPrice_3.Text = "Từ 4 - 7 triệu";
            this.checkBoxPrice_3.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrice_2
            // 
            this.checkBoxPrice_2.AutoSize = true;
            this.checkBoxPrice_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrice_2.Location = new System.Drawing.Point(210, 26);
            this.checkBoxPrice_2.Name = "checkBoxPrice_2";
            this.checkBoxPrice_2.Size = new System.Drawing.Size(141, 24);
            this.checkBoxPrice_2.TabIndex = 3;
            this.checkBoxPrice_2.Text = "Từ 2 - 4 triệu";
            this.checkBoxPrice_2.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrice_4
            // 
            this.checkBoxPrice_4.AutoSize = true;
            this.checkBoxPrice_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrice_4.Location = new System.Drawing.Point(33, 69);
            this.checkBoxPrice_4.Name = "checkBoxPrice_4";
            this.checkBoxPrice_4.Size = new System.Drawing.Size(151, 24);
            this.checkBoxPrice_4.TabIndex = 2;
            this.checkBoxPrice_4.Text = "Từ 7 - 13 triệu";
            this.checkBoxPrice_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPrice_4.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrice_5
            // 
            this.checkBoxPrice_5.AutoSize = true;
            this.checkBoxPrice_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrice_5.Location = new System.Drawing.Point(210, 69);
            this.checkBoxPrice_5.Name = "checkBoxPrice_5";
            this.checkBoxPrice_5.Size = new System.Drawing.Size(139, 24);
            this.checkBoxPrice_5.TabIndex = 1;
            this.checkBoxPrice_5.Text = "Trên 13 triệu";
            this.checkBoxPrice_5.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrice_1
            // 
            this.checkBoxPrice_1.AutoSize = true;
            this.checkBoxPrice_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrice_1.Location = new System.Drawing.Point(33, 26);
            this.checkBoxPrice_1.Name = "checkBoxPrice_1";
            this.checkBoxPrice_1.Size = new System.Drawing.Size(130, 24);
            this.checkBoxPrice_1.TabIndex = 0;
            this.checkBoxPrice_1.Text = "Dưới 2 triệu";
            this.checkBoxPrice_1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxBlack);
            this.groupBox3.Controls.Add(this.checkBoxBlue);
            this.groupBox3.Controls.Add(this.checkBoxOrgane);
            this.groupBox3.Controls.Add(this.checkBoxPink);
            this.groupBox3.Controls.Add(this.checkBoxRed);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(503, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 112);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Màu Sắc: ";
            // 
            // checkBoxBlack
            // 
            this.checkBoxBlack.AutoSize = true;
            this.checkBoxBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBlack.ForeColor = System.Drawing.Color.Black;
            this.checkBoxBlack.Location = new System.Drawing.Point(264, 26);
            this.checkBoxBlack.Name = "checkBoxBlack";
            this.checkBoxBlack.Size = new System.Drawing.Size(64, 24);
            this.checkBoxBlack.TabIndex = 4;
            this.checkBoxBlack.Text = "Đen";
            this.checkBoxBlack.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.AutoSize = true;
            this.checkBoxBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBlue.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxBlue.Location = new System.Drawing.Point(156, 26);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(73, 24);
            this.checkBoxBlue.TabIndex = 3;
            this.checkBoxBlue.Text = "Xanh";
            this.checkBoxBlue.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrgane
            // 
            this.checkBoxOrgane.AutoSize = true;
            this.checkBoxOrgane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOrgane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxOrgane.Location = new System.Drawing.Point(156, 72);
            this.checkBoxOrgane.Name = "checkBoxOrgane";
            this.checkBoxOrgane.Size = new System.Drawing.Size(69, 24);
            this.checkBoxOrgane.TabIndex = 2;
            this.checkBoxOrgane.Text = "Cam";
            this.checkBoxOrgane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxOrgane.UseVisualStyleBackColor = true;
            // 
            // checkBoxPink
            // 
            this.checkBoxPink.AutoSize = true;
            this.checkBoxPink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPink.ForeColor = System.Drawing.Color.Fuchsia;
            this.checkBoxPink.Location = new System.Drawing.Point(41, 72);
            this.checkBoxPink.Name = "checkBoxPink";
            this.checkBoxPink.Size = new System.Drawing.Size(75, 24);
            this.checkBoxPink.TabIndex = 1;
            this.checkBoxPink.Text = "Hồng";
            this.checkBoxPink.UseVisualStyleBackColor = true;
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.AutoSize = true;
            this.checkBoxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRed.ForeColor = System.Drawing.Color.Red;
            this.checkBoxRed.Location = new System.Drawing.Point(41, 26);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(54, 24);
            this.checkBoxRed.TabIndex = 0;
            this.checkBoxRed.Text = "Đỏ";
            this.checkBoxRed.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox512GB);
            this.groupBox2.Controls.Add(this.checkBox128GB);
            this.groupBox2.Controls.Add(this.checkBox256GB);
            this.groupBox2.Controls.Add(this.checkBox64GB);
            this.groupBox2.Controls.Add(this.checkBox32GB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 114);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ Nhớ: ";
            // 
            // checkBox512GB
            // 
            this.checkBox512GB.AutoSize = true;
            this.checkBox512GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox512GB.Location = new System.Drawing.Point(292, 26);
            this.checkBox512GB.Name = "checkBox512GB";
            this.checkBox512GB.Size = new System.Drawing.Size(88, 24);
            this.checkBox512GB.TabIndex = 4;
            this.checkBox512GB.Text = "512GB";
            this.checkBox512GB.UseVisualStyleBackColor = true;
            // 
            // checkBox128GB
            // 
            this.checkBox128GB.AutoSize = true;
            this.checkBox128GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox128GB.Location = new System.Drawing.Point(178, 26);
            this.checkBox128GB.Name = "checkBox128GB";
            this.checkBox128GB.Size = new System.Drawing.Size(88, 24);
            this.checkBox128GB.TabIndex = 3;
            this.checkBox128GB.Text = "128GB";
            this.checkBox128GB.UseVisualStyleBackColor = true;
            // 
            // checkBox256GB
            // 
            this.checkBox256GB.AutoSize = true;
            this.checkBox256GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox256GB.Location = new System.Drawing.Point(178, 65);
            this.checkBox256GB.Name = "checkBox256GB";
            this.checkBox256GB.Size = new System.Drawing.Size(88, 24);
            this.checkBox256GB.TabIndex = 2;
            this.checkBox256GB.Text = "256GB";
            this.checkBox256GB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox256GB.UseVisualStyleBackColor = true;
            // 
            // checkBox64GB
            // 
            this.checkBox64GB.AutoSize = true;
            this.checkBox64GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox64GB.Location = new System.Drawing.Point(33, 65);
            this.checkBox64GB.Name = "checkBox64GB";
            this.checkBox64GB.Size = new System.Drawing.Size(78, 24);
            this.checkBox64GB.TabIndex = 1;
            this.checkBox64GB.Text = "64GB";
            this.checkBox64GB.UseVisualStyleBackColor = true;
            // 
            // checkBox32GB
            // 
            this.checkBox32GB.AutoSize = true;
            this.checkBox32GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox32GB.Location = new System.Drawing.Point(33, 26);
            this.checkBox32GB.Name = "checkBox32GB";
            this.checkBox32GB.Size = new System.Drawing.Size(78, 24);
            this.checkBox32GB.TabIndex = 0;
            this.checkBox32GB.Text = "32GB";
            this.checkBox32GB.UseVisualStyleBackColor = true;
            // 
            // phoneManufacturerComboBox
            // 
            this.phoneManufacturerComboBox.FormattingEnabled = true;
            this.phoneManufacturerComboBox.Location = new System.Drawing.Point(745, 39);
            this.phoneManufacturerComboBox.Name = "phoneManufacturerComboBox";
            this.phoneManufacturerComboBox.Size = new System.Drawing.Size(169, 30);
            this.phoneManufacturerComboBox.TabIndex = 5;
            // 
            // typePhoneComboBox
            // 
            this.typePhoneComboBox.FormattingEnabled = true;
            this.typePhoneComboBox.Location = new System.Drawing.Point(464, 39);
            this.typePhoneComboBox.Name = "typePhoneComboBox";
            this.typePhoneComboBox.Size = new System.Drawing.Size(169, 30);
            this.typePhoneComboBox.TabIndex = 4;
            // 
            // idPhoneInp
            // 
            this.idPhoneInp.Location = new System.Drawing.Point(142, 39);
            this.idPhoneInp.Name = "idPhoneInp";
            this.idPhoneInp.Size = new System.Drawing.Size(152, 28);
            this.idPhoneInp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại Điện Thoại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hãng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Điện Thoại: ";
            // 
            // dgPhone
            // 
            this.dgPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP});
            this.dgPhone.Location = new System.Drawing.Point(15, 413);
            this.dgPhone.Name = "dgPhone";
            this.dgPhone.RowHeadersWidth = 51;
            this.dgPhone.RowTemplate.Height = 24;
            this.dgPhone.Size = new System.Drawing.Size(945, 271);
            this.dgPhone.TabIndex = 2;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // FindPhoneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgPhone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FindPhoneControl";
            this.Size = new System.Drawing.Size(978, 709);
            this.Load += new System.EventHandler(this.FindPhoneControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idPhoneInp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox512GB;
        private System.Windows.Forms.CheckBox checkBox128GB;
        private System.Windows.Forms.CheckBox checkBox256GB;
        private System.Windows.Forms.CheckBox checkBox64GB;
        private System.Windows.Forms.CheckBox checkBox32GB;
        private System.Windows.Forms.ComboBox phoneManufacturerComboBox;
        private System.Windows.Forms.ComboBox typePhoneComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxBlack;
        private System.Windows.Forms.CheckBox checkBoxBlue;
        private System.Windows.Forms.CheckBox checkBoxOrgane;
        private System.Windows.Forms.CheckBox checkBoxPink;
        private System.Windows.Forms.CheckBox checkBoxRed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxPrice_3;
        private System.Windows.Forms.CheckBox checkBoxPrice_2;
        private System.Windows.Forms.CheckBox checkBoxPrice_4;
        private System.Windows.Forms.CheckBox checkBoxPrice_5;
        private System.Windows.Forms.CheckBox checkBoxPrice_1;
        private System.Windows.Forms.DataGridView dgPhone;
        private System.Windows.Forms.Button refeshBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
    }
}
