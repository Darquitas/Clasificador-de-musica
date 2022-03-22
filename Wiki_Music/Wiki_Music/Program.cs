using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki_Music
{
    class Program
    {
        static void Main(string[] args)
        {
            string Continuar;



            do
            {
                Console.WriteLine("------------------------");
                Console.Write("¿Desea  Seguir buscando? y/n");
                Continuar = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

            }
            while (Continuar != "n");
        }
    }
}
