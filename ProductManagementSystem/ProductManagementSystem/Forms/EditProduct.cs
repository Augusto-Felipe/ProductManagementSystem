using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using ProductManagementSystem.Models;

namespace ProductManagementSystem
{
    public partial class EditProduct : Form
    {
        public event EventHandler DataEdited;

        public EditProduct()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string productID = txt_id.Text;
            string newProductName = txt_newName.Text;

            try
            {
                var configPath = "config.json";
                var configJson = File.ReadAllText(configPath);
                var config = JsonConvert.DeserializeObject<SqlConnection>(configJson);
                var connectionString = config.ConnectionString;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = $"UPDATE PRODUTO SET nome = '{newProductName}' WHERE id = {productID}";

                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produto atualizado com sucesso!");
                            DataEdited.Invoke(this, EventArgs.Empty);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado");
                            this.Close();
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
