using System;

namespace Pratice_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {/*//pratice_1
            string a=Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(a,16));
          */
           /* //pratice_2
        int[] a = { 1, 3, -5, 4 };
        int[] b = { 1, 4, -5, -2 };
            int d = 0;
            foreach(int c in a){
                Console.WriteLine(c*b[d]);
                d++;
            }
            */
            /*//pratice_3
            string a=Console.ReadLine();
            int b = System.Convert.ToInt32(a);
            if(b%3==0){
                Console.WriteLine("是三的倍数");
            }
            else if(b%7==0){
                Console.WriteLine("是七的倍数");
            }
            else{
                Console.WriteLine("不是3和7的倍数");

            }
            */
            /*//pratice_4
            string a=Console.ReadLine();
            string[] b = a.Split(' ');
            Console.WriteLine(b[0]=="Hello");
            */
            /*//pratice_5
            string a=Console.ReadLine();
            Console.WriteLine(a.Substring(1,2).Equals("HP")?a.Remove(1,2):"flase");
            */
            //pratice_6
            Console.WriteLine("输入第一个整数：");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个整数：");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第三个整数：");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("最大:"+Math.Max(Math.Max(a,b),c));
            Console.WriteLine("最小:"+Math.Min(Math.Min(a, b), c));

        }
    }
}
