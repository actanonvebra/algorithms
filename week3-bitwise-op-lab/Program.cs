using System.Dynamic;
using System;

class Program{
    static void Main(string[] args){

        #region [example-1] (left shift ve rotate)

        // uint a=0x10000000;      // 0001 0000 0000 0000 0000 0000 0000 0000
        // uint mask=0x80000000;   // 1000 0000 0000 0000 0000 0000 0000 0000

        // System.Console.WriteLine("before A: "+ a);
        // /*for döngüsünün ve if bloğunun çalışması
        // for döngünde yapılan şey tam olarak ne?
        // fark ettiysen maskeyi kaydırmıyoruz.
        // ilk iterasyonda
        // yani i=0 iken
        // if bloğuna bakalım

        // a & mask == 1, şartını koşmuşuz.
        // döngünün ilk dönüşünde bu false olacaktır çünkü ilk hallerini şöyle ele al
        //     0001 0000 0000 0000 0000 0000 0000 0000
        //     1000 0000 0000 0000 0000 0000 0000 0000
        // and 0000 0000 0000 0000 0000 0000 0000 0000
        // döngünün kalanında a 1 kere sola shift edilir.
        // a şöyle görünür ilk dönüş sonunda
        //     0010 0000 0000 0000 0000 0000 0000 0000
        
        // i=1 iken if bloğu yine çalışmaz ve a sayısı
        // bir kere daha sola shift edilir
        //     0100 0000 0000 0000 0000 0000 0000 0000

        // i=2 iken if bloğu yine çalışmaz ve a sayısı
        // bir kere daha sola shift edilir
        //     1000 0000 0000 0000 0000 0000 0000 0000

        // i=3 iken, if bloğuna geldik

        // a & mask == 1, artık bu blok true döner çünkü 
        //     1000 0000 0000 0000 0000 0000 0000 0000
        //     1000 0000 0000 0000 0000 0000 0000 0000
        // AND 1000 0000 0000 0000 0000 0000 0000 0000
        // if içinde 
        // a sayısı sola 1 kere kaydırılır
        // yeni a sayım
        //     0000 0000 0000 0000 0000 0000 0000 0000
        //     fark ettiysen a sayısının 1 olan biti çöp oldu
        //     onu da bir alt satırda
        //     a++;
        //     şeklinde ekler ve 1 olan bit kaybedilmemiş olur
        //     0000 0000 0000 0000 0000 0000 0000 0001
        //     bu kadar.
        

        // */
        // for(int i=0; i<9; i++){
        //     if((a&mask)!=0){
        //         a=a<<1;
        //         a++;
        //     }else{
        //         a=a<<1;
        //     }
        // }
        // System.Console.WriteLine("after A: "+ a);
        #endregion

        #region [example-2] (move the firt 4 bits to the last 4 bits)

        uint a=0xABCD1234;
        // 1010 1011 1100 1101 0001 0010 0011 0100 --> a sayımız bu
        Console.WriteLine(Convert.ToString(a,toBase:2));       
        
        uint firstFourBits=(a&0xf0000000)>>28;
        // 1010 --> a sayısının en yüksek seviyeli 4 biti dışında bitlerinin tamamını sıfırladık,
        // sonra 28 defa sağa shift ettik böylelikle 1010 sayısı oluşmuş oldu.
        // fark ettiysen 1010 sayısı a nın en yüksek seviyeli ilk 4 bitiyle aynı.
        Console.WriteLine(Convert.ToString(firstFourBits,toBase:2));

        a=a&0xfffffff0;
        // a sayısıyla sağındaki sayıyı andledik şöyle ki
        // a sayısı şu şekilde --> 1010 1011 1100 1101 0001 0010 0011 0100  
        // 0x ile başlayan şu  --> 1111 1111 1111 1111 1111 1111 1111 0000
        // andlendiklerinde    --> 1010 1011 1100 1101 0001 0010 0011 0000
        // bunu yapmakla elimize ne geçti, a'nın en düşük seviyeli 4 bitini sıfırlamış olduk.
        
        Console.WriteLine(Convert.ToString(a,toBase:2));

        uint result=a|firstFourBits;
        // a yukarda en düşük seviyeli 4 biti 0 lanmıştı onu buraya taşıyalım
        // a sayısı şuydu --> 1010 1011 1100 1101 0001 0010 0011 0000 
        // firstFourBits  --> 0000 0000 0000 0000 0000 0000 0000 1010
        // or'landıklarında-> 1010 1011 1100 1101 0001 0010 0011 1010

        Console.WriteLine(Convert.ToString(result,toBase:2));

        #endregion
        
        
        
        Console.ReadLine();

    }
}