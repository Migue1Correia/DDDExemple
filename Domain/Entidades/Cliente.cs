using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Cliente
    {
        public int ID { get; set; }

        public int Nome { get; set; }
        public string DataNacimento {  get; set; }
        
        public string NumeroCNH { get; set; }

        public int Estado { get; set; }

    }
}
