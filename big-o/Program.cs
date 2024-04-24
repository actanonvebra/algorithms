using System;

namespace big_o
{
    class Program
    {
        // 0(LOGN)
        public static int BinarySearch(int[] array, int target)
        {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;
            else if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Hedef bulunamadı.
        }
        
        static void Main(string[] args)
        {
            /* BIG O notation
            Algoritma performansı analiz edilirken iki kritere dikkat edilir.
            1) Zaman
            2) Hafıza
            Ne kadar zaman harcıyor? Ne kadar hafıza tüketiyor?
            Bu soruların cevapları önemlidir ama her şeyden öte hafıza kullanımı çok ciddi bir kriterdir.
            
            Bazı BIG O karmaşıklık sınıfları:

            a) O(1) : Sabit zaman karmaşıklığı olarak ifade edilebilir.
                      Çalışma süresi girdi boyutundan bağımsızdır.
                      Örneğin : dizi elemanına eirşmek 
                      int[] array = { 1, 2, 3, 4, 5 };
                      int firstElement = array[0];

            b) O(LOGN) : Algoritmanın çalışma süresi logaritmik bir fonksiyon şeklinde büyüme gösterir.
                         Veri aralığı her bir iterasyonda yarıya düşüyorsa bu aklına gelmeli.
                         Örneğin : Binary Search algoritması.

            c) O(n) : Girdi boyutuyla doğrusal şekilde artan bir çalışma süresi vardır.
                      Örneğin : Dizinin elemanlarını ekrana yazdırmak.

            d) O(nlogn) : Girdi boyutunun logaritmik fonksiyonu ile girdi boyutu çarpılmak durumunda kalır.
                            Örneğin : 
                            public static void QuickSort(int[] array, int left, int right)
                            {
                                if (left < right)
                                {
                                    int pivotIndex = Partition(array, left, right);
                                    QuickSort(array, left, pivotIndex - 1);
                                    QuickSort(array, pivotIndex + 1, right);
                                }
                            }

                            private static int Partition(int[] array, int left, int right)
                            {
                                int pivot = array[right];
                                int i = left - 1;

                                for (int j = left; j < right; j++)
                                {
                                    if (array[j] < pivot)
                                    {
                                        i++;
                                        Swap(ref array[i], ref array[j]);
                                    }
                                }

                                Swap(ref array[i + 1], ref array[right]);
                                return i + 1;
                            }

                            private static void Swap(ref int a, ref int b)
                            {
                                int temp = a;
                                a = b;
                                b = temp;
                            }

                
            e) O(n^2) : Çalışma süresi girdinin karesiyle doğru orantılıdır.
                        Örneğin : iç içe iki for döngüsü diyebiliriz.
            
            */

            #region O(1)

            int[] array = { 1, 2, 3, 4, 5 };
            int firstElement = array[0];
            
            #endregion

            #region O(logn) 

            
            int[] sortedArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int target = 12;
            int index = BinarySearch(sortedArray, target);
            
            if (index != -1)
            {
                Console.WriteLine("Hedef değer {0} dizinin {1}. indisinde bulundu.", target, index);
            }
            else
            {
                Console.WriteLine("Hedef değer bulunamadı.");
            }

            #endregion

            #region O(n)

            

            #endregion









        }
    }

}
