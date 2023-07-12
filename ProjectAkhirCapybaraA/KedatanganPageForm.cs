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
    public partial class KedatanganPageForm : Form
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

        public KedatanganPageForm()
        {
            InitializeComponent();
        }

        private void KedatanganPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.kurir' table. You can move, or remove it, as needed.
            this.kurirTableAdapter.Fill(this.gudanginventoryDataSet.kurir);
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.gudang' table. You can move, or remove it, as needed.
            this.gudangTableAdapter.Fill(this.gudanginventoryDataSet.gudang);
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.kedatangan' table. You can move, or remove it, as needed.
            this.kedatanganTableAdapter.Fill(this.gudanginventoryDataSet.kedatangan);

            ConnectToDatabase();
            LoadComboBoxGudang();
            LoadComboBoxKurir();

        }

        public DataTable GetKedatangan()
        {
            string query = "SELECT * FROM kedatangan";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void AddKedatangan(int idKedatangan, DateTime tglDatang, int idGudang, int idKurir)
        {
            string query = "INSERT INTO kedatangan (Id_kedatangan, tgl_datang, Id_gudang, Id_kurir) VALUES (@IdKedatangan, @TglDatang, @IdGudang, @IdKurir)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdKedatangan", idKedatangan);
            command.Parameters.AddWithValue("@TglDatang", tglDatang);
            command.Parameters.AddWithValue("@IdGudang", idGudang);
            command.Parameters.AddWithValue("@IdKurir", idKurir);

            command.ExecuteNonQuery();

            RefreshDataGridView();
            bindingNavigator.BindingSource = kedatanganBindingSource;
        }

        public void UpdateKedatangan(int idKedatangan, DateTime tglDatang, int idGudang, int idKurir)
        {
            string query = "UPDATE kedatangan SET tgl_datang = @TglDatang, Id_gudang = @IdGudang, Id_kurir = @IdKurir WHERE Id_kedatangan = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TglDatang", tglDatang);
            command.Parameters.AddWithValue("@IdGudang", idGudang);
            command.Parameters.AddWithValue("@IdKurir", idKurir);
            command.Parameters.AddWithValue("@Id", idKedatangan);

            command.ExecuteNonQuery();
        }

        public void DeleteKedatangan(int idKedatangan)
        {
            string query = "DELETE FROM kedatangan WHERE Id_kedatangan = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", idKedatangan);

            command.ExecuteNonQuery();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int idKedatangan = Convert.ToInt32(idKedatanganTextBox.Text);
            DateTime tglDatang = Convert.ToDateTime(dateTimePicker1.Text);
            int idGudang = Convert.ToInt32(idGudangCmbBox.Text);
            int idKurir = Convert.ToInt32(idKurirCmbBox.Text);

            ConnectToDatabase();
            AddKedatangan(idKedatangan, tglDatang, idGudang, idKurir);
            CloseConnection();

            RefreshDataGridView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int idKedatangan = Convert.ToInt32(idKedatanganTextBox.Text);
            DateTime tglDatang = Convert.ToDateTime(dateTimePicker1.Text);
            int idGudang = Convert.ToInt32(idGudangCmbBox.Text);
            int idKurir = Convert.ToInt32(idKurirCmbBox.Text);

            ConnectToDatabase();
            UpdateKedatangan(idKedatangan, tglDatang, idGudang, idKurir);
            CloseConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int idKedatangan = Convert.ToInt32(idKedatanganTextBox.Text);

            ConnectToDatabase();
            DeleteKedatangan(idKedatangan);
            CloseConnection();

            RefreshDataGridView();
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            idKedatanganTextBox.Clear();
        }

        private void RefreshDataGridView()
        {
            ConnectToDatabase();
            DataTable dataTable = GetKedatangan();
            CloseConnection();

            dataGridView.DataSource = dataTable;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            bindingNavigator.BindingSource = kedatanganBindingSource; // Set the binding source to refresh the binding navigator
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataRelasiForm dataRelasi = new DataRelasiForm();
            this.Close();
            dataRelasi.Show();
        }

        private void LoadComboBoxGudang()
        {
            string query = "SELECT Id_gudang FROM gudang";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string idGudang = reader["Id_gudang"].ToString();
                idGudangCmbBox.Items.Add(idGudang);
            }

            reader.Close();
        }

        private void LoadComboBoxKurir()
        {
            string query = "SELECT Id_kurir FROM kurir";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string idKurir = reader["Id_kurir"].ToString();
                idKurirCmbBox.Items.Add(idKurir);
            }

            reader.Close();
        }
    }
}
