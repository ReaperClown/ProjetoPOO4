using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPOO4
{
    public class Operations
    {
        public string oddEven(int num)
        {
            if (num % 2 == 0)
            {
                return "O número é par.";
            }
            else
            {
                return "O número é ímpar.";
            }
        }

        public string multipleFive(int num)
        {
            if (num % 5 == 0)
            {
                return "O número é múltiplo de 5.";
            }
            else
            {
                return "O número não é múltiplo de 5.";
            }
        }

        public string nameForename(string name, string lastName)
        {
            return $"{name} {lastName}";
        }
    }
}
