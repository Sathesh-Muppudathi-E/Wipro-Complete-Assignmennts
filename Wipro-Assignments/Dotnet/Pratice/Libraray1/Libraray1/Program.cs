using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library1
{
    public class Program
    {
        public static void Main(string[] args) { }
        public int? Add(int? a, int? b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            return a + b;
        }

        public int? Subtract(int? a, int? b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            return a - b;
        }

        public int? Multiply(int? a, int? b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            return a * b;
        }

        public int? Square(int? a)
        {
            if (a == null)
            {
                return null;
            }
            return a * a;
        }

        public int? Divide(int? a, int? b)
        {
            if (a == null || b == null || b == 0)
            {
                return null;
            }
            return a / b;
        }
    }
}

