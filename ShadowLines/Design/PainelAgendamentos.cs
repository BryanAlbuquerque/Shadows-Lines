using System;
using System.Drawing;
using System.Windows.Forms;
using ShadowLines.Classes;
using System.Collections.Generic;

namespace ShadowLines.Design
{
    internal class PainelAgendamentos
    {
        private Panel painel;
        private AgendamentoData agendamentoData;

        public PainelAgendamentos()
        {
            agendamentoData = new AgendamentoData();
        }

        public Panel CriarPainel()
        {
            painel = new Panel
            {
                Location = new Point(250, 100),
                Size = new Size(600, 400),
                BackColor = Color.WhiteSmoke,
                AutoScroll = true
            };

            CarregarInformacoes();
            return painel;
        }

        private void CarregarInformacoes()
        {
            List<Agendamento> agendamentos = agendamentoData.ObterAgendamentosDoDia();

            int y = 10;
            foreach (Agendamento ag in agendamentos)
            {
                Label lblInfo = new Label
                {
                    AutoSize = false,
                    Size = new Size(580, 70),
                    Location = new Point(10, y),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(8),
                    Text =
                        $"🧍 Cliente: {ag.NomeCliente}\n" +
                        $"🗓 Data: {ag.DataAgendamento:dd/MM/yyyy HH:mm}\n" +
                        $"💼 Serviço: {ag.Servico} | 💰 Valor: R${ag.Valor}\n" +
                        $"⚙️ Situação: {ag.Situacao} | 💳 Pagamento: {ag.Pagamento}"
                };

                // cores diferentes conforme status
                if (ag.Situacao == "Cancelado")
                    lblInfo.BackColor = Color.LightCoral;
                else if (ag.Pagamento == "Pago")
                    lblInfo.BackColor = Color.LightGreen;
                else
                    lblInfo.BackColor = Color.LightYellow;

                painel.Controls.Add(lblInfo);
                y += 80;
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
