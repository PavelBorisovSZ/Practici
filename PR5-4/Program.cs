using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_4
{
    interface Share
    {
        void Draw(int size);
    }
    class VerticalLine : Share
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
    class HorizontalLine : Share
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("*");
            }
        }
    }
    class Square : Share
    {
        public void Draw(int size)
        {
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Share> shapes = new List<Share>();
            shapes.Add(new VerticalLine());
            shapes.Add(new HorizontalLine());
            shapes.Add(new Square());
            foreach (Share figure in shapes)
            {
                figure.Draw(20);
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}