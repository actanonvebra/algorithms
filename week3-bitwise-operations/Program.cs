using System;

class Program
{
    static void Main(string[] args)
    {
        #region [example-1] & (and operator)

        // uint a = 1;  // 0000 0000 0000 0000 0000 0000 0000 0001

        // a = a | 0x3; // 0000 0000 0000 0000 0000 0000 0000 0011

        // Console.WriteLine("a or 0x3 : "+a);

        #endregion

        #region [example-2] (odd or even)

        /*
        If the first bit of the number is 1, the number is even.
        If the first bit of the number is 0, the number is odd.

        example:


        0000 0000 0000 0000 0000 0000 0000 0000 --> 0

        even numbers
        0000 0000 0000 0000 0000 0000 0000 0001 --> 1
        0000 0000 0000 0000 0000 0000 0000 0011 --> 3        
        0000 0000 0000 0000 0000 0000 0000 0111 --> 7
        0000 0000 0000 0000 0000 0000 0000 1111 --> 15
        
        odd numbers
        0000 0000 0000 0000 0000 0000 0000 0010 --> 2
        0000 0000 0000 0000 0000 0000 0000 0110 --> 6
        0000 0000 0000 0000 0000 0000 0000 1110 --> 14
        */
        #endregion

        #region [example-3] (negative or positive, bit)

        /* Number is a 32 bit integer type.
        0000 0000 0000 0000 0000 0000 0000 0000 -->0 
        0000 0000 0000 0000 0000 0000 0000 0001 -->1 

        1000 0000 0000 0000 0000 0000 0000 0001 -->-1
        |
        |
        ¯¯¯¯ highest level bit (1), result = - (negative)

        */


        #endregion

        #region [example-4] (print bits of a number)

                /*
        The following operations are as follows

        number x
        0000 0000 0000 0000 0000 0000 0000 0001 
        
        number mask
        1000 0000 0000 0000 0000 0000 0000 0000

        for loop

        i=0,

        if x&mask == 0

        result, respectively for each bit value
        x -->       0000 0000 0000 0000 0000 0000 0000 0001
        mask -->    1000 0000 0000 0000 0000 0000 0000 0000
        result -->  0000 0000 0000 0000 0000 0000 0000 0000

        if block return true, Console.Write("0");

        i=1,

        if x&mask == 0
        
        result, respectively for each bit value
        x -->       0000 0000 0000 0000 0000 0000 0000 0001
        mask -->    0100 0000 0000 0000 0000 0000 0000 0000 (right shift (mask = mask>>1))
        result -->  0000 0000 0000 0000 0000 0000 0000 0000

        .
        .
        .
        .
        .
        .

        i=31 (32 in total)

        else,

        result, respectively for each bit value
        x -->       0000 0000 0000 0000 0000 0000 0000 0001
        mask -->    0100 0000 0000 0000 0000 0000 0000 0001
        result -->  0000 0000 0000 0000 0000 0000 0000 0001

        if block return false
        else --> Console.Write("1");

        */

        int x = unchecked((int)0x00000001);
        int mask = unchecked((int)0x80000000);
        for(int i=0; i<32; i++){
            if ((x & mask)==0){
                Console.Write("0");
            }
            else{
                Console.Write("1");
            }

            mask=mask>>1;
        }


        #endregion

        
        Console.ReadLine();
    }
}
