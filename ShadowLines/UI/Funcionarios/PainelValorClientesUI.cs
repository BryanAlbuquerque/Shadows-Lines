using ShadowLines.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines.UI
{
    internal class PainelValorClientesUI
    {
        private DashBoardFuncionarios dashBoardFuncionarios;
        private Label quantidade;
        public PainelValorClientesUI()
        {
            dashBoardFuncionarios = new DashBoardFuncionarios();
        }

        public Panel CriarPainel()
        {
            CardUI panel = new CardUI { Size = new Size(300, 120), Location = new Point(650, 130) };

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
                Text = dashBoardFuncionarios.ObterValorTotalAgendamentosHojeFuncionario(SessaoUsuarioModel.FuncionarioID).ToString("C"),
                Font = new Font("Segoe UI", 27, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.Navy,
                Location = new Point(10, 40)
            };

            Label descricao = new Label
            {
                Text = "Valor total de Hoje",
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
