using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenis.Dall.model
{
    public class Inscricao
    {
        public int cod { get; set; }

        public Jogador jogador { get; set; }

        public Campeonato campeonato { get; set; }
    }
}