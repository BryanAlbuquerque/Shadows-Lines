using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ShadowLines.Classes
{
    internal class Servico
    {
        private readonly static string _connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public int ServicoID { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }


        // 🔹 LISTAR TODOS OS SERVIÇOS (para ComboBox, Grid, etc.)
        public static List<Servico> Select()
        {
            var lista = new List<Servico>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Servicos ORDER BY Nome";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new Servico
                            {
                                ServicoID = r.GetInt32(r.GetOrdinal("ServicoID")),
                                Nome = r["Nome"].ToString(),
                                Valor = (decimal)r["Valor"]
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public static Servico SelectSet(int id)
        {
            Servico servico = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Servicos WHERE ServicoID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            servico = new Servico
                            {
                                ServicoID = r.GetInt32(r.GetOrdinal("ServicoID")),
                                Nome = r["Nome"].ToString(),
                                Valor = (decimal)r["Valor"]
                            };
                        }
                    }
                }
            }

            return servico;
        }



        public bool Insert()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Servicos (Nome, Valor)
                                 VALUES (@Nome, @Valor)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Valor", Valor);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Servicos SET
                                    Nome = @Nome,
                                    Valor = @Valor
                                 WHERE ServicoID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ServicoID);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Valor", Valor);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
