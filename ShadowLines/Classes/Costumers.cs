using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ShadowLines.Models
{
    class Costumers
    {
        public static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public static bool AddCustomer
            (string name, int cpf, int number,
            string email, DateTime birthday, string adress)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = @" 
                    INSERT INTO Clientes 
                    (Nome_Completo, CPF, Telefone, Email, Data_Nascimento, Endereco, DataCadastro)
                    VALUES 
                    (@name, @cpf, @number, @email, @birthday, @adress, GETDATE())";

                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@name", name);
                    comando.Parameters.AddWithValue("@cpf", cpf);
                    comando.Parameters.AddWithValue("@number", email);
                    comando.Parameters.AddWithValue("@birthday", birthday);
                    comando.Parameters.AddWithValue("@adress", adress);

                    try
                    {
                        conexao.Open();
                        int rowsAffected = comando.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi inserido.");
                            return false;

                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
