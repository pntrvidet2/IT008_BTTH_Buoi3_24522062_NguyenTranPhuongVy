using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;




namespace BT02
{
    public partial class FormBT02 : Form
    {
        private Random rand = new Random();
        public FormBT02()
        {
            this.Text = "BT02 - Minh họa sự kiện Paint";
            this.BackColor = Color.White;
            this.Width = 600;
            this.Height = 400;

            this.Paint += new PaintEventHandler(FormBT02_Paint);

            this.Resize += (s, e) => this.Invalidate();
            this.Click += (s, e) => this.Invalidate(); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormBT02_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int x = rand.Next(0, this.ClientSize.Width - 200);
            int y = rand.Next(0, this.ClientSize.Height - 50);

            using (Font font = new Font("Impact", 28, FontStyle.Bold))
            {
                // Lớp ngoài (viền sáng)
                g.DrawString("Paint Event", font, Brushes.HotPink, x + 2, y + 2);
                // Lớp chính
                g.DrawString("Paint Event", font, Brushes.DeepPink, x, y);
              
            }

        }
    }
}