using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_2
{
    class Num
    {
        private int numb = 0;
        public int GetNumber(int number)
        {
            if (SetNumber(number))
            {
                this.numb = number;
            }
            else
            {
                this.numb = 0;
            }
            return this.numb;
        }
        private bool SetNumber(int number)
        {
            if (number == this.numb + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Num num = new Num();
            int number;
            for (int i = 1; i >= 0; i = num.GetNumber(number) + 1)
            {
                Console.WriteLine($"Введите число {i}");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey(true);
        }
    }
}