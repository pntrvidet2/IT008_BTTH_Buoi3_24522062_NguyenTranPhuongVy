namespace BT03
{
    public partial class FormBT03 : Form
    {
        private Button btnChangeColor;
        private Random rand = new Random();
        public FormBT03()
        {
            this.Text = "BT03 - Minh họa sự kiện Click";
            this.Width = 400;
            this.Height = 300;
            this.StartPosition = FormStartPosition.CenterScreen;

            
            btnChangeColor = new Button();
            btnChangeColor.Text = "Change Color";
            btnChangeColor.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnChangeColor.Size = new Size(150, 50);
            btnChangeColor.Location = new Point((this.ClientSize.Width - 150) / 2,
                                                (this.ClientSize.Height - 50) / 2);

           
            btnChangeColor.Click += BtnChangeColor_Click;
           
            this.Controls.Add(btnChangeColor);
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            this.BackColor = randomColor;
        }
    }
}
