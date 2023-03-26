using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_2
{
    class Packag
    {
        public string Descript
        {
            get;
            private set;
        }
        public int Weight
        {
            get;
            private set;
        }
        public Packag(string description, int weight)
        {
            Descript = description;
            Weight = weight;
        }
    }
    class SendingService
    {
        private static int LimitWeight;
        private const int Limit = 10;
        public void SendPackag(Packag packag)
        {
            LimitWeight += packag.Weight;
            if (LimitWeight >= Limit)
            {
                Console.WriteLine("Ошибка! Вес отправленных посылок превысил лимит, отправка прервана.");
            }
            else
            {
                Console.WriteLine("{0} весом {1} кг успешно отправлена.", packag.Descript, packag.Weight);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Packag packag_1 = new Packag("Стандартная посылка №0000001", 4);
            Packag packag_2 = new Packag("Тяжеловесная посылка №0000002", 7);
            SendingService sendingService = new SendingService();
            sendingService.SendPackag(packag_1);
            sendingService.SendPackag(packag_2);
            Console.ReadKey(true);
        }
    }
}