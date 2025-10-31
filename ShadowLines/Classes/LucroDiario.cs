using System;
using ShadowLines.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace ShadowLines.Classes
{
    internal class LucroDiario
    {
        private readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";


        public List<LucroDiarioModel> ObterlucroDiario()
        {
            List<LucroDiarioModel> lista = new List<LucroDiarioModel>();

            string query = @"
                SELECT 
                    COUNT(AgendamentoID) AS QuantidadeAgendamentos,
                    SUM(Valor) AS LucroTotal FROM Agendamentos";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new LucroDiarioModel
                    {
                       LucroTotal = Convert.ToDecimal(dr["LucroTotal"]),
                       QuantidadeAgendamentos = Convert.ToInt32(dr["QuantidadeAgendamentos"])
                    });
                }
                dr.Close();
            }

            return lista;
        }
    }

}
