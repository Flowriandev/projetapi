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
    public partial class StockForm : Form
    {
        static HttpClient client = new HttpClient();

        public StockForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetProductAsync("articles");
        }

        static async Task<ArticleClass> GetProductAsync(string path)
        {
            ArticleClass product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<ArticleClass>();
            }
            return product;
        }

    }
}
