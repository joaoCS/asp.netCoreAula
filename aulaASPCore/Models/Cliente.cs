using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaASPCore.Models
{
    public class Cliente
    {
        public Cliente() { }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
    }
}
