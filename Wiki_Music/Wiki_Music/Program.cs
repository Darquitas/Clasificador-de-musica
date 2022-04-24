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
            char Indice;


            do
            {

                Console.WriteLine("|******************************************** Wiki Music ♫ *********|");
                Console.WriteLine("|*                                                                 *|");
                Console.WriteLine("|*                        ♫♫♫♫♫__♥♥♥__♫♫♫♫♫                        *|");
                Console.WriteLine("|*        Biemvenido a Wiki Music,¿En que te podemos ayudar?       *|");
                Console.WriteLine("|*                       ______ ♫ ♥ ♫ ______                       *|");
                Console.WriteLine("|*                                                                 *|");
                Console.WriteLine("|*               1.Buscar Genero de Musica                         *|");
                Console.WriteLine("|*               2.Buscar Artista                                  *|");
                Console.WriteLine("|*                                                                 *|");
                Console.WriteLine("|*               0.Salir                                           *|");
                Console.WriteLine("|*                                                                 *|");
                Console.WriteLine("|*                                                                 *|");
                Console.WriteLine("|******** Wiki Music ♫ *********************************************|");
                Console.WriteLine("\n");
                Console.WriteLine("Dime una Opción");

                do
                {
                    Indice = Console.ReadKey(true).KeyChar;
                }
                while ( Indice < '0' || Indice > '2' );
                
                switch( Indice)
                {
                    case '0':
                        {
                            Environment.Exit(0);
                        }
                        break;
                    case '1':
                        {
                            Console.WriteLine("|******************************************** Wiki Music ♫ *********|");
                            Console.WriteLine("|*                                                                 *|");
                            Console.WriteLine("|*                 1.Mostrar Genero                                *|");
                            Console.WriteLine("|*                 2.Añadir Genero                                 *|");
                            Console.WriteLine("|*                 3.Modidicar Genero                              *|");
                            Console.WriteLine("|*                 4.Eliminar Genero                               *|");
                            Console.WriteLine("|******** Wiki Music ♫ *********************************************|");

                            Indice = Console.ReadLine();
                            Console.Clear();

                            switch( Indice)
                            {
                                case '4':
                                    Console.WriteLine("Selecione genero a eliminar:");
                                    break;
                                default:
                                    break;
                            }


                            break;
                        }

                }
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
