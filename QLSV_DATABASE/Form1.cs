using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_DATABASE
{

    public partial class Form1 : Form
    {
        public static string conectionstring = @"Data Source=NHDHIEUU;Initial Catalog=QLSVIT008;User ID=sa;Password=123456";
        SqlConnection connection = new SqlConnection(conectionstring);
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#776B5D");
            groupBox2.BackColor = groupBox1.BackColor = ColorTranslator.FromHtml("#B0A695");
            ttsv.BackgroundColor = ColorTranslator.FromHtml("#EBE3D5");
        }
        private void ThemButt_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                float dtb = (int.Parse(anhBox.Text) + int.Parse(vanBox.Text) + int.Parse(toanBox.Text)) / 3;
                command.CommandText = "insert into DSSV values (" + (int.Parse)(mssvBox.Text) + ",'" + hotenBox.Text + "','" + malopBox.Text + "'," + (float.Parse)(toanBox.Text) + "," + (float.Parse)(anhBox.Text) + "," + (float.Parse)(vanBox.Text) + "," + dtb + ")";
                command.ExecuteNonQuery();
                ttsv.DataSource = GetAllNV().Tables[0];
                MessageBox.Show("Thêm sinh viên thành công!!!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thông tin sinh viên không hợp lệ!", "Thông báo");
            }
        }

        private void SuaButt_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "update DSSV set HOTEN='" + hotenBox.Text + "' , MALOP ='" + malopBox.Text + "' , TOAN=" + (float.Parse)(toanBox.Text) + " , ANH= " + (float.Parse)(anhBox.Text) + " , VAN= " + (float.Parse)(vanBox.Text) + " WHERE MSSV=" + (int.Parse)(mssvBox.Text);
                command.ExecuteNonQuery();
                ttsv.DataSource = GetAllNV().Tables[0];
                MessageBox.Show("Sửa thông tin sinh viên thành công!!!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thông tin sinh viên không hợp lệ!", "Thông báo");
            }
        }
        private void XoaButt_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM DSSV WHERE MSSV='" + (int.Parse)(mssvBox.Text) + "'";
                command.ExecuteNonQuery();
                ttsv.DataSource = GetAllNV().Tables[0];
                MessageBox.Show("Xóa sinh viên thành công!!!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thông tin sinh viên không hợp lệ!", "Thông báo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connection.Open();
        }
        private void Form1_Leave(object sender, EventArgs e)
        {
            connection.Close();
        }
        DataSet GetAllNV()
        {
            DataSet result = new DataSet();
            command = connection.CreateCommand();
            command.CommandText = "select* from DSSV";
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        private void DSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = ttsv.CurrentRow.Index;
            mssvBox.Text = ttsv.Rows[i].Cells[0].Value.ToString();
            hotenBox.Text = ttsv.Rows[i].Cells[1].Value.ToString();
            malopBox.Text = ttsv.Rows[i].Cells[2].Value.ToString();
            toanBox.Text = ttsv.Rows[i].Cells[3].Value.ToString();
            anhBox.Text = ttsv.Rows[i].Cells[4].Value.ToString();
            vanBox.Text = ttsv.Rows[i].Cells[5].Value.ToString();
            
        }
        private void timButton_Click(object sender, EventArgs e)
        {
            int mssv;
   
            if (int.TryParse(textBox1.Text, out mssv))
            {
                string query = "SELECT * FROM DSSV WHERE MSSV = " + mssv;

                DataSet data = new DataSet(); // Tạo mới đối tượng DataSet

                // Thực thi truy vấn
                command = connection.CreateCommand();
                command.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);

                // Kiểm tra có tìm thấy sinh viên không
                if (data.Tables[0].Rows.Count > 0)
                {
                    ttsv.DataSource = data.Tables[0]; // Gán nguồn dữ liệu cho DataGridView
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã số " + mssv);
                    ttsv.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ttsv.DataSource = GetAllNV().Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MessageBox.Show("Đã kết nối với Databse thành công!!!", "Thông báo");

            }
            catch
            {
                MessageBox.Show("Kết nối với Database thất bại!!!", "Thông báo");
            }
        }
    }

}
