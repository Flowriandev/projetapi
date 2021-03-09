using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegoApp
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            pnl_btn.Visible = true;
            pnl_stock_list.Visible = false;
            pnl_cmd.Visible = false;
        }

        private void btn_stock_list_Click(object sender, EventArgs e)
        {
            pnl_btn.Visible = false;
            pnl_stock_list.Visible = true;
        }

        private void btn_stock_add_Click(object sender, EventArgs e)
        {
            pnl_btn.Visible = false;
            pnl_cmd.Visible = true;
        }

    }
}
