using MySql.Data.MySqlClient;
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

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            string productID = txt_id.Text;

            if (string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Digite um ID válido!");
            }
            else
            {
                try
                {
                    var sqlConnection = SqlConnection.FromConfigFile();

                    using (MySqlConnection conn = new MySqlConnection(sqlConnection.ConnectionString))
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
}
