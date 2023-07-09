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
    public partial class StaffPageForm : Form
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

        public StaffPageForm()
        {
            InitializeComponent();
        }

        private void RefreshDataGridView()
        {
            ConnectToDatabase();
            DataTable dataTable = GetStaff();
            CloseConnection();

            dataGridView.DataSource = dataTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageForm Bhome = new HomePageForm();
            this.Close();
            Bhome.Show();
        }

        private void StaffPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gudanginventoryDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.gudanginventoryDataSet.staff);

            ConnectToDatabase();

        }

        public DataTable GetStaff()
        {
            string query = "SELECT * FROM staff";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void AddStaff(int id, string nama, string noTelp, string username)
        {
            string query = "INSERT INTO staff (Id_staff, Nama_staff, No_telp, Username_staff) VALUES (@IdStaff, @NamaStaff, @NoTelp, @Username)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdStaff", id);
            command.Parameters.AddWithValue("@NamaStaff", nama);
            command.Parameters.AddWithValue("@NoTelp", noTelp);
            command.Parameters.AddWithValue("@Username", username);

            command.ExecuteNonQuery();

            RefreshDataGridView();
            bindingNavigator.BindingSource = staffBindingSource;
        }

        public void UpdateStaff(int id, string nama, string noTelp, string username)
        {
            string query = "UPDATE staff SET Nama_staff = @NamaStaff, No_telp = @NoTelp, Username_staff = @Username WHERE Id_staff = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NamaStaff", nama);
            command.Parameters.AddWithValue("@NoTelp", noTelp);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public void DeleteStaff(int id)
        {
            string query = "DELETE FROM staff WHERE Id_staff = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            string noTelp = noTelpTextBox.Text;
            string username = usernameTextBox.Text;

            ConnectToDatabase();
            AddStaff(id, nama, noTelp, username);
            CloseConnection();

            RefreshDataGridView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string nama = namaTextBox.Text;
            string noTelp = noTelpTextBox.Text;
            string username = usernameTextBox.Text;

            ConnectToDatabase();
            UpdateStaff(id, nama, noTelp, username);
            CloseConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);

            ConnectToDatabase();
            DeleteStaff(id);
            CloseConnection();

            RefreshDataGridView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            bindingNavigator.BindingSource = staffBindingSource; // Set the binding source to refresh the binding navigator
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            namaTextBox.Clear();
            noTelpTextBox.Clear();
            usernameTextBox.Clear();
        }
    }
}
