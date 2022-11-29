using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autopeças.EF
{
    public class Peca
    {
        public int Id { get; set; }
        public string NomePeça { get; set; }
        public string Categoria { get; set; }
        public int Valor { get; set; }
    }
}
