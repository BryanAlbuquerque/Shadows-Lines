using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
