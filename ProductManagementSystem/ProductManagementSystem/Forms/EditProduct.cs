using MySql.Data.MySqlClient;
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

        private void Btn_send_Click(object sender, EventArgs e)
        {
            string productID = txt_id.Text;
            string newProductName = txt_newName.Text;


            if (string.IsNullOrEmpty(productID) || string.IsNullOrEmpty(newProductName))
            {
                MessageBox.Show("Ambos os campos devem ser preenchidos!");
            }
            else
            {
                try
                {
                    var sqlConnection = SqlConnection.FromConfigFile();

                    using (MySqlConnection conn = new MySqlConnection(sqlConnection.ConnectionString))
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
}
