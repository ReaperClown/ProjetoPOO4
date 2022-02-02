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
    }
}
