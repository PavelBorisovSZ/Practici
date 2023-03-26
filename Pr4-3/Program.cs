using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_3
{
    class Orc
    {
        private static int Counter;
        public static int amountGoldAll
        {
            get;
            private set;
        }
        public int amountGold
        {
            get;
            private set;
        }
        public Orc()
        {
            Counter++;
            amountGoldAll += 2;
            if (Counter > 5)
            {
                amountGold += 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Orc ors_1 = new Orc();
            Console.WriteLine(Orc.amountGoldAll);
            Orc ors_2 = new Orc();
            Orc ors_3 = new Orc();
            Console.WriteLine(Orc.amountGoldAll);
            Orc ors_4 = new Orc();
            Orc ors_5 = new Orc();
            Orc ors_6 = new Orc();
            Console.WriteLine(ors_6.amountGold);
            Console.ReadKey(true);
        }
    }
}