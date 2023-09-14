using MySql.Data.MySqlClient;

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
                string connectionString = "Server=localhost;User=root;Password=;Database=db_inventario";

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
