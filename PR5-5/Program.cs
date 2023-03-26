using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_5
{
    interface Magic
    {
        string Name
        {
            get;
            set;
        }
        int Mana
        {
            get;
            set;
        }
        void WriteInfo();
    }
    class Spell : Magic
    {
        public string Name
        {
            get;
            set;
        }
        public int Mana
        {
            get;
            set;
        }
        private string Effect
        {
            get;
            set;
        }
        public Spell(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void WriteInfo()
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
        public void WriteInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Mana);
        }
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                Mana -= spell.Mana;
                Console.WriteLine($"{Name} колдует!");
                spell.WriteInfo();
            }
            else
            {
                int mana = spell.Mana - Mana;
                Console.WriteLine($"Для использования {spell.Name} не хватает {mana} единиц маны. Хлебните зелья!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Spell alohomora = new Spell("Алохомора", 60, "Замок открывается!");
            Spell vingardiumLeviosa = new Spell("Вингардиум Левиоса", 60, "Предмет поднимается в воздух!");
            Magician harryPotter = new Magician("Гарри Поттер", 100);
            harryPotter.CastSpell(alohomora);
            harryPotter.CastSpell(vingardiumLeviosa);
            Console.ReadKey(true);
        }
    }
}