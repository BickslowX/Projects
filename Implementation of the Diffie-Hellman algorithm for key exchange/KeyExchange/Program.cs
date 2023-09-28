using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace KeyExchange
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            int a = r.Next(80000, 100000); //секретный ключ Євы
            int p = GenP(); //Відкрите просте число Р
            int g = rootByModule(p);
            int A = PowByMod(g, a, p);
            WriteLine($" ( g, p, А) = ( {g}, {p}, {A})");
            int b = r.Next(80000, 100000);
            int B = PowByMod(g, b, p);
            WriteLine(" B = " + B);
            int Kb = PowByMod(A, b, p);
            int Ka = PowByMod(B, a, p);
            WriteLine("K(Bob) = " + Kb);
            WriteLine("K(Alice) = " + Ka);
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
        static int GenP()//Генерацiя р
        {
            int P = 0;
            bool f = false;
            while (f == false)
            {
                P = (int)r.Next(80000, 100000);
                if (Prime(P) == true)
                {
                    f = true;
                }
            }
            return P;
        }
        static int PowByMod(int a, int b, int k) // a^b mod n - возведение a в степень b по модулю n возведення а у степвiнь б за модулем к
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
        static int Oiler(int n)// функцiя Ойлера
        {
            int result = n;
            for (int i = 2; i * i <= n; ++i)
                if (n % i == 0)
                {
                    while (n % i == 0)
                        n /= i;
                    result -= result / i;
                }
            if (n > 1)
                result -= result / n;
            return result;
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
        static int rootByModule(int a)//знаходження первiсного корня до а
        {
            int p = Oiler(a);
            int t = r.Next(1, (int)p / 2);
            for (int i = (int)t; i < p; i++)
                for (int j = (int)t; j < p; j++)
                    if (Degree(i, j) % a == 1)
                        return i;
            return 0;
        }
    }
}