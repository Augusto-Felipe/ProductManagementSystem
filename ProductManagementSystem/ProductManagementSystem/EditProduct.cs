using MySql.Data.MySqlClient;

namespace ProductManagementSystem
{
    public partial class EditProduct : Form
    {
        private int SelectedProductId;

        public event EventHandler DataEdited;

        public EditProduct(int selectedProductId)
        {
            InitializeComponent();
            SelectedProductId = selectedProductId;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            string newProductName = txt_newName.Text;

            try
            {
                string connectionString = "Server=localhost;User=root;Password=;Database=db_inventario";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = $"UPDATE PRODUTO SET nome = '{newProductName}' WHERE id = {SelectedProductId}";

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
