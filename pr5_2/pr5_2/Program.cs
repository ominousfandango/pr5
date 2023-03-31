using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_2
{
    class Pr
    {

    
    interface IHello
    {
        void SayHello();
    }
    class Rus: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Русский - Привет.");
        }
    }
    class Eng: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Английский - Hello.");
        }
    }
    class Fr: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Французский - Bonjour.");
        }
    }
    class Yap: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Японский - Konichiva.");
        }
    }
    class Kit: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Китайский - Ni hao.");
        }
    }

    static void Main()
    {
        List<IHello> Hi = new List<IHello>();
        Hi.Add(new Rus());
        Hi.Add(new Eng());
        Hi.Add(new Fr());
        Hi.Add(new Yap());
        Hi.Add(new Kit());
        foreach (IHello lang in Hi)
        {
            lang.SayHello();
        }
        Console.ReadKey(true);
    }
    }
}
