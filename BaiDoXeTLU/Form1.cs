using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace BaiDoXeTLU
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        public Form1()
        {
            InitializeComponent();

            // Tìm kết nối camera
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo info in cameras)
            {
                cmbThietBi.Items.Add(info.Name);
            }
            cmbThietBi.SelectedIndex = 0;
        }

        // Đồng hồ
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        // Load xe
        private void LoadXeHienTai()
        {

            string sql = "Select idCode, timeIn from xetrongbai";

            using (MySqlConnection conn = new MySqlConnection(ConnectDB.connString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "Mã thẻ";
                    dataGridView1.Columns[1].HeaderText = "Thời gian vào";

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadXeHienTai();
        }


        // Button kết nối camera
        private void btnOnCamera_Click(object sender, EventArgs e)
        {
            if(cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[cmbThietBi.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pView.Image = bitmap;
            pView.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Button ngắt kết nối camera
        private void btnOffCamera_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }

        }

        // Bấm nút X ngắt kết nối camera
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }


        // Form quản lý thẻ
        private void quảnLýThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThe qlThe = new QuanLyThe();
            qlThe.ShowDialog();
        }

        // --- Chức năng chính


        // Xử lý xe vào

        private void btnXeVao_Click(object sender, EventArgs e)
        {

            if (cam != null && cam.IsRunning)
            {
                string input = Interaction.InputBox("Nhập mã thẻ", "Xe vào", "");
                if (input == "") return;
                if (Int32.TryParse(input, out int code))
                {
                    if (!QuanLyThe.IsCodeExist(code))
                    {
                        MessageBox.Show("Thẻ không có trong hệ thống");
                    }
                    else if (IsCodeAvailable(code))
                    {
                        MessageBox.Show("Thẻ đang được sử dụng");
                    }
                    else
                    {
                        pXeVao.Image = (Bitmap)pView.Image.Clone();
                        pXeVao.SizeMode = PictureBoxSizeMode.StretchImage;
                        string path = "C:\\Users\\HL94NVT\\source\\repos\\BaiDoXeTLU\\BaiDoXeTLU\\Resources\\Image\\XeVao\\";
                        var time = DateTime.Now.ToString("yyyy_MM_dd.HH_mm_ss");
                        string imageName = "XeVao_" + time + ".png";
                        path += imageName;

                        pXeVao.Image.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                        ThemXeVao(code, imageName);
                        LoadXeHienTai();
                    }

                }
                else
                {
                    MessageBox.Show("Mã thẻ không hợp lệ");
                }

            }
            else
            {
                MessageBox.Show("Camera chưa được bật");
            }

        }

        private void ThemXeVao(int code, string fileName)
        {
            ConnectDB.conn.Open();
            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            string query = "INSERT INTO `xetrongbai` (`idCode`,`timeIn`,`imageIn`) VALUES ('" + code + "', '" + date + "', '" + fileName + "');";
            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            ConnectDB.conn.Close();
        }


        // Xử lý xe ra
        private void btnXeRa_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                string input = Interaction.InputBox("Nhập mã thẻ", "Xe ra", "");
                if (input == "") return;
                if (Int32.TryParse(input, out int code))
                {
                    if (!QuanLyThe.IsCodeExist(code))
                    {
                        MessageBox.Show("Thẻ không có trong hệ thống");
                    }
                    else if (!IsCodeAvailable(code))
                    {
                        MessageBox.Show("Thẻ chưa được sử dụng");
                    }
                    else
                    {
                        string pathXeVao = "C:\\Users\\HL94NVT\\source\\repos\\BaiDoXeTLU\\BaiDoXeTLU\\Resources\\Image\\XeVao\\";
                        string pathXeRa = "C:\\Users\\HL94NVT\\source\\repos\\BaiDoXeTLU\\BaiDoXeTLU\\Resources\\Image\\XeRa\\";
                        string imageNameIn = GetFileNameImage(code);
                        pathXeVao += imageNameIn;

                        pXeVao.Image = new Bitmap(pathXeVao);
                        pXeRa.Image = (Bitmap)pView.Image.Clone();
                        pXeVao.SizeMode = PictureBoxSizeMode.StretchImage;
                        pXeRa.SizeMode = PictureBoxSizeMode.StretchImage;

                        DateTime timeCurrent = DateTime.Now;
                        var timeXeRa = timeCurrent.ToString("yyyy-MM-dd H:mm:ss");

                        var timeXeRaConvert = timeCurrent.ToString("yyyy_MM_dd.HH_mm_ss");
                        string getTimeXeVao = GetTimeIn(code);
                        DateTime dateValue = DateTime.Parse(getTimeXeVao);
                        string timeXeVao = dateValue.ToString("yyyy-MM-dd H:mm:ss");
                        string imageNameOut = "XeRa_" + timeXeRaConvert + ".png";
                        pathXeRa += imageNameOut;

                        pXeRa.Image.Save(pathXeRa, System.Drawing.Imaging.ImageFormat.Png);
                        SaveLog(code, timeXeVao, timeXeRa, imageNameIn, imageNameOut);
                        TraTien(code, timeXeVao);
                        LoadXeHienTai();
                    }

                }
                else
                {
                    MessageBox.Show("Mã thẻ không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("Camera chưa được bật");
            }
        }
        private void TraTien(int code, string timeIn)
        {
            ConnectDB.conn.Open();
            lbPrice.Text = TinhTien(timeIn);
            string query = $"Delete from xetrongbai Where idCode='{code}' ";
            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            ConnectDB.conn.Close();
        }
        private string TinhTien(string timeIn)
        {
            DateTime dateOut = DateTime.Now;
            DateTime dateIn = DateTime.Parse(timeIn);
            string ngayHomNay = dateOut.ToString("yyyy-MM-dd");
            ngayHomNay += " 18:00:00";
            DateTime mocThoiGian = DateTime.Parse(ngayHomNay);

            string ngayRa = dateOut.ToString("yyyy-MM-dd");
            string ngayVao = dateIn.ToString("yyyy-MM-dd");

            TimeSpan ts = dateOut - dateIn;
            int differenceInDays = ts.Days;

            if (differenceInDays > 0)
            {
                int tienTheoNgay = 10000;
                return tienTheoNgay * differenceInDays + " VND";
            }
            else if (dateOut > mocThoiGian)
            {
                return "5.000 VND";
            }
            else
            {
                return "3.000 VND";
            }
        }

        private void SaveLog(int code, string timeIn, string timeOut, string imageIn, string imageOut)
        {
            ConnectDB.conn.Open();
            string query = "INSERT INTO `logs` (`idCode`,`timeIn`,`timeOut`,`imageIn`,`imageOut`) VALUES ('" + code +
                "', '" + timeIn + "', '" + timeOut + "', '"
                + imageIn + "', '" + imageOut + "');";

            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            ConnectDB.conn.Close();
        }

        // Clear hình ảnh, giá tiền
        private void btnClear_Click(object sender, EventArgs e)
        {
            pXeVao.Image = null;
            pXeRa.Image = null;
            lbPrice.Text = "          VND";
        }

        //
        private bool IsCodeAvailable(int code)
        {
            ConnectDB.conn.Open();
            bool flag;
            string query = $"SELECT * FROM xetrongbai WHERE idCode='{code}'";
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

        private string GetFileNameImage(int code)
        {
            ConnectDB.conn.Open();
            string query = $"select * from xetrongbai where idCode ='{code}'";
            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            string name ="";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(2);
                }
            }
            ConnectDB.conn.Close();
            return name;



        }

        private string GetTimeIn(int code)
        {
            ConnectDB.conn.Open();
            string query = $"select * from xetrongbai where idCode ='{code}'";
            MySqlCommand cmd = new MySqlCommand(query, ConnectDB.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            string name = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(1);
                }
            }
            ConnectDB.conn.Close();
            return name;



        }


    }
}
