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
    public partial class MemilikiPageForm : Form
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

        public MemilikiPageForm()
        {
            InitializeComponent();
        }

        private void MemilikiPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.memiliki' table. You can move, or remove it, as needed.
            this.memilikiTableAdapter.Fill(this.gudanginventoryDataSet.memiliki);

            ConnectToDatabase();
            LoadComboBoxPemilik();
            LoadComboBoxBarang();
            
        }

        public DataTable GetMemiliki()
        {
            string query = "SELECT * FROM memiliki";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void AddMemiliki(int idKepemilikan, int idPemilik, int idBarang)
        {
            string query = "INSERT INTO memiliki (Id_kepemilikan, Id_pemilik, Id_barang) VALUES (@IdKepemilikan, @IdPemilik, @IdBarang)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdKepemilikan", idKepemilikan);
            command.Parameters.AddWithValue("@IdPemilik", idPemilik);
            command.Parameters.AddWithValue("@IdBarang", idBarang);

            command.ExecuteNonQuery();

            RefreshDataGridView();
            bindingNavigator.BindingSource = memilikiBindingSource;
        }

        public void UpdateMemiliki(int idKepemilikan, int idPemilik, int idBarang)
        {
            string query = "UPDATE memiliki SET Id_pemilik = @IdPemilik, Id_barang = @IdBarang WHERE Id_kepemilikan = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdPemilik", idPemilik);
            command.Parameters.AddWithValue("@IdBarang", idBarang);
            command.Parameters.AddWithValue("@Id", idKepemilikan);

            command.ExecuteNonQuery();
        }

        public void DeleteMemiliki(int idKepemilikan)
        {
            string query = "DELETE FROM memiliki WHERE Id_kepemilikan = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", idKepemilikan);

            command.ExecuteNonQuery();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int idKepemilikan = Convert.ToInt32(IdKepemilikanTextBox.Text);
            int idPemilik = Convert.ToInt32(idPemilikCmbBox.Text);
            int idBarang = Convert.ToInt32(idBarangCmbBox.Text);

            ConnectToDatabase();
            AddMemiliki(idKepemilikan, idPemilik, idBarang);
            CloseConnection();

            RefreshDataGridView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int idKepemilikan = Convert.ToInt32(IdKepemilikanTextBox.Text);
            int idPemilik = Convert.ToInt32(idPemilikCmbBox.Text);
            int idBarang = Convert.ToInt32(idBarangCmbBox.Text);

            ConnectToDatabase();
            UpdateMemiliki(idKepemilikan, idPemilik, idBarang);
            CloseConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int idKepemilikan = Convert.ToInt32(IdKepemilikanTextBox.Text);

            ConnectToDatabase();
            DeleteMemiliki(idKepemilikan);
            CloseConnection();

            RefreshDataGridView();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            IdKepemilikanTextBox.Clear();
        }

        private void RefreshDataGridView()
        {
            ConnectToDatabase();
            DataTable dataTable = GetMemiliki();
            CloseConnection();

            dataGridView.DataSource = dataTable;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            bindingNavigator.BindingSource = memilikiBindingSource; // Set the binding source to refresh the binding navigator
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataRelasiForm dataRelasi = new DataRelasiForm();
            this.Close();
            dataRelasi.Show();
        }

        private void LoadComboBoxBarang()
        {
            string query = "SELECT Id_barang FROM barang";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string idBarang = reader["Id_barang"].ToString();
                idBarangCmbBox.Items.Add(idBarang);
            }

            reader.Close();
        }

        private void LoadComboBoxPemilik()
        {
            string query = "SELECT Id_pemilik FROM pemilik";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string idPemilik = reader["Id_pemilik"].ToString();
                idPemilikCmbBox.Items.Add(idPemilik);
            }

            reader.Close();
        }
    }
}
