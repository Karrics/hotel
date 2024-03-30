using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        Point point;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void splitter1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void splitter1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientCard client = new ClientCard();
            client.Show();
        }

        private void splitter2_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void splitter2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;username=root;password=root;database=hotel_manager;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT name, sur_name, status FROM users;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object value1 = reader["name"];
                            object value2 = reader["sur_name"];
                            object value3 = reader["status"];

                            ClientsList.Text += value1.ToString() + ' ' + value2.ToString() + ' ' + '-' + ' ' + value3.ToString() + Environment.NewLine;
                        }

                        if (ClientsList.Text == "")
                        {
                            MessageBox.Show("Запрос не вернул результатов или нет строк в результатах.");
                        }
                    }
                }

                conn.Close();
            }
        }

        private void reserved_Click(object sender, EventArgs e)
        {
            ClientsList.Clear();
            string connStr = "server=localhost;port=3306;username=root;password=root;database=hotel_manager;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT name, sur_name, status FROM users WHERE status = 'зарезервировано';";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object value1 = reader["name"];
                            object value2 = reader["sur_name"];
                            object value3 = reader["status"];

                            ClientsList.Text += value1.ToString() + ' ' + value2.ToString() + ' ' + '-' + ' ' + value3.ToString() + Environment.NewLine;
                        }

                        if (ClientsList.Text == "")
                        {
                            MessageBox.Show("Запрос не вернул результатов или нет строк в результатах.");
                        }
                    }
                }

                conn.Close();
            }
        }

        private void free_Click(object sender, EventArgs e)
        {
            ClientsList.Clear();
            string connStr = "server=localhost;port=3306;username=root;password=root;database=hotel_manager;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT name, sur_name, status FROM users WHERE status = 'свободно';";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object value1 = reader["name"];
                            object value2 = reader["sur_name"];
                            object value3 = reader["status"];

                            ClientsList.Text += value1.ToString() + ' ' + value2.ToString() + ' ' + '-' + ' ' + value3.ToString() + Environment.NewLine;
                        }

                        if (ClientsList.Text == "")
                        {
                            MessageBox.Show("Запрос не вернул результатов или нет строк в результатах.");
                        }
                    }
                }

                conn.Close();
            }
        }

        private void employed_Click(object sender, EventArgs e)
        {
            ClientsList.Clear();
            string connStr = "server=localhost;port=3306;username=root;password=root;database=hotel_manager;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT name, sur_name, status FROM users WHERE status = 'занято';";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object value1 = reader["name"];
                            object value2 = reader["sur_name"];
                            object value3 = reader["status"];

                            ClientsList.Text += value1.ToString() + ' ' + value2.ToString() + ' ' + '-' + ' ' + value3.ToString() + Environment.NewLine;
                        }

                        if (ClientsList.Text == "")
                        {
                            MessageBox.Show("Запрос не вернул результатов или нет строк в результатах.");
                        }
                    }
                }

                conn.Close();
            }
        }

        private void check_out_Click(object sender, EventArgs e)
        {
            ClientsList.Clear();
            string connStr = "server=localhost;port=3306;username=root;password=root;database=hotel_manager;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT name, sur_name, status FROM users WHERE status = 'выписывается';";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object value1 = reader["name"];
                            object value2 = reader["sur_name"];
                            object value3 = reader["status"];

                            ClientsList.Text += value1.ToString() + ' ' + value2.ToString() + ' ' + '-' + ' ' + value3.ToString() + Environment.NewLine;
                        }

                        if (ClientsList.Text == "")
                        {
                            MessageBox.Show("Запрос не вернул результатов или нет строк в результатах.");
                        }
                    }
                }
                conn.Close();
            }
        }

        public System.Windows.Forms.RadioButton GetSelectedRadioButton()
        {
            return reserved; 
        }

        private void ClientsList_DoubleClick(object sender, EventArgs e)
        {
            textBox3.Text = "Номер №";
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            button1.Visible = true;
            string connStr = "server=localhost;port=3306;username=root;password=root;database=hotel_manager;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                if (reserved.Checked)
                { 
                    string query = "SELECT id, name, sur_name, date_in, date_out FROM users WHERE status = 'зарезервировано';";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                object value1 = reader["id"];
                                object value2 = reader["date_in"];
                                object value3 = reader["date_out"];
                                object value4 = reader["name"];
                                object value5 = reader["sur_name"];

                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox3.Text += value1.ToString();
                                textBox6.Text += value3.ToString();
                                textBox5.Text += value2.ToString();
                                textBox4.Text += value4.ToString() + ' ' + value5.ToString();

                            }

                            if (ClientsList.Text == "")
                            {
                                MessageBox.Show("Запрос не вернул результатов или нет строк в результатах.");
                            }
                        }
                    }
                }

                if (free.Checked)
                {
                    string query = "SELECT id, name, sur_name, date_in, date_out FROM users WHERE status = 'свободно';";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                object value1 = reader["id"];
                                object value2 = reader["date_in"];
                                object value3 = reader["date_out"];
                                object value4 = reader["name"];
                                object value5 = reader["sur_name"];

                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox3.Text += value1.ToString();
                                textBox6.Text += value3.ToString();
                                textBox5.Text += value2.ToString();
                                textBox4.Text += value4.ToString() + ' ' + value5.ToString();

                            }

                            if (ClientsList.Text == "")
                            {
                                MessageBox.Show("Запрос не вернул результатов или нет строк в результатах.");
                            }
                        }
                    }
                }

                if (employed.Checked)
                {
                    string query = "SELECT id, name, sur_name, date_in, date_out FROM users WHERE status = 'занято';";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                object value1 = reader["id"];
                                object value2 = reader["date_in"];
                                object value3 = reader["date_out"];
                                object value4 = reader["name"];
                                object value5 = reader["sur_name"];

                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox3.Text += value1.ToString();
                                textBox6.Text += value3.ToString();
                                textBox5.Text += value2.ToString();
                                textBox4.Text += value4.ToString() + ' ' + value5.ToString();

                            }

                            if (ClientsList.Text == "")
                            {
                                MessageBox.Show("Запрос не вернул результатов или нет строк в результатах.");
                            }
                        }
                    }
                }

                if (check_out.Checked)
                {
                    string query = "SELECT id, name, sur_name, date_in, date_out FROM users WHERE status = 'выписывается';";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                object value1 = reader["id"];
                                object value2 = reader["date_in"];
                                object value3 = reader["date_out"];
                                object value4 = reader["name"];
                                object value5 = reader["sur_name"];

                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox3.Text += value1.ToString();
                                textBox6.Text += value3.ToString();
                                textBox5.Text += value2.ToString();
                                textBox4.Text += value4.ToString() + ' ' + value5.ToString();

                            }

                            if (ClientsList.Text == "")
                            {
                                MessageBox.Show("Запрос не вернул результатов или нет строк в результатах.");
                            }
                        }
                    }
                }

                conn.Close();
            }
        }
    }
}
