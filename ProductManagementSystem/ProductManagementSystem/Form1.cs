using MySql.Data.MySqlClient;
using System.Data;

namespace ProductManagementSystem
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string product = txt_name.Text;

            if (product.Length > 1)
            {
                try
                {
                    string connectionString = "Server=localhost;User=root;Password=;Database=db_inventario";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string sql = $"INSERT INTO PRODUTO (nome) VALUES ('{product}')";

                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Produto Inserido!");

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nome do produto deve conter mais de 1 caractere!");
            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(txt_name.Text);

            try
            {
                string connectionString = "Server=localhost;User=root;Password=;Database=db_inventario";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = $"DELETE FROM PRODUTO WHERE id = {productID}";

                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    RefreshDataGridView();

                    MessageBox.Show("Produto Excluido!");

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                string connectionString = "Server=localhost;User=root;Password=;Database=db_inventario";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
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

        private void btn_edit_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedProductID = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                EditProduct editForm = new EditProduct(selectedProductID);
                editForm.ShowDialog();
            }
        }
    }
}