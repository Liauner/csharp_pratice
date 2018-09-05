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


            //P5.十进制转十六进制
            Console.WriteLine("输入你想转化的十进制数:");
            Console.WriteLine(toSixteen(Convert.ToInt32(Console.ReadLine()),""));


            //P6.Write a program in C# Sharp to find maximum occurring character in a string.
            Console.WriteLine("输入字符串:");
            string a= Console.ReadLine();
            var result = a.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).OrderByDescending(c=>c.Value);
            foreach(var str in result){
                Console.WriteLine(str.Key);
                Console.WriteLine(str.Value);
                break;
            };

            */



        }
        public static string toSixteen(int ten,string sixten){
            if(ten/16==0){
                if(ten%16==0){
                    return sixten;
                }else{
                     sixten = tos(ten % 16) + sixten;
                    return sixten;
                }
            }

                int a = ten / 16;
                int b = ten % 16;
            sixten = tos(b) + sixten;
            return toSixteen(a, sixten);
        }

        public static string tos(int number){
            if(number<=9 && number>=0){
                return number.ToString();
            }else{
                return Convert.ToChar(('A' + (number - 10))).ToString();
            }

        }
    }
}
