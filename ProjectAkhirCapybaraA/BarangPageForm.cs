using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectAkhirCapybaraA
{
    public partial class BarangPageForm : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=LAPTOP-A8KDLC9E;Initial Catalog=gudanginventory;User ID=sa;Password=123";

        public void ConnectToDatabase()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void AddBarang(int id, string nama, int banyak, string tipe, string deskripsi)
        {
            string query = "INSERT INTO barang (Id_barang, Nama_barang, banyak_barang, Tipe_barang, Deskripsi_brg) VALUES (@IdBarang, @NamaBarang, @BanyakBarang, @TipeBarang, @Deskripsi)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdBarang", id);
            command.Parameters.AddWithValue("@NamaBarang", nama);
            command.Parameters.AddWithValue("@BanyakBarang", banyak);
            command.Parameters.AddWithValue("@TipeBarang", tipe);
            command.Parameters.AddWithValue("@Deskripsi", deskripsi);

            command.ExecuteNonQuery();

            RefreshDataGridView();
            bindingNavigator.BindingSource = barangBindingSource;
        }


        public void UpdateBarang(int id, string nama, int banyak, string tipe, string deskripsi)
        {
            string query = "UPDATE barang SET Nama_barang = @NamaBarang, banyak_barang = @BanyakBarang, Tipe_barang = @TipeBarang, Deskripsi_brg = @Deskripsi WHERE Id_barang = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NamaBarang", nama);
            command.Parameters.AddWithValue("@BanyakBarang", banyak);
            command.Parameters.AddWithValue("@TipeBarang", tipe);
            command.Parameters.AddWithValue("@Deskripsi", deskripsi);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public void DeleteBarang(int id)
        {
            string query = "DELETE FROM barang WHERE Id_barang = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            int banyak = Convert.ToInt32(banyakTextBox.Text);
            string tipe = tipeTextBox.Text;
            string deskripsi = deskripsiTextBox.Text;

            ConnectToDatabase();
            UpdateBarang(id, nama, banyak, tipe, deskripsi);
            CloseConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);

            ConnectToDatabase();
            DeleteBarang(id);
            CloseConnection();

            RefreshDataGridView();
        }


        public DataTable GetBarang()
        {
            string query = "SELECT * FROM barang";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            int banyak = Convert.ToInt32(banyakTextBox.Text);
            string tipe = tipeTextBox.Text;
            string deskripsi = deskripsiTextBox.Text;

            ConnectToDatabase();
            AddBarang(id, nama, banyak, tipe, deskripsi);
            CloseConnection();

            RefreshDataGridView();
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            bindingNavigator.BindingSource = barangBindingSource; // Set the binding source to refresh the binding navigator
        }

        private void RefreshDataGridView()
        {
            ConnectToDatabase();
            DataTable dataTable = GetBarang();
            CloseConnection();

            dataGridView.DataSource = dataTable;
        }

        public BarangPageForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageForm Bhome = new HomePageForm();
            this.Close();
            Bhome.Show();
        }

        private void BarangPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.gudanginventoryDataSet.barang);

            ConnectToDatabase();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            namaTextBox.Clear();
            banyakTextBox.Clear();
            tipeTextBox.Clear();
            deskripsiTextBox.Clear();
        }
    }
}
