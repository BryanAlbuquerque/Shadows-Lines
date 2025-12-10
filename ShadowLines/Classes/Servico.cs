using Microsoft.Data.SqlClient;
using ShadowLines.Models;
using System.Collections.Generic;

namespace ShadowLines.Classes
{
    internal class Servico
    {
        private readonly static string _connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public static List<ServicoModel> Select()
        {
            List<ServicoModel> lista = new List<ServicoModel>();

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
                            lista.Add(new ServicoModel
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

        public static ServicoModel SelectSet(int id)
        {
            ServicoModel servicoModel = null;

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
                            servicoModel = new ServicoModel
                            {
                                ServicoID = r.GetInt32(r.GetOrdinal("ServicoID")),
                                Nome = r["Nome"].ToString(),
                                Valor = (decimal)r["Valor"]
                            };
                        }
                    }
                }
            }

            return servicoModel;
        }



        public bool Insert()
        {
            ServicoModel servico = new ServicoModel();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Servicos (Nome, Valor)
                                 VALUES (@Nome, @Valor)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", servico.Nome);
                    cmd.Parameters.AddWithValue("@Valor", servico.Valor);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update()
        {
            ServicoModel servico = new ServicoModel();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Servicos SET
                                    Nome = @Nome,
                                    Valor = @Valor
                                 WHERE ServicoID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", servico.ServicoID);
                    cmd.Parameters.AddWithValue("@Nome", servico.Nome);
                    cmd.Parameters.AddWithValue("@Valor", servico.Valor);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
