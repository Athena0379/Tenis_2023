using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenis.Dall.model
{
    public class Jogador
    {
        public int cod { get; set; }

        public string nome { get; set; }

        public string nick { get; set; }

        public string senha { get; set; }

        public List<Campeonato> campeonatos { get; set; }

    }
}