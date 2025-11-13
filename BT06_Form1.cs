namespace BT06
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator clone by Nguyen Tran Phuong Vy\nMimic Windows Calculator", "About");
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Text = "";

            if (button.Text == "." && txtDisplay.Text.Contains("."))
                return;

            txtDisplay.Text += button.Text;
            isOperationPerformed = false;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double second = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+": txtDisplay.Text = (result + second).ToString(); break;
                case "-": txtDisplay.Text = (result - second).ToString(); break;
                case "x": txtDisplay.Text = (result * second).ToString(); break;
                case "/": txtDisplay.Text = (second != 0) ? (result / second).ToString() : "Error"; break;
            }
            isOperationPerformed = false;
        }
        private void btnCE_Click(object sender, EventArgs e) { txtDisplay.Text = "0"; }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0"; result = 0; operation = ""; isOperationPerformed = false;
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1) txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else txtDisplay.Text = "0";
        }
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (double.Parse(txtDisplay.Text) * -1).ToString();
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (double.Parse(txtDisplay.Text) / 100).ToString();
        }
        private void btnMC_Click(object sender, EventArgs e) { memory = 0; }
        private void btnMR_Click(object sender, EventArgs e) { txtDisplay.Text = memory.ToString(); }
        private void btnMS_Click(object sender, EventArgs e) { memory = double.Parse(txtDisplay.Text); }
        private void btnMPlus_Click(object sender, EventArgs e) { memory += double.Parse(txtDisplay.Text); }


        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            if (value >= 0)
            {
                txtDisplay.Text = Math.Sqrt(value).ToString();
                isOperationPerformed = true;
            }
            else
            {
                txtDisplay.Text = "Error";
            }
        }
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            if (value != 0)
            {
                txtDisplay.Text = (1 / value).ToString();
                isOperationPerformed = true;
            }
            else
            {
                txtDisplay.Text = "Error";
            }
        }

    }
}
