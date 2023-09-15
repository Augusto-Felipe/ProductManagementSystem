using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using ProductManagementSystem.Models;

namespace ProductManagementSystem
{
    public partial class DeleteProduct : Form
    {
        public event EventHandler DataDeleted;
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(txt_id.Text);

            try
            {
                var configPath = "config.json";
                var configJson = File.ReadAllText(configPath);
                var config = JsonConvert.DeserializeObject<SqlConnection>(configJson);
                var connectionString = config.ConnectionString;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = $"DELETE FROM PRODUTO WHERE id = {productID}";

                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    DataDeleted.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Produto Excluido!");

                    this.Close();

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
