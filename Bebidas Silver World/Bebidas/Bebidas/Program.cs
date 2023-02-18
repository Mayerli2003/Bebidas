using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            int DUI=0;
            //Esta string por que en el caso de que el usuario ingrese letras no de error
            string id;
            PersonaDatos datos= new PersonaDatos();
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("__________Bienbenido al sistema de Silver World__________\n");

                Console.WriteLine("           __________Eliga su rol__________");
                Console.WriteLine("\n1 - Cliente");
                Console.WriteLine("\n2 - Empleado");
                Console.WriteLine("\n3 - Salir");
                Console.WriteLine("----------------------------------------------------------");



                Console.WriteLine("\nIngrese el numero de su consulta");
                id = Console.ReadLine();

                switch (id)
                {
                    case "1":
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("------------------------Rol de Cliente-------------------------");

                            Console.WriteLine("\n1 - Comprar");
                            Console.WriteLine("\n2 - Lista de bebidas");
                            Console.WriteLine("\n3 - Salir");
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                   
                                    
                                    datos.DatosUsuario(datos.Nombre, datos.Apellido, datos.Edad);
                                    Console.WriteLine(datos.Mostrar());
                                    
                                    
                                    if (datos.Edad >= 18)
                                    {
                                        Console.WriteLine("Ingrese su DUI");
                                        DUI = int.Parse(Console.ReadLine());
                                        Console.WriteLine("DUI: " + DUI);
                                        Console.ReadLine();

                                        Console.WriteLine("El Cliente es mayor de Edad a continuacion estas son las Bebidas para ti");

                                       
                                        do
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("--------------------------------------------------------------");
                                            Console.WriteLine("__________Menu de bebidas__________\n");

                                            Console.WriteLine("           __________Bebidas alcoholicas__________");
                                            Console.WriteLine("\n1 - Margarita");
                                            Console.WriteLine("\n2 - Mojito");
                                            Console.WriteLine("\n3 - Manhattan");
                                            Console.WriteLine("\n4 - Piña colada");
                                            Console.WriteLine("\n5 - Daiquiri");
                                            Console.WriteLine("\n6 - Long Island");
                                            Console.WriteLine("\n7 - Bloody Mary");
                                            Console.WriteLine("\n8 - Mai Tai");
                                            Console.WriteLine("\n9 - Sidecar");
                                            Console.WriteLine("           __________Licuados__________");
                                            Console.WriteLine("\n10 - Tropical");
                                            Console.WriteLine("\n11 - Invernal");
                                            Console.WriteLine("\n12 - Clásico");
                                            Console.WriteLine("\n13 - Chocomilk clásico");
                                            Console.WriteLine("\n14 - Completo");
                                            Console.WriteLine("           __________Bebidas calientes e infusiones__________");
                                            Console.WriteLine("\n15 - Té Blanco");
                                            Console.WriteLine("\n16 - Té Rojo");
                                            Console.WriteLine("\n17 - Té negro de fresa");
                                            Console.WriteLine("\n18 - Manzanilla");
                                            Console.WriteLine("\n19 - Matcha Latte");
                                            Console.WriteLine("\n20 - Chocolate caliente");
                                            Console.WriteLine("\n21 - Café negro");
                                            Console.WriteLine("\n22 - Capuccino");
                                            

                                            Console.WriteLine("----------------------------------------------------------");
                                            Console.WriteLine("\n23 - Salir");


                                            Console.WriteLine("\nIngrese el numero de su consulta");
                                            id = Console.ReadLine();
                                            switch (id)
                                            {
                                                case "1":
                                                    break;


                                                case "2":
                                                    break;
                                                case "3":
                                                    break;
                                                case "4":
                                                    break;
                                                case "5":
                                                    break;
                                                case "6":
                                                    break;
                                                case "7":
                                                    break;
                                                case "8":
                                                    break;
                                                case "9":
                                                    break;
                                                case "10":
                                                    break;
                                                case "11":
                                                    break;
                                                case "12":
                                                    break;
                                                case "13":
                                                    break;
                                                case "14":
                                                    break;
                                                case "15":
                                                    break;
                                                case "16":
                                                    break;
                                                case "17":
                                                    break;
                                                case "18":
                                                    break;
                                                case "19":
                                                    break;
                                                case "20":
                                                    break;
                                                case "21":
                                                    break;
                                                case "22":
                                                    break;
                                                case "23":
                                                    Environment.Exit(0);
                                                    break;
                                                default:
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                                    Console.ReadKey();
                                                    break;

                                            }
                                        

                                        }
                                        while (id != "23");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El cliente no puede ordenanr nada de bebidas alcoholicas deseas que te muestre el menu infantil");
                                       
                                        do
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("--------------------------------------------------------------");
                                            Console.WriteLine("__________Menu de bebidas__________\n");

                                            Console.WriteLine("           __________Licuados__________");
                                            Console.WriteLine("\n10 - Tropical");
                                            Console.WriteLine("\n11 - Invernal");
                                            Console.WriteLine("\n12 - Clásico");
                                            Console.WriteLine("\n13 - Chocomilk clásico");
                                            Console.WriteLine("\n14 - Completo");
                                            Console.WriteLine("           __________Bebidas calientes e infusiones__________");
                                            Console.WriteLine("\n15 - Té Blanco");
                                            Console.WriteLine("\n16 - Té Rojo");
                                            Console.WriteLine("\n17 - Té negro de fresa");
                                            Console.WriteLine("\n18 - Manzanilla");
                                            Console.WriteLine("\n19 - Matcha Latte");
                                            Console.WriteLine("\n20 - Chocolate caliente");
                                            Console.WriteLine("\n21 - Café negro");
                                            Console.WriteLine("\n22 - Capuccino");
                                            

                                            Console.WriteLine("----------------------------------------------------------");
                                            Console.WriteLine("\n23 - Salir");


                                            Console.WriteLine("\nIngrese el numero de su consulta");
                                            id = Console.ReadLine();

                                            switch (id)
                                            {
                                                case "1":
                                                    break;


                                                case "2":
                                                    break;
                                                case "3":
                                                    break;
                                                case "4":
                                                    break;
                                                case "5":
                                                    break;
                                                case "6":
                                                    break;
                                                case "7":
                                                    break;
                                                case "8":
                                                    break;
                                                case "9":
                                                    break;
                                                case "10":
                                                    break;
                                                case "11":
                                                    break;
                                                case "12":
                                                    break;
                                                case "13":
                                                    break;
                                                case "14":
                                                    break;
                                                case "15":
                                                    break;
                                                case "16":
                                                    break;
                                                case "17":
                                                    break;
                                                case "18":
                                                    break;
                                                case "19":
                                                    break;
                                                case "20":
                                                    break;
                                                case "21":
                                                    break;
                                                case "22":
                                                    break;
                                                case "23":
                                                    Environment.Exit(0);
                                                    break;
                                                default:
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                                    Console.ReadKey();
                                                    break;

                                            }
                                        

                                        }
                                        while (id != "23");

                                    }
                                    Console.WriteLine("-------------------------------------");
                                    Console.ReadLine();

                                    break;

                                case "2":

                                   
                                    do
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("--------------------------------------------------------------");
                                        Console.WriteLine("__________Menu de bebidas__________\n");

                                        Console.WriteLine("           __________Bebidas alcoholicas__________");
                                        Console.WriteLine("\n1 - Margarita");
                                        Console.WriteLine("\n2 - Mojito");
                                        Console.WriteLine("\n3 - Manhattan");
                                        Console.WriteLine("\n4 - Piña colada");
                                        Console.WriteLine("\n5 - Daiquiri");
                                        Console.WriteLine("\n6 - Long Island");
                                        Console.WriteLine("\n7 - Bloody Mary");
                                        Console.WriteLine("\n8 - Mai Tai");
                                        Console.WriteLine("\n9 - Sidecar");
                                        Console.WriteLine("           __________Licuados__________");
                                        Console.WriteLine("\n10 - Tropical");
                                        Console.WriteLine("\n11 - Invernal");
                                        Console.WriteLine("\n12 - Clásico");
                                        Console.WriteLine("\n13 - Chocomilk clásico");
                                        Console.WriteLine("\n14 - Completo");
                                        Console.WriteLine("           __________Bebidas calientes e infusiones__________");
                                        Console.WriteLine("\n15 - Té Blanco");
                                        Console.WriteLine("\n16 - Té Rojo");
                                        Console.WriteLine("\n17 - Té negro de fresa");
                                        Console.WriteLine("\n18 - Manzanilla");
                                        Console.WriteLine("\n19 - Matcha Latte");
                                        Console.WriteLine("\n20 - Chocolate caliente");
                                        Console.WriteLine("\n21 - Café negro");
                                        Console.WriteLine("\n22 - Capuccino");
                                        

                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("\n23 - Salir");


                                        Console.WriteLine("\nIngrese el numero de la bebida para obtener mas información");
                                        id = Console.ReadLine();

                                        switch (id)
                                        {
                                            case "1":
                                                break;


                                            case "2":
                                                break;
                                            case "3":
                                                break;
                                            case "4":
                                                break;
                                            case "5":
                                                break;
                                            case "6":
                                                break;
                                            case "7":
                                                break;
                                            case "8":
                                                break;
                                            case "9":
                                                break;
                                            case "10":
                                                break;
                                            case "11":
                                                break;
                                            case "12":
                                                break;
                                            case "13":
                                                break;
                                            case "14":
                                                break;
                                            case "15":
                                                break;
                                            case "16":
                                                break;
                                            case "17":
                                                break;
                                            case "18":
                                                break;
                                            case "19":
                                                break;
                                            case "20":
                                                break;
                                            case "21":
                                                break;
                                            case "22":
                                                break;
                                            case "23":
                                                Environment.Exit(0);
                                                break;
                                            default:
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("La opcion que ha elegido no es correcta");
                                                Console.ReadKey();
                                                break;

                                        }
                                    

                                    }
                                    while (id != "23");
                                    break;

                                case "3":
                                    Environment.Exit(0);
                                    break;

                                default:
                                    
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                    Console.ReadKey();
                                    
                                    break;

                            }

                        }
                        while (id != "3");
                        {

                        }
                        
                        
                        
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case "2":
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("------------------------Rol de Empleado-------------------------");

                            Console.WriteLine("\n1 - Comprar");
                            Console.WriteLine("\n2 - Lista de bebidas");
                            Console.WriteLine("\n3 - Lista de empleados");
                            Console.WriteLine("\n4 - Calcular pago por horas de trabajo");
                            Console.WriteLine("\n5 - Salir");
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();

                            switch (id)
                            {
                                case "1":
                                
                                    if (datos.Edad >= 18)
                                    {


                                        Console.WriteLine("El Cliente es mayor de Edad a continuacion estas son las Bebidas para ti");


                                        do
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("--------------------------------------------------------------");
                                            Console.WriteLine("__________Menu de bebidas__________\n");

                                            Console.WriteLine("           __________Bebidas alcoholicas__________");
                                            Console.WriteLine("\n1 - Margarita");
                                            Console.WriteLine("\n2 - Mojito");
                                            Console.WriteLine("\n3 - Manhattan");
                                            Console.WriteLine("\n4 - Piña colada");
                                            Console.WriteLine("\n5 - Daiquiri");
                                            Console.WriteLine("\n6 - Long Island");
                                            Console.WriteLine("\n7 - Bloody Mary");
                                            Console.WriteLine("\n8 - Mai Tai");
                                            Console.WriteLine("\n9 - Sidecar");
                                            Console.WriteLine("           __________Licuados__________");
                                            Console.WriteLine("\n10 - Tropical");
                                            Console.WriteLine("\n11 - Invernal");
                                            Console.WriteLine("\n12 - Clásico");
                                            Console.WriteLine("\n13 - Chocomilk clásico");
                                            Console.WriteLine("\n14 - Completo");
                                            Console.WriteLine("           __________Bebidas calientes e infusiones__________");
                                            Console.WriteLine("\n15 - Té Blanco");
                                            Console.WriteLine("\n16 - Té Rojo");
                                            Console.WriteLine("\n17 - Té negro de fresa");
                                            Console.WriteLine("\n18 - Manzanilla");
                                            Console.WriteLine("\n19 - Matcha Latte");
                                            Console.WriteLine("\n20 - Chocolate caliente");
                                            Console.WriteLine("\n21 - Café negro");
                                            Console.WriteLine("\n22 - Capuccino");
                                            

                                            Console.WriteLine("----------------------------------------------------------");
                                            Console.WriteLine("\n23 - Café con leche");


                                            Console.WriteLine("\nIngrese el numero de su consulta");
                                            id = Console.ReadLine();
                                            switch (id)
                                            {
                                                case "1":
                                                    break;


                                                case "2":
                                                    break;
                                                case "3":
                                                    break;
                                                case "4":
                                                    break;
                                                case "5":
                                                    break;
                                                case "6":
                                                    break;
                                                case "7":
                                                    break;
                                                case "8":
                                                    break;
                                                case "9":
                                                    break;
                                                case "10":
                                                    break;
                                                case "11":
                                                    break;
                                                case "12":
                                                    break;
                                                case "13":
                                                    break;
                                                case "14":
                                                    break;
                                                case "15":
                                                    break;
                                                case "16":
                                                    break;
                                                case "17":
                                                    break;
                                                case "18":
                                                    break;
                                                case "19":
                                                    break;
                                                case "20":
                                                    break;
                                                case "21":
                                                    break;
                                                case "22":
                                                    break;
                                                case "23":
                                                    Environment.Exit(0);
                                                    break;
                                                default:
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                                    Console.ReadKey();
                                                    break;

                                            }
                                        }
                                        while (id != "23");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El cliente no puede ordenanr nada de bebidas alcoholicas deseas que te muestre el menu infantil");

                                        do
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("--------------------------------------------------------------");
                                            Console.WriteLine("__________Menu de bebidas__________\n");

                                            Console.WriteLine("           __________Licuados__________");
                                            Console.WriteLine("\n10 - Tropical");
                                            Console.WriteLine("\n11 - Invernal");
                                            Console.WriteLine("\n12 - Clásico");
                                            Console.WriteLine("\n13 - Chocomilk clásico");
                                            Console.WriteLine("\n14 - Completo");
                                            Console.WriteLine("           __________Bebidas calientes e infusiones__________");
                                            Console.WriteLine("\n15 - Té Blanco");
                                            Console.WriteLine("\n16 - Té Rojo");
                                            Console.WriteLine("\n17 - Té negro de fresa");
                                            Console.WriteLine("\n18 - Manzanilla");
                                            Console.WriteLine("\n19 - Matcha Latte");
                                            Console.WriteLine("\n20 - Chocolate caliente");
                                            Console.WriteLine("\n21 - Café negro");
                                            Console.WriteLine("\n22 - Capuccino");
                                            Console.WriteLine("\n22 - Café con leche");

                                            Console.WriteLine("----------------------------------------------------------");
                                            Console.WriteLine("\n23 - Café con leche");


                                            Console.WriteLine("\nIngrese el numero de su consulta");
                                            id = Console.ReadLine();
                                            switch (id)
                                            {
                                                case "1":
                                                    break;


                                                case "2":
                                                    break;
                                                case "3":
                                                    break;
                                                case "4":
                                                    break;
                                                case "5":
                                                    break;
                                                case "6":
                                                    break;
                                                case "7":
                                                    break;
                                                case "8":
                                                    break;
                                                case "9":
                                                    break;
                                                case "10":
                                                    break;
                                                case "11":
                                                    break;
                                                case "12":
                                                    break;
                                                case "13":
                                                    break;
                                                case "14":
                                                    break;
                                                case "15":
                                                    break;
                                                case "16":
                                                    break;
                                                case "17":
                                                    break;
                                                case "18":
                                                    break;
                                                case "19":
                                                    break;
                                                case "20":
                                                    break;
                                                case "21":
                                                    break;
                                                case "22":
                                                    break;
                                                case "23":
                                                    Environment.Exit(0);
                                                    break;
                                                default:
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                                    Console.ReadKey();
                                                    break;

                                            }

                                        }
                                        while (id != "23");

                                    }
                                    Console.WriteLine("-------------------------------------");
                                    Console.ReadLine();
                                    Console.ReadLine();

                                    break;

                                case "2":

                                    

                                    do
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("--------------------------------------------------------------");
                                        Console.WriteLine("__________Menu de bebidas__________\n");

                                        Console.WriteLine("           __________Bebidas alcoholicas__________");
                                        Console.WriteLine("\n1 - Margarita");
                                        Console.WriteLine("\n2 - Mojito");
                                        Console.WriteLine("\n3 - Manhattan");
                                        Console.WriteLine("\n4 - Piña colada");
                                        Console.WriteLine("\n5 - Daiquiri");
                                        Console.WriteLine("\n6 - Long Island");
                                        Console.WriteLine("\n7 - Bloody Mary");
                                        Console.WriteLine("\n8 - Mai Tai");
                                        Console.WriteLine("\n9 - Sidecar");
                                        Console.WriteLine("           __________Licuados__________");
                                        Console.WriteLine("\n10 - Tropical");
                                        Console.WriteLine("\n11 - Invernal");
                                        Console.WriteLine("\n12 - Clásico");
                                        Console.WriteLine("\n13 - Chocomilk clásico");
                                        Console.WriteLine("\n14 - Completo");
                                        Console.WriteLine("           __________Bebidas calientes e infusiones__________");
                                        Console.WriteLine("\n15 - Té Blanco");
                                        Console.WriteLine("\n16 - Té Rojo");
                                        Console.WriteLine("\n17 - Té negro de fresa");
                                        Console.WriteLine("\n18 - Manzanilla");
                                        Console.WriteLine("\n19 - Matcha Latte");
                                        Console.WriteLine("\n20 - Chocolate caliente");
                                        Console.WriteLine("\n21 - Café negro");
                                        Console.WriteLine("\n22 - Capuccino");
                                      

                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("\n23 - Salir");


                                        Console.WriteLine("\nIngrese el numero de su consulta");
                                        id = Console.ReadLine();

                                        switch (id)
                                        {
                                            case "1":
                                                break;

                                              
                                            case "2":
                                                break;
                                            case "3":
                                                break;
                                            case "4":
                                                break;
                                            case "5":
                                                break;
                                            case "6":
                                                break;
                                            case "7":
                                                break;
                                            case "8":
                                                break;
                                            case "9":
                                                break;
                                            case "10":
                                                break;
                                            case "11":
                                                break;
                                            case "12":
                                                break;
                                            case "13":
                                                break;
                                            case "14":
                                                break;
                                            case "15":
                                                break;
                                            case "16":
                                                break;
                                            case "17":
                                                break;
                                            case "18":
                                                break;
                                            case "19":
                                                break;
                                            case "20":
                                                break;
                                            case "21":
                                                break;
                                            case "22":
                                                break;
                                            case "23":
                                                Environment.Exit(0);
                                                break;
                                            default:
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("La opcion que ha elegido no es correcta");
                                                Console.ReadKey();
                                                break;

                                        }

                                    }
                                    while (id != "23");
                                    
                                    break;

                                case "3":
                                    empleado.Nombres();
                                    Console.ReadLine();
                                    
                                    break;

                                case "4":
                                    empleado.Sueldo();
                                    Console.ReadLine();
                                  
                                    break;

                                case "5":
                                    Environment.Exit(0);
                                    break;


                                default:
                                    
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                    Console.ReadKey();
                                    break;

                            }

                        }
                        while (id != "5");
                        {

                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":

                        Environment.Exit(0);
                        break;


                    default:
                       
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("La opcion que ha elegido no es correcta");
                        Console.ReadKey();
                        break;


                }

            }
            while (id!="3");
            {

            }
            Console.ReadLine();
        }
        abstract class Bebidas
        {
            //en tipo de bebida se escogera desde un menu donde se muestren las bebida calientes y heladas
            //bebidas alcohólicas, bebidas gaseosas, infusiones o zumos
            public abstract string tipo();

            //clasificacion de cada una de las bebidas mencionadas anteriormente
            public abstract string categoria();
            
            //preparacion de cada una de las categorias de bibidas
            public abstract string preparacion();

        }

        class alcoholicas : Bebidas
        {
            Empleado empleado= new Empleado();

            public override string categoria()
            {
                throw new NotImplementedException();
            }

            public override string preparacion()
            {
                throw new NotImplementedException();
            }

            public override string tipo()
            {
                throw new NotImplementedException();
            }

            public double Margarita()
            {
                return 15.00;
            }


        }
        class licuados : Bebidas
        {
            public override string categoria()
            {
                throw new NotImplementedException();
            }

           

            public override string preparacion()
            {
                throw new NotImplementedException();
            }

            public override string tipo()
            {
                throw new NotImplementedException();
            }
        }
        class CalientesInfuciones : Bebidas
        {
            public override string categoria()
            {
                throw new NotImplementedException();
            }

            

            public override string preparacion()
            {
                throw new NotImplementedException();
            }

            public override string tipo()
            {
                throw new NotImplementedException();
            }
        }
        abstract class Persona
        {
            public abstract void Nombres();

        }
        class PersonaDatos
        {
            private string nombre;

            private string apellido;

            private int edad;

            //private int dui;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public int Edad { get => edad; set => edad = value; }
            //public int DUI { get => DUI; set => DUI = value; }



            public void DatosUsuario(string _nombre, string _apellido, int _edad/*, int _dui*/)
            {
                this.Nombre = _nombre;
                this.Apellido = _apellido;
                this.Edad = _edad;
                //this.DUI= _dui; 

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-----Ingrese  Sus Datos----- \n");
                Console.WriteLine("Ingrese su Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Apellido:");
                Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Su edad:");
                Edad = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("Ingrese su numero de DUI:");
            //         DUI = int.Parse(Console.ReadLine());
            public string Mostrar()
            {
                Console.WriteLine("-------------------------------------");
                return" \n Nombre: " + Nombre + " \n Apellido: " + Apellido + "\n Edad: " + Edad /*+ "\n DUI: " + DUI*/;
               

               
                
            }


        }
        class Cliente: Persona
        {
            PersonaDatos datos = new PersonaDatos();
          public void Datos()
          {
                Console.WriteLine(datos.Mostrar());

          }

            public override void Nombres()
            {
                throw new NotImplementedException();
            }
        }
        class Empleado: Persona
        {
            //alcoholicas alcoholicas = new alcoholicas();
            PersonaDatos datos = new PersonaDatos();
            private int codigo1 = 5678;
            private int codigo2 = 2345;
            int codigoGeneral;
            int hora = 0;
            double sueldo=0;
            double respuesta;
            

            
            public int Codigo1 { get => codigo1; set => codigo1 = value; }
            public int Codigo2 { get => Codigo2; set => codigo2 = value; }
            //public int DUI { get => DUI; set => DUI = value; }



            //public void descuento(int _codigo1, int _codigo2)
            //{
            //    this.Codigo1 = _codigo1;
            //    this.Codigo2 = _codigo2;
              

            //    Console.WriteLine("-------------------------------------");
            //    Console.WriteLine("-----Ingrese  su codigo----- \n");
                
            //    codigoGeneral = int.Parse( Console.ReadLine());
            //    if (codigoGeneral == codigo1)
            //    {
            //        respuesta = alcoholicas.Margarita()*0.20;
            //        Console.WriteLine("Precio con el 20% de descuento es de $"+ respuesta);

            //    }
            //    if(codigoGeneral == codigo2)
            //    {
            //        respuesta = alcoholicas.Margarita() * 0.50;
            //        Console.WriteLine("Precio con el 50% de descuento es de $" + respuesta);
            //    }
            //    else
            //    {
            //        Console.WriteLine("El codigo no es correcto o no cuenta con descuento");
            //        Console.WriteLine("Precio sin  descuento es de $" + alcoholicas.Margarita());

            //    }
               
            //}
            public void Datos()
            {
                Console.WriteLine(datos.Mostrar());

            }

            public override void Nombres()
            {
                string[] nombreEmpleado = new string[10];
                nombreEmpleado[0] = "Matias Castilllo";
                nombreEmpleado[1] = "Rigoberto Montalvo";
                nombreEmpleado[2] = "Maria Monterrosa";
                nombreEmpleado[3] = "Judith Martínez";
                nombreEmpleado[4] = "Marta Caballero";
                nombreEmpleado[5] = "Ricardo Guardado";
                nombreEmpleado[6] = "Marbely Martínez";
                nombreEmpleado[7] = "Roberto Fuentes";
                nombreEmpleado[8] = "Margarita Madrid";
                nombreEmpleado[9] = "Dania Herrera";

                Console.WriteLine("Lista de empleados con descuento:\n" +
                    "\n1-" + nombreEmpleado[0] +
                    "\n -Tipo de codigo: " + Codigo1 +
                     "\n ------------------------------------------------------- " +
                    "\n2-" + nombreEmpleado[1] +
                    "\n -Tipo de codigo " + Codigo2 +
                     "\n ------------------------------------------------------- " +
                    "\n3-" + nombreEmpleado[2] +
                    "\n -Tipo de Contrato: " + Codigo1
                    + "\n ------------------------------------------------------- " +
                    "\n4-" + nombreEmpleado[3] +
                    "\n -Tipo de Contrato: " + Codigo2
                    + "\n ------------------------------------------------------- " +
                    "\n5-" + nombreEmpleado[4] +
                    "\n -Tipo de Contrato: " + Codigo1
                    + "\n ------------------------------------------------------- " +
                    "\n6-" + nombreEmpleado[5] +
                    "\n -Tipo de Contrato: " + Codigo2
                    + "\n ------------------------------------------------------- " +
                    "\n7-" + nombreEmpleado[6] +
                    "\n -Tipo de Contrato: " + Codigo1
                    + "\n ------------------------------------------------------- " +
                    "\n8-" + nombreEmpleado[7] +
                    "\n -Tipo de Contrato: " + Codigo2
                    + "\n ------------------------------------------------------- " +
                    "\n9-" + nombreEmpleado[8] +
                    "\n -Tipo de Contrato: " + Codigo1
                    + "\n ------------------------------------------------------- " +
                    "\n10-" + nombreEmpleado[9] +
                    "\n -Tipo de Contrato: " + Codigo2
                    + "\n ------------------------------------------------------- ");
                Console.ReadLine();
            }
            public void Sueldo()
            {
                Console.WriteLine("Por cada hora de trabajo de trabajo obtine $5.00");
                Console.WriteLine("Ingrese el total de horas trabajadas");
                hora = int.Parse(Console.ReadLine());
                sueldo = hora * 5+ 10;
                Console.WriteLine("Este es el sueldo segun las horas ingresadas mas los bonos $"+ sueldo);
            }
            
        }
        //Descripcion de lo que tiene que realizar el progama
        /*Primero tiene que mostrar un menu
         con  las opciones
        -------------------------------
        Rol de Usuario-------------------
        1.Hacer  un pedido
        2.Visualizar munu de Bebidas 
        3. Salir
        -------------------------------------
        
         1.Al hacer un pedido que le pida el nombre y todos los datos comunes y que le pida su edad 
        y acorde a su edad le muestre las bebidas que estan disponibles para su edad sin bebidas alcoholicas
        si es mayor de 18 años que pida el DUI y que le muestre  un menu con las bebidas
        
         y luego de eso que le pida las especificaciones de la bebida que quiere comprar le cobre y genere una factura 
        
         -------------------------------
        Rol de Empleado-------------------
        1.Hacer  un pedido con descjuento de empleado
        2.Lista de empleados donde muestre sus datos y tambien su especializad en la realizacion  de bebidas profecionales
        3. Calcular pago de empleados segun  las horas trabajadas*/
     
      
    }
}
