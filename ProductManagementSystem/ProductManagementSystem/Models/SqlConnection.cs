using Newtonsoft.Json;

namespace ProductManagementSystem.Models
{
    public class SqlConnection
    {
        public string ConnectionString { get; set; }

        public static SqlConnection FromConfigFile()
        {
            try
            {
                var configPath = "config.json";
                var configJson = File.ReadAllText(configPath);
                var config = JsonConvert.DeserializeObject<SqlConnection>(configJson);
                return config;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao ler configuração do arquivo JSON.", ex);
            }
        }
    }
}
