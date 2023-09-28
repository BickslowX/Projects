using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Caesar
{
    class Program
    {
        static string abetka = " ,.?!:абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
        static void Main(string[] args)
        {
            WriteLine("Input text in ukrainian:");
            char[] InputText = ReadLine().ToLower().ToCharArray();
            WriteLine("\nInput coding key");
            int key = Convert.ToInt32(ReadLine());
            string coding = "";
            for (int i = 0; i < InputText.Length; i++)
            {
                for (int j = 0; j < abetka.Length; j++)
                {
                    if (InputText[i] == abetka[j])
                    {
                        coding += abetka[(j + key) % abetka.Length];
                    }
                }
            }
            WriteLine($"\nCoded text:\n {coding}");
            string decoding = "";
            for (int i = 0; i < coding.Length; i++)
            {
                for (int j = 0; j < abetka.Length; j++)
                {
                    if (coding[i] == abetka[j])
                    {
                        int temp = j - key;
                        while (temp < 0)
                        {
                            temp = abetka.Length - temp - 2;
                        }
                        decoding += abetka[(temp) % abetka.Length];
                    }
                }
            }
            WriteLine($"\nDecoded text:\n {decoding}");
            ReadKey();
        }
    }
}