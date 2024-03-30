using System;
using System.Drawing;
using System.Windows.Forms;
using static hotel.Form1;

namespace hotel
{
    public partial class ClientCard : Form
    {
        public ClientCard()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.BackColor = Color.DarkRed;
        }

        Point point;
        private void ClientCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void ClientCard_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClientCard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
