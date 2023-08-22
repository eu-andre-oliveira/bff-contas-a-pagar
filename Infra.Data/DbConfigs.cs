
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SQLite;

namespace Api.Configs
{
    public static class DbConfigs
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = "Data Source=projeto86.db;Version=3;";

            // Cria o arquivo do banco de dados se ele não existir
            SQLiteConnection.CreateFile("projeto86.db");

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS contas (nome TEXT, email TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Tabela 'contas' criada com sucesso!");

                connection.Close();
            }
            return services;
        }
    }
}
