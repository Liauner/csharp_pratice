using System;
using System.Linq;
using System.Text;

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
         /*//pratice_6
         Console.WriteLine("输入第一个整数：");
         int a=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("输入第二个整数：");
         int b = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("输入第三个整数：");
         int c = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("最大:"+Math.Max(Math.Max(a,b),c));
         Console.WriteLine("最小:"+Math.Min(Math.Min(a, b), c));
         */
         /*//pratice_7
            Console.WriteLine("输入第一个整数");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第一个整数");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a == b ? 0 : Math.Abs(a - 20) < Math.Abs(b - 20) ? a : b);
        */
         /*//pratice_8
             Console.WriteLine("输入字符串：");
             string str= Console.ReadLine();
             int b=str.Count(a => a == 'w');
             Console.WriteLine(b >= 1 &&b<= 3);
         */
         /*//pratice_9
             Console.WriteLine("输入字符串：");
             string str= Console.ReadLine();
             if(str.Length<=3){
                 Console.WriteLine(str.ToUpper());
             }
             else{
                 Console.WriteLine(str.Substring(0,4).ToLower()+str.Substring(4));
             }
         */
         /*//pratice_10
             Console.WriteLine("输入字符串：");
             string str=Console.ReadLine();
             string sttr = "";
             for (int i = 0; i < str.Length;i+=2){
                 sttr += str[i];
             }
             Console.WriteLine(sttr);
         */
         /*//praticec_11
             int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
             int sum = 0;
             foreach(int a in nums){
                 sum += a;
             }
             Console.WriteLine("总和为："+sum);
         */
         /*//pratice_12
            int[] a = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] b = { 1, 2, 2, 3,3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 }; 
            Console.WriteLine(a[0]==b[0]||a[a.Length-1]==b[b.Length-1]);
        */
         /*//pratice_13
            int[] a = { 1, 2, 8 };
            int[] f =new int[3] ;
            for (int c = a.Length - 1; c >=0; c--)
            {
                if(c-1<0){
                    f[a.Length - 1] = a[0];
                    continue;
                }
                f[c - 1] = a[c];
            }
            foreach(int e in f){
                Console.WriteLine(e);
            }
        */
         /*//pratice_14
            int[] a = { 1, 2, 5 };
            int[] b = { 0,3,8}; 
            int[] c = { -1,0,2 }; 
            Console.WriteLine($"[{a[1]},{b[1]},{c[1]}]");
            */
         /*//pratice_15
            int[] a = { 2, 4, 7, 8, 6 };
            bool c = false;
            foreach(int b in a){
                if (b % 2 != 0)
                {
                    c = true;
                }
            }
                Console.WriteLine(c ? "有奇数":"无奇数");
            */
            /*//pratice_16
             Console.WriteLine("输入字符串：");
            bool b = true;
            string a=Console.ReadLine();
            for (int i = 0; i<a.Length/2;i++){
                if (a[i] == a[a.Length - 1 - i])
                    continue;
                else
                    b = false;
            }
            Console.WriteLine(b?"是回文":"不是回文");
            */
            //pratice_16改
            string StringReverse(string str)
            {
                StringBuilder builder = new StringBuilder(str);
                for (int i = 0, j = str.Length - 1; i <= j;i++,j--){
                    builder[i] = str[j];
                    builder[j] = str[i];
                }
                return builder.ToString();
            } 
            Console.WriteLine("输入字符串：");
            string s=Console.ReadLine();
            Console.WriteLine(StringReverse(s).Equals(s)?"是回文":"不是回文");
        }
    }
}
