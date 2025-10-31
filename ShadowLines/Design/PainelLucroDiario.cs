using ShadowLines.Classes;
using ShadowLines.Models;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines.Design
{
    internal class PainelLucroDiario
    {
        private Panel painel;
        private LucroDiario LucroDiario;

        public Panel CriarPainel()
        {
            painel = new Panel
            {
                Location = new Point(500, 150),
                Size = new Size(100, 100),
                BackColor = Color.White,
                BorderStyle = BorderStyle.Fixed3D
            };

            //CarregarInformacoes();
            return painel;
        }
    }
}
