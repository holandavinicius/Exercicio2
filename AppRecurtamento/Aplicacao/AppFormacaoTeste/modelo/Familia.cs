using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFormacaoTeste.modelo
{
    public class Familia
    {
        public int Id { get; set; }
        public string NomeFamilia { get; set; }

        public Familia(int id, string nomeFamilia)
        {
            Id = id;
            NomeFamilia = nomeFamilia;
        }
    }
}
