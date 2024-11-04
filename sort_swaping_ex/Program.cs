using System;

namespace sort_swaping_ex
{
     class Program
    {
        public static void sorting(ref int x, ref int y)
        {
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
        }
        static void Main(string[] args)
        {
           int a, b, c;
            Console.Write("a?");
            a = int.Parse(Console.ReadLine());
            Console.Write("b?");
            b = int.Parse(Console.ReadLine());
            Console.Write("c?");
            c = int.Parse(Console.ReadLine());

            //if (a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}
            //if (b > c)
            //{
            //    int temp = b;
            //    b = c;
            //    c = temp;
            //}
            //if (a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}

            sorting(ref a, ref b);
            sorting(ref b, ref c);
            sorting(ref a, ref b);
            Console.WriteLine("{0}<{1}<{2}",a,b,c);
            Console.Read();
        }
    }
}
