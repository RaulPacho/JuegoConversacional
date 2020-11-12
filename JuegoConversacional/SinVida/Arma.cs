using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoConversacional.SinVida
{
    class Arma
    {
        public string Nombre { get; set; }
        public string Ataque { get; set; }
        private int dano;

        public int Dano { get => dano; set => dano = (value > 100 || value < 1) ? 1 : value; }


    }
}
