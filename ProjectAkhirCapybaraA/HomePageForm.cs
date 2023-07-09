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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            BarangPageForm barangPage = new BarangPageForm();
            barangPage.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffPageForm staffPage = new StaffPageForm();
            staffPage.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryPageForm inventoryPage = new InventoryPageForm();
            inventoryPage.Show();
            this.Hide();
        }

        private void btnKurir_Click(object sender, EventArgs e)
        {
            KurirPageForm kurirPage = new KurirPageForm();
            kurirPage.Show();
            this.Hide();
        }

        private void btnPemilik_Click(object sender, EventArgs e)
        {
            PemilikPageForm PemilikPage = new PemilikPageForm();
            PemilikPage.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OptionPageForm optionPage = new OptionPageForm();
            this.Close();
            optionPage.Show();
        }
    }
}
