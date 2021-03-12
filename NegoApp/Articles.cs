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
using Newtonsoft.Json.Converters;

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



        public string JsonAjoutArticle()
        {
            var jsonData = new ArticleDto()
            {
                id = 0,
                annee = anneeTextBox.Text,
                description = descriptionTextBox.Text,
                prix = Convert.ToInt32(PrixTextBox.Text),
                famille = FamilleTextBox.Text,
                nom = nomTextBox.Text,
            };
      
            return JsonConvert.SerializeObject(jsonData, Formatting.Indented);
        }
        private void Articles_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNvArt_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44384/api/Articles";
            string requestParams = JsonAjoutArticle();

            webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
        }
    }
}
