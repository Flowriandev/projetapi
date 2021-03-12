using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegoApp
{
    public partial class Accueil : Form
    {

        Stock stockForm = new Stock();
        Articles articlesForm = new Articles();
        Clients clientsForm = new Clients();
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            stockForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            articlesForm.Show();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            clientsForm.Show();
        }
    }
}
