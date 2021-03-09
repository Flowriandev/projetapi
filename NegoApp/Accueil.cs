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
    public partial class Accueil : Form
    {

        Stock stockForm = new Stock();
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
    }
}
