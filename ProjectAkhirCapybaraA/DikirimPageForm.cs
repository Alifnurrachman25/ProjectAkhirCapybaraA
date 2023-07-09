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
    public partial class DikirimPageForm : Form
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

        public DikirimPageForm()
        {
            InitializeComponent();
        }

        private void DikirimPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.kurir' table. You can move, or remove it, as needed.
            this.kurirTableAdapter.Fill(this.gudanginventoryDataSet.kurir);
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.gudanginventoryDataSet.barang);
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.dikirim' table. You can move, or remove it, as needed.
            this.dikirimTableAdapter.Fill(this.gudanginventoryDataSet.dikirim);

            ConnectToDatabase();
        }

        public DataTable GetDikirim()
        {
            string query = "SELECT * FROM dikirim";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void AddDikirim(int idPengiriman, DateTime tglKirim, int idBarang, int idKurir)
        {
            string query = "INSERT INTO dikirim (Id_pengiriman, tgl_kirim, Id_barang, Id_kurir) VALUES (@IdPengiriman, @TglKirim, @IdBarang, @IdKurir)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdPengiriman", idPengiriman);
            command.Parameters.AddWithValue("@TglKirim", tglKirim);
            command.Parameters.AddWithValue("@IdBarang", idBarang);
            command.Parameters.AddWithValue("@IdKurir", idKurir);

            command.ExecuteNonQuery();

            RefreshDataGridView();
            bindingNavigator.BindingSource = dikirimBindingSource;
        }

        public void UpdateDikirim(int idPengiriman, DateTime tglKirim, int idBarang, int idKurir)
        {
            string query = "UPDATE dikirim SET tgl_kirim = @TglKirim, Id_barang = @IdBarang, Id_kurir = @IdKurir WHERE Id_pengiriman = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TglKirim", tglKirim);
            command.Parameters.AddWithValue("@IdBarang", idBarang);
            command.Parameters.AddWithValue("@IdKurir", idKurir);
            command.Parameters.AddWithValue("@Id", idPengiriman);

            command.ExecuteNonQuery();
        }

        public void DeleteDikirim(int idPengiriman)
        {
            string query = "DELETE FROM dikirim WHERE Id_pengiriman = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", idPengiriman);

            command.ExecuteNonQuery();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int idPengiriman = Convert.ToInt32(idPengirimanTextBox.Text);
            DateTime tglKirim = Convert.ToDateTime(dateTimePicker1.Text);
            int idBarang = Convert.ToInt32(idBarangTextBox.Text);
            int idKurir = Convert.ToInt32(idKurirTextBox.Text);

            ConnectToDatabase();
            AddDikirim(idPengiriman, tglKirim, idBarang, idKurir);
            CloseConnection();

            RefreshDataGridView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int idPengiriman = Convert.ToInt32(idPengirimanTextBox.Text);
            DateTime tglKirim = Convert.ToDateTime(dateTimePicker1.Text);
            int idBarang = Convert.ToInt32(idBarangTextBox.Text);
            int idKurir = Convert.ToInt32(idKurirTextBox.Text);

            ConnectToDatabase();
            UpdateDikirim(idPengiriman, tglKirim, idBarang, idKurir);
            CloseConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int idPengiriman = Convert.ToInt32(idPengirimanTextBox.Text);

            ConnectToDatabase();
            DeleteDikirim(idPengiriman);
            CloseConnection();

            RefreshDataGridView();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idPengirimanTextBox.Clear();
            
            idBarangTextBox.Clear();
            idKurirTextBox.Clear();
        }

        private void RefreshDataGridView()
        {
            ConnectToDatabase();
            DataTable dataTable = GetDikirim();
            CloseConnection();

            dataGridView.DataSource = dataTable;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            bindingNavigator.BindingSource = dikirimBindingSource; // Set the binding source to refresh the binding navigator
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataRelasiForm dataRelasi = new DataRelasiForm();
            this.Close();
            dataRelasi.Show();
        }
    }
}
