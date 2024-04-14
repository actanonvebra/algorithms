using System;
using System.Runtime.InteropServices.Marshalling;


namespace Program
{
    class Program
    {
        static int say=0;
        // static int BinarySearch(int[] x, int left, int right, int data)
        // {
        //     say++;
        //     int indis= left+(right-left)/2;

        //     if(left>right) //diziyi aştın
        //     {
        //         return 0;
        //     }
        //     if(x[indis]==data) // buldun
        //     {
        //         return 1;
        //     }
        //     else if(x[indis]<data) //solunda aramaya devam ediyorsun
        //     {
        //         return BinarySearch(x,indis+1,right,data);
        //     }
        //     else // sağında aramaya çalışıyorsun.
        //     {
        //         return BinarySearch(x,left,indis-1,data);
        //     }
        // }
        static void Main(string[] args)
        {

            // int[] numbers=new int[1000];
            // for(int i=0; i<1000; i++)
            // {
            //     numbers[i]=i;
            // }
            // Console.WriteLine(BinarySearch(numbers,0,999,34)); 

            #region pi 
            // pi sayısının hesaplanması üzerine bir matematiksel formülü
            // algoritmaya çeviriyoruz.
            // formül: pi/2=(2/1x2/3)x(4/3x4/5)x(6/5x6/7)... şeklinde devam etmektedir.
            double pi=2;
            for(int i=2; i<100000; i=i+2)
            {
                pi=pi*(double)i/(i-1)*i/(i+1);
            }
            Console.WriteLine("pi sayisi: "+pi);


            // pi sayısının bir diğer formüllerinden biri olan
            // pi=4/1-4/3+4/5-4/7... şeklinde devam etmekte

            int isaret=1;
            double piSayisi =0;
            for(int i=1; i<100000; i=i+2)
            {
                piSayisi=piSayisi+(double)4/i*isaret;
                isaret=isaret*-1;
            }
            Console.WriteLine("pi sayisi ikinci formul: "+piSayisi);
            #endregion

            #region substring
            string st1 = "***23214*eabcey"; 
            string st2 = "xyzakabce34563243247ce"; 
            int adet = 0;
            int enBuyuk = 0;

            for (int i = 0; i < st1.Length; i++)
            {
                int indis = 0;

                for (int j = 0; j < st2.Length; j++)
                {
                    if(i + indis >= st1.Length) // ilk stringin indeks değeri kendisini aşmasın.
                    {
                        break; 
                    }
                    if (st1[i + indis] == st2[j]) // karakter eşitliği yakalandığında gir.
                    {
                        adet++;
                        indis++;
                        if (adet > enBuyuk) 
                        {
                            enBuyuk = adet;
                        }
                        if (i + indis >= st2.Length) // indeks değeri st2 yi aşmasın.
                        {
                            break;
                        }
                        continue; // ilk karakterlerden sonra hemen 2.karakterler ve sonrasına geç 
                    }
                    else // verimsiz ancak iş görüyor, verimsizliğinin nedeni eşleşmeyen karakterlerde boş yere 0 olanı 0 yapıyor.
                    {
                        indis = 0;
                        adet = 0;
                    }
                }
            }
            Console.WriteLine("En uzun birliktelik: " + enBuyuk);
            #endregion
            
            Console.ReadLine();
        }
    }
}