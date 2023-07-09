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
    public partial class KurirPageForm : Form
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

        public KurirPageForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KurirPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.kurir' table. You can move, or remove it, as needed.
            this.kurirTableAdapter.Fill(this.gudanginventoryDataSet.kurir);

        }

        public DataTable GetKurir()
        {
            string query = "SELECT * FROM kurir";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void AddKurir(int id, string nama, string jenisKelamin, string asal, string noTelp)
        {
            string query = "INSERT INTO kurir (Id_kurir, Nama_kurir, jenis_kelamin, asal_kurir, No_telp) VALUES (@IdKurir, @NamaKurir, @JenisKelamin, @Asal, @NoTelp)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdKurir", id);
            command.Parameters.AddWithValue("@NamaKurir", nama);
            command.Parameters.AddWithValue("@JenisKelamin", jenisKelamin);
            command.Parameters.AddWithValue("@Asal", asal);
            command.Parameters.AddWithValue("@NoTelp", noTelp);

            command.ExecuteNonQuery();

            RefreshDataGridView();
            bindingNavigator.BindingSource = kurirBindingSource;
        }

        public void UpdateKurir(int id, string nama, string jenisKelamin, string asal, string noTelp)
        {
            string query = "UPDATE kurir SET Nama_kurir = @NamaKurir, jenis_kelamin = @JenisKelamin, asal_kurir = @Asal, No_telp = @NoTelp WHERE Id_kurir = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NamaKurir", nama);
            command.Parameters.AddWithValue("@JenisKelamin", jenisKelamin);
            command.Parameters.AddWithValue("@Asal", asal);
            command.Parameters.AddWithValue("@NoTelp", noTelp);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public void DeleteKurir(int id)
        {
            string query = "DELETE FROM kurir WHERE Id_kurir = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            string jenisKelamin = jenisKelaminTextBox.Text;
            string asal = asalTextBox.Text;
            string noTelp = noTelpTextBox.Text;

            ConnectToDatabase();
            AddKurir(id, nama, jenisKelamin, asal, noTelp);
            CloseConnection();

            RefreshDataGridView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            string jenisKelamin = jenisKelaminTextBox.Text;
            string asal = asalTextBox.Text;
            string noTelp = noTelpTextBox.Text;

            ConnectToDatabase();
            UpdateKurir(id, nama, jenisKelamin, asal, noTelp);
            CloseConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);

            ConnectToDatabase();
            DeleteKurir(id);
            CloseConnection();

            RefreshDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageForm Bhome = new HomePageForm();
            this.Close();
            Bhome.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            namaTextBox.Clear();
            jenisKelaminTextBox.Clear();
            asalTextBox.Clear();
            noTelpTextBox.Clear();
        }

        private void RefreshDataGridView()
        {
            ConnectToDatabase();
            DataTable dataTable = GetKurir();
            CloseConnection();

            dataGridView.DataSource = dataTable;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            bindingNavigator.BindingSource = kurirBindingSource; // Set the binding source to refresh the binding navigator
        }
    }
}
