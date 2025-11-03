using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ShadowLines.Models;

namespace ShadowLines.Classes
{
    internal class LucroDiario
    {
        private readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public LucroDiarioModel ObterLucroDiario()
        {
            LucroDiarioModel model = new LucroDiarioModel();

            string query = @"
                SELECT 
                    COUNT(*) AS QuantidadeAgendamentos,
                    SUM(Valor) AS LucroTotal,
                    SUM(CASE WHEN Pagamento = 'Pago' THEN 1 ELSE 0 END) AS QuantidadePagos,
                    SUM(CASE WHEN Situacao = 'Finalizado' THEN 1 ELSE 0 END) AS QuantidadeFinalizados
                FROM Agendamentos
                WHERE CONVERT(date, DataAgendamento) = CONVERT(date, GETDATE());";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    model.QuantidadeAgendamentos = dr["QuantidadeAgendamentos"] != DBNull.Value ? Convert.ToInt32(dr["QuantidadeAgendamentos"]) : 0;
                    model.LucroTotal = dr["LucroTotal"] != DBNull.Value ? Convert.ToDecimal(dr["LucroTotal"]) : 0;
                    model.QuantidadePagos = dr["QuantidadePagos"] != DBNull.Value ? Convert.ToInt32(dr["QuantidadePagos"]) : 0;
                    model.QuantidadeFinalizados = dr["QuantidadeFinalizados"] != DBNull.Value ? Convert.ToInt32(dr["QuantidadeFinalizados"]) : 0;
                }
                dr.Close();
            }

            return model;
        }
    }
}
