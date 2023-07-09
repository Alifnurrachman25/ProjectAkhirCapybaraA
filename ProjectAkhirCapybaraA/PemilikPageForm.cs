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
    public partial class PemilikPageForm : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=LAPTOP-A8KDLC9E;Initial Catalog=gudanginventory;User ID=sa;Password=123";
        public PemilikPageForm()
        {
            InitializeComponent();
        }


        private void PemilikPageForm_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();

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

        private void RefreshDataGridView()
        {
            ConnectToDatabase();
            DataTable dataTable = GetPemilik();
            CloseConnection();

            dataGridView.DataSource = dataTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageForm Bhome = new HomePageForm();
            this.Close();
            Bhome.Show();
        }


        public DataTable GetPemilik()
        {
            string query = "SELECT * FROM pemilik";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }


        public void AddPemilik(int id, string nama, string alamat, string noTelp)
        {
            string query = "INSERT INTO pemilik (Id_pemilik, Nama_pemilik, Alamat_pemilik, No_telp) VALUES (@IdPemilik, @NamaPemilik, @AlamatPemilik, @NoTelp)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdPemilik", id);
            command.Parameters.AddWithValue("@NamaPemilik", nama);
            command.Parameters.AddWithValue("@AlamatPemilik", alamat);
            command.Parameters.AddWithValue("@NoTelp", noTelp);

            command.ExecuteNonQuery();

            RefreshDataGridView();
            bindingNavigator.BindingSource = pemilikBindingSource;
        }


        public void UpdatePemilik(int id, string nama, string alamat, string noTelp)
        {
            string query = "UPDATE pemilik SET Nama_pemilik = @NamaPemilik, Alamat_pemilik = @AlamatPemilik, No_telp = @NoTelp WHERE Id_pemilik = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NamaPemilik", nama);
            command.Parameters.AddWithValue("@AlamatPemilik", alamat);
            command.Parameters.AddWithValue("@NoTelp", noTelp);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }


        public void DeletePemilik(int id)
        {
            string query = "DELETE FROM pemilik WHERE Id_pemilik = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            string alamat = alamatTextBox.Text;
            string noTelp = noTelpTextBox.Text;

            ConnectToDatabase();
            AddPemilik(id, nama, alamat, noTelp);
            CloseConnection();

            RefreshDataGridView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            string alamat = alamatTextBox.Text;
            string noTelp = noTelpTextBox.Text;

            ConnectToDatabase();
            UpdatePemilik(id, nama, alamat, noTelp);
            CloseConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);

            ConnectToDatabase();
            DeletePemilik(id);
            CloseConnection();

            RefreshDataGridView();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            bindingNavigator.BindingSource = pemilikBindingSource; // Set the binding source to refresh the binding navigator
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            namaTextBox.Clear();
            noTelpTextBox.Clear();
            alamatTextBox.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void noTelpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void alamatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
