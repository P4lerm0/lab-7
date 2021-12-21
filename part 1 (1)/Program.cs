using System;
using System.Linq;

namespace lab7.part11
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "строчные буквы adifah';:/./jahf";
            string rus_str = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            Console.WriteLine(string.Join("", input.Where(c => rus_str.Contains(c.ToString()))));
        }
    }
}
