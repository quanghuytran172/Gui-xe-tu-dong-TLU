using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiDoXeTLU
{
    class Auth
    {



        public Auth()
        {
            try
            {

                ConnectDB.conn = new MySqlConnection(ConnectDB.connString);
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
        }
        public bool IsLogin(string username, string password)
        {
            ConnectDB.conn.Open();
            bool flag;
            string query = $"SELECT * FROM users WHERE username='{username}' AND password='{HashPassword(password)}'";
            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            ConnectDB.conn.Close();
            return flag;
        }

        public bool IsValidUsername(string username)
        {
            ConnectDB.conn.Open();
            bool flag;
            string query = $"SELECT * FROM users WHERE username='{username}'";
            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            ConnectDB.conn.Close();
            return flag;
        }
        public void Register(string username, string password)
        {
            ConnectDB.conn.Open();
            string hashPassword = HashPassword(password);
            string query = "INSERT INTO `users` (`username`,`password`) VALUES ('" + username + "', '" + hashPassword + "');";
            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            ConnectDB.conn.Close();
        }

        static string HashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypt_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(password_bytes);
        }
    }
}
