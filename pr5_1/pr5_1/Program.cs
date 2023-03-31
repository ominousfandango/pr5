using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pr5_1
{
    class Pr {
        interface IAnimal
        {
            void Voice();
        }

        class Dog : IAnimal
        {
            public void Voice() {
                Console.WriteLine("– гав!");
            }
        }
        class Cat : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("– мяу!");
            }
        }


        class Cow : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("– муу!");
            }
        }
        class sheep : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("– бее!");
            }
        }
        class horse : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("– иго-го!");
            }
        }

        static void Main( )
    {
        List<IAnimal> myAnimals = new List<IAnimal>();

            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Cow());
            myAnimals.Add(new sheep());
            myAnimals.Add(new horse());
            Console.WriteLine("мы гладим зверюшек, а они нам говорят:");
            foreach ( IAnimal animal in myAnimals )
            {
                animal.Voice();
            }

            

        Console.ReadKey(true);

    }

    static void PetAnimal(IAnimal animal)
    {
        Console.WriteLine("мы гладим зверюшку, а она нам говорит:");
        animal.Voice();
            Console.ReadKey(true);
        }
    
    }

}
