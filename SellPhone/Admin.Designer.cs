namespace SellPhone
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlSubnav = new System.Windows.Forms.Panel();
            this.pnlBrandType = new System.Windows.Forms.Panel();
            this.btnProviderType = new System.Windows.Forms.Button();
            this.pnlPhone = new System.Windows.Forms.Panel();
            this.btnPhone = new System.Windows.Forms.Button();
            this.pnlEmploy = new System.Windows.Forms.Panel();
            this.btnEmploy = new System.Windows.Forms.Button();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlSubnav.SuspendLayout();
            this.pnlBrandType.SuspendLayout();
            this.pnlPhone.SuspendLayout();
            this.pnlEmploy.SuspendLayout();
            this.pnlBill.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.pnlMenu);
            this.menu.Controls.Add(this.pnlSubnav);
            this.menu.Controls.Add(this.pnlBill);
            this.menu.Controls.Add(this.pnlAccount);
            this.menu.Controls.Add(this.pnlReport);
            this.menu.Controls.Add(this.pnlSearch);
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(258, 854);
            this.menu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbLogo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 145);
            this.panel1.TabIndex = 0;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLogo.Image = global::SellPhone.Properties.Resources.snapedit_1699004990344;
            this.ptbLogo.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(249, 145);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMenu.Location = new System.Drawing.Point(3, 154);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(249, 59);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::SellPhone.Properties.Resources.menu;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-17, -3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(283, 65);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "        Danh mục";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlSubnav
            // 
            this.pnlSubnav.Controls.Add(this.pnlBrandType);
            this.pnlSubnav.Controls.Add(this.pnlPhone);
            this.pnlSubnav.Controls.Add(this.pnlEmploy);
            this.pnlSubnav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubnav.Location = new System.Drawing.Point(3, 219);
            this.pnlSubnav.MaximumSize = new System.Drawing.Size(249, 201);
            this.pnlSubnav.Name = "pnlSubnav";
            this.pnlSubnav.Size = new System.Drawing.Size(249, 201);
            this.pnlSubnav.TabIndex = 10;
            // 
            // pnlBrandType
            // 
            this.pnlBrandType.Controls.Add(this.btnProviderType);
            this.pnlBrandType.Location = new System.Drawing.Point(0, 3);
            this.pnlBrandType.MaximumSize = new System.Drawing.Size(249, 59);
            this.pnlBrandType.Name = "pnlBrandType";
            this.pnlBrandType.Size = new System.Drawing.Size(249, 59);
            this.pnlBrandType.TabIndex = 2;
            // 
            // btnProviderType
            // 
            this.btnProviderType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProviderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProviderType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnProviderType.ForeColor = System.Drawing.Color.White;
            this.btnProviderType.Image = global::SellPhone.Properties.Resources.file;
            this.btnProviderType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProviderType.Location = new System.Drawing.Point(-17, -3);
            this.btnProviderType.MaximumSize = new System.Drawing.Size(283, 65);
            this.btnProviderType.Name = "btnProviderType";
            this.btnProviderType.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProviderType.Size = new System.Drawing.Size(283, 65);
            this.btnProviderType.TabIndex = 2;
            this.btnProviderType.Text = "        NCC-Loại";
            this.btnProviderType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProviderType.UseVisualStyleBackColor = true;
            this.btnProviderType.Click += new System.EventHandler(this.btnBrandType_Click);
            // 
            // pnlPhone
            // 
            this.pnlPhone.Controls.Add(this.btnPhone);
            this.pnlPhone.Location = new System.Drawing.Point(0, 68);
            this.pnlPhone.MaximumSize = new System.Drawing.Size(249, 59);
            this.pnlPhone.Name = "pnlPhone";
            this.pnlPhone.Size = new System.Drawing.Size(249, 59);
            this.pnlPhone.TabIndex = 3;
            // 
            // btnPhone
            // 
            this.btnPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhone.ForeColor = System.Drawing.Color.White;
            this.btnPhone.Image = global::SellPhone.Properties.Resources.call;
            this.btnPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhone.Location = new System.Drawing.Point(-17, -3);
            this.btnPhone.MaximumSize = new System.Drawing.Size(283, 65);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPhone.Size = new System.Drawing.Size(283, 65);
            this.btnPhone.TabIndex = 2;
            this.btnPhone.Text = "        Điện Thoại";
            this.btnPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhone.UseVisualStyleBackColor = true;
            // 
            // pnlEmploy
            // 
            this.pnlEmploy.Controls.Add(this.btnEmploy);
            this.pnlEmploy.Location = new System.Drawing.Point(0, 133);
            this.pnlEmploy.MaximumSize = new System.Drawing.Size(249, 59);
            this.pnlEmploy.Name = "pnlEmploy";
            this.pnlEmploy.Size = new System.Drawing.Size(249, 59);
            this.pnlEmploy.TabIndex = 5;
            // 
            // btnEmploy
            // 
            this.btnEmploy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmploy.ForeColor = System.Drawing.Color.White;
            this.btnEmploy.Image = global::SellPhone.Properties.Resources.freelancer;
            this.btnEmploy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploy.Location = new System.Drawing.Point(-17, -3);
            this.btnEmploy.MaximumSize = new System.Drawing.Size(283, 65);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnEmploy.Size = new System.Drawing.Size(283, 65);
            this.btnEmploy.TabIndex = 2;
            this.btnEmploy.Text = "        Nhân Viên";
            this.btnEmploy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploy.UseVisualStyleBackColor = true;
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.btnBill);
            this.pnlBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBill.Location = new System.Drawing.Point(3, 426);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(249, 59);
            this.pnlBill.TabIndex = 6;
            // 
            // btnBill
            // 
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::SellPhone.Properties.Resources.invoice;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(-17, -3);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(283, 65);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "        Hóa Đơn";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.btnAccount);
            this.pnlAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAccount.Location = new System.Drawing.Point(3, 491);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(249, 59);
            this.pnlAccount.TabIndex = 9;
            // 
            // btnAccount
            // 
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::SellPhone.Properties.Resources.user;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(-17, -3);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(283, 65);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "        Tài Khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.btnReport);
            this.pnlReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlReport.Location = new System.Drawing.Point(3, 556);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(249, 59);
            this.pnlReport.TabIndex = 8;
            // 
            // btnReport
            // 
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::SellPhone.Properties.Resources.business_report;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(-17, -3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(283, 65);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "        Báo Cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSearch.Location = new System.Drawing.Point(3, 621);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(249, 59);
            this.pnlSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::SellPhone.Properties.Resources.zoom_in;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(-17, -3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(283, 65);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "        Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // timerMenu
            // 
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlContainer);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(258, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1020, 854);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 95);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1020, 759);
            this.pnlContainer.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlHeader.Controls.Add(this.lblSlogan);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1020, 95);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSlogan.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(0, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(1020, 95);
            this.lblSlogan.TabIndex = 0;
            this.lblSlogan.Text = "JUST DO IT";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::SellPhone.Properties.Resources._6u2ywY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 854);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 910);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 910);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlSubnav.ResumeLayout(false);
            this.pnlBrandType.ResumeLayout(false);
            this.pnlPhone.ResumeLayout(false);
            this.pnlEmploy.ResumeLayout(false);
            this.pnlBill.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            this.pnlReport.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlBrandType;
        private System.Windows.Forms.Button btnProviderType;
        private System.Windows.Forms.Panel pnlPhone;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Panel pnlEmploy;
        private System.Windows.Forms.Button btnEmploy;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Panel pnlSubnav;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

