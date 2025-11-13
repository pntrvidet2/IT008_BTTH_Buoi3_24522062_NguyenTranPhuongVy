namespace BT08
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb1 = new Label();
            lb2 = new Label();
            lb3 = new Label();
            lb4 = new Label();
            label5 = new Label();
            txtSoTK = new TextBox();
            txtTenKH = new TextBox();
            txtDiaChi = new TextBox();
            txtSoTien = new TextBox();
            btnThoat = new Button();
            btnThemCapNhat = new Button();
            btnXoa = new Button();
            lvTaiKhoan = new ListView();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(81, 61);
            lb1.Name = "lb1";
            lb1.RightToLeft = RightToLeft.No;
            lb1.Size = new Size(91, 20);
            lb1.TabIndex = 0;
            lb1.Text = "Số tài khoản";
            lb1.TextAlign = ContentAlignment.MiddleRight;
            lb1.Click += label1_Click;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(61, 103);
            lb2.Name = "lb2";
            lb2.RightToLeft = RightToLeft.No;
            lb2.Size = new Size(111, 20);
            lb2.TabIndex = 1;
            lb2.Text = "Tên khách hàng";
            lb2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Location = new Point(38, 147);
            lb3.Name = "lb3";
            lb3.RightToLeft = RightToLeft.No;
            lb3.Size = new Size(134, 20);
            lb3.TabIndex = 2;
            lb3.Text = "Địa chỉ khách hàng";
            lb3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lb4
            // 
            lb4.AutoSize = true;
            lb4.Location = new Point(13, 185);
            lb4.Name = "lb4";
            lb4.RightToLeft = RightToLeft.No;
            lb4.Size = new Size(160, 20);
            lb4.TabIndex = 3;
            lb4.Text = "Số tiền trong tài khoản";
            lb4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(56, 9);
            label5.Name = "label5";
            label5.Size = new Size(610, 50);
            label5.TabIndex = 4;
            label5.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // txtSoTK
            // 
            txtSoTK.Location = new Point(178, 54);
            txtSoTK.Name = "txtSoTK";
            txtSoTK.Size = new Size(293, 27);
            txtSoTK.TabIndex = 5;
            txtSoTK.TextChanged += txtSoTK_TextChanged;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(178, 96);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(293, 27);
            txtTenKH.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(178, 140);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(293, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(178, 182);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(293, 27);
            txtSoTien.TabIndex = 8;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ButtonFace;
            btnThoat.BackgroundImageLayout = ImageLayout.None;
            btnThoat.Location = new Point(529, 152);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThemCapNhat
            // 
            btnThemCapNhat.BackColor = SystemColors.ButtonFace;
            btnThemCapNhat.Location = new Point(529, 82);
            btnThemCapNhat.Name = "btnThemCapNhat";
            btnThemCapNhat.Size = new Size(146, 29);
            btnThemCapNhat.TabIndex = 10;
            btnThemCapNhat.Text = "Thêm / Cập Nhật";
            btnThemCapNhat.UseVisualStyleBackColor = false;
            btnThemCapNhat.Click += btnThemCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ButtonFace;
            btnXoa.Location = new Point(529, 117);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // lvTaiKhoan
            // 
            lvTaiKhoan.Location = new Point(13, 233);
            lvTaiKhoan.Name = "lvTaiKhoan";
            lvTaiKhoan.Size = new Size(775, 187);
            lvTaiKhoan.TabIndex = 13;
            lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvTaiKhoan);
            Controls.Add(btnXoa);
            Controls.Add(btnThemCapNhat);
            Controls.Add(btnThoat);
            Controls.Add(txtSoTien);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenKH);
            Controls.Add(txtSoTK);
            Controls.Add(label5);
            Controls.Add(lb4);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Name = "Form1";
            Text = "Quản Lý Tài Khoản";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private Label lb2;
        private Label lb3;
        private Label lb4;
        private Label label5;
        private TextBox txtSoTK;
        private TextBox txtTenKH;
        private TextBox txtDiaChi;
        private TextBox txtSoTien;
        private Button btnThoat;
        private Button btnThemCapNhat;
        private Button btnXoa;
        private ListView lvTaiKhoan;
    }
}
