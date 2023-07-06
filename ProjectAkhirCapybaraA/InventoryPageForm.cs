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
    public partial class InventoryPageForm : Form
    {
        public InventoryPageForm()
        {
            InitializeComponent();
        }

        private void InventoryPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.gudang' table. You can move, or remove it, as needed.
            this.gudangTableAdapter.Fill(this.gudanginventoryDataSet.gudang);

        }
    }
}
