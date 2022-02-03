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
                return $"O número {num} é par.";
            }
            else
            {
                return $"O número {num} é ímpar.";
            }
        }

        public string multipleFive(int num)
        {
            if (num % 5 == 0)
            {
                return $"O número {num} é múltiplo de 5.";
            }
            else
            {
                return $"O número {num} não é múltiplo de 5.";
            }
        }

        public string nameForename(string name, string lastName)
        {
            return $"{name} {lastName}";
        }
    }
}
