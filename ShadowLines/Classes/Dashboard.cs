using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace ShadowLines.Forms
{
    public class DashboardForm : Form
    {
        private Chart chartLucroDiario;
        private string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public DashboardForm()
        {
            this.Text = "Dashboard Financeiro - ShadowLines";
            this.Size = new Size(950, 600);
            this.BackColor = Color.FromArgb(245, 245, 255);
            this.StartPosition = FormStartPosition.CenterScreen;

            InicializarGrafico();
            CarregarDados();
        }

        private void InicializarGrafico()
        {
            chartLucroDiario = new Chart();
            chartLucroDiario.Dock = DockStyle.Fill;
            chartLucroDiario.ChartAreas.Add(new ChartArea("AreaPrincipal"));
            chartLucroDiario.Legends.Add(new Legend("Legenda"));

            var area = chartLucroDiario.ChartAreas["AreaPrincipal"];
            area.AxisX.Title = "Funcionários";
            area.AxisY.Title = "Lucro Diário (R$)";
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.BackColor = Color.White;

            this.Controls.Add(chartLucroDiario);
        }

        private void CarregarDados()
        {
            string query = @"
                SELECT f.FuncionarioID, COUNT(a.AgendamentoID) AS QtdeAtendimentos, SUM(a.Valor) AS TotalLucro
                FROM Agendamentos a
                INNER JOIN Funcionarios f ON a.FuncionarioID = f.FuncionarioID
                WHERE CAST(a.DataAgendamento AS DATE) = CAST(GETDATE() AS DATE)
                GROUP BY f.FuncionarioID
                ORDER BY TotalLucro DESC";

            try
            {
                using (var conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    using (var comando = new SqlCommand(query, conexao))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            Series serieLucro = new Series("Lucro Diário");
                            serieLucro.ChartType = SeriesChartType.Column;
                            serieLucro.Color = Color.FromArgb(100, 88, 255);
                            serieLucro.IsValueShownAsLabel = true;
                            serieLucro.BorderWidth = 2;

                            chartLucroDiario.Series.Clear();
                            chartLucroDiario.Series.Add(serieLucro);

                            while (reader.Read())
                            {
                                string funcionario = reader["FuncionarioID"].ToString();
                                double total = Convert.ToDouble(reader["TotalLucro"]);
                                serieLucro.Points.AddXY("Func " + funcionario, total);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do gráfico:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CarregarDados(); // Atualiza os dados ao abrir o formulário
        }
    }
}
