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


        public static List<ServicoModel> Buscar(string termo)
        {
            List<ServicoModel> lista = new List<ServicoModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT ServicoID, Nome, Valor, DataInclusao
                         FROM Servicos 
                         WHERE CAST(ServicoID AS VARCHAR) LIKE '%' + @termo + '%'
                         OR Nome LIKE '%' + @termo + '%'
                         OR CAST(Valor AS VARCHAR) LIKE '%' + @termo + '%'
                         OR DataInclusao LIKE '%' + @termo + '%'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termo);

                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new ServicoModel()
                            {
                                ServicoID = r.GetInt32(r.GetOrdinal("ServicoID")),
                                Nome = r["Nome"].ToString(),
                                Valor = (decimal)r["Valor"],
                                DataInclusao = (System.DateTime)r["DataInclusao"]
                            });
                        }
                    }
                }
            }

            return lista;
        }




        public bool Insert(ServicoModel servico)
        {
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

        public bool Update(ServicoModel servico)
        {

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

        public bool Delete(int servicoID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Servicos WHERE ServicoID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", servicoID);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
