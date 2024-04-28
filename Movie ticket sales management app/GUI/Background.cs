﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie_ticket_sales_management_app.DAL;
using Movie_ticket_sales_management_app.DTO;
using Movie_ticket_sales_management_app.BUS;

namespace Movie_ticket_sales_management_app
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }

        private void Background_Load(object sender, EventArgs e)
        {
            this.Show();
            frmDangnhap dn = new frmDangnhap();
            dn.ShowDialog();
        }
    }
}
