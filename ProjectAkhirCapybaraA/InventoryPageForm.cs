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

namespace ProjectAkhirCapybaraA
{
    public partial class InventoryPageForm : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=LAPTOP-A8KDLC9E;Initial Catalog=gudanginventory;User ID=sa;Password=123";
        public InventoryPageForm()
        {
            InitializeComponent();
        }

        public void ConnectToDatabase()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        private void InventoryPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.gudang' table. You can move, or remove it, as needed.
            this.gudangTableAdapter.Fill(this.gudanginventoryDataSet.gudang);

            ConnectToDatabase();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            bindingNavigator.BindingSource = gudangBindingSource; // Set the binding source to refresh the binding navigator
        }

        private void RefreshDataGridView()
        {
            ConnectToDatabase();
            DataTable dataTable = GetGudang();
            CloseConnection();

            dataGridView.DataSource = dataTable;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            namaTextBox.Clear();
            jalanTextBox.Clear();
            kotaTextBox.Clear();
            provinsiTextBox.Clear();
        }

        public DataTable GetGudang()
        {
            string query = "SELECT * FROM gudang";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void AddGudang(int id, string nama, string jalan, string kota, string provinsi)
        {
            string query = "INSERT INTO gudang (Id_gudang, Nama_gudang, Jalan, Kota, Provinsi) VALUES (@IdGudang, @NamaGudang, @Jalan, @Kota, @Provinsi)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdGudang", id);
            command.Parameters.AddWithValue("@NamaGudang", nama);
            command.Parameters.AddWithValue("@Jalan", jalan);
            command.Parameters.AddWithValue("@Kota", kota);
            command.Parameters.AddWithValue("@Provinsi", provinsi);

            command.ExecuteNonQuery();

            RefreshDataGridView();
            bindingNavigator.BindingSource = gudangBindingSource;
        }

        public void UpdateGudang(int id, string nama, string jalan, string kota, string provinsi)
        {
            string query = "UPDATE gudang SET Nama_gudang = @NamaGudang, Jalan = @Jalan, Kota = @Kota, Provinsi = @Provinsi WHERE Id_gudang = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NamaGudang", nama);
            command.Parameters.AddWithValue("@Jalan", jalan);
            command.Parameters.AddWithValue("@Kota", kota);
            command.Parameters.AddWithValue("@Provinsi", provinsi);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public void DeleteGudang(int id)
        {
            string query = "DELETE FROM gudang WHERE Id_gudang = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            string jalan = jalanTextBox.Text;
            string kota = kotaTextBox.Text;
            string provinsi = provinsiTextBox.Text;

            ConnectToDatabase();
            AddGudang(id, nama, jalan, kota, provinsi);
            CloseConnection();

            RefreshDataGridView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            string jalan = jalanTextBox.Text;
            string kota = kotaTextBox.Text;
            string provinsi = provinsiTextBox.Text;

            ConnectToDatabase();
            UpdateGudang(id, nama, jalan, kota, provinsi);
            CloseConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);

            ConnectToDatabase();
            DeleteGudang(id);
            CloseConnection();

            RefreshDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageForm Bhome = new HomePageForm();
            this.Close();
            Bhome.Show();
        }
    }
}
