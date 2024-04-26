using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Movie_ticket_sales_management_app
{
    public partial class frmPhanloaive : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-JH4SMB4R\\SQLEXPRESS;Initial Catalog=QL_Banvexemphim;Integrated Security=True;";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PhanLoaiVe ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        public frmPhanloaive()
        {
            InitializeComponent();
        }

        private void frmPhanloaive_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgv.CurrentRow.Index;
            cbbMave.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbbLoaive.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbbTenphim.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cbbSuatchieu.Text = dgv.Rows[i].Cells[3].Value.ToString();
            cbbPhong.Text = dgv.Rows[i].Cells[4].Value.ToString();
            cbbVitrighe.Text = dgv.Rows[i].Cells[5].Value.ToString();
            cbbGiatien.Text = dgv.Rows[i].Cells[6].Value.ToString();


        }

        private void btThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into PhanLoaiVe values('" + cbbMave.Text + "','" + cbbLoaive.Text + "', N'" + cbbTenphim.Text + "', N'" + cbbSuatchieu.Text + "','" + cbbPhong.Text + "','" + cbbVitrighe.Text + "', N'" + cbbGiatien.Text + "')";
            command.ExecuteNonQuery();
            loaddata();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from PhanLoaiVe where Mave= '" + cbbMave.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update PhanLoaiVe set  LoaiVe = '" + cbbLoaive.Text + "', TenPhim = N'" + cbbTenphim.Text + "', SuatChieu = '" + cbbSuatchieu.Text + "', Phong = '" + cbbPhong.Text + "', ViTriGhe = '" + cbbVitrighe.Text + "', GiaTien ='" + cbbGiatien.Text + "' where MaVe = " + cbbMave + " ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btKhoitao_Click(object sender, EventArgs e)
        {
            cbbMave.ResetText();
            cbbLoaive.ResetText();
            cbbTenphim.ResetText(); 
            cbbSuatchieu.ResetText();   
            cbbPhong.ResetText();   
            cbbVitrighe.ResetText();    
            cbbGiatien.ResetText();
            cbbMave.Focus();
        }
    }
}
