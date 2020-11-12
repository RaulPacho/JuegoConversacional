using JuegoConversacional.ConVida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoConversacional.SinVida
{
    class Habitacion
    {
        public string Nombre { get; set; }
        private List<Persona> ocupantes;
        private List<Arma> armas;
        private List<Tesoro> tesoros;
        private string descripcion;
        public string Descripcion { get => descripcion; set => descripcion = (ocupantes.Count == 0 &&
                                    armas.Count == 0 && tesoros.Count == 0) ? value + " Pues menuda mierda ¿no?" : value; }


    }
}
