namespace BT08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CapNhatSTT()
        {
            int stt = 1;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                item.SubItems[0].Text = stt.ToString();
                stt++;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTK.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem itemXoa = null;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == txtSoTK.Text)
                {
                    itemXoa = item;
                    break;
                }
            }

            if (itemXoa == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lvTaiKhoan.Items.Remove(itemXoa);
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhatSTT();

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.GridLines = true;

            lvTaiKhoan.Columns.Add("STT", 50);
            lvTaiKhoan.Columns.Add("Số Tài Khoản", 120);
            lvTaiKhoan.Columns.Add("Tên", 150);
            lvTaiKhoan.Columns.Add("Địa Chỉ", 180);
            lvTaiKhoan.Columns.Add("Số Tiền", 100, HorizontalAlignment.Right);
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTK.Text) ||
        string.IsNullOrWhiteSpace(txtTenKH.Text) ||
        string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
        string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSoTien.Text, out decimal soTien))
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra tồn tại STK
            ListViewItem itemTonTai = null;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == txtSoTK.Text)
                {
                    itemTonTai = item;
                    break;
                }
            }

            if (itemTonTai == null)
            {
                // Thêm mới
                ListViewItem item = new ListViewItem(); // STT tạm thời sẽ gán sau
                item.SubItems[0].Text = ""; // STT
                item.SubItems.Add(txtSoTK.Text);
                item.SubItems.Add(txtTenKH.Text);
                item.SubItems.Add(txtDiaChi.Text);
                item.SubItems.Add(soTien.ToString());

                lvTaiKhoan.Items.Add(item);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật
                itemTonTai.SubItems[2].Text = txtTenKH.Text;
                itemTonTai.SubItems[3].Text = txtDiaChi.Text;
                itemTonTai.SubItems[4].Text = soTien.ToString();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cập nhật STT và tổng tiền
            CapNhatSTT();
            txtSoTK.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();

            // Đặt con trỏ vào ô Mã số tài khoản đầu tiên
            txtSoTK.Focus();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form
            }
        }

        private void txtSoTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
