using System;

namespace ConsoleApplication1
{
    public class ASM1_DayFibonaci
    {
        public static void Main3(string[] args)
                        {
                             int a = 0, b = 1, trm, i, n;
                
                            Console.Write("\n");
                            Console.Write("In day Fibonacci :\n\n");
                
                            Console.Write("Nhap so phan tu can hien thi: ");
                            n = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Day Fibonacci gom {0} phan tu la: \n", n);
                            Console.Write("{0}    {1}", a, b);
                
                            for (i = 3; i <= n; i++)
                            {
                                trm = a+ b;
                                Console.Write("  {0}  ", trm);
                                a = b;
                                b = trm;
                            }
                            Console.Write("\n");   
                
                            Console.ReadKey();
                        }
    }
}