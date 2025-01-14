﻿using MySql.Data.MySqlClient;

namespace hotel
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=hotel_manager");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
