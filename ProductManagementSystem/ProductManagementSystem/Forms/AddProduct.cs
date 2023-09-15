using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using ProductManagementSystem.Models;
using System.IO;
using static Org.BouncyCastle.Math.EC.ECCurve;

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
                
                    var configPath = "config.json";
                    var configJson = File.ReadAllText(configPath);
                    var config = JsonConvert.DeserializeObject<SqlConnection>(configJson);
                    var connectionString = config.ConnectionString;


                    //string connectionString = "Server=localhost;User=root;Password=;Database=db_inventario";

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
