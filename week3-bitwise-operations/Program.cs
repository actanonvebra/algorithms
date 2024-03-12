using System;

class Program
{
    static void Main(string[] args)
    {
        #region example-1

        uint a = 1;  // 0000 0000 0000 0000 0000 0000 0000 0001

        a = a | 0x3; // 0000 0000 0000 0000 0000 0000 0000 0011

        Console.WriteLine("a or 0x3 : "+a);

        #endregion

        #region example-2 (odd or even)

        /*
        If the first bit of the number is 1, the number is even.
        If the first bit of the number is 0, the number is odd.
        */



        #endregion

        Console.ReadLine();
    }
}
