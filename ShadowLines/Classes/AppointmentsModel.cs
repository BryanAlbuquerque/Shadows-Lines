using System;

namespace ShadowLines.Classes
{
    internal class Agendamento
    {
        public int AgendamentoID { get; set; }
        public int ClienteID { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Servico { get; set; }
        public int FuncionarioID { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; }
        public string Pagamento { get; set; }
    }
}
