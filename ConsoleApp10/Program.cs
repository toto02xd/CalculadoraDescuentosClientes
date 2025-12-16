using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mario Alejandro Chaj Sipáque 
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese su nombre");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese Su Genero");
            string Genero = Console.ReadLine().ToLower(); ;

            Console.WriteLine("Ingrese la cantidad de hijos");
            string Can_hij = Console.ReadLine();
            int Can_hij1 = Convert.ToInt32(Can_hij);

            Console.WriteLine("Ingrese su Total de la compra");
            string mon_com = Console.ReadLine();
            int mon_com1 = Convert.ToInt32(mon_com);

            Console.Clear();

            if (Genero == "hombre")
            {

                if (Can_hij1 == 0)
                {
                    Console.WriteLine("Joven " + Nombre);
                    Console.WriteLine("Subtotal:" + mon_com1);
                    Console.WriteLine("Se aplicará un descuento del 2.5 % sobre el total de su compra ");
                    Console.WriteLine("El total de su compra con descuento seria de :" + mon_com1 * 0.975);
                }
                else if (Can_hij1 >= 1)
                {
                    Console.WriteLine("Señor " + Nombre);
                    Console.WriteLine("Subtotal:" + mon_com1);
                    Console.WriteLine("Se aplicará un descuento del 5 % sobre el total de su compra ");
                    Console.WriteLine("El total de su compra con descuento seria de :" + mon_com1 * 0.95);
                }
            }

            else if (Genero == "mujer")
            {
                if (Can_hij1 == 0)
                {
                    Console.WriteLine("Señorita " + Nombre);
                    Console.WriteLine("Subtotal:" + mon_com1);
                    Console.WriteLine("Se aplicará un descuento del 10 % sobre el total de su compra ");
                    Console.WriteLine("El total de su compra con descuento seria de :" + mon_com1 * 0.90);
                }
                else if (Can_hij1 <= 2)
                {
                    Console.WriteLine("Señora " + Nombre);
                    Console.WriteLine("Subtotal:" + mon_com1);
                    Console.WriteLine("Se aplicará un descuento del 15 % sobre el total de su compra");
                    Console.WriteLine("El total de su compra con descuento seria de :" + mon_com1 * 0.85);
                }
                else if (Can_hij1 >= 3)
                {
                    Console.WriteLine("Señora " + Nombre);
                    Console.WriteLine("Subtotal:" + mon_com1);
                    Console.WriteLine("Se aplicará un descuento del 20% sobre el total de su compra ");
                    Console.WriteLine("El total de su compra con descuento seria de :" + mon_com1 * 0.80);
                }

            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();


        }
    }
}
