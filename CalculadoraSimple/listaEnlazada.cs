using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimple
{
    internal class listaEnlazada
    {
        public Nodo inicio;
        public Nodo actual;

        public void AgregarFinal(Nodo unNodo)
        {
            if (inicio == null)
            {
                inicio = unNodo;
                actual = unNodo;
            }
            else
            {
                unNodo.anterior = actual;
                actual.siguiente = unNodo;
                actual = unNodo;
            }
        }
    }
}
