using System;

namespace ShadowLines.Models
{
    internal class FuncionarioModel
    {
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cargo { get; set; }
        public int NivelAcesso { get; set; }
    }
}
