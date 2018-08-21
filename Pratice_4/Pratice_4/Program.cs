using System;

namespace Pratice_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Sort and Search
            //Pratice1
            /* Console.WriteLine("输入数组的大小：");
             int len = Convert.ToInt32(Console.ReadLine());
             int[] a = new int[len];
             for (int i = 0; i < len; i++)
             {
                 Console.WriteLine($"输入第{i + 1}个数：");
                 a[i] = Convert.ToInt32(Console.ReadLine());
             }
             */
            int[] a ={13,14,94,33,82,25,59,94,65,23,45,27,73,25,39,10};
            Console.WriteLine($"排序后:[{string.Join(",", Shellsort(a))}]");
        }

        public static int[] Shellsort(int[] array)
        {
            int num=0, l=0, m = 0;
            l = array.Length;
            for (int i = l / 2; i >= 1;)
            {
                for (int j = i; j < l; j++)
                {
                    m = i;
                    for (int z = j;z<i-1 ; )
                    {
                        if (array[z] < array[z-i])
                        {
                            num = array[z];
                            array[z-i] = array[z];
                            array[z] = num;

                        }
                        z -= i;

                    }
                }
                i = i / 2;
            }
            Console.WriteLine(m);
            return array;

        }
    }
}
