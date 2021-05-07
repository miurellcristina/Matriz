using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que muestra el uso de arreglos en dos dimenciones o matrices
            //Variable de control para ciclo for
            int n=0, m=0;
            double sumatoria = 0, promedio = 0.0;

            //Variable random
            Random rnd = new Random();

            int[,] datos = new int[4, 7];

            for (n=0; n<4; n++)// avanza al siguiente renglon
            {
                for (m = 0; m < 4; m++)
                {
                    //para llevar a  cabo la asignacion (nombre matriz, indice fy c y el valor)
                    datos[n, m] = rnd.Next(30);
                }
            }
            //imprimir datos
            for (n = 0; n < 4; n++)
            {
                Console.WriteLine("\n\n\nSemana {0}", n);
                for (m = 0; m < 7; m++)
                {
                    Console.Write("{0}  ", datos[n, m]);
                }
                
            }
            //calcular promedio
            Console.WriteLine("\n");
            for (n = 0; n < 4; n++)
            {
                sumatoria = 0.0;
                promedio = 0.0;
                for(m=0; m<7; m++)
                {
                    sumatoria += datos[n, m];
                }
                promedio = sumatoria / 7.0;
                Console.WriteLine("\n\nEl promedio de la semana {0} es {1}", n, promedio);
            }

            //calcular promedio general
            Console.WriteLine("\n");
            for (n = 0; n < 4; n++)
            {
                for (m = 0; m < 7; m++)
                {
                    sumatoria += datos[n, m];
                }
                
            }
            promedio = sumatoria / 28.0;
            Console.WriteLine("\n\nEl promedio general es {0}", sumatoria);
            Console.WriteLine("\n\nEl promedio general es {0}", promedio);
            Console.ReadKey();
        }
    }
}
