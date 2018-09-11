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



            //P7.Write a program in C# Sharp to sort a string array in ascending order. 
            Console.WriteLine("输入字符串");
            string a =Console.ReadLine();
            Console.WriteLine($"{string.Join("",a.OrderBy(c => c)) }");


            //P8.Write a program in C# Sharp to extract a substring from a given string without using the library function.
            Console.WriteLine("输入字符串:");
            string str= Console.ReadLine();
            Console.WriteLine("输入开始提取的位置：");
            int index= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入子字符串的长度：");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(substring(str,index,len));
            */

            //P9. Write a program in C# Sharp to read a string through the keyboard and sort it using bubble sort.
            Console.WriteLine("输入字符串数量");
            int len=Convert.ToInt32( Console.ReadLine());
            string[] array_str = new string[len];
            for (int i = 0; i < len;i++){
                Console.WriteLine($"输入第{i}个字符串：");
                array_str[i]=Console.ReadLine();
            }
            for (int i = 0; i < len;i++){
                for (int j = 0; j < len - 1 - i;j++){
                    if(string.Compare(array_str[j],array_str[j+1])>0){
                        string temp = array_str[j];
                        array_str[j] = array_str[j + 1];
                        array_str[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine($"[{string.Join(",",array_str)}]");



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

        public static string substring(string str,int index,int len){
            string newstr = "";
            for (int i = index - 1; i < index + len - 1;i++){
                newstr += str[i];
            }
            return newstr;

        }


    }
}
