namespace BT09
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            cbChuyenNganh = new ComboBox();
            listBoxMonHoc1 = new ListBox();
            listBoxMonHoc2 = new ListBox();
            btnChuyenPhai = new Button();
            btnChuyenTrai = new Button();
            groupBoxThongTin = new GroupBox();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            btnXoa = new Button();
            btnLuu = new Button();
            dGVThongTin = new DataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            ChuyenNganh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            SoMon = new DataGridViewTextBoxColumn();
            MonHoc = new DataGridViewTextBoxColumn();
            groupBoxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVThongTin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 27);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 59);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 90);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Chuyên Ngành";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 123);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 157);
            label5.Name = "label5";
            label5.Size = new Size(203, 20);
            label5.TabIndex = 4;
            label5.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(285, 24);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(235, 27);
            txtMaSV.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(285, 59);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(235, 27);
            txtHoTen.TabIndex = 6;
            // 
            // cbChuyenNganh
            // 
            cbChuyenNganh.FormattingEnabled = true;
            cbChuyenNganh.Location = new Point(285, 92);
            cbChuyenNganh.Name = "cbChuyenNganh";
            cbChuyenNganh.Size = new Size(235, 28);
            cbChuyenNganh.TabIndex = 7;
            // 
            // listBoxMonHoc1
            // 
            listBoxMonHoc1.FormattingEnabled = true;
            listBoxMonHoc1.Location = new Point(155, 180);
            listBoxMonHoc1.Name = "listBoxMonHoc1";
            listBoxMonHoc1.SelectionMode = SelectionMode.MultiExtended;
            listBoxMonHoc1.Size = new Size(235, 104);
            listBoxMonHoc1.TabIndex = 11;
            // 
            // listBoxMonHoc2
            // 
            listBoxMonHoc2.FormattingEnabled = true;
            listBoxMonHoc2.Location = new Point(469, 180);
            listBoxMonHoc2.Name = "listBoxMonHoc2";
            listBoxMonHoc2.SelectionMode = SelectionMode.MultiExtended;
            listBoxMonHoc2.Size = new Size(211, 104);
            listBoxMonHoc2.TabIndex = 12;
            // 
            // btnChuyenPhai
            // 
            btnChuyenPhai.BackColor = SystemColors.AppWorkspace;
            btnChuyenPhai.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChuyenPhai.Location = new Point(413, 197);
            btnChuyenPhai.Name = "btnChuyenPhai";
            btnChuyenPhai.Size = new Size(40, 29);
            btnChuyenPhai.TabIndex = 13;
            btnChuyenPhai.Text = ">";
            btnChuyenPhai.UseVisualStyleBackColor = false;
            btnChuyenPhai.Click += btnChuyenPhai_Click;
            // 
            // btnChuyenTrai
            // 
            btnChuyenTrai.BackColor = SystemColors.AppWorkspace;
            btnChuyenTrai.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChuyenTrai.Location = new Point(413, 232);
            btnChuyenTrai.Name = "btnChuyenTrai";
            btnChuyenTrai.Size = new Size(41, 29);
            btnChuyenTrai.TabIndex = 14;
            btnChuyenTrai.Text = "<";
            btnChuyenTrai.UseVisualStyleBackColor = false;
            btnChuyenTrai.Click += btnChuyenTrai_Click;
            // 
            // groupBoxThongTin
            // 
            groupBoxThongTin.AutoSize = true;
            groupBoxThongTin.Controls.Add(rbNu);
            groupBoxThongTin.Controls.Add(rbNam);
            groupBoxThongTin.Controls.Add(btnXoa);
            groupBoxThongTin.Controls.Add(btnLuu);
            groupBoxThongTin.Controls.Add(btnChuyenTrai);
            groupBoxThongTin.Controls.Add(btnChuyenPhai);
            groupBoxThongTin.Controls.Add(listBoxMonHoc2);
            groupBoxThongTin.Controls.Add(listBoxMonHoc1);
            groupBoxThongTin.Controls.Add(cbChuyenNganh);
            groupBoxThongTin.Controls.Add(txtHoTen);
            groupBoxThongTin.Controls.Add(txtMaSV);
            groupBoxThongTin.Controls.Add(label5);
            groupBoxThongTin.Controls.Add(label4);
            groupBoxThongTin.Controls.Add(label3);
            groupBoxThongTin.Controls.Add(label2);
            groupBoxThongTin.Controls.Add(label1);
            groupBoxThongTin.Location = new Point(0, 0);
            groupBoxThongTin.Name = "groupBoxThongTin";
            groupBoxThongTin.Size = new Size(788, 342);
            groupBoxThongTin.TabIndex = 0;
            groupBoxThongTin.TabStop = false;
            groupBoxThongTin.Text = "Thông Tin Sinh Viên";
            groupBoxThongTin.Enter += groupBoxThongTin_Enter;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(421, 121);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 19;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(285, 123);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 24);
            rbNam.TabIndex = 18;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ButtonFace;
            btnXoa.Location = new Point(413, 287);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa Chọn";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ButtonFace;
            btnLuu.Location = new Point(254, 287);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(136, 29);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu Thông Tin";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // dGVThongTin
            // 
            dGVThongTin.AllowUserToAddRows = false;
            dGVThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVThongTin.Columns.AddRange(new DataGridViewColumn[] { MaSV, HoTen, ChuyenNganh, GioiTinh, SoMon, MonHoc });
            dGVThongTin.Location = new Point(0, 328);
            dGVThongTin.Name = "dGVThongTin";
            dGVThongTin.ReadOnly = true;
            dGVThongTin.RowHeadersWidth = 51;
            dGVThongTin.ScrollBars = ScrollBars.Horizontal;
            dGVThongTin.Size = new Size(788, 188);
            dGVThongTin.TabIndex = 1;
            // 
            // MaSV
            // 
            MaSV.HeaderText = "MSSV";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.ReadOnly = true;
            MaSV.Width = 125;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ Tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 200;
            // 
            // ChuyenNganh
            // 
            ChuyenNganh.HeaderText = "Chuyên Ngành";
            ChuyenNganh.MinimumWidth = 6;
            ChuyenNganh.Name = "ChuyenNganh";
            ChuyenNganh.ReadOnly = true;
            ChuyenNganh.Width = 150;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Width = 125;
            // 
            // SoMon
            // 
            SoMon.HeaderText = "Số Môn";
            SoMon.MinimumWidth = 6;
            SoMon.Name = "SoMon";
            SoMon.ReadOnly = true;
            SoMon.Width = 125;
            // 
            // MonHoc
            // 
            MonHoc.HeaderText = "Danh Sách Môn Học";
            MonHoc.MinimumWidth = 6;
            MonHoc.Name = "MonHoc";
            MonHoc.ReadOnly = true;
            MonHoc.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(dGVThongTin);
            Controls.Add(groupBoxThongTin);
            Name = "Form1";
            Text = "Nhập Liệu Sinh Viên";
            Load += Form1_Load;
            groupBoxThongTin.ResumeLayout(false);
            groupBoxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVThongTin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private ComboBox cbChuyenNganh;
        private ListBox listBoxMonHoc1;
        private ListBox listBoxMonHoc2;
        private Button btnChuyenPhai;
        private Button btnChuyenTrai;
        private GroupBox groupBoxThongTin;
        private Button btnXoa;
        private Button btnLuu;
        private DataGridView dGVThongTin;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn ChuyenNganh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SoMon;
        private DataGridViewTextBoxColumn MonHoc;
    }
}
