using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegoApp
{
    public partial class Stock : Form
    {
        static HttpClient client = new HttpClient();

        public Stock()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://localhost:44384/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            pnl_cmd.Visible = false;
            pnl_btn.Visible = true;
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            pnl_stock_list.Visible = false;
            pnl_btn.Visible = true;
        }

        private async Task button1_ClickAsync(object sender, EventArgs e)
        {
        }
    }
}
