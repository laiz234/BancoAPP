using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Numero { get; set; }
        public string Cliente { get; internal set; }

        public override string ToString()
        {
            return $"{Id} - {IdCliente} - {Numero} ";
        }
    }
}
