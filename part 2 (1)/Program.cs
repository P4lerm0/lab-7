using System;

namespace lab7.part22
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] D = { ',', '.', ';', ':', '!', '?', '-', '(', ')', '/' };
            char[] a = { 'а', 'F', 'в', 'F', ',', 'А', 'з', '!', '-', 'к', ';' };
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                    if (a[i] == D[j])
                        count += 1;
            }
            Console.Write("Количество знаков препинания в строке = " + count);
        }
    }
}