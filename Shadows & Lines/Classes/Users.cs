using System;
using Microsoft.Data.SqlClient;

namespace Shadows___Lines.Classes
{
    internal class Users
    {
        public static string connectionString = 
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true";

        public bool AuthenticateUser(string username, string passwordID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = 
                    @"SELECT COUNT(1) 
                    FROM Users 
                    WHERE Nome = @Username 
                    AND ID_Funcionario = @PasswordID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordID", passwordID);
                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
