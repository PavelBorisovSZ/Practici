using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_2
{
    internal class Program
    {
        class SmsMessage
        {
            private string _mtext;
            public string MText
            {
                get
                {
                    return _mtext;
                }
                private set
                {
                    _mtext = NormalizeMessageText(value);
                }
            }
            private double Price
            {
                get
                {
                    return CalculatePrice();
                }
            }
            public SmsMessage(string text)
            {
                MText = text;
            }
            public void SendMessage()
            {

                Console.WriteLine($"Отправлено сообщение '{_mtext}' длиной {_mtext.Length} символов и стоимостью {Price} руб.");
            }
            private string NormalizeMessageText(string text)
            {
                if (text.Length > 250)
                {
                    return text.Substring(0, text.Length - 250);
                }
                return text;
            }
            private double CalculatePrice()
            {
                if (_mtext.Length < 65)
                {
                    return 1.5;
                }
                else
                {
                    int length = MText.Length - 65;
                    return 1.5 + length * 0.5;
                }
            }
        }
        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("РСЧС: 21.02.23 на территории области ожидается мокрый снег, на дорогах местами снежные заносы. Порывы ветра до 17 м/с. Тел: 112.");
            sms.SendMessage();
            Console.ReadKey(true);
        }
    }
}