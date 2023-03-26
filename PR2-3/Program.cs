using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_3
{
    internal class Program
    {
        class Cr
        {
            private string s;
            private int shift;
            public string GetCipher()
            {
                return s;
            }
            public void SetCipher(string code, int shift)
            {
                this.s = EncryptStr(code, shift);
                this.shift = shift;
            }
            private string EncryptStr(string code, int shift)
            {
                char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                char L;
                int index;
                string stringCipher = "";
                for (int i = 0; i < code.Length; i++)
                {

                    L = code[i];
                    if (L == ' ')
                    {
                        stringCipher += L;
                        continue;
                    }
                    index = Array.IndexOf(alphabet, L);
                    index += shift;
                    if (index > 32)
                    {
                        index -= 33;
                    }
                    else if (index < 0)
                    {
                        index += 33;
                    }
                    stringCipher += alphabet[index];
                }
                return stringCipher;
            }
        }
        static void Main(string[] args)
        {
            Cr myCipher = new Cr();
            myCipher.SetCipher("в своем друге ты должен иметь своего лучшего врага", 21);
            Console.WriteLine(myCipher.GetCipher());
            myCipher.SetCipher("мрупщл нужнлрю ц мрупщр", -12);
            Console.WriteLine(myCipher.GetCipher());
            Console.ReadKey(true);
        }
    }
}