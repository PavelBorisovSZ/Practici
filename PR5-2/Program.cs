using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_2
{
    interface Hello
    {
        void SayHello();
    }
    class Russian : Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English : Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Deutsch : Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Hallo");
        }
    }
    class French : Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Salut");
        }
    }
    class Latin : Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Salve");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hello> greetings = new List<Hello>();
            greetings.Add(new Russian());
            greetings.Add(new English());
            greetings.Add(new Deutsch());
            greetings.Add(new French());
            greetings.Add(new Latin());
            foreach (Hello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}