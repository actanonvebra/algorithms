using System;
using System.Runtime.InteropServices.Marshalling;


namespace Program
{
    class Program
    {
        static int say=0;
        static int BinarySearch(int[] x, int left, int right, int data)
        {
            say++;
            int indis= left+(right-left)/2;

            if(left>right) //diziyi aştın
            {
                return 0;
            }
            if(x[indis]==data) // buldun
            {
                return 1;
            }
            else if(x[indis]<data) //solunda aramaya devam ediyorsun
            {
                return BinarySearch(x,indis+1,right,data);
            }
            else // sağında aramaya çalışıyorsun.
            {
                return BinarySearch(x,left,indis-1,data);
            }
        }
        static void Main(string[] args)
        {

            int[] numbers=new int[1000];
            for(int i=0; i<1000; i++)
            {
                numbers[i]=i;
            }
            Console.WriteLine(BinarySearch(numbers,0,999,34)); 

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

            
            string st1="ab123dfghjk12";
            string st2="11ab**123**dfghjk12***";
            




            Console.ReadLine();
        }
    }
}