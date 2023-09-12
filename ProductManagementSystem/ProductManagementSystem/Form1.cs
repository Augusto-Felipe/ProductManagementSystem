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

            //try
            //{
            //    string data_source = "datasource=localhost;username=root;password=;database=db_inventario";

            //    conn = new MySqlConnection(data_source);

            //    string sql = "INSERT INTO PRODUTO (nome) VALUES ('" + txt_name.Text + "')";

            //    MySqlCommand command = new MySqlCommand(sql, conn);

            //    conn.Open();

            //    command.ExecuteReader();

            //    MessageBox.Show("Produto Inserido!");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;User=root;Password=;Database=db_inventario";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM PRODUTO;";

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
    }
}