using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using ShadowLines.Classes;

namespace ShadowLines.Design
{
    internal class PainelAgendamentos
    {
        private Panel painel;
        private CarrergarAgendamentos dadosAgendamentos;

        public PainelAgendamentos()
        {
            dadosAgendamentos = new CarrergarAgendamentos();
        }

        public Panel CriarPainel()
        {
            painel = new Panel
            {
                Location = new Point(250, 100),
                Size = new Size(500, 500),
                AutoScroll = true,
                BorderStyle = BorderStyle.None,
                BackColor = Color.Transparent
            };

            CarregarInformacoes();
            return painel;
        }

        private void CarregarInformacoes()
        {
            List<Agendamentos> agendamentos = dadosAgendamentos.ObterAgendamentosDoDia();
            int y = 10;

            foreach (Agendamentos ag in agendamentos)
            {
                // Painel do agendamento
                Panel card = new Panel
                {
                    Size = new Size(460, 120),
                    Location = new Point(10, y),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10)
                };

                // Título (nome do cliente)
                Label lblNome = new Label
                {
                    Text = $"👤 Cliente: {ag.NomeCliente}",
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    AutoSize = true,
                    ForeColor = Color.FromArgb(30, 30, 30),
                    Location = new Point(10, 10)
                };

                // Data e horário
                Label lblData = new Label
                {
                    Text = $"🗓 Data: {ag.DataAgendamento:dd/MM/yyyy HH:mm}",
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    AutoSize = true,
                    Location = new Point(10, 40)
                };

                // Serviço e valor
                Label lblServico = new Label
                {
                    Text = $"💼 Serviço: {ag.Servico}   💰 Valor: R${ag.Valor:N2}",
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    AutoSize = true,
                    Location = new Point(10, 65)
                };

                // Situação e pagamento
                Label lblSituacao = new Label
                {
                    Text = $"⚙️ Situação: {ag.Situacao}   💳 Pagamento: {ag.Pagamento}",
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    AutoSize = true,
                    Location = new Point(10, 90)
                };

                // 🎨 Cor de fundo por status
                if (ag.Situacao == "Cancelado")
                    card.BackColor = Color.Red;
                else if (ag.Pagamento == "Pago")
                    card.BackColor = Color.YellowGreen;
                else
                    card.BackColor = Color.FromArgb(255, 250, 235);

                // Adiciona tudo ao painel do card
                card.Controls.Add(lblNome);
                card.Controls.Add(lblData);
                card.Controls.Add(lblServico);
                card.Controls.Add(lblSituacao);

                // Adiciona ao painel principal
                painel.Controls.Add(card);

                y += card.Height + 10;
            }

            // Caso não haja agendamentos
            if (agendamentos.Count == 0)
            {
                Label lblVazio = new Label
                {
                    Text = "Nenhum agendamento para hoje.",
                    Font = new Font("Segoe UI", 16, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                painel.Controls.Add(lblVazio);
            }
        }
    }
}
