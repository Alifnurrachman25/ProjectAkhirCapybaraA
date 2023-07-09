using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhirCapybaraA
{
    public partial class OptionPageForm : Form
    {
        public OptionPageForm()
        {
            InitializeComponent();
        }

        private void btnDataMaster_Click(object sender, EventArgs e)
        {
            HomePageForm homePage = new HomePageForm();
            homePage.Show();
            this.Hide();
        }

        private void btnDataRelasi_Click(object sender, EventArgs e)
        {
            DataRelasiForm dataRelasi = new DataRelasiForm();
            dataRelasi.Show();
            this.Hide();
        }
    }
}
