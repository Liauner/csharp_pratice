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
            //pratice_3
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
        }
    }
}
