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
    public partial class PemilikPageForm : Form
    {
        public PemilikPageForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageForm Bhome = new HomePageForm();
            this.Close();
            Bhome.Show();
        }

        private void PemilikPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.memiliki' table. You can move, or remove it, as needed.
            this.memilikiTableAdapter.Fill(this.gudanginventoryDataSet.memiliki);
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.pemilik' table. You can move, or remove it, as needed.
            this.pemilikTableAdapter.Fill(this.gudanginventoryDataSet.pemilik);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
