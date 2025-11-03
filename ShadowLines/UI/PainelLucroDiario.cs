using ShadowLines.Classes;
using ShadowLines.Models;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines.Design
{
    internal class PainelLucroDiario
    {
        private Panel painel;
        private readonly LucroDiario lucroDiarioService = new LucroDiario();

        public Panel CriarPainel()
        {
            painel = new Panel
            {
                Location = new Point(750, 100),
                Size = new Size(350, 200),
                BackColor = Color.FromArgb(240, 248, 255),
                BorderStyle = BorderStyle.None,
            };

            // Carregar as informações do banco
            CarregarInformacoes();

            return painel;
        }

        private void CarregarInformacoes()
        {
            LucroDiarioModel dados = lucroDiarioService.ObterLucroDiario();

            int y = 15;
            int espacamento = 35;

            Label lblTitulo = new Label
            {
                Text = "📊 Lucro Diário Total Estimado:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, y),
                AutoSize = true
            };
            painel.Controls.Add(lblTitulo);
            y += espacamento;

            Label lblLucro = new Label
            {
                Text = $"💵 R$ {dados.LucroTotal:N2}",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Location = new Point(20, y),
                AutoSize = true
            };
            painel.Controls.Add(lblLucro);
            y += espacamento;

            Label lblAgendamentos = new Label
            {
                Text = $"📅 Agendamentos do Dia: {dados.QuantidadeAgendamentos}",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                Location = new Point(10, y),
                AutoSize = true
            };
            painel.Controls.Add(lblAgendamentos);
            y += espacamento;

            Label lblPagos = new Label
            {
                Text = $"✅ Já Pagos ou Finalizados: {dados.QuantidadePagos}",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                Location = new Point(10, y),
                AutoSize = true
            };
            painel.Controls.Add(lblPagos);
        }
    }
}
