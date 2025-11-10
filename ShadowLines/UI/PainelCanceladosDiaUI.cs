using System.Drawing;
using System.Windows.Forms;
using ShadowLines.Classes;

namespace ShadowLines.Design
{
    internal class PainelCanceladosDiaUI
    {
        private Dashboard dashboard;

        public PainelCanceladosDiaUI()
        {
            dashboard = new Dashboard();
        }

        public Panel CriarPainel()
        {
            Panel panel = new Panel
            {
                Size = new Size(250, 120),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15)
            };

            Label titulo = new Label
            {
                Text = "Cancelados Hoje",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(40, 40, 40),
                Location = new Point(10, 10)
            };

            Label valor = new Label
            {
                Text = dashboard.ObterAgendamentosCanceladosHoje().ToString(),
                Font = new Font("Segoe UI", 27, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.Red,
                Location = new Point(10, 40)
            };

            Label descricao = new Label
            {
                Text = "Agendamentos cancelados hoje",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                AutoSize = true,
                ForeColor = Color.Gray,
                Location = new Point(10, 90)
            };

            panel.Controls.Add(titulo);
            panel.Controls.Add(valor);
            panel.Controls.Add(descricao);

            return panel;
        }
    }
}
