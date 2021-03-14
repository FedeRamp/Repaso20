using System;
using System.Collections.Generic;
namespace Repaso20
{
    public class PrimosAnteriores
    {
        public PrimosAnteriores()
        {
        }

        public static bool esPrimo(int num)
        //boolean para chequear si un int es primo
        {
            if (num == 0) return false;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> get(int limiteSuperior)
        {
            List<int> resultado = new List<int>();
            for(int i = 1; i < limiteSuperior; i++)
            {
                if (esPrimo(i))
                {
                    resultado.Add(i);
                }
            }
            return resultado;
        }
    }
}
