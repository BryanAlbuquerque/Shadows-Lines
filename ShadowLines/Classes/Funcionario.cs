using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ShadowLines.Models;

namespace ShadowLines.Classes
{
    internal class Funcionario
    {
        private readonly static string _connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public static List<FuncionarioModel> Select()
        {
            List<FuncionarioModel> lista = new List<FuncionarioModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM Funcionarios 
                                WHERE NivelAcesso = 1                     
                                ORDER BY FuncionarioID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new FuncionarioModel
                            {
                                FuncionarioID = r.GetInt32(r.GetOrdinal("FuncionarioID")),
                                Nome = r.GetString(r.GetOrdinal("Nome")),
                                CPF = r.GetInt64(r.GetOrdinal("CPF")),
                                DataNascimento = r.GetDateTime(r.GetOrdinal("DataNascimento")),
                                Email = r.GetString(r.GetOrdinal("Email")),
                                Telefone = r.GetInt64(r.GetOrdinal("Telefone")),
                                Endereco = r["Endereco"]?.ToString(),
                                Cargo = r["Cargo"]?.ToString(),
                                NivelAcesso = r.GetInt32(r.GetOrdinal("NivelAcesso"))
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public static List<FuncionarioModel> Buscar(string termo)
        {
            List<FuncionarioModel> lista = new List<FuncionarioModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT * FROM Funcionarios
                    WHERE 
                        Nome LIKE @termo
                        OR CPF LIKE @termo
                        OR Telefone LIKE @termo
                        OR Email LIKE @termo
                        OR Cargo LIKE @termo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", $"%{termo}%");

                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new FuncionarioModel
                            {
                                FuncionarioID = r.GetInt32(r.GetOrdinal("FuncionarioID")),
                                Nome = r.GetString(r.GetOrdinal("Nome")),
                                CPF = r.GetInt64(r.GetOrdinal("CPF")),
                                DataNascimento = r.GetDateTime(r.GetOrdinal("DataNascimento")),
                                Email = r.GetString(r.GetOrdinal("Email")),
                                Telefone = r.GetInt64(r.GetOrdinal("Telefone")),
                                Endereco = r["Endereco"]?.ToString(),
                                Cargo = r["Cargo"]?.ToString(),
                                NivelAcesso = r.GetInt32(r.GetOrdinal("NivelAcesso"))
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public bool Insert(FuncionarioModel funcionario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Funcionarios
                    (Nome, CPF, DataNascimento, Email, Telefone, Endereco, Cargo, NivelAcesso)
                    VALUES
                    (@Nome, @CPF, @Nascimento, @Email, @Telefone, @Endereco, @Cargo, @Nivel)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
                    cmd.Parameters.AddWithValue("@Nascimento", funcionario.DataNascimento);
                    cmd.Parameters.AddWithValue("@Email", funcionario.Email);
                    cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                    cmd.Parameters.AddWithValue("@Endereco", (object)funcionario.Endereco ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cargo", (object)funcionario.Cargo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nivel", funcionario.NivelAcesso);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(FuncionarioModel funcionario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Funcionarios SET
                        Nome = @Nome,
                        CPF = @CPF,
                        DataNascimento = @Nascimento,
                        Email = @Email,
                        Telefone = @Telefone,
                        Endereco = @Endereco,
                        Cargo = @Cargo,
                        NivelAcesso = @Nivel
                        WHERE FuncionarioID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", funcionario.FuncionarioID);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
                    cmd.Parameters.AddWithValue("@Nascimento", funcionario.DataNascimento);
                    cmd.Parameters.AddWithValue("@Email", funcionario.Email);
                    cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                    cmd.Parameters.AddWithValue("@Endereco", (object)funcionario.Endereco ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cargo", (object)funcionario.Cargo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nivel", funcionario.NivelAcesso);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
