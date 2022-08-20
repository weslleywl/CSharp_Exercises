using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relacionamentos
{
    public class plataforma
    {
        public bool ps4 { get; set; }

        public bool xboxone { get; set; }

        public bool xbox360 { get; set; }

        public bool ps3 { get; set; }

        public bool pc { get; set; }

        public List<jogo> jogos { get; set; }
    }
}
