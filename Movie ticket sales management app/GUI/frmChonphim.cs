using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_ticket_sales_management_app.GUI
{
    public partial class frmChonphim : Form
    {
        public frmChonphim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQLBanVevaChiTiet Banve = new frmQLBanVevaChiTiet();
            Banve.ShowDialog(this);
        }

        private void btnMua2_Click(object sender, EventArgs e)
        {
            frmBanVe2 banve2 = new frmBanVe2();
            banve2.ShowDialog(this);

        }

        private void btnMua3_Click(object sender, EventArgs e)
        {
            frmBanVe3 banve3 = new frmBanVe3();
            banve3.ShowDialog(this);
        }

        private void btnMua4_Click(object sender, EventArgs e)
        {
            frmBanVe4 banve4 = new frmBanVe4();
            banve4.ShowDialog(this);
        }
    }
}
