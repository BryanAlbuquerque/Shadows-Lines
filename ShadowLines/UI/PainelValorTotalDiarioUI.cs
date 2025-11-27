using System.Drawing;
using System.Windows.Forms;
using ShadowLines.Classes;

namespace ShadowLines.UI
{
    internal class PainelValorTotalDiarioUI
    {
        private Dashboard dashboard;

        public PainelValorTotalDiarioUI()
        {
            dashboard = new Dashboard();
        }

        public Panel CriarPainel()
        {
            CardUI panel = new CardUI
            {
                Size = new Size(250, 120),
                Location = new Point(910, 130),
            };

            Label titulo = new Label
            {
                Text = "Valor Total",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(40, 40, 40),
                Location = new Point(10, 10)
            };

            Label valor = new Label
            {
                Text = dashboard.ObterValorTotalAgendamentosHoje().ToString("C2"),
                Font = new Font("Segoe UI", 27, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(80, 60, 200),
                Location = new Point(10, 40)
            };

            Label descricao = new Label
            {
                Text = "Valor total estimado de faturamento hoje",
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
