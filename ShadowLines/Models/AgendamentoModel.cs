using System;

namespace ShadowLines.Models
{
    public class AgendamentoModel
    {
        public int AgendamentoID { get; set; }
        public int ClienteID { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Servicos { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; }
        public string Pagamento { get; set; }
        public string NomeCliente { get; set; } // Nome do cliente da tabela Clientes
        public string NomeFuncionario { get; set; } // Nome do funcionário da tabela Funcionarios
    }
}
