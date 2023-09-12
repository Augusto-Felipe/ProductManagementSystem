using MySql.Data.MySqlClient;

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
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=db_inventario";

                conn = new MySqlConnection(data_source);

                string sql = "INSERT INTO PRODUTO (nome) VALUES ('" + txt_name.Text + "')";

                MySqlCommand command = new MySqlCommand(sql, conn);

                conn.Open();

                command.ExecuteReader();

                MessageBox.Show("Produto Inserido!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}