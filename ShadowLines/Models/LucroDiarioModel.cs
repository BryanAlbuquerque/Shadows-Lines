using System;

namespace ShadowLines.Models
{
    internal class LucroDiarioModel
    {
        public int QuantidadeAgendamentos { get; set; }
        public decimal LucroTotal { get; set; }
        public int QuantidadePagos { get; set; }   
        public int QuantidadeFinalizados { get; set; }
    }
}
