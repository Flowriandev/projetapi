﻿using System;
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

namespace NegoApp
{
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public async void GetData()
        {
            string baseUrl = "https://localhost:44384/api/Articles";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            String json = await content.ReadAsStringAsync();
                            JArray j = JArray.Parse(json);
                            List<Articles> elements = new List<Articles>();
                            foreach (var elem in j)
                            {
                                elements.Add(new Articles()
                                {
                                    ID = (long)elem["id"],
                                    Nom = (string)elem["nom"],
                                    Description = (string)elem["description"],
                                    Annee = (string)elem["annee"],
                                    Prix = (double)elem["prix"],
                                });
                            }
                            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(j.ToString(), (typeof(DataTable)));
                            Nom.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(exception);
            }
        }

        private void NvArticle_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
