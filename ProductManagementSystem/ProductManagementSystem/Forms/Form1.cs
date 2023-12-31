using MySql.Data.MySqlClient;
using ProductManagementSystem.Forms;
using ProductManagementSystem.Models;
using System.Data;

namespace ProductManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct();
            addForm.ShowDialog();
        }

        private void Btn_list_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteForm = new DeleteProduct();
            deleteForm.DataDeleted += DataChanged;
            deleteForm.ShowDialog();
        }

        private void RefreshDataGridView()
        {
            try
            {
                var sqlConnection = SqlConnection.FromConfigFile();

                using (MySqlConnection conn = new MySqlConnection(sqlConnection.ConnectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM PRODUTO";

                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            EditProduct editForm = new EditProduct();
            editForm.DataEdited += DataChanged;
            editForm.ShowDialog();
        }
    }
}