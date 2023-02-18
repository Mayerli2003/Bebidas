using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;

            Personas personas = new Personas();
            Empleado empleado = new Empleado();
            Bebidas bebidas = new Bebidas();


            Console.WriteLine("----------  BIENVEDIDO/A  ----------");
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("------------- MENU:------------------");
                Console.WriteLine("Ingrese el numero de su consulta");
                Console.WriteLine("\n1 - Lista de Bebidas");
                Console.WriteLine("\n2 - Comprar");
                Console.WriteLine("\n3 - Salir");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("\nIngrese el numero de su consulta");
                id = Convert.ToInt32(Console.ReadLine());
                switch (id)
                {
                    case 1:

                        Console.WriteLine("---------- Lista de Bebidas ----------");
                        

                        break;

                    case 2:

                        Console.WriteLine("---------- Datos de Compra -------------");

                        personas.DatosCliente(personas.Nombre, personas.Apellido,personas.Edad);

                        empleado.DatosEmpleado(empleado.Nombre, empleado.Apellido);

                        bebidas.DatosBebidas(bebidas.Nombre, bebidas.Valor1,bebidas.Tipo1, bebidas.Descripcion1,bebidas.Cantidad);


                        Console.WriteLine(personas.getCliente());
                      
                        Console.WriteLine(empleado.GetEmpleado());
                       
                        Console.WriteLine(bebidas.GettipoBebidas());
                        Console.ReadLine();
                        break;

                       

                    case 3:
                        Environment.Exit(0);
                        break;

                        
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("La opcion que has elegido no es correcta");
                        Console.ReadKey();
                        break;
                }

                       

                
            }
            while (id != 10);
            {
                Console.WriteLine("Fin de  consultas");
            }
        }
        


        class Personas
        {
            private string nombre;

            private string apellido;

            private int edad;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public int Edad { get => edad; set => edad = value; }

            public void DatosCliente(string _nombre, string _Apellido, int _edad)
            {
                this.Nombre = _nombre;
                this.Apellido = _Apellido;
                this.Edad = _edad;

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-----Ingrese  Sus Datos----- \n");
                Console.WriteLine("Ingrese su Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Apellido:");
                Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Su edad:");
                Edad = int.Parse(Console.ReadLine());
                if (Edad >= 18)
                {
                    Console.WriteLine("El Cliente es Mayor de Edad a continuacion estas son las Bebidas para ti");
                }
                else
                {
                    Console.WriteLine("El cliente no puede ordenanr nada de bebidas alcoholicas deseas que te muestre el menu infantil");
                    
                }
                Console.WriteLine("-------------------------------------");
            }
            public String getCliente()
            {
                Console.WriteLine("-------------------------------------");
                return " \n Nombre: " + Nombre + " \n Apellido: " + Apellido + "\n Edad: " + Edad;

                Console.WriteLine("-------------------------------------");
            }
        }

        class Empleado: Personas
        {

            private string nombre;

            private string apellido;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }

            public void DatosEmpleado(string _nombre, string _Apellido)
            {
                this.Nombre = _nombre;
                this.Apellido = _Apellido;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-----Ingrese sus datos Empleado----- \n");
                Console.WriteLine("Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Su Apellido:");
                Apellido = Console.ReadLine();
                Console.WriteLine("-------------------------------------");
            }
            public String GetEmpleado()
            {
                Console.WriteLine("-------------------------------------");
                return " \n Nombre: " + Nombre + " \n Apellido: " + Apellido;

                Console.WriteLine("-------------------------------------");
            }
        }

       
       public class   Bebidas 
       {
            private string nombre;

            private double Valor;

            private string Tipo;

            private string Descripcion;

            private int cantidad;

            public string Nombre { get => nombre; set => nombre = value; }
            public double Valor1 { get => Valor; set => Valor = value; }
            public string Tipo1 { get => Tipo; set => Tipo = value; }
            public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
            public int Cantidad { get => cantidad; set => cantidad = value; }

            public void DatosBebidas(string _nombres, double _Valor, string _tipo,string _Descripcion,int _Cantidad)
            {
                this.Nombre = _nombres;
                this.Tipo = _tipo;
                this.Valor = _Valor;
                this.Descripcion = _Descripcion;
                this.Cantidad = _Cantidad;

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("----------Ingrese datos de la bebida ----------\n");

                Console.WriteLine("Nombre de la Bebida:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo de bebida:");
                Tipo = Console.ReadLine();
                Console.WriteLine("Ingrese el valor del la Bebida:");
                Valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la Descripcion de las bebidas");
                Descripcion = Console.ReadLine();
                Console.WriteLine("Ingrese la Cantidad de  las bebidas");
                Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");

               
            }
            public String GettipoBebidas()
            {
                Double total = cantidad * Valor;
                Console.WriteLine("-------------------------------------");
                return " \n Nombre: " + Nombre + "\n Valor de la bebida: $ " + Valor + "\n Y el total es " + total + " \n Tipo de la bebida : " + Tipo + "\n Descripcion del Producto: $ " + Descripcion + "\n Cantidad del Producto: $ " +Cantidad;
                Console.WriteLine("-------------------------------------");
            }

             

       }
       
    }
}
