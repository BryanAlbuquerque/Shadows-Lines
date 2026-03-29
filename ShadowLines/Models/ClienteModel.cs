using System;

namespace ShadowLines.Models
{
    internal class ClienteModel
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public long Telefone { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
