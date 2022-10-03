using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_grupo_19

{ // NUESTRO NOMBRE DE GRUPO 19 ES PROGRAMADORES
    internal class Nodo
    {

        public string Pcodigo, Pnombre;
        public double Pprecio, Pstock, Pimporte;
        private Nodo siguiente;
        internal Nodo Siguiente
        {
            get => siguiente; set => siguiente = value;
        }
        public Nodo(string Pcod, string Pnom, double Ppre, double Pstk)
        {
            Pcodigo = Pcod;
           Pnombre = Pnom;
            Pprecio = Ppre;
            Pstock = Pstk;
           Pimporte = Ppre * Pstk;
            siguiente = null;
        }
    }
}
