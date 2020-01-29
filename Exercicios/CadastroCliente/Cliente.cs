using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    class Cliente
    {
        public float cpf;
        public float rg { get; set; }
        public string nome { get; set; }
        public int dataNascimento { get; set; }
        public float telefone { get; set; }
    }
}
