using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace NegoApp
{
    public partial class Articles : Form
    {

        private HttpWebRequest webRequest;
        public Articles()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void GetData()
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
          
        }
        

        private void NvArticle_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
