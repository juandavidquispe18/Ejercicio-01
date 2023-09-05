using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar datos requeridos
            Console.WriteLine("Seleccione el tipo de fruta: ");
            Console.WriteLine("1: Naranja");
            Console.WriteLine("2: Fresa");
            Console.WriteLine("3: Mango");
            Console.WriteLine("=============================");
            int tipo_fruta = int.Parse(Console.ReadLine());

            Console.WriteLine("=============================");
            Console.WriteLine("Ingrese la distancia en kilómetros: ");
            double km_distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("=============================");
            Console.WriteLine("Ingrese la cantidad de cajas de fruta: ");
            double cantidad_cajas = int.Parse(Console.ReadLine());
            double precio_caja = 0d;

            if (tipo_fruta == 1) //Naranja
            {
                if (km_distancia < 30) 
                {
                    precio_caja = 2.00;
                }
                else 
                {
                    precio_caja = 4.00;
                }
            }
            else if (tipo_fruta == 2) //Fresa
            {
                if (km_distancia < 30) 
                {
                    precio_caja = 6.00;
                }
                else 
                {
                    precio_caja = 9.00;
                }
            }
            else if (tipo_fruta == 3) //Mango
            {
                if (km_distancia < 30) 
                {
                    precio_caja = 3.00;
                }
                else 
                {
                    precio_caja = 5.00;
                }
            }
            else 
            {
                Console.WriteLine("Usted a ingresado un tipo de fruta inválido. ");
                return;
            }
            double costo_total = precio_caja * cantidad_cajas;

            //Mostrar resultado
            Console.WriteLine("=============================");
            Console.WriteLine("El costo total del transporte es: S/." + costo_total);
            Console.ReadKey();
        }
    }
}
