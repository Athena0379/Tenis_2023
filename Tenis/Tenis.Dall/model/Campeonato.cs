using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenis.Dall.model
{
    public class Campeonato
    {
        public int cod { get; set; }

        public string nome { get; set; }

        public DateTime data { get; set; }

        public List<Jogador> Jogadores { get; set; }
    }
}