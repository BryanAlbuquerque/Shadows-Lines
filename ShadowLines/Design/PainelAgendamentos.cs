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
                Size = new Size(500, 400),
                BackColor = Color.White,
                AutoScroll = true,
                BorderStyle = BorderStyle.Fixed3D
            };

            CarregarInformacoes();
            return painel;
        }

        private void CarregarInformacoes()
        {
            // ✅ Chama o método pelo objeto da classe, não pelo nome da classe
            List<Agendamentos> agendamentos = dadosAgendamentos.ObterAgendamentosDoDia();

            int y = 10;

            foreach (Agendamentos ag in agendamentos)
            {
                Label lblInfo = new Label
                {
                    AutoSize = true,
                    MaximumSize = new Size(550, 0),
                    Location = new Point(10, y),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(8),
                    Text =
                        $"🧍 Cliente: {ag.NomeCliente}\n" +
                        $"🗓 Data: {ag.DataAgendamento:dd/MM/yyyy HH:mm}\n" +
                        $"💼 Serviço: {ag.Servico} | 💰 Valor: R${ag.Valor:N2}\n" +
                        $"⚙️ Situação: {ag.Situacao} | 💳 Pagamento: {ag.Pagamento}"
                };

                // 🎨 Cores diferentes conforme status
                if (ag.Situacao == "Cancelado")
                    lblInfo.BackColor = Color.LightCoral;
                else if (ag.Pagamento == "Pago")
                    lblInfo.BackColor = Color.LightGreen;
                else
                    lblInfo.BackColor = Color.LightYellow;

                painel.Controls.Add(lblInfo);
                y += lblInfo.Height + 10;
            }

            // caso não haja agendamentos
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
