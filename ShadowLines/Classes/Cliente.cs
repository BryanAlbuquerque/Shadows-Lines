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
                                Nome, 
                                CPF, 
                                Telefone, 
                                Email, 
                                DataNascimento, 
                                Endereco, 
                                DataCadastro
                                FROM Clientes 
                                WHERE Nome LIKE '%' + @termo + '%'
                                OR CPF LIKE '%' + @termo + '%'
                                OR Email LIKE '%' + @termo + '%'
                                OR DataNascimento LIKE '%' + @termo + '%'";

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
                                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                                CPF = reader.GetInt64(reader.GetOrdinal("CPF")),
                                Telefone = reader.GetInt64(reader.GetOrdinal("Telefone")),
                                Email = reader["Email"] as string,
                                DataNascimento = reader["DataNascimento"] as DateTime?,
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
                        SELECT ClienteID, Nome, CPF, Telefone, Email,
                        DataNascimento, Endereco, DataCadastro
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
                                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                                CPF = reader.GetInt64(reader.GetOrdinal("CPF")),
                                Telefone = reader.GetInt64(reader.GetOrdinal("Telefone")),
                                Email = reader["Email"] as string,
                                DataNascimento = reader.IsDBNull(reader.GetOrdinal("DataNascimento")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DataNascimento")),
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
                    (Nome, CPF, Telefone, Email, DataNascimento, Endereco)
                    VALUES
                    (@Nome, @CPF, @Telefone, @Email, @Nascimento, @Endereco)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@Email", (object)cliente.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nascimento", (object)cliente.DataNascimento ?? DBNull.Value);
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
                        Nome = @Nome,
                        CPF = @CPF,
                        Telefone = @Telefone,
                        Email = @Email,
                        DataNascimento = @Nascimento,
                        Endereco = @Endereco
                    WHERE ClienteID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", cliente.ClienteID);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@Email", (object)cliente.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nascimento", (object)cliente.DataNascimento ?? DBNull.Value);
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
