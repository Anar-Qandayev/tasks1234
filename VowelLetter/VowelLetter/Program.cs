using System;

namespace VowelLetter
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Convert.ToString(Console.ReadLine());
            int count = VowelLetter(text);
            Console.WriteLine(count + "-> eded sait var");
        }
        static int VowelLetter(string text)
        {
            int count = 0;
            char[] array = { 'a', 'ı', 'o', 'u', 'e', 'ə', 'i', 'ö', 'ü' };
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (text[i] == array[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
