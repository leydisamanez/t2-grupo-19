using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t2_grupo_19
{
    internal class Lista
    {
        Nodo Pprimero;
        public Nodo Praiz;
        public Lista()
        {
            Pprimero = null;
        }
        public void insertar(string Pcodigo, string Pnombre, double Pprecio, double
       Pstock)
        {
            if (Pprimero == null)
            {
                Pprimero = new Nodo(Pcodigo, Pnombre, Pprecio, Pstock);
                Praiz = Pprimero;
            }
            else
            {
                Nodo nuevo = new Nodo(Pcodigo, Pnombre, Pprecio, Pstock);
                Pprimero.Siguiente = nuevo;
                Pprimero = nuevo;
            }
        }
        public void desplegar(DataGridView data)
        {
            Nodo actual;
            actual = Praiz;
            data.Rows.Clear();
            while (actual != null)
            {
                data.Rows.Add(actual.Pcodigo, actual.Pnombre, actual.Pprecio,
                actual.Pstock, actual.Pimporte);
                actual = actual.Siguiente;
            }
        }
        public void buscar(string nom, DataGridView data)
        {
            Nodo actual = Praiz;
            while (actual.Pnombre != nom)
                actual = actual.Siguiente;
            data.Rows.Clear();
            data.Rows.Add(actual.Pcodigo, actual.Pnombre, actual.Pprecio,
            actual.Pstock, actual.Pimporte);
        }
        public void eliminar(string Pcod)
        {
            Nodo Pactual, Panterior;
            bool Pencontrado = false;
            Pactual = Praiz;
            Panterior = null;
            while (Pactual != null && !Pencontrado)
            {
                Pencontrado = (Pactual.Pcodigo == Pcod);
                if (!Pencontrado)
                {
                    Panterior = Pactual;
                    Pactual = Pactual.Siguiente;
                }
            }
            if (Pactual != null)
            {
                if (Pactual == Praiz)
                {
                    Praiz = Pactual.Siguiente;
                }
                else
                {
                    Panterior.Siguiente = Pactual.Siguiente;
                }
                Pactual = null;






            }


        }


        }
    }
