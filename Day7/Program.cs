using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Probelm2
            //Sum2000();
            //Console.WriteLine();
            //SumEven();
            //Console.WriteLine();
            //SumOdd();

            //Thread thread1 = new Thread(Sum2000);
            ////thread1.Join(TimeSpan.FromSeconds(2000));
            //thread1.Start();
            //Thread thread2 = new Thread(SumEven);
            //thread2.Start();
            //SumOdd();
            #endregion

            Department d = new Department();
            Employee e = new Employee("Ahmed", 2);
            Thread t = new Thread(()=>d.AddEmp(e));
            t.Start();
            Employee e2 = new Employee("Mahmoud", 5);
            Thread t2 = new Thread(() => d.AddDept(e2));
            t2.Start();
            //e.Add();
            //d.AddDept(e2);
        }
        static void Sum2000()
        {
            double sum = 0;
            for(int i = 1; i <= 2000; i++) 
            {
                sum += i;
                Console.Write($" Sum2000 {sum}");
            }
        }
        static void SumEven()
        {
            double sum = 0;
            for (int i = 2000; i <= 4000; i+=2)
            {
                sum += i;
                Console.Write($" SumEven {sum}");
            }
        }
        static void SumOdd()
        {
            double sum = 0;
            for (int i = 4000; i <= 6000; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.Write($" SumOdd {sum}");
                }
            }
        }
    }
}
