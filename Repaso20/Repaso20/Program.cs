using System;

namespace Repaso20
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            string ingreso = "";
            int numeroIngresado = -1;
            do
            {
                Console.WriteLine("Ingresar un numero mayor a 1");
                ingreso = Console.ReadLine();
                if(!int.TryParse(ingreso, out numeroIngresado))
                {
                    Console.WriteLine("Un número, por favor");
                    ingreso = "";
                } else if(numeroIngresado < 1)
                {
                    Console.WriteLine("Mayor a 1, por favor");
                    ingreso = "";
                }
            } while (ingreso == "");


            int cantidadPrimosAnteriores = PrimosAnteriores.get(numeroIngresado).Count - 1;
            int factorialDelIngreso = Factorial.get(numeroIngresado);

            string mensaje = "Hasta el " + numeroIngresado + " hay " +
                                    cantidadPrimosAnteriores + " primos, y el factorial es "
                                    + factorialDelIngreso;

            Console.WriteLine(mensaje);

        }
    }
}
