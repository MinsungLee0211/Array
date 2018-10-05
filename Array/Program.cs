using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarr = { 0, 1, 2, 3 };
            /*
             * c언어에서는
             * int* inarr의 형태로 처리하여 위치 포인터와 같이 함
             */

            char[] chararr = { '안', '녕', '하', '귀', '찮', '아' };
            string mystring = "안녕하귀찮아";

            Console.WriteLine(chararr);
            Console.ReadKey();
        }
    }
}
