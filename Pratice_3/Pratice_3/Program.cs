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
            //Pratice_14

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
