using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relacionamentos
{
    public class jogo
    {
        public string nome { get; set; }

        public string desenvolvedor { get; set; }

        public int lancamento { get; set; }

        public List<plataforma> plataformas { get; set; }
    }
}
