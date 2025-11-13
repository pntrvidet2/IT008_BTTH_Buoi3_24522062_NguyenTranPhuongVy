using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BT09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã số sinh viên!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên!");
                return;
            }
            if (cbChuyenNganh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Chuyên Ngành!");
                return;
            }

            string gt = "";
            if (rbNam.Checked) gt = "Nam";
            else if (rbNu.Checked) gt = "Nữ";
            else
            {
                MessageBox.Show("Vui lòng chọn Giới tính!");
                return;
            }
           
            int soMon = listBoxMonHoc2.Items.Count;
            dGVThongTin.Rows.Add(txtMaSV.Text, txtHoTen.Text, cbChuyenNganh.SelectedItem.ToString(), gt, soMon);
            txtMaSV.Clear();
            txtHoTen.Clear();
            cbChuyenNganh.SelectedIndex = -1;
            rbNam.Checked = false;
            rbNu.Checked = false;
            foreach (var item in listBoxMonHoc2.Items)
                listBoxMonHoc1.Items.Add(item);
            listBoxMonHoc2.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Enabled = true;
            txtMaSV.Clear();
            txtHoTen.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false;
            dGVThongTin.AllowUserToAddRows = false;
            cbChuyenNganh.Items.Add("Kỹ Thuật Phần Mềm");
            cbChuyenNganh.Items.Add("Kỹ Thuật Máy Tính");
            cbChuyenNganh.Items.Add("Khoa Học Máy Tính");
            cbChuyenNganh.Items.Add("Trí Tuệ Nhân Tạo");
            cbChuyenNganh.Items.Add("Thương Mại Điện Tử");
            cbChuyenNganh.Items.Add("Truyền Thông Đa Phương Tiện");
            cbChuyenNganh.Items.Add("An Toàn Thông Tin");
            cbChuyenNganh.Items.Add("Hệ Thống Thông Tin");
            cbChuyenNganh.Items.Add("Mạng Máy Tính và Truyền Thông");
            cbChuyenNganh.Items.Add("Công Nghệ Thông Tin");
            cbChuyenNganh.Items.Add("Khoa Học Dữ Liệu");
            if (cbChuyenNganh.Items.Count > 0)
                cbChuyenNganh.SelectedIndex = 0;

            listBoxMonHoc1.Items.Clear();
            listBoxMonHoc1.SelectionMode = SelectionMode.MultiExtended;
            listBoxMonHoc1.Items.Add("Giải tích");
            listBoxMonHoc1.Items.Add("Nhập môn lập trình");
            listBoxMonHoc1.Items.Add("Đại số tuyến tính");
            listBoxMonHoc1.Items.Add("Lập trình trực quan");
            listBoxMonHoc1.Items.Add("Cơ sở dữ liệu");
            listBoxMonHoc1.Items.Add("Mạng máy tính");
            listBoxMonHoc1.Items.Add("Hệ điều hành");
            listBoxMonHoc1.Items.Add("AI cơ bản");
            listBoxMonHoc1.Items.Add("Trí tuệ nhân tạo");
            listBoxMonHoc1.Items.Add("Nhập môn mạng máy tính");

            listBoxMonHoc2.Items.Clear();

        }
        private void btnChuyenPhai_Click(object sender, EventArgs e)
        {
            var selected = new object[listBoxMonHoc1.SelectedItems.Count];
            listBoxMonHoc1.SelectedItems.CopyTo(selected, 0);

            foreach (var item in selected)
            {
                listBoxMonHoc1.Items.Remove(item);
                listBoxMonHoc2.Items.Add(item);
            }
        }
        private void btnChuyenTrai_Click(object sender, EventArgs e)
        {
            var selected = new object[listBoxMonHoc2.SelectedItems.Count];
            listBoxMonHoc2.SelectedItems.CopyTo(selected, 0);

            foreach (var item in selected)
            {
                listBoxMonHoc2.Items.Remove(item);
                listBoxMonHoc1.Items.Add(item);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dGVThongTin.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa dòng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dGVThongTin.SelectedRows)
                        dGVThongTin.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }

}

