using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ShadowLines.Classes
{
    class CadastrarClientes
    {
        public static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public static bool AdicionarCliente(
            string name, string cpf, string number,
            string email, DateTime birthday, string adress)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(number) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(adress))
            {
                MessageBox.Show("Erro! Existem campos em branco.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Conversão de string para tipos numéricos
            if (!long.TryParse(cpf, out long cpfValue))
            {
                MessageBox.Show("CPF inválido. Digite apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!long.TryParse(number, out long phoneValue))
            {
                MessageBox.Show("Telefone inválido. Digite apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

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
                    comando.Parameters.AddWithValue("@cpf", cpfValue);
                    comando.Parameters.AddWithValue("@number", phoneValue);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@birthday", birthday);
                    comando.Parameters.AddWithValue("@adress", adress);

                    try
                    {
                        conexao.Open();
                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("✅ Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi inserido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao inserir dados no banco:\n" + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}
