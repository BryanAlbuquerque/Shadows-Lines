using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using ShadowLines.Models;

namespace ShadowLines.Classes
{
    internal class Cliente
    {
        private readonly static string _connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";
       
        public static List<ClienteModel> Select(string termo)
        {
            List<ClienteModel> lista = new List<ClienteModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT 
                                ClienteID, 
                                Nome_Completo, 
                                CPF, 
                                Telefone, 
                                Email, 
                                Data_Nascimento, 
                                Endereco, 
                                DataCadastro
                                FROM Clientes 
                                WHERE Nome_Completo LIKE '%' + @termo + '%'
                                OR CPF LIKE '%' + @termo + '%'
                                OR Email LIKE '%' + @termo + '%'
                                OR Data_Nascimento LIKE '%' + @termo + '%'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termo);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ClienteModel
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


        public static ClienteModel SelectedSet(int id)
        {
            ClienteModel cliente = null;

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
                            cliente = new ClienteModel
                            {
                                ClienteID = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                                Nome_Completo = reader.GetString(reader.GetOrdinal("Nome_Completo")),
                                CPF = reader.GetInt64(reader.GetOrdinal("CPF")),
                                Telefone = reader.GetInt64(reader.GetOrdinal("Telefone")),
                                Email = reader["Email"] as string,
                                Data_Nascimento = reader.IsDBNull(reader.GetOrdinal("Data_Nascimento")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("Data_Nascimento")),
                                Endereco = reader["Endereco"] as string,
                                DataCadastro = reader.GetDateTime(reader.GetOrdinal("DataCadastro"))
                            };
                        }
                    }
                }
            }

            return cliente;
        }

        public bool Insert(ClienteModel cliente)
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
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome_Completo);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@Email", (object)cliente.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nascimento", (object)cliente.Data_Nascimento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Endereco", (object)cliente.Endereco ?? DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(ClienteModel cliente)
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
                    cmd.Parameters.AddWithValue("@ID", cliente.ClienteID);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome_Completo);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@Email", (object)cliente.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nascimento", (object)cliente.Data_Nascimento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Endereco", (object)cliente.Endereco ?? DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(ClienteModel cliente)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Clientes WHERE ClienteID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", cliente.ClienteID);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
