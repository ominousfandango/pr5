using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_5
{
    class Pr
    {

        interface Iwitcher
        {
            void spell();
        }
        class Magician: Iwitcher
        {
            public int Mana { get; set; }
            public string Name { get; set; }
            private string Effect { get; set; }
            public Magician(int mana, string name)
            {
                Mana = mana;
                Name = name;
            }
            public void Use()
            {
                Console.WriteLine(Effect);
            }
            public void spell()
            {
                int mana = 100;
                if (Mana >= mana)
                {
                    Console.WriteLine(Name + " шаманит!");
                    Mana -= mana;
                }
                else
                {
                    Console.WriteLine("для использования заклинания не хватает " + (Math.Abs(mana - Mana)) + " единиц маны. Хлебните зелья!");
                }
            }
        }
        static void Main()
        {
            List<Iwitcher> Wizardry = new List<Iwitcher>();

            Wizardry.Add(new Magician(100, "Гарри Поттер"));

            foreach (Iwitcher cast in Wizardry)
            {
                cast.spell();
            }

            Console.ReadKey(true);
        }

    }
}
