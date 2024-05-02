using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimple
{
    internal class Calcular
    {
        public String cadena { get; set; }
        public listaEnlazada NumSim = new listaEnlazada();
        public void IngresarCadena(String C)
        {
            cadena = C;
        }
        public void MostrarCadena()
        {
            Console.WriteLine(cadena);
        }
        void CargarNodo(string s)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = s;
            NumSim.AgregarFinal(nuevo);
        }
        public string CalcularOperacion()
        {
            string def = "";
            bool error = false;
            for (int i = 0; i < cadena.Length; i++)
            {

                if (char.IsNumber(cadena[i]))
                {
                    def += cadena[i];
                }
                else if (cadena[i] == '/' || cadena[i] == '+' || cadena[i] == '-' || cadena[i] == '*')
                {
                    if (def.Length != 0)
                    {
                        CargarNodo(def);

                        CargarNodo(char.ToString(cadena[i]));
                        def = "";
                    }
                    else
                    {
                       
                        return "Error: no se puede poner dos simbolos juntos";
                        
                    }
                }
                else
                {

                    return "Error caracter no valido";
                    
                }


            }
            if (!error)
            {
                CargarNodo(def);
                return calculos();
            }else
            {
                return "Error";
            }


        }
        Nodo encontrarMD(Nodo unNodo)
        {

            Nodo aux = unNodo;
            while (unNodo != null)
            {
                if (unNodo.Nombre == "*" || unNodo.Nombre == "/")
                {
                    return unNodo;
                }

                unNodo = unNodo.siguiente;
            }

            return aux;
        }
        string calculos()
        {
            Nodo actual = NumSim.inicio;
            if (actual.siguiente == null)
            {
                return actual.Nombre;
            }
            while (actual != null)
            {
                actual = encontrarMD(actual);
                if (actual.Nombre == "*")
                {
                    if (actual.siguiente.Nombre == "")
                    {
                        return "Error le falta un numero a la derecha";
                    }
                    if(actual.anterior.Nombre == "")
                    {
                        return "Error le falto un numero a la izquierda";
                    }
                    int numero1 = int.Parse(actual.anterior.Nombre);
                    int numero2 = int.Parse(actual.siguiente.Nombre);

                    int resul = numero1 * numero2;

                    Nodo nuevo = new Nodo();
                    nuevo.Nombre = resul.ToString();
                    if (actual.anterior.anterior == null)
                    {
                        NumSim.inicio = nuevo;
                        if (actual.siguiente.siguiente == null)
                        {
                            Console.WriteLine("El resultado es: {0}", resul);
                            return resul.ToString();
                        }
                        else
                        {
                            nuevo.siguiente = actual.siguiente.siguiente;
                            actual.siguiente.siguiente.anterior = nuevo;
                        }
                    }
                    else
                    {
                        nuevo.anterior = actual.anterior.anterior;
                        actual.anterior.anterior.siguiente = nuevo;
                        if (actual.siguiente.siguiente != null)
                        {
                            nuevo.siguiente = actual.siguiente.siguiente;
                            actual.siguiente.siguiente.anterior = nuevo;
                        }
                    }
                    Recorrer(NumSim.inicio);
                    Console.WriteLine();
                    actual = NumSim.inicio;
                }
                else if (actual.Nombre == "/")
                {
                    if (actual.siguiente.Nombre == "")
                    {
                        return "Error le falta un numero a la derecha";
                    }
                    if (actual.anterior.Nombre == "")
                    {
                        return "Error le falto un numero a la izquierda";
                    }
                    int numero1 = int.Parse(actual.anterior.Nombre);
                    int numero2 = int.Parse(actual.siguiente.Nombre);
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Error no se pueda calcular");
                        return "Error: no se puede dividir entre 0";
                    }
                    int resul = numero1 / numero2;

                    Nodo nuevo = new Nodo();
                    nuevo.Nombre = resul.ToString();
                    if (actual.anterior.anterior == null)
                    {
                        NumSim.inicio = nuevo;
                        if (actual.siguiente.siguiente == null)
                        {
                            Console.WriteLine("El resultado es: {0}", resul);
                            return resul.ToString();
                        }
                        else
                        {
                            nuevo.siguiente = actual.siguiente.siguiente;
                            actual.siguiente.siguiente.anterior = nuevo;
                        }
                    }
                    else
                    {
                        nuevo.anterior = actual.anterior.anterior;
                        actual.anterior.anterior.siguiente = nuevo;
                        if (actual.siguiente.siguiente != null)
                        {
                            nuevo.siguiente = actual.siguiente.siguiente;
                            actual.siguiente.siguiente.anterior = nuevo;
                        }
                    }
                    Recorrer(NumSim.inicio);
                    Console.WriteLine();
                    actual = NumSim.inicio;
                }
                else if (actual.Nombre == "-")
                {
                    if (actual.siguiente.Nombre == "")
                    {
                        return "Error le falta un numero a la derecha";
                    }
                    if (actual.anterior.Nombre == "")
                    {
                        return "Error le falto un numero a la izquierda";
                    }
                    int numero1 = int.Parse(actual.anterior.Nombre);
                    int numero2 = int.Parse(actual.siguiente.Nombre);

                    int resul = numero1 - numero2;

                    Nodo nuevo = new Nodo();
                    nuevo.Nombre = resul.ToString();
                    if (actual.anterior.anterior == null)
                    {
                        NumSim.inicio = nuevo;
                        if (actual.siguiente.siguiente == null)
                        {
                            Console.WriteLine("El resultado es: {0}", resul);
                            return resul.ToString();
                        }
                        else
                        {
                            nuevo.siguiente = actual.siguiente.siguiente;
                            actual.siguiente.siguiente.anterior = nuevo;
                        }
                    }
                    else
                    {
                        nuevo.anterior = actual.anterior.anterior;
                        actual.anterior.anterior.siguiente = nuevo;
                        if (actual.siguiente.siguiente != null)
                        {
                            nuevo.siguiente = actual.siguiente.siguiente;
                            actual.siguiente.siguiente.anterior = nuevo;
                        }
                    }
                    Recorrer(NumSim.inicio);
                    Console.WriteLine();
                    actual = NumSim.inicio;
                }
                else if (actual.Nombre == "+")
                {
                    if (actual.siguiente.Nombre == "")
                    {
                        return "Error le falta un numero a la derecha";
                    }
                    if (actual.anterior.Nombre == "")
                    {
                        return "Error le falto un numero a la izquierda";
                    }
                    int numero1 = int.Parse(actual.anterior.Nombre);
                    int numero2 = int.Parse(actual.siguiente.Nombre);

                    int resul = numero1 + numero2;

                    Nodo nuevo = new Nodo();
                    nuevo.Nombre = resul.ToString();
                    if (actual.anterior.anterior == null)
                    {
                        NumSim.inicio = nuevo;
                        if (actual.siguiente.siguiente == null)
                        {
                            Console.WriteLine("El resultado es: {0}", resul);
                            return resul.ToString();
                        }
                        else
                        {
                            nuevo.siguiente = actual.siguiente.siguiente;
                            actual.siguiente.siguiente.anterior = nuevo;
                        }
                    }
                    else
                    {
                        nuevo.anterior = actual.anterior.anterior;
                        actual.anterior.anterior.siguiente = nuevo;
                        if (actual.siguiente.siguiente != null)
                        {
                            nuevo.siguiente = actual.siguiente.siguiente;
                            actual.siguiente.siguiente.anterior = nuevo;
                        }
                    }
                    Recorrer(NumSim.inicio);
                    Console.WriteLine();
                    actual = NumSim.inicio;
                }
                actual = actual.siguiente;
            }
            return "Error: fallo la formula";
        }
        void Recorrer(Nodo unNodo)
        {
            while (unNodo != null)
            {
                Console.Write(unNodo.Nombre);
                unNodo = unNodo.siguiente;

            }
        }
    }
}
