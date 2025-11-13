using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT07
{
    public partial class Form1 : Form
    {
        enum SeatStatus { Available, Selected, Sold }

        SeatStatus[] seatStatus = new SeatStatus[15];
        int[] prices = new int[15];
        Button[] seats = new Button[15];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gán ghế vào mảng
            seats[0] = btn1; seats[1] = btn2; seats[2] = btn3; seats[3] = btn4; seats[4] = btn5;
            seats[5] = btn6; seats[6] = btn7; seats[7] = btn8; seats[8] = btn9; seats[9] = btn10;
            seats[10] = btn11; seats[11] = btn12; seats[12] = btn13; seats[13] = btn14; seats[14] = btn15;

            for (int i = 0; i < 15; i++)
            {
                seatStatus[i] = SeatStatus.Available;
                seats[i].BackColor = Color.White;
                seats[i].UseVisualStyleBackColor = false; // quan trọng để BackColor hiển thị
                seats[i].Click += Seat_Click;

                // Giá vé theo hàng
                if (i < 5) prices[i] = 5000;       // Lô A
                else if (i < 10) prices[i] = 6500; // Lô B
                else prices[i] = 8000;             // Lô C

                seats[i].BackColor = Color.White;
                seats[i].UseVisualStyleBackColor = false; // cực kỳ quan trọng
                seats[i].Click += Seat_Click;

            }

        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = int.Parse(btn.Tag.ToString());

            if (seatStatus[index] == SeatStatus.Available)
            {
                if (btn.BackColor == Color.White)
                    btn.BackColor = Color.DarkBlue; // đang chọn
                else if (btn.BackColor == Color.DarkBlue)
                    btn.BackColor = Color.White;      // bỏ chọn
            }
            else if (seatStatus[index] == SeatStatus.Sold)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!", "Thông báo");
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < 15; i++)
            {
                if (seatStatus[i] == SeatStatus.Available && seats[i].BackColor == Color.LightGreen)
                {
                    seats[i].BackColor = Color.Yellow; // đã bán
                    seatStatus[i] = SeatStatus.Sold;
                    total += prices[i];
                }
            }
            lblTongTien.Text = total + " VND";
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (seatStatus[i] == SeatStatus.Available && seats[i].BackColor == Color.LightGreen)
                {
                    seats[i].BackColor = Color.White; // trả về chưa bán
                }
            }
            lblTongTien.Text = "0";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close(); // hoặc Application.Exit();
        }
    }
}
