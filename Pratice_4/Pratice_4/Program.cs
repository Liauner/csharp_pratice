using System;
using System.Linq;

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
             int[] a = { 55, 94, 87, 1, 4, 32, 11, 77, 39, 42, 64, 53, 70, 12, 9};//{13,14,94,33,82,25,59,94,65,23,45,27,73,25,39,10};
            Console.WriteLine($"排序后:[{string.Join(",", Shellsort(a))}]");
            */
            /*//Pratice2 猴子排序
            int[] a ={ 55, 94, 87, 1, 4, 32, 11, 77, 39, 42, 64, 53, 70, 12, 9 };
            Bogosort(a);
            */
            /*//Pratice3 冒泡排序
            int[] a = { 55, 94, 87, 1, 4, 32, 11, 77, 39, 42, 64, 53, 70, 12, 9};
            int[] b = a.OrderBy(x => x).ToArray();
            Console.WriteLine($"[{string.Join(",",b)}]");
            BubbleSort2(b);
            */
            /*//Pratice3(额外) 插入排序
            int[] a = { 55, 94, 87, 1, 4, 32, 11, 77, 39, 42, 64, 53, 70, 12, 9 };
            InsertionSort(a);
            */
            /*//Pratice4 计数排序
            int[] a = { 55, 94, 87, 1, 4, 32, 11, 77, 39, 42, 64, 53, 70, 12, 9 ,0,9};
            CountingSort(a);
            */
            /*//P5 堆排序
            int[] a = { 55, 94, 87, 1, 4, 32, 11, 77, 39, 42, 64, 53, 70, 12, 9, 0, 9 };
            new Heapsort(a).sort();
            Console.WriteLine($"[{string.Join(",",a)}]");
            */
            //P6归并排序
            int[] a = { 55, 94, 87, 1, 4, 32, 11, 77, 39, 42, 64, 53, 70, 12, 9 };
            Mergesort(a);
        }
        #region 希尔排序
        public static int[] Shellsort(int[] array)
        {
            int l = 0, m = 0;
            l = array.Length;
            for (int i = l / 2; i >= 1;)
            {
                for (int j = i; j < l; j++)
                {
                    m = array[j];
                    for (int z = j; ;)
                    {
                        if (z > i - 1 && array[z - i] >= m)
                        {
                            array[z] = array[z - i];
                            z -= i;
                        }
                        else
                        {
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
        #endregion

        #region 猴子排序
        public static void Bogosort(int[] a)
        {
            int sum = 0;
            while (!isOrder(shuffle(a)))
            {
                shuffle(a);
                sum++;
            }
            Console.WriteLine(sum);
        }

        public static Boolean isOrder(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] >= array[i])
                    return false;
            }
            return true;
        }

        public static int[] shuffle(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int swap = random.Next(array.Length);
                int temp = array[i];
                array[i] = array[swap];
                array[swap] = temp;
            }
            Console.WriteLine($"[{string.Join(",", array)}]");
            return array;
        }
        #endregion

        #region 冒泡排序 
        public static void BubbleSort(int[] array)
        {
            int len = array.Length - 1;
            int temp, sum = 0;
            for (int i = len; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    temp = array[j];
                    sum++;
                    if (array[j - 1] >= array[j])
                    {
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine($"[{string.Join(",", array)}]");
        }
        //冒泡改良，最优可为O(n)，关键在于swapped
        public static void BubbleSort2(int[] intArray)
        {
            int temp = 0;
            bool swapped;
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < intArray.Length - 1 - i; j++)
                {
                    sum++;
                    if (intArray[j] > intArray[j + 1])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                        if (!swapped)
                            swapped = true;
                    }

                }
                if (!swapped)
                    return;
            }
            Console.WriteLine(sum);

        }
        #endregion

        #region 插入排序
        public static void InsertionSort(int[] array)
        {
            int len = array.Length;
            int temp, i, j;
            for (i = 1; i < len; i++)
            {
                temp = array[i];
                j = i;
                while (j >= 1 && array[j - 1] > temp)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = temp;
            }
            Console.WriteLine($"[{string.Join(",", array)}]");
        }
        #endregion

        #region 计数排序
        public static void CountingSort(int[] array)
        {
            int len = array.Length;
            int k = 100;
            int[] Newarray = new int[len], Count = new int[k];
            int CountIndex;
            for (int i = 0; i < len; i++)
            {
                CountIndex = array[i];
                Count[CountIndex]++;
            }
            for (int j = 1; j < k; j++)
            {
                Count[j] = Count[j] + Count[j - 1];

            }
            for (int z = len - 1; z >= 0; z--)
            {
                CountIndex = array[z];
                Newarray[Count[CountIndex] - 1] = CountIndex;
                Count[CountIndex] -= 1;
            }
            Console.WriteLine($"[{string.Join(",", Newarray)}]");
        }



        #endregion

        #region 堆排序
        class Heapsort
        {
            private int[] arr;

            public Heapsort(int[] array)
            {
                arr = array;
            }
            private void swap(int a, int b)
            {
                int temp = arr[a];
                arr[a] = arr[b];
                arr[b] = temp;
            }
            private void maxHeapify(int index, int len)
            {
                int li = index * 2 + 1;
                int ri = li + 1;
                int cmax = li;
                if (li > len) return;
                if (ri <= len && arr[ri] > arr[li])
                    cmax = ri;
                if (arr[cmax] > arr[index])
                {
                    swap(index, cmax);
                    maxHeapify(cmax, len);
                }
            }
            public void sort()
            {
                int len = arr.Length - 1;
                int BeginIndex = len / 2 - 1;
                for (int i = BeginIndex; i >= 0; i--)
                {
                    maxHeapify(i, len);
                }

                for (int j = len; j > 0; j--)
                {
                    swap(0, j);
                    maxHeapify(0, j - 1);
                }

            }
        }
        #endregion
        #region 归并排序
        public static void Mergesort(int[] array)
        {
            int len = array.Length;
            int[] result = new int[len];
            int start, block;
            for (block = 1; block < len; block *= 2)
            {
                for (start = 0; start < len; start += 2 * block)
                {
                    int low = start;
                    int mid = (start + block) < len ? start + block : len;
                    int high = (start +2* block) < len ? start +2* block : len;
                    //
                    int start1 = low, end1 = mid;
                    int start2 = mid, end2 = high;
                    while (start1 < end1 && start2 < end2)
                        result[low++] = array[start1] < array[start2] ? array[start1++] : array[start2++];
                    while (start1 < end1)
                        result[low++] = array[start1++];
                    while (start2 < end2)
                        result[low++] = array[start2++];
                }
                int[] temp = array;
                array = result;
                result = temp;
            }
            Console.WriteLine($"[{string.Join(",",array)}]");
        }
        #endregion
    }
}
