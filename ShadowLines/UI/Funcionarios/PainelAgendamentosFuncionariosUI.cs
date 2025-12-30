using ShadowLines.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines.UI
{
    internal class PainelAgendamentosFuncionariosUI
    {
        private Panel painel;
        private DashBoardFuncionarios dashBoardFuncionarios;

        public PainelAgendamentosFuncionariosUI()
        {
            dashBoardFuncionarios = new DashBoardFuncionarios();
        }

        public Panel CriarPainel()
        {
            painel = new Panel
            {
                Location = new Point(280, 270),
                Size = new Size(550, 550),
                AutoScroll = true,
                BorderStyle = BorderStyle.None,
                BackColor = Color.White,
            };

            CarregarInformacoes();
            return painel;
        }

        private void CarregarInformacoes()
        {
            var agendamentos = dashBoardFuncionarios.ObterClientesDoDia();

            int y = 15;

            foreach (var ag in agendamentos)
            {
                Panel card = new Panel
                {
                    Size = new Size(510, 150),
                    Location = new Point(20, y),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10)
                };

                Label lblNome = new Label
                {
                    Text = $"👤 Cliente: {ag.NomeCliente}",
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Location = new Point(10, 10)
                };

                Label lblData = new Label
                {
                    Text = $"📅 Data: {ag.DataAgendamento:dd/MM/yyyy HH:mm}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(10, 40)
                };

                Label lblServico = new Label
                {
                    Text = $"💼 Serviço: {ag.Servicos}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(10, 65)
                };

                Label lblValor = new Label
                {
                    Text = $"💰 Valor: R$ {ag.Valor:N2}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(350, 65),
                    TextAlign = ContentAlignment.MiddleRight
                };

                Label lblSitPagamento = new Label
                {
                    Text = $"⚙️ Situação: {ag.Situacao}    💳 Pagamento: {ag.Pagamento}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(10, 95)
                };

                
                 if (!string.IsNullOrEmpty(ag.Pagamento) && ag.Pagamento.Equals("Pago", StringComparison.OrdinalIgnoreCase))
                    card.BackColor = Color.LightBlue;
                else
                    card.BackColor = Color.FromArgb(235, 245, 255);

                card.Controls.Add(lblNome);
                card.Controls.Add(lblData);
                card.Controls.Add(lblServico);
                card.Controls.Add(lblValor);
                card.Controls.Add(lblSitPagamento);

                painel.Controls.Add(card);

                y += card.Height + 16;
            }

            if (agendamentos == null || agendamentos.Count == 0)
            {
                Label lblVazio = new Label
                {
                    Text = "Nenhum agendamento encontrado para hoje.",
                    Font = new Font("Segoe UI", 16, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(40, 40)
                };
                painel.Controls.Add(lblVazio);
            }
        }
    }
}
