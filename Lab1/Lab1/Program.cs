using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab01
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i*i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        static int FindPrime(int n)
        {
            int i = 0, result = 2;
            while(i<n)
            {
                if (IsPrime(i))
                    result = i;
                i++;
            }
            return result;
        }

        static int FindPrime2(int n)
        {
            int i = 0, result = n - 1;
            while (!IsPrime(result))
                result--;
            return result;
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.MyEventHandler += (object sender, MyEventArgs e) => {
                Console.WriteLine($"IncrementEvent: {e.Count} times");
            };

            myClass.IncrementEvent();
            myClass.IncrementEvent();
            myClass.IncrementEvent();

            int[] array = new int[] { 32, 122, 76, 2022, 12321, 943243 };

            Thread thread1 = new Thread(() => {
                Console.WriteLine($"Start fir: {Thread.CurrentThread.Name} {DateTime.Now.ToString("hh:mm:s:ms")}");

                foreach (int el in array)
                    Console.WriteLine($"{ Thread.CurrentThread.Name}: {el} => {FindPrime2(el)}");

                Console.WriteLine($"End fir: {Thread.CurrentThread.Name} {DateTime.Now.ToString("hh:mm:s:ms")}");
            });
            thread1.Name = "First thread";
            thread1.Start();

            Thread thread2 = new Thread(() => {
                Console.WriteLine($"Start fir: {Thread.CurrentThread.Name} {DateTime.Now.ToString("hh:mm:s:ms")}");

                foreach (int el in array)
                    Console.WriteLine($"{ Thread.CurrentThread.Name}: {el} => {FindPrime2(el)}");

                Console.WriteLine($"End fir: {Thread.CurrentThread.Name} {DateTime.Now.ToString("hh:mm:s:ms")}");

            });
            thread2.Name = "Second thread";
            thread2.Start();
            Console.ReadLine();
        }
    }
}
