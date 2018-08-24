using System;

namespace Pratice_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Sort and Search
            //Pratice1 希尔排序
            /* Console.WriteLine("输入数组的大小：");
             int len = Convert.ToInt32(Console.ReadLine());
             int[] a = new int[len];
             for (int i = 0; i < len; i++)
             {
                 Console.WriteLine($"输入第{i + 1}个数：");
                 a[i] = Convert.ToInt32(Console.ReadLine());
             }
             */
            /* 解决
             int[] a = { 55, 94, 87, 1, 4, 32, 11, 77, 39, 42, 64, 53, 70, 12, 9, };//{13,14,94,33,82,25,59,94,65,23,45,27,73,25,39,10};
            Console.WriteLine($"排序后:[{string.Join(",", Shellsort(a))}]");
            */
            /*//Pratice2 猴子排序
            int[] a ={ 55, 94, 87, 1, 4, 32, 11, 77, 39, 42, 64, 53, 70, 12, 9, };
            Bogosort(a);
            */
        }
        //希尔排序
        public static int[] Shellsort(int[] array)
        {
            int  l=0, m = 0;
            l = array.Length;
            for (int i = l / 2; i >= 1;)
            {
                for (int j = i; j < l; j++)
                {
                    m = array[j];
                    for (int z = j; ; )
                    {
                        if(z>i-1&&array[z-i]>=m){
                            array[z] = array[z - i];
                            z -= i;
                        }
                        else{
                            array[z] = m;
                            break;
                        }

                    }
                }
                i = i / 2;
            }
            Console.WriteLine(m);
            return array;
        }

        public static void Bogosort(int[] a){
            int sum = 0;
            while (!isOrder(shuffle(a))){
                shuffle(a);
                sum++;
            } 
            Console.WriteLine(sum);
        }

        public static Boolean isOrder(int[] array){
            for (int i = 1; i < array.Length;i++){
                if (array[i - 1] >= array[i])
                    return false;
            }
            return true;
        }

        public static int[] shuffle(int[] array){
            Random random = new Random();
            for (int i = 0; i < array.Length;i++){
                int swap = random.Next(array.Length);
                int temp = array[i];
                array[i] = array[swap];
                array[swap] = temp;
            }
            Console.WriteLine($"[{string.Join(",",array)}]");
            return array;
        }
    }
}
