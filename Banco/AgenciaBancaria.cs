using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class AgenciaBancaria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} ";
        }
    }
}