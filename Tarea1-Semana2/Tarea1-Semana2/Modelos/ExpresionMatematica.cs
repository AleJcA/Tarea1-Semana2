using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarea1_Semana2.Modelos
{
    public class ExpresionMatematica
    {
       public double numero1 { get; set; }
       public double numero2 { get; set; }

        public double suma, resta, div, multi, max, min;

        public double Suma()
        {
            suma = numero1 + numero2;

            return suma;
        }

        public double Resta()
        {
            resta = numero1 - numero2;

            return resta;
        }

        public double Divison()
        {
            div = numero1 / numero2;

            return div;
        }

        public double Multiplicacion()
        {
            multi = numero1 * numero2;

            return multi;
        }

        public void Maximo()
        {
            if (numero1 > numero2)
            {
                Console.WriteLine(max = numero1);
            }if(numero2 > numero1)
            {
                Console.WriteLine(max = numero2);
            }
        }

        public void Minimo()
        {
            if (numero1 < numero2)
            {
                Console.WriteLine(min = numero1);
            }if (numero2 < numero1)
            {
                Console.WriteLine(min = numero2);
            }
        }
        public string toString()
        {
            return $"Suma:  {suma}" +
                   $" Resta: {resta}" +
                   $" Division: {div}" +
                   $" Multiplicacion: {multi}" +
                   $" Maximo: {max}" +
                   $" Minimo: {min}";


        }
    }
}
