using System;
namespace ConsoleApplication1
{
    public class ASM1_SoNguyenTo
    {
        public static void Main3(string[] args)
        {
            int n, i, ctr;
            Console.WriteLine("Nhap so n:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n>2)
            {
                ctr = 0;
                for (i= 2; i < n; i++)
                {
                    if (n%i==0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr==0 && n!=1)
                {
                    Console.WriteLine("{0}", n);
                }
                
            }
            else
            {
                Console.WriteLine("Khong co so nguyen to <2");
            }
            Console.Write("\n");   
                
            Console.ReadKey();
        }
        
    }
}