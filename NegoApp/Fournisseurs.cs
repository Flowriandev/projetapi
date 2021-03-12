using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace NegoApp
{
    public partial class Fournisseurs : Form
    {
        public Fournisseurs()
        {
            InitializeComponent();
        }
        private void dataGridView1_Load(object sender, EventArgs e)
        {
            string baseUrl = "https://localhost:44384/api/Fournisseurs";
            var webRequest = (HttpWebRequest)WebRequest.Create(baseUrl);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {
                var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var j = JsonConvert.DeserializeObject<List<FournisseurDto>>(s);
                var datalist = new BindingList<FournisseurDto>(j);
                var data = new BindingSource(datalist, null);

                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            }
        }
    }
}
