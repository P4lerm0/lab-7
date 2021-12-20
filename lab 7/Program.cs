using System;

namespace lab7.part1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] D = { 'а', 'б', 'в', 'г', 'д', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            char[] a = { 'а', 'F', 'в', 'F', ',', 'А', 'з', 'и', 'й', 'к' };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                    if (Char.IsLower(a[i]) && a[i] == D[j])
                        Console.Write(a[i]);
            }
        }
    }
}