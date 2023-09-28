using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;
namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string str = "";
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Ja\Desktop\Men-Of-Good-Will.txt");
                str = sr.ReadToEnd(); // зчитування даних з файлу
                sr.Close(); // закриття файлу (пiсля зчитування)
                WriteLine("Symbol Count: " + str.Length.ToString());
            }
            catch // обробка виключання, якщо файл не вiдкритодля зчитування
            {
                WriteLine("Error Reading of File!");
            }
            //сформуємо частоту вживання бiграм за вказаним текстом
            var freq = new Dictionary<string, int>();
            for (int i = 1; i < str.Length; i++)
            {
                var pair = str[i - 1].ToString() + str[i].ToString();
                int count = 0;
                freq.TryGetValue(pair, out count);
                freq[pair] = count + 1;
            }
            //сформуємо словник найвживанiших бiграм
            var SmartDict = new Dictionary<string, int>();
            foreach (var pair in freq)
            {
                if (pair.Value > 0 && char.IsLetter(pair.Key[0]) && char.IsLetter(pair.Key[1]) && pair.Key[0] != ' ' && pair.Key[1] != ' ' && pair.Key != "\n\n")
                {
                    WriteLine(pair.Key + " " + pair.Value);
                    var bigram = pair.Key;
                    SmartDict[bigram] = pair.Value;
                }
            }
            //виконання
            double modificate(string txt)
            {
                Dictionary<string, int> copy = new Dictionary<string, int>(SmartDict);
                foreach (var birgram in SmartDict.Keys)
                {
                }
                double multiply = 1;
                for (int i = 0; i < txt.Length - 1; i++)
                {
                    string f = txt[i].ToString() + txt[i + 1].ToString();
                    foreach (var bigram in SmartDict.Keys)
                    {
                        if (f == bigram)
                        {
                            multiply *= SmartDict[bigram];
                        }
                    }
                }
                double multiplysqrt = Math.Pow(multiply, (1.0 / (txt.Length - 1)));
                WriteLine("\n" + multiplysqrt + "\n");
                return multiplysqrt;
            }
            //визначення коєфiцiента
            double c = 1, c1, c2, c3;
            Console.WriteLine("\nВведiть чистий текст 1");
            c1 = modificate(Convert.ToString(ReadLine()));
            WriteLine("Введiть чистий текст 2");
            c2 = modificate(Convert.ToString(ReadLine()));
            WriteLine("Введiть чистий текст 3");
            c3 = modificate(Convert.ToString(ReadLine()));
            if (c1 < c2 & c2 < c3)
                c = c1;
            if (c2 < c1 && c1 < c3)
                c = c2;
            if (c3 < c2 && c2 < c1)
                c = c3;
            double d = 1, d1, d2, d3;
            WriteLine("\nВведiть шкiдливий текст 1");
            d1 = modificate(Convert.ToString(ReadLine()));
            Console.WriteLine("Введiть шкiдливий текст 2");
            d2 = modificate(Convert.ToString(ReadLine()));
            WriteLine("Введiть шкiдливий текст 3");
            d3 = modificate(Convert.ToString(ReadLine()));
            if (d1 < d2 & d2 < d3)
                d = d1;
            if (d2 < d1 && d1 < d3)
                d = d2;
            if (d3 < d2 && d2 < d1)
                d = d3;
            double cd = (c + d) / 2.0;
            WriteLine($"Пороговий коєфiцiєнт = {cd}");
            //перевiрка введеного рядка
            bool gg = true;
            while (gg == true)
            {
                WriteLine("Введiть бажаний рядок для перевiрки на коректнiсть");
                double f = modificate(ReadLine());
                if (f > cd)
                    WriteLine("Рядок коректний, коєффицієнт = " + f);
                else
                    WriteLine("Рядок некоректний, коєффицієнт = " + f);
                WriteLine("\nЯкщо бажаєте перевiрити ще рядки, то введiть 1");
                if (ReadLine() == "1")
                    gg = true;
                else
                    gg = false;
            }
        }
    }
}