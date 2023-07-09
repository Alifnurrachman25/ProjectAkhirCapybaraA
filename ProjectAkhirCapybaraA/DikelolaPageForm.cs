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
    public partial class DikelolaPageForm : Form
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

        public DikelolaPageForm()
        {
            InitializeComponent();
        }

        private void DikelolaPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.gudanginventoryDataSet.staff);
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.gudang' table. You can move, or remove it, as needed.
            this.gudangTableAdapter.Fill(this.gudanginventoryDataSet.gudang);
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.dikelola' table. You can move, or remove it, as needed.
            this.dikelolaTableAdapter.Fill(this.gudanginventoryDataSet.dikelola);

        }

        public DataTable GetDikelola()
        {
            string query = "SELECT * FROM dikelola";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void AddDikelola(int idKelola, int idGudang, int idStaff)
        {
            string query = "INSERT INTO dikelola (Id_kelola, Id_gudang, Id_staff) VALUES (@IdKelola, @IdGudang, @IdStaff)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdKelola", idKelola);
            command.Parameters.AddWithValue("@IdGudang", idGudang);
            command.Parameters.AddWithValue("@IdStaff", idStaff);

            command.ExecuteNonQuery();

            RefreshDataGridView();
            bindingNavigator.BindingSource = staffBindingSource;
        }

        public void UpdateDikelola(int idKelola, int idGudang, int idStaff)
        {
            string query = "UPDATE dikelola SET Id_gudang = @IdGudang, Id_staff = @IdStaff WHERE Id_kelola = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdGudang", idGudang);
            command.Parameters.AddWithValue("@IdStaff", idStaff);
            command.Parameters.AddWithValue("@Id", idKelola);

            command.ExecuteNonQuery();
        }

        public void DeleteDikelola(int idKelola)
        {
            string query = "DELETE FROM dikelola WHERE Id_kelola = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", idKelola);

            command.ExecuteNonQuery();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int idKelola = Convert.ToInt32(idKelolaTextBox.Text);
            int idGudang = Convert.ToInt32(idGudangTextBox.Text);
            int idStaff = Convert.ToInt32(idStaffTextBox.Text);

            ConnectToDatabase();
            AddDikelola(idKelola, idGudang, idStaff);
            CloseConnection();

            RefreshDataGridView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int idKelola = Convert.ToInt32(idKelolaTextBox.Text);
            int idGudang = Convert.ToInt32(idGudangTextBox.Text);
            int idStaff = Convert.ToInt32(idStaffTextBox.Text);

            ConnectToDatabase();
            UpdateDikelola(idKelola, idGudang, idStaff);
            CloseConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int idKelola = Convert.ToInt32(idKelolaTextBox.Text);

            ConnectToDatabase();
            DeleteDikelola(idKelola);
            CloseConnection();

            RefreshDataGridView();
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            idKelolaTextBox.Clear();
            idGudangTextBox.Clear();
            idStaffTextBox.Clear();
        }

        private void RefreshDataGridView()
        {
            ConnectToDatabase();
            DataTable dataTable = GetDikelola();
            CloseConnection();

            dataGridView.DataSource = dataTable;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            bindingNavigator.BindingSource = dikelolaBindingSource; // Set the binding source to refresh the binding navigator
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataRelasiForm dataRelasi = new DataRelasiForm();
            this.Close();
            dataRelasi.Show();
        }
    }
}
