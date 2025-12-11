using System;

namespace ShadowLines.Models
{
    internal class ServicoModel
    {
        public int ServicoID { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
