using System;
using System.Drawing;
using System.Windows.Forms;
using ShadowLines.Classes;
using System.Globalization;
using System.Collections.Generic;

namespace ShadowLines.Design
{
    internal class PainelAgendamentos
    {
        private Panel painel;
        private AgendamentosDiarios agendamentoData;

        public PainelAgendamentos()
        {
            agendamentoData = new AgendamentosDiarios();
        }

        public Panel CriarPainel()
        {
            painel = new Panel
            {
                Location = new Point(250, 80),
                Size = new Size(600, 400),
                BackColor = Color.White,
                AutoScroll = true
            };

            CarregarInformacoes();
            return painel;
        }

        private void CarregarInformacoes()
        {
            List<Agendamento> agendamentos = AgendamentosDiarios.ObterAgendamentosDoDia();

            int y = 10;
            foreach (Agendamento ag in agendamentos)
            {
                Label lblInfo = new Label
                {
                    AutoSize = true,
                    MaximumSize = new Size(550, 0), // largura máxima, altura ajusta automaticamente
                    Location = new Point(10, y),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(8),
                    BackColor = Color.White,
                    Text =
                        $"🧍 Cliente: {ag.NomeCliente}\n" +
                        $"🗓 Data: {ag.DataAgendamento:dd/MM/yyyy HH:mm}\n" +
                        $"💼 Serviço: {ag.Servico} | 💰 Valor: R${ag.Valor}\n" +
                        $"⚙️ Situação: {ag.Situacao} | 💳 Pagamento: {ag.Pagamento.ToString(CultureInfo.InvariantCulture)}"
                };

                // cores diferentes conforme status
                if (ag.Situacao == "Cancelado")
                    lblInfo.BackColor = Color.Red;
                else if (ag.Pagamento == "Pago")
                    lblInfo.BackColor = Color.LightGreen;
                else
                    lblInfo.BackColor = Color.White;

                painel.Controls.Add(lblInfo);
                y += lblInfo.Height + 10; // adiciona espaço conforme a altura real do label
            }

            if (agendamentos.Count == 0)
            {
                Label lblVazio = new Label
                {
                    Text = "Nenhum agendamento para hoje.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                painel.Controls.Add(lblVazio);
            }
        

            if (agendamentos.Count == 0)
            {
                Label lblVazio = new Label
                {
                    Text = "Nenhum agendamento para hoje.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                painel.Controls.Add(lblVazio);
            }
        }
    }
}
