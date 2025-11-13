

namespace BT05
    {
    public partial class LAB02_EXAMPLE : Form
    {
        public LAB02_EXAMPLE()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumber1.Text);
            double b = double.Parse(txtNumber2.Text);
            txtAnswer.Text = (a + b).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumber1.Text);
            double b = double.Parse(txtNumber2.Text);
            txtAnswer.Text = (a - b).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumber1.Text);
            double b = double.Parse(txtNumber2.Text);
            txtAnswer.Text = (a * b).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumber1.Text);
            double b = double.Parse(txtNumber2.Text);
            if (b == 0)
                MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                txtAnswer.Text = (a / b).ToString();
        }

  
    }
}

