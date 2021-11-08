using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiDoXeTLU
{
    public partial class QuanLyThe : Form
    {
        public QuanLyThe()
        {
            InitializeComponent();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemThe_Click(object sender, EventArgs e)
        {

            if (Int32.TryParse(txtReader.Text, out int code))
            {
                if (!IsCodeExist(code))
                {
                    AddCode(code);
                    txtReader.Text = "";
                    LoadDuLieuThe();
                }
                else
                {
                    MessageBox.Show("Mã thẻ không hợp lệ");
                }

            }
            else
            {
                MessageBox.Show("Mã thẻ không hợp lệ");
            }
            
           
        }
        private void AddCode(int code)
        {
            ConnectDB.conn.Open();
            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            string query = "INSERT INTO `thexe` (`idCode`,`timeCreate`) VALUES ('" + code + "', '" + date + "');";
            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            ConnectDB.conn.Close();
        }
        public static bool IsCodeExist(int code)
        {
            ConnectDB.conn.Open();
            bool flag;
            string query = $"SELECT * FROM thexe WHERE idCode='{code}'";
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
        private void LoadDuLieuThe()
        {
            string sql = "Select * from thexe order by timeCreate desc";

            using (MySqlConnection conn = new MySqlConnection(ConnectDB.connString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "Mã thẻ";
                    dataGridView1.Columns[1].HeaderText = "Thời gian nhập";

                }
            }


        }
        private void btnXoaThe_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            ConnectDB.conn.Open();
            string query = "Delete from thexe Where idCode='"+ dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            LoadDuLieuThe();
            ConnectDB.conn.Close();


        }

        private void QuanLyThe_Load(object sender, EventArgs e)
        {
            LoadDuLieuThe();
        }
    }
}
