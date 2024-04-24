using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int sumaTotalValoresParesMayoresAOcho = 0;
            int sumaTotalValoresParesMenoresAOcho = 0;

            Console.WriteLine("Codigo corregido: ");
            foreach (var valor in valores)                      //Creo que cumplí en disminuir la complejidad cognitiva...
            {
                if (valor % 2 == 0 && valor > 8)
                {
                    sumaTotalValoresParesMayoresAOcho += valor; //El codigo original tenia un error en el operador de asignación compuesto "+="
                }                                               //Estaba usando =+ en su lugar
                else if (valor % 2 == 0 && valor < 8)
                {
                    sumaTotalValoresParesMenoresAOcho += valor;
                }
            }

            Console.WriteLine($"La suma total de los valores pares mayores a ocho es: {sumaTotalValoresParesMayoresAOcho}");
            Console.WriteLine($"La suma total de los valores pares menores a ocho es: {sumaTotalValoresParesMenoresAOcho}");

            //----------------------------------------------------------------------------------------------------------------

            //   CON LINQ:
            Console.WriteLine("\nCon LinQ: ");
            var mayoresAOcho = valores.Where(x => x % 2 == 0 && x > 8).Sum();
            Console.WriteLine("La suma total de los valores pares mayores a ocho es: " + mayoresAOcho);
            var menoresAOcho = valores.Where(x => x % 2 == 0 && x < 8).Sum();
            Console.WriteLine("La suma total de los valores pares menores a ocho es: " + menoresAOcho);
        }
    }
}
