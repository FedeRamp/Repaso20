using System;
namespace Repaso20
{
    public class Factorial
    {
        public Factorial()
        {
        }

        public static double get(int numero)
        {
            
            if(numero == 1)
            {
                return 1;
            } else
            {
                return numero * Factorial.get(numero - 1);
            }
            
        }
    }
}
