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
        mask -->    0000 0000 0000 0000 0000 0000 0000 0001
        result -->  0000 0000 0000 0000 0000 0000 0000 0001

        if block return false
        else --> Console.Write("1");

        */

        // int x = unchecked((int)0x00000001);
        // int mask = unchecked((int)0x80000000);
        // for(int i=0; i<32; i++){
        //     if ((x & mask)==0){
        //         Console.Write("0");
        //     }
        //     else{
        //         Console.Write("1");
        //     }

        //     mask=mask>>1;
        // }


        #endregion

        #region [example-5] (set bit 5 of the number to 1)

        // uint number=0x00000000; // 0000 0000 0000 0000 0000 0000 0000 0000
        //                         // decimal notation : 0
        // // uint number = 0; 
        // // uint number = 0x0;

        // uint mask=0x0000010;   // 0000 0000 0000 0000 0000 0000 0001 0000
        //                         // decimal notation : 16

        
        // number=number|mask;    
        // // number ---> 0000 0000 0000 0000 0000 0000 0000 0000
        // // mask   ---> 0000 0000 0000 0000 0000 0000 0001 0000
        // //  | (or) --> 0000 0000 0000 0000 0000 0000 0001 0000
        // Console.WriteLine("New number value: "+number);


        #endregion

        #region [example-5.1] (set bit 17 of the number to 1)

        // uint number1=0x00000000; // 0000 0000 0000 0000 0000 0000 0000 0000
        // Console.WriteLine("Number1 value: "+number1);

        // uint mask1=0x00010000;   // 0000 0000 0000 0001 0000 0000 0000 0000
        // Console.WriteLine("Mask1 value: "+mask1);

        // number1=number1|mask1;
        // Console.WriteLine("Number1 new value: "+number1);

        #endregion

        #region [example-6] (shift commands)
        
        /*
        Right Shift | number = number >> 1; 
        thnink a 4-bit number...
        1 1 0 0 
        right shift >>1
        0 1 1 0
        right shift >>1
        0 0 1 1 
        right shift >>1
        0 0 0 1
        right shift >>1
        0 0 0 0

        Left shift | number = number << 1; 
        
        1 1 0 0
        left shift <<1;
        1 0 0 0
        left shift <<1;
        0 0 0 0
               
        */

        // uint number3=0x00000008; // 0000 0000 0000 0000 0000 0000 0000 1000 | decimal value = 8
        // Console.WriteLine("number 3, decimal value = "+number3);
        // number3 = number3 >> 1;  // 0000 0000 0000 0000 0000 0000 0000 0100 | decimal value = 4
        // Console.WriteLine("(1 time right shift) number 3, decimal value = "+number3);
        // number3 = number3 >> 1;  // 0000 0000 0000 0000 0000 0000 0000 0010 | devimal value = 2
        // Console.WriteLine("(1 time right shift) number 3, decimal value = "+number3);
        // number3 = number3 >> 1;  // 0000 0000 0000 0000 0000 0000 0000 0001 | devimal value = 1
        // Console.WriteLine("(1 time right shift) number 3, decimal value = "+number3);
        // number3 = number3 >> 1;  // 0000 0000 0000 0000 0000 0000 0000 0000 | devimal value = 0
        // Console.WriteLine("(1 time right shift) number 3, decimal value = "+number3);


        // uint number4=0x20000000; // 0010 0000 0000 0000 0000 0000 0000 0000 | 2^29 
        // Console.WriteLine("number 3, decimal value = "+number4);
        // number4 = number4 << 1;  // 0100 0000 0000 0000 0000 0000 0000 0000 | 2^30
        // Console.WriteLine("(1 time left shift) number 4, decimal value = "+number4);
        // number4 = number4 << 1;  // 1000 0000 0000 0000 0000 0000 0000 0000 | 2^31 (max value)
        // Console.WriteLine("(1 time left shift) number 4, decimal value = "+number4);
        // number4 = number4 << 1;  // 0000 0000 0000 0000 0000 0000 0000 0000 | decimal value = 0 


        
        #endregion

        #region [example-7] (How many bits are 1?)

        // uint number=0xffbb0000;
        // uint mask=1;
        // int counter=0;
        // for(int i=0; i<32; i++){
        //     if((number&mask)==1){
        //         counter++;
        //     }
        //     number=number>>1;
        // }
        // Console.WriteLine("Counter: "+counter);

        #endregion

        #region [example-8] (write binary)

        // uint k = 0xffbb00a0; // 11111111101110110000000010100000
        // uint mask = 0x80000000; // 100000000000000000000000000000
        // for(int i=0; i<32; i++){
        //     if((k&mask)!=0){
        //         Console.Write("1");
        //     }
        //     else{
        //         Console.Write("0");
        //     }
        //     mask =mask >>1;
        // }

        #endregion

        #region [example-9] (1 bits --> 0)

        // uint a= 0xffbb00a0; // 1111 1111 1011 1011 0000 0000 1010 0000
        // uint b=0x1;         // 0000 0000 0000 0000 0000 0000 0000 0001
        // uint c=0xffffffe;   // 1111 1111 1111 1111 1111 1111 1111 1110
        // /* for döngüsünde olanlar
        // for döngüsünde olanlar
        // i=0 iken

        // 1111 1111 1011 1011 0000 0000 1010 0000
        // 0000 0000 0000 0000 0000 0000 0000 0001
        // 1111 1111 1111 1111 1111 1111 1111 1110

        // a ile b and operatörüne girdi sonuç 0'a eşit değilse yani sonuç 1 ise içeri gir
        // ancak burada a'nın ilk biti 0 b'nin ise 1 andlendiğinde sonuç 0 olacağından if içerisine girmedik.

        // i=1,2,3 durumları içinde aynı şey geçerli tabi bu esnada
        // b ve c shift ediliyor 
        // dikkat edersen c ye hep 1 ekleniyor çünkü c nin yüksek seviyeli bitlerinde hep 1 var 
        // bunlar kaybedilmesin istiyoruz.

        // neyse 
        // i=4 olduğunda sayılar şöyle görünecekler:
        // 1111 1111 1011 1011 0000 0000 1010 0000
        // 0000 0000 0000 0000 0000 0000 0010 0000
        // 1111 1111 1111 1111 1111 1111 1101 1111 

        // a yerinden oynamıyor
        // b ve c her iterasyonda sola 1 kaydırılıyor, c ye sürekli 1 ekleniyor ki en öndeki 1 ler kaybolmasın.
        // şimdi if içerisine geldik:

        // a&b != 0 --> a ve b yi andlediğinde sonuç 0 değilse 1'dir dolayısıyla bakalım if'e girecek mi?
        // 1111 1111 1011 1011 0000 0000 1010 0000
        // 0000 0000 0000 0000 0000 0000 0010 0000
        // if e girecek.
        // if içinde yapılan şey şu 

        // a = a & c 
        
        // bu ne işe yarıyor?
        
        // 1111 1111 1011 1011 0000 0000 1010 0000  -> a sayısı
        // 1111 1111 1111 1111 1111 1111 1101 1111  -> c sayısı

        // bunlar andlenip a ya aktarılıyor, yani a nın 1 olan biti artık 0 olacak çünkü
        // 0 and 1 = 0 dır.
        
        // Sonuç olarak bu mantıkla gidildiğinde çıktılarda a nın sayısal değerinin artık 0 olduğunu
        // çünkü 1 olan bitlerinin tamamının 0 landığını görmüş oluyoruz.
        
        // */
        // Console.WriteLine("before a: "+a);
        // Console.WriteLine("before b: "+b);
        // Console.WriteLine("before c: "+c);
        // for(int i=0; i<32; i++){
        //     if((a&b)!=0){
        //         a=a&c;
        //     }
        //     b=b<<1;
        //     c=c<<1;
        //     c=c+1;
        // }
        // Console.WriteLine("a: "+a);
        // Console.WriteLine("b: "+b);
        // Console.WriteLine("c: "+c);
        #endregion

        #region [example-10] (Move bits of number a to number b)

        uint a=0x0000ffff; // 0000 0000 0000 0000 1111 1111 1111 1111
        uint mask=0x1;     // 0000 0000 0000 0000 0000 0000 0000 0001
        uint b=0x00000000; // 0000 0000 0000 0000 0000 0000 0000 0000

        System.Console.WriteLine("before a: "+a);
        System.Console.WriteLine("before b: "+b);

        for(int i=0; i<32; i++){
            if((a&mask)==1){
                b=a|b;
            }
            mask=mask<<1;
        }
        System.Console.WriteLine("after a: "+a);
        System.Console.WriteLine("after b: "+b);

        #endregion

        Console.ReadLine();
    }
}