using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenis.Dall.model
{
    public class Partida
    {
        public int cod { get; set; }

        public DateTime data { get; set; }

        public Campeonato campeonato { get; set; }

        public Jogador Jogador1 { get; set; }
        public Jogador Jogador2 { get; set; }
    }
}