using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ShadowLines.Classes
{
    class Users
    {
        private static string connectionString =
               "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public static bool Authenticate01(string name, int id)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                const string sqlAuth = @"
                    SELECT 1
                    FROM Funcionarios 
                    WHERE Nome = @name
                    AND ID_Funcionario = @id
                    AND Nivel_Acesso = 1";

                using (var cmd = new SqlCommand(sqlAuth, conexao))
                {
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    conexao.Open();
                    var ok = cmd.ExecuteScalar();
                    return ok != null;
                }
            }
        }

        public static bool Authenticate02(string name, int id)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string sqlAuth = @"
                    SELECT 1
                    FROM Funcionarios 
                    WHERE Nome = @name
                    AND ID_Funcionario = @id
                    AND Nivel_Acesso = 2";

                using (var cmd = new SqlCommand(sqlAuth, conexao))
                {
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    conexao.Open();
                    var ok = cmd.ExecuteScalar();
                    return ok != null;
                }
            }
        }

        public static bool Autenticate03(string name, int id)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string sqlAuth = @"
                    SELECT 1
                    FROM Funcionarios 
                    WHERE Nome = @name
                    AND ID_Funcionario = @id
                    AND Nivel_Acesso = 3";

                using (var cmd = new SqlCommand(sqlAuth, conexao))
                {
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    conexao.Open();
                    var ok = cmd.ExecuteScalar();
                    return ok != null;
                }
            }

        }
    }
}
