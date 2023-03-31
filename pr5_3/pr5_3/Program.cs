using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pr5_3
{
    class Pr
    {
        interface IFilter
        {
            string Execute(string textLine);
        }

        class DigitFilter: IFilter
        {
            public string Execute(string textLine)
            {
                return textLine = Regex.Replace(textLine, "[0-9]", "", RegexOptions.IgnoreCase);
            }
        }

        class LetterFilter: IFilter
        {
            public string Execute( string textLine )
            {


                return textLine;
            }
        }

        static string Oper(string textLine, int methN)
        {
            DigitFilter Digit = new DigitFilter();
            LetterFilter Letter = new LetterFilter();
            if (methN == 1) 
            { 
                textLine = Digit.Execute(textLine); 
            }
            else 
            { 
                textLine = Letter.Execute(textLine); 
            }
            return textLine;
        }

        static void Main()
        {
            Console.WriteLine("введите текст: ");
            string textLine = Convert.ToString(value: Console.ReadLine());
            Console.WriteLine("выберите один из методов: ");
            Console.WriteLine("1 - DigitFilter, 2 - LetterFilter ");
            int a = Convert.ToInt32(Console.ReadLine());
            Oper(textLine, a);


            Console.WriteLine(textLine);

            Console.ReadKey(true);
        }

    }
}
