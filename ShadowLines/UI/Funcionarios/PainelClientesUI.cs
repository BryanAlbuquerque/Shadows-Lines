using ShadowLines.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines.UI
{
    internal class PainelClientesUI
    {
        private DashBoardFuncionarios dashBoardFuncionarios;
        private Label quantidade;  

        public PainelClientesUI()
        {
            dashBoardFuncionarios = new DashBoardFuncionarios();
        }

        public Panel CriarPainel()
        {
            CardUI panel = new CardUI { Size = new Size(300, 120), Location = new Point(300, 130) };
            Label titulo = new Label
            {
                Text = "Clientes de Hoje",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(40, 40, 40),
                Location = new Point(10, 10)
            };

            quantidade = new Label  
            {
                Text = dashBoardFuncionarios.ObterTotalAgendamentosHoje().ToString(),
                Font = new Font("Segoe UI", 27, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.YellowGreen,
                Location = new Point(10, 40)
            };

            Label descricao = new Label
            {
                Text = "Agendamentos do dia",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                AutoSize = true,
                ForeColor = Color.Gray,
                Location = new Point(10, 90)
            };

            panel.Controls.Add(titulo);
            panel.Controls.Add(quantidade);
            panel.Controls.Add(descricao);
            return panel;
        }

        // Novo método para atualizar o painel
        public void AtualizarPainel()
        {
            if (quantidade != null)
            {
                quantidade.Text = dashBoardFuncionarios.ObterTotalAgendamentosHoje().ToString();
            }
        }
    }
}