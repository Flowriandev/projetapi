using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

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
            string baseUrl = "https://localhost:44384/api/Articles";
            var webRequest = (HttpWebRequest)WebRequest.Create(baseUrl);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {
                var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var j = JsonConvert.DeserializeObject<List<ArticleDto>>(s);
                var datalist = new BindingList<ArticleDto>(j);
                var data = new BindingSource(datalist, null);

                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            }
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

    }
}
