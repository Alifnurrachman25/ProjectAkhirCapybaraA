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
    public partial class DataRelasiForm : Form
    {
        public DataRelasiForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OptionPageForm optionPage = new OptionPageForm();
            this.Close();
            optionPage.Show();
        }

        private void btnKepemilikan_Click(object sender, EventArgs e)
        {
            MemilikiPageForm memilikiPage = new MemilikiPageForm();
            memilikiPage.Show();
            this.Hide();
        }

        private void btnDikirim_Click(object sender, EventArgs e)
        {
            DikirimPageForm dikirimPage = new DikirimPageForm();
            dikirimPage.Show();
            this.Hide();
        }

        private void btnKedatangan_Click(object sender, EventArgs e)
        {
            KedatanganPageForm kedatanganPage = new KedatanganPageForm();
            kedatanganPage.Show();
            this.Hide();
        }

        private void btnPengelolaan_Click(object sender, EventArgs e)
        {
            DikelolaPageForm dikelolaPage = new DikelolaPageForm();
            dikelolaPage.Show();
            this.Hide();
        }
    }
}
