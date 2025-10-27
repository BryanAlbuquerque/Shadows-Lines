using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace ShadowLines.Classes
{
    internal class CarregarDadosClientes
    {
        private static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";
        
        public DataTable CarregarDados()
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clientes";
                using (var comando = new SqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Erro ao carregar dados: " + ex.Message);
                        return null;
                    }
                }
            }
        }
    }
}
