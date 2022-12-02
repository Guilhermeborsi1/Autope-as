using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autopeças.EF
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Carro { get; set; }
        public string Idade { get; set; }
        public string CPF_Nota { get; set; }
    }
}
