using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stairs
{
    internal class Program
    {
        static void Main()
        {
            // TASK 1
            // Показать на экране лесенку. Должен быть реализован ввод с клавиатуры:

            Console.WriteLine("Please enter count of stairs:");
            int stairs;
            stairs = int.Parse(Console.ReadLine());
            for (int a = 0; a < stairs; a++)
            {
                Console.WriteLine("***");
                for (int b = -1; b < a; b++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("*");
                for (int c = -1; c < a; c++)
                {
                    Console.Write("  ");
                }
            }


        }
    }
}*/

namespace Numbers
{
    internal class Program
    {
        static void Main()
        {
            // TASK 2
            // Написать программу, которая будет считывать с консоли любое число и выводить его в 2Д изображении:

            
             string number = Convert.ToString(Console.ReadLine());
             
            void Show(char num)
            {
                switch (num)
                {
                    case '0':
                        Console.WriteLine(@"
                ****
                *  *
                *  *
                *  *
                ****");
                        break;
                    case '1':
                        Console.WriteLine(@"
                   *
                  **
                 * *
                   *
                   *");
                        break;
                    case '2':
                        Console.WriteLine(@"
                ****
                *  *
                   *
                 *
                *****");
                        break;
                    case '3':
                        Console.WriteLine(@"
                ****
                   *
                 ***
                   *
                ****");
                        break;
                    case '4':
                        Console.WriteLine(@"
                *  *
                *  *
                ****
                   *
                   * ");
                        break;
                    case '5':
                        Console.WriteLine(@"
                  *****
                  *
                 **
                   *
               ****");
                        break;
                    case '6':
                        Console.WriteLine(@"
                   ****
                  *    *    
                  **** 
                  *   *
                  ****");
                        break;
                    case '7':
                        Console.WriteLine(@"
                  *****
                     *
                    *
                   *
                  *");
                        break;
                    case '8':
                        Console.WriteLine(@"
                  *****
                  *   *
                  *****   
                  *   *
                  *****");
                        break;
                    case '9':
                        Console.WriteLine(@"
                  *****
                  *   *
                  *****
                      *
                  *****");
                        break;
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                Show(number[i]);
            }
        }
    }
}