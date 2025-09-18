using System;
using Microsoft.Data.SqlClient;

namespace ShadowLines.Models
{
    internal class Users
    {
        public static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public int AuthenticateUser(string username, string passwordID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT Nivel_Acesso
                      FROM Funcionarios 
                      WHERE Nome = @Username 
                      AND ID_Funcionario = @PasswordID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordID", passwordID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result == null ? 0 : Convert.ToInt32(result);
                    // 0 = não autenticado
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    return 0;
                }
            }
        }
    }
}
