using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_1
{
    class Spel
    {
        public string Name
        {
            get;
            private set;
        }
        public int Mana
        {
            get;
            private set;
        }
        private string Effect
        {
            get;
            set;
        }
        public Spel(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void Use()
        {
            Console.WriteLine(Effect);
        }
    }
    class Magician
    {
        public string Name
        {
            get;
            private set;
        }
        public int Mana
        {
            get;
            private set;
        }
        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(Spel spell)
        {
            if (Mana >= spell.Mana)
            {
                Mana -= spell.Mana;
                Console.WriteLine("{0} колдует!", Name);
                spell.Use();
            }
            else
            {
                int mana = spell.Mana - Mana;
                Console.WriteLine("Для использования {0} не хватает {1} единиц маны. Хлебните зелья!", spell.Name, mana);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Spel alohomora = new Spel("Алохомора", 60, "Замок открывается!");
            Spel vingardiumLeviosa = new Spel("Вингардиум Левиоса", 60, "Предмет поднимается в воздух!");
            Magician harryPotter = new Magician("Гарри Поттер", 100);
            harryPotter.CastSpell(alohomora);
            harryPotter.CastSpell(vingardiumLeviosa);
            Console.ReadKey(true);
        }
    }
}