using System;
using System.Linq;

namespace Pratice_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Array
            /*//Pratice_11 and 12
            Console.WriteLine($"[{string.Join(",", OrderArray(5, 0))}]"); 
            */
            /*//Pratice_14

            Console.WriteLine("请输入数组大小：");
            int length=Convert.ToInt32(Console.ReadLine())+1;
            int[] a = new int[length];
            for (int i = 0; i < length - 1;i++){
                Console.WriteLine($"第{i+1}个数为：");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("输入要插入的数字");
            int InsertNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入要插入的位置");
            int InsertIndex = Convert.ToInt32(Console.ReadLine());
            while(true){
                if(InsertIndex>length+1||InsertIndex<=-1){
                    Console.WriteLine("超出位置，请重新输入：");
                    InsertIndex= Convert.ToInt32(Console.ReadLine());
                }
                break;
            };
            for (int j = length-1 ; j+1 >= InsertIndex;j--){
                if (InsertIndex == j+1)
                {
                    a[j] = InsertNumber;

                }
                else { if(j!=0)a[j] = a[j - 1];
                }
            }
            Console.WriteLine($"[{string.Join(",",a)}]");
            */
            /*//Pratice_16 and 17
            int length;
            Console.WriteLine("输入数组大小:");
            length = Convert.ToInt32(Console.ReadLine());
            while(true){
                if (length < 2)
                {
                    Console.WriteLine("数组大小必须大于2");
                    length = Convert.ToInt32(Console.ReadLine());
                }
                else { break; }
            };
            int[] a = new int[length];
            for (int i=0; i < a.Length;i++){
                Console.WriteLine($"输入第{i+1}个整数：");
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"第二个最大数为{SecondMax(a)}");
            */
            /*//Pratice_7
            int[] a = { 1,2,3,4,5};
            int[] b = { 10,9,8,7};
            int[] c = new int[a.Length + b.Length];
            a.CopyTo(c, 0);
            b.CopyTo(c, a.Length);
            Console.WriteLine($"{string.Join(",",c.OrderBy(x=>x).ToArray())}");
            */
        }

        //P_16 and 17
        public static int SecondMax(int[] ar){
            int[] arr= ar.OrderBy(x => x).ToArray();
            return arr[ar.Length - 2];
        }

        public static int[] OrderArray(int length,int order){
            int[] a = new int[length];
            int[] c;
            for (int i = 0; i < length;i++){
                Console.Write($"第{i+1}个数字：");
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            c=order == 0 ?
             a.OrderBy(b => b).ToArray() : a.OrderByDescending(b => b).ToArray();
            return c;

        }
    }
}
