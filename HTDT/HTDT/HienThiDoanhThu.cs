using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HTDT
{
    public partial class HienThiDoanhThu : Form
    {
        string sCon = "Data Source=ZAP\\ZAPPDEV;Initial Catalog=QLBH;Integrated Security=True";
        public HienThiDoanhThu()
        {
            InitializeComponent();
        }

        private void HienThiDoanhThu_Load(object sender, EventArgs e)
        {
            

        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            }
            SqlCommand cmd = new SqlCommand("hienthidoanhthutheongay", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            }
            SqlCommand cmd = new SqlCommand("dttheothang", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            }
            SqlCommand cmd = new SqlCommand("dttheonam", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }
    }
}
