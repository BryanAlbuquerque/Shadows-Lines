using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace ShadowLines.Classes
{
    internal class Cliente
    {
        private readonly static string _connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";
        public int ClienteID { get; set; }
        public string Nome_Completo { get; set; }
        public long CPF { get; set; }
        public long Telefone { get; set; }
        public string Email { get; set; }
        public DateTime? Data_Nascimento { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }

        public static List<Cliente> Select()
        {
            var lista = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Clientes ORDER BY ClienteID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cliente
                            {
                                ClienteID = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                                Nome_Completo = reader.GetString(reader.GetOrdinal("Nome_Completo")),
                                CPF = reader.GetInt64(reader.GetOrdinal("CPF")),
                                Telefone = reader.GetInt64(reader.GetOrdinal("Telefone")),
                                Email = reader["Email"] as string,
                                Data_Nascimento = reader["Data_Nascimento"] as DateTime?,
                                Endereco = reader["Endereco"] as string,
                                DataCadastro = reader.GetDateTime(reader.GetOrdinal("DataCadastro"))
                            });
                        }
                    }
                }
            }
            return lista;
        }


        public static Cliente SelectedSet(int id)
        {
            Cliente cliente = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                        SELECT ClienteID, Nome_Completo, CPF, Telefone, Email,
                        Data_Nascimento, Endereco, DataCadastro
                        FROM Clientes
                        WHERE ClienteID = @ClienteID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente
                            {
                                ClienteID = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                                Nome_Completo = reader.GetString(reader.GetOrdinal("Nome_Completo")),
                                CPF = reader.GetInt64(reader.GetOrdinal("CPF")),
                                Telefone = reader.GetInt64(reader.GetOrdinal("Telefone")),
                                Email = reader["Email"] as string,
                                Data_Nascimento = reader["Data_Nascimento"] as DateTime?,
                                Endereco = reader["Endereco"] as string,
                                DataCadastro = reader.GetDateTime(reader.GetOrdinal("DataCadastro"))
                            };
                        }
                    }
                }
            }

            return cliente;
        }

        public bool Insert()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Clientes
                    (Nome_Completo, CPF, Telefone, Email, Data_Nascimento, Endereco)
                    VALUES
                    (@Nome, @CPF, @Telefone, @Email, @Nascimento, @Endereco)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome_Completo);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nascimento", (object)Data_Nascimento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Endereco", (object)Endereco ?? DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Clientes SET
                        Nome_Completo = @Nome,
                        CPF = @CPF,
                        Telefone = @Telefone,
                        Email = @Email,
                        Data_Nascimento = @Nascimento,
                        Endereco = @Endereco
                    WHERE ClienteID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ClienteID);
                    cmd.Parameters.AddWithValue("@Nome", Nome_Completo);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nascimento", (object)Data_Nascimento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Endereco", (object)Endereco ?? DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
