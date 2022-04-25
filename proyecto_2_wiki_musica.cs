using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Wiki_Musica
{
    class Programa_usuario

    {
        public struct usuario
        {
            public String nombre_usuario;
            public String email_usuario;
            public DateTime fecha_nacimiento;
            public String genero;
            public string Genero_Musical;
            public string Artista
                    ;



        }


        enum genero { masculino, fenemino }
        enum Estadocuenta { activo, inactivo, eliminado }
        enum Genero_Musical { Reggaeton, Merengue, Bachata, Rock, Parrandera }


        const int tope = 3;
        static usuario[] lista = new usuario[tope];
        static int contador = 0;
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu()
        {
            int opcion; ;
            Console.WriteLine("***Menú de Opciones***");
            Console.WriteLine("1. Ingrese datos del usuario");
            Console.WriteLine("2. Eliminar");
            Console.WriteLine("3. Modificar");
            Console.WriteLine("4. Salir");
            do
            {
                Console.WriteLine("Ingrese la Opción: ");
                opcion = int.Parse(Console.ReadLine());
                if (opcion <= 0 || opcion >= 5)
                {
                    Console.WriteLine("Ingrese una opcion validad");
                }


            } while (opcion > 4);
            switch (opcion)
            {
                case 1: ingresardatos(); break;
                case 2: eliminardatos(); break;
                case 3: modificardatos(); break;

            }


        }


        public static void ingresardatos()
        {

            //lista = new usuario [tope];
            for (int i = contador; i <= tope; i++)
            {
                Console.WriteLine("Ingreso datos del usuario " + (i + 1));

                Console.WriteLine("Ingrese el nombre: ");
                lista[i].nombre_usuario = Console.ReadLine();

                Console.WriteLine("Ingrese el email: ");
                lista[i].email_usuario = Console.ReadLine();

                Console.WriteLine("Ingrese la fecha de nacimiento: ");
                lista[i].fecha_nacimiento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Genero Musical Favorito: ");
                lista[i].Genero_Musical = seleccionarGenero_Musical();

                //Console.WriteLine(" Estado de cuenta :");

                contador++;

                if (contador > tope)
                {
                    Console.WriteLine("Valor maximo para ingresar alcanzado");
                    break;
                }




            }

            menu();


        }

        public static void eliminardatos()
        {
            string dato = "";

            Console.WriteLine("Ingrese nombre a eliminar");
            dato = Console.ReadLine();

            for (int i = 0; i < dato.Length; i++)
            {
                if (lista[i].nombre_usuario.Equals(dato))
                    lista[i].email_usuario.ToString();
                else
                    Console.WriteLine("El nombre no existe");

            }

            menu();


        }
        public static void modificardatos()
        {
            string respuesta = "";
            string nvnombre, nvemail, nvgenero;
            int nuevodato = 0;
            do
            {
                Console.WriteLine("Desea modficar los datos del usuario");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();

                if (respuesta.Equals("SI"))
                {
                    if (nuevodato >= 0 && nuevodato < lista.Length)
                    {
                        Console.WriteLine("Ingrese el nuevo nombre: " + lista[nuevodato].nombre_usuario);
                        nvnombre = Console.ReadLine();
                        lista[nuevodato].nombre_usuario = nvnombre;
                        Console.WriteLine("Ingrese el nuevo email: " + lista[nuevodato].email_usuario);
                        nvemail = Console.ReadLine();
                        lista[nuevodato].email_usuario = nvemail;
                        Console.WriteLine("Ingrese el nuevo genero: " + lista[nuevodato].genero);
                        nvgenero = Console.ReadLine();
                        lista[nuevodato].genero = nvgenero;
                    }
                    else if (respuesta.Equals("No"))
                    {
                        Console.WriteLine("Aceptado");
                    }



                }

            } while (respuesta.Equals("SI"));
            menu();


        }

        public static string seleccionarGenero_Musical()
        {
            int opcion = 0;
            string Gen_musical = "";

            Console.WriteLine("Seleccione : 1. -Reggaeton   2. -Merengue    3. -Bachata    4. -Rock    5. -Parrandera");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Gen_musical = Genero_Musical.Reggaeton.ToString();
                Console.WriteLine("Seleccione un artista : 1. Bad Bunny   2. -Ozuna     3. - JBalvin    4. -Blessd      5. -Feid     6. - Ryan Castro    7. -Kevin Roldan");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                    Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                    opcion = int.Parse(Console.ReadLine());
                }
                if (opcion == 2)
                {
                    Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                    Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                    opcion = int.Parse(Console.ReadLine());
                }
                if (opcion == 3)
                {
                    Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                    Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                    opcion = int.Parse(Console.ReadLine());
                if (opcion == 4)
                {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                }
                if (opcion == 5)
                {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                }
                if (opcion == 6)
                {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                    }

                if (opcion == 7)
                {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                }
            }
        }
            
            else if (opcion == 2)
            {
                Gen_musical = Genero_Musical.Merengue.ToString();
                Console.WriteLine("Seleccione un artista : 1. Juan Luis Guerra   2. -Sergio Vargas     3. - Johnny Ventura    4. -Eddy Herrera      5. -Wilfrido Vargas ");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                    Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                    opcion = int.Parse(Console.ReadLine());
                }
                if (opcion == 2)
                {
                    Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                    Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                    opcion = int.Parse(Console.ReadLine());
                }
                if (opcion == 3)
                {
                    Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                    Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                    opcion = int.Parse(Console.ReadLine());
                }
                if (opcion == 4)
                {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                }
                if (opcion == 5)
                {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                }



                }
            else if (opcion == 3)
            {
                Gen_musical = Genero_Musical.Bachata.ToString();
                Console.WriteLine("Seleccione un artista : 1.   Romeo Santos   2. -Aventura     3. - Juan Luis Guerra    4. -Prince Royce      5. -Luis Vargas ");
                opcion = int.Parse(Console.ReadLine());
                    if (opcion == 1)
                    {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                    }
                    if (opcion == 2)
                    {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                    }
                    if (opcion == 3)
                    {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                    }
                    if (opcion == 4)
                    {
                            Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                            Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                            opcion = int.Parse(Console.ReadLine());
                    }
                    if (opcion == 5)
                    {
                        Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                        Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                        opcion = int.Parse(Console.ReadLine());
                    }

            }
            else if (opcion == 4)
            {
                Gen_musical = Genero_Musical.Rock.ToString();
                Console.WriteLine("Seleccione un artista : 1.   Wos   2. -Mettallica     3. - AC/DC    4. -Slipknot      5. - The Beatles    6. -Queen    7.- Pink Floyd  ");
                opcion = int.Parse(Console.ReadLine());
                        if (opcion == 1)
                        {
                            Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                            Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                            opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 2)
                        {
                            Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                            Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                            opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 3)
                        {
                            Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                            Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                            opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 4)
                        {
                                Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                                Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                                opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 5)
                        {
                                Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                                Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                                opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 6)
                        { 
                                Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                                Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                                opcion = int.Parse(Console.ReadLine());
                        }

                        if (opcion == 7)
                        {
                                Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                                Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                                opcion = int.Parse(Console.ReadLine());
                        }

            }
            else if (opcion == 5)
            {
                Gen_musical = Genero_Musical.Parrandera.ToString();
                Console.WriteLine("Seleccione un artista : 1.   Rodolfo Aicardi   2. -Pastor Lopez     3. - Dario Gomez    4. -Alzate      5. -Octavio Mesa    6. -Alfredo Gutierrez");
                opcion = int.Parse(Console.ReadLine());
                        if (opcion == 1)
                        {
                            Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                            Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                            opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 2)
                        {
                            Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                            Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                            opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 3)
                        {
                            Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                            Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                            opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 4)
                        {
                                Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                                Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                                opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 5)
                        {
                                Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                                Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                                opcion = int.Parse(Console.ReadLine());
                        }
                        if (opcion == 6)
                        {
                                Gen_musical = Genero_Musical.Reggaeton.ToString().ToUpper();
                                Console.WriteLine("Seleccione que quiere saber del artista : 1- De donde es?   2- Cancion mas popular    3- Cuantos años tiene?  ");
                                opcion = int.Parse(Console.ReadLine());
                        }

                        }
            return Gen_musical;

        }


    }}

}