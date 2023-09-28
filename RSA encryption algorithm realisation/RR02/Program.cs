using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RR02
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            WriteLine(" Введiть текст для кодування: "); string InputText = Console.ReadLine();
            int p = GenP();
            int g = rootByModule(p);
            int x = r.Next(1, p);
            int y = PowByMod(g, x, p);
            WriteLine($"\n Вiдкритий ключ: ({p}, {g}, {y})");
            Dictionary<string, string> BIgram_Index = new Dictionary<string, string>();//словник з біграмами та їх кодами за аскі
            for (int i = 0; i < InputText.Length-1; i++)
            {
                string pair = InputText[i].ToString() + InputText[i+1].ToString();
                string code = "";
                BIgram_Index.TryGetValue(pair, out code);
                BIgram_Index[pair] = "";
                BIgram_Index[pair] += (int)InputText[i];
                BIgram_Index[pair] += (int)InputText[i+1];
            }
            int k = r.Next(1, p - 1);
            //----------coding------------------
            string coding = "";
            int a = PowByMod(g, k, p);
            int tempo = PowByMod(y, k, p);
            for (int i = 0; i < InputText.Length-1; i +=2)
            {
                string m = "";
                m += (int)InputText[i];
                m += (int)InputText[i+1];
                int M = Convert.ToInt32(m);
                int b = mnosh(tempo, M, p);
                coding += a + "_" + b + " ";
            }//---------------------------------
            WriteLine("\n Закодований текст:");
            WriteLine(coding);
            //------------decoding---------------
            string decoding = "";
            string[] D = coding.Split(' ');//розбиття ряду кодів на коди
            for (int i = 0; i < D.Length-1; i++)
            {
                string[] tem = D[i].Split('_');
                int dA = Convert.ToInt32(tem[0]);
                int dB = Convert.ToInt32(tem[1]);
                int dM = mnosh(dB, PowByMod(dA, p - 1 - x, p), p);
                foreach (KeyValuePair<string, string> pair in BIgram_Index)
                {
                    string temp1 = "0" + Convert.ToString(dM);
                    if (pair.Value == Convert.ToString(dM))
                    {
                        decoding += pair.Key;
                    }
                    else if(pair.Value == temp1)
                    {
                            decoding += pair.Key;
                    }
                }
            }
            //----------------------------------
            WriteLine("\n Разкодований текст:");
            WriteLine(decoding);
            WriteLine("\n Finish!");
            ReadKey();
        }
        static int mnosh(int a, int b, int k) //множення а на b по модулю k
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= k)
                {
                    sum -= k;
                }
            }
            return sum;
        }
        static int PowByMod(int a, int b, int k) // a^b mod n - возведення а у ступiнь b за модулем к
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= k)
                    {
                        sum -= k;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }
        static int GenP()//Генерацiя р
        {
            int P = 0;
            bool f = false;
            while (f == false)
            {
                P = (int)r.Next(80000, 120000);
                if (Prime(P) == true)
                {
                    f = true;
                }
            }
            return P;
        }
        static bool Prime(int n)//перевiрка числа на простоту
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int Degree(int x, int n)// швидке возведення x до степеню n(бiнарне)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                int p = Degree(x, n / 2);
                return p * p;
            }
            else
            {
                return x * Degree(x, n - 1);
            }
        }

        static int Oiler(int n)// функцiя Ойлера
        {
            int result = n;
            if(Prime(n)==true)
            {
                return n - 1;
            }
            for (int i = 2; i * i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        n /= i;
                    }
                    result -= result / i;
                }
            }
            if (n > 1)
            {
                result -= result / n;
            }
            return result;
        }
        static int rootByModule(int a)//знаходження первiсного корня до а
        {
            int p = Oiler(a);
            int t = r.Next(1, p / 2);
            for (int i = t; i < p; i++)
            {
                for (int j = t; j < p; j++)
                {
                    if (Degree(i, j) % (int)a == 1)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }
    }
}
