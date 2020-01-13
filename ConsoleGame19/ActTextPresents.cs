using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleGame19
{    
    /// <summary>
    /// Класс для вывода текста
    /// </summary>
    static class  ActTextPresents
    {        
        public static void TextPresents(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {                
                Console.Write(text[i]);
                Thread.Sleep(0);
            }

            Console.WriteLine("\nНажмите Enter что бы продолжить...");
            Console.ReadKey();
        }

        public static void TextPresents(string text,int timeSpeed)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(timeSpeed);
            }

            Console.WriteLine("\nНажмите Enter что бы продолжить...");
            Console.ReadKey();
        }
    }
}
