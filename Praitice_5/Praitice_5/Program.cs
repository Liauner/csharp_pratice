using System;
using System.Linq;

namespace Praitice_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           /* //P1. Write a program in C# Sharp to input a string and print it.
            Console.WriteLine("输入字符串:");
            Console.WriteLine($"你输入的字符:{Console.ReadLine()}");

            //P2.Write a program in C# Sharp to find the length of a string without using library function. 
            Console.WriteLine("输入字符串:");
            Array str=Console.ReadLine().ToCharArray();
            int len=0;
            foreach(char s in str){
                len++;
            }
            Console.WriteLine($"字符串长度为:{len}");


            //P3.Write a program in C# Sharp to separate the individual characters from a string. 
            Console.WriteLine("输入字符串:");
            Array str = Console.ReadLine().ToCharArray();
            foreach (char s in str)
            {
                Console.Write(s+" ");
            }

            Console.WriteLine("输入字符串:");
            Array str =  Console.ReadLine().Reverse().ToArray();
            foreach (char s in str)
            {
                Console.Write(s + " ");
            }
            */

            //P4.Write a program in C# Sharp to count a total number of vowel or consonant in a string.
            Console.WriteLine("输入字符串:");
            string str =Console.ReadLine().ToLower();
            int yuan=0, fu=0;
            foreach(char s in str){
                if (s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u')
                    yuan++;
                if (s >= 'a' && s <= 'z')
                    fu++;
            }
            Console.WriteLine($"元音字符有{yuan}个");
            Console.WriteLine($"辅音字符有{fu}个");
        }
    }
}
