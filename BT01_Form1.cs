namespace BT01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Constructor: Form1 được tạo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Form1_Load: Form đang load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            listBox1.Items.Add("Form1_Shown: Form vừa hiển thị");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Add("Form1_Activated: Form được active");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            listBox1.Items.Add("Form1_Deactivate: Form mất active");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBox1.Items.Add("Form1_FormClosing: Form đang đóng");

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; 
                listBox1.Items.Add("=> Đóng bị hủy bởi người dùng");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Add("Form1_FormClosed: Form đã đóng");
        }

    }
}
