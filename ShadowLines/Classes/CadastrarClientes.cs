using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ShadowLines.Classes
{
    class CadastrarClientes
    {
        private static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public static bool AdicionarCliente(
            string nome, string cpf, string telefone,
            string email, DateTime aniversario, string endereco)
        {
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(telefone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("Erro! Existem campos em branco.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Conversão de string para tipos numéricos
            if (!long.TryParse(cpf, out long NumeroCpf))
            {
                MessageBox.Show("CPF inválido. Digite apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!long.TryParse(telefone, out long NumeroTelefone))
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
                    (@nome, @cpf, @telefone, @email, @aniversario, @endereco, GETDATE())";

                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@cpf", NumeroCpf);
                    comando.Parameters.AddWithValue("@telefone", NumeroTelefone);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@aniversario", aniversario);
                    comando.Parameters.AddWithValue("@endereco", endereco);

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
