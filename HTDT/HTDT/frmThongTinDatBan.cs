using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTDT
{
    public partial class frmThongTinDatBan : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QLBH;Integrated Security=True;Trust Server Certificate=True";
        public frmThongTinDatBan()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối DB");
            }

            string sMaDatBan = txtMaDatBan.Text;
            if (string.IsNullOrEmpty(sMaDatBan))
            {
                MessageBox.Show("Mã đặt bàn không được để trống");
            }
            // Kiểm tra sự tồn tại của mã đặt bàn
            string checkQuery = "SELECT COUNT(*) FROM ThongTinDatBan WHERE TTDB_ID = @id";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@id", sMaDatBan);

            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Mã đặt bàn đã tồn tại. Vui lòng nhập mã khác.");
                con.Close();
                return;
            }
            string sMaBan = txtMaBan.Text;
            string sMaKH = txtMaKH.Text;
            string sThoiGian = txtTime.Value.ToString("HH:mm:ss");
            string sNgay = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string sSoluong = txtSoLuong.Text;

            if (string.IsNullOrEmpty(sMaBan) || string.IsNullOrEmpty(sMaKH) ||
                        string.IsNullOrEmpty(sSoluong))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sQuery = "insert into ThongTinDatBan values(@id, @stt, @makh,@time,@ngay,@soluong)";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@id", sMaDatBan);
            cmd.Parameters.AddWithValue("@stt", sMaBan);
            cmd.Parameters.AddWithValue("@makh", sMaKH);
            cmd.Parameters.AddWithValue("@time", sThoiGian);
            cmd.Parameters.AddWithValue("@ngay", sNgay);
            cmd.Parameters.AddWithValue("@soluong", sSoluong);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mới khách hàng");
            }
            con.Close();
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
                string sQuery = "SELECT * FROM ThongTinDatBan ";
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex < 0)
                {
                    return;
                }


                txtMaDatBan.Text = dataGridView1.Rows[e.RowIndex].Cells["TTDB_ID"].Value?.ToString() ?? "";
                txtMaBan.Text = dataGridView1.Rows[e.RowIndex].Cells["B_STT"].Value?.ToString() ?? "";
                txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["KH_ID"].Value?.ToString() ?? "";
                txtTime.Text = dataGridView1.Rows[e.RowIndex].Cells["TTDB_GIO"].Value?.ToString() ?? "";
                txtSoLuong.Text = dataGridView1.Rows[e.RowIndex].Cells["TTDB_SL"].Value?.ToString() ?? "";


                if (dataGridView1.Rows[e.RowIndex].Cells["TTDB_NGAY"].Value != null)
                {
                    dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["TTDB_NGAY"].Value);
                }
                else
                {
                    dateTimePicker2.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
