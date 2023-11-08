namespace SellPhone
{
    partial class BillControl
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
            this.lblBreadCrume = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.cbPhuongThucTT = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongThucTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBreadCrume
            // 
            this.lblBreadCrume.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBreadCrume.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBreadCrume.Location = new System.Drawing.Point(0, 0);
            this.lblBreadCrume.Name = "lblBreadCrume";
            this.lblBreadCrume.Size = new System.Drawing.Size(1020, 82);
            this.lblBreadCrume.TabIndex = 1;
            this.lblBreadCrume.Text = "Hóa Đơn";
            this.lblBreadCrume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.cbPhuongThucTT);
            this.grbInfo.Controls.Add(this.label7);
            this.grbInfo.Controls.Add(this.label4);
            this.grbInfo.Controls.Add(this.txtMaSP);
            this.grbInfo.Controls.Add(this.label5);
            this.grbInfo.Controls.Add(this.txtTongSL);
            this.grbInfo.Controls.Add(this.label6);
            this.grbInfo.Controls.Add(this.txtHoTen);
            this.grbInfo.Controls.Add(this.label3);
            this.grbInfo.Controls.Add(this.txtMaNV);
            this.grbInfo.Controls.Add(this.label2);
            this.grbInfo.Controls.Add(this.txtCCCD);
            this.grbInfo.Controls.Add(this.label1);
            this.grbInfo.Controls.Add(this.txtSDT);
            this.grbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbInfo.Location = new System.Drawing.Point(0, 82);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(1020, 252);
            this.grbInfo.TabIndex = 2;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Danh Sách Hóa Đơn";
            // 
            // cbPhuongThucTT
            // 
            this.cbPhuongThucTT.AutoSize = true;
            this.cbPhuongThucTT.Location = new System.Drawing.Point(746, 101);
            this.cbPhuongThucTT.Name = "cbPhuongThucTT";
            this.cbPhuongThucTT.Size = new System.Drawing.Size(106, 32);
            this.cbPhuongThucTT.TabIndex = 13;
            this.cbPhuongThucTT.Text = "Trả Góp";
            this.cbPhuongThucTT.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(720, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phương Thức Thanh Toán:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(370, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Sản Phẩm:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(514, 103);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(191, 34);
            this.txtMaSP.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(356, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Số Lượng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTongSL
            // 
            this.txtTongSL.Location = new System.Drawing.Point(514, 160);
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.Size = new System.Drawing.Size(191, 34);
            this.txtTongSL.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Họ Tên:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(115, 103);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(191, 34);
            this.txtHoTen.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(426, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã NV:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(514, 54);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(191, 34);
            this.txtMaNV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "CCCD:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(115, 156);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(191, 34);
            this.txtCCCD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SDT:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(115, 51);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 34);
            this.txtSDT.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 308);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Điện Thoại";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.MaKH,
            this.NgayMuaHang,
            this.PhuongThucTT});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 30);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(1014, 275);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 150;
            // 
            // NgayMuaHang
            // 
            this.NgayMuaHang.DataPropertyName = "NgayMuaHang";
            this.NgayMuaHang.HeaderText = "Ngày Mua Hàng";
            this.NgayMuaHang.MinimumWidth = 8;
            this.NgayMuaHang.Name = "NgayMuaHang";
            this.NgayMuaHang.Width = 150;
            // 
            // PhuongThucTT
            // 
            this.PhuongThucTT.DataPropertyName = "PhuongThucTT";
            this.PhuongThucTT.HeaderText = "Phương Thức Thanh Toán";
            this.PhuongThucTT.MinimumWidth = 8;
            this.PhuongThucTT.Name = "PhuongThucTT";
            this.PhuongThucTT.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 642);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1020, 107);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // button5
            // 
            this.button5.Image = global::SellPhone.Properties.Resources.cross;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(824, 33);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(4);
            this.button5.Size = new System.Drawing.Size(146, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "   Hủy";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::SellPhone.Properties.Resources.plus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(653, 33);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4);
            this.button1.Size = new System.Drawing.Size(146, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "   Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.lblBreadCrume);
            this.Name = "BillControl";
            this.Size = new System.Drawing.Size(1020, 759);
            BillControl billControl = this;
            this.Load += new System.EventHandler(this.BillControl_Load);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBreadCrume;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.CheckBox cbPhuongThucTT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucTT;
    }
}
