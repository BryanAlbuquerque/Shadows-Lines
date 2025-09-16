using System.Data;
using Microsoft.Data.SqlClient;

namespace ShadowLines.Models
{
    class Users
    {
        private static readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public static int Authenticate(string name, int id)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                const string sqlAuth = @"
                    SELECT Nivel_Acesso
                    FROM Funcionarios 
                    WHERE Nome = @name
                    AND ID_Funcionario = @id";

                using (var cmd = new SqlCommand(sqlAuth, conexao))
                {
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    conexao.Open();
                    var result = cmd.ExecuteScalar();
                    return result == null ? 0 : Convert.ToInt32(result);
                }
            }
        }
    }
}
