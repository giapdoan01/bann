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

namespace HTDT
{
    public partial class frmBan : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QLBH;Integrated Security=True;Trust Server Certificate=True";
        public frmBan()
        {
            InitializeComponent();
        }


        private void frmBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối DB", "Thông báo");
            }

            string sSTT = txtSTT.Text;
            string checkQuery = "SELECT COUNT(*) FROM ThongTinDatBan WHERE B_STT = @stt";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@stt", sSTT);
            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Số thứ tự bàn đã tồn tại. Vui lòng nhập số khác.");
                con.Close();
                return;
            }
            string sQuery = "insert into BAN values(@stt)";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@stt", sSTT);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mới");
            }
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection(sCon);
            try

            {
                con.Open();
                string sQuery = "select * from BAN";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, sCon);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "ThongTin");
                dataGridView1.DataSource = ds.Tables["ThongTin"];
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi kết nối DB");
            }
            con.Close();
        }
    }
}
