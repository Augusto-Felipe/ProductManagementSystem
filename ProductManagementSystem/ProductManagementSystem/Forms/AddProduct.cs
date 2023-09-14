using MySql.Data.MySqlClient;

namespace ProductManagementSystem.Forms
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                        string insertProduct = $"INSERT INTO PRODUTO (nome) VALUES ('{product}')";

                        using (MySqlCommand command = new MySqlCommand(insertProduct, conn))
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
    }
}
