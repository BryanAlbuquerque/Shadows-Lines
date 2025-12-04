using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ShadowLines.Classes
{
    internal class Funcionario
    {
        private readonly static string _connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public int FuncionarioID { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cargo { get; set; }
        public int NivelAcesso { get; set; }

        public static List<Funcionario> Select()
        {
            var lista = new List<Funcionario>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM Funcionarios 
                                WHERE NivelAcesso = 0                     
                                ORDER BY FuncionarioID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new Funcionario
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

        public static List<Funcionario> Buscar(string termo)
        {
            var lista = new List<Funcionario>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT * FROM Funcionarios
                    WHERE 
                        Nome LIKE @t
                        OR CPF LIKE @t
                        OR Telefone LIKE @t
                        OR Email LIKE @t
                        OR Cargo LIKE @t";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@t", $"%{termo}%");

                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new Funcionario
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

        public bool Insert()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Funcionarios
                    (Nome, CPF, DataNascimento, Email, Telefone, Endereco, Cargo, Nivel_Acesso)
                    VALUES
                    (@Nome, @CPF, @Nascimento, @Email, @Telefone, @Endereco, @Cargo, @Nivel)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@Nascimento", DataNascimento);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@Endereco", (object)Endereco ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cargo", (object)Cargo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nivel", NivelAcesso);

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
                    cmd.Parameters.AddWithValue("@ID", FuncionarioID);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@Nascimento", DataNascimento);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@Endereco", (object)Endereco ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cargo", (object)Cargo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nivel", NivelAcesso);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
