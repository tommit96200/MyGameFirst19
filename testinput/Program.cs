using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testinput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите число: ");
            string str = "qwe";
            int number = 1;
            bool tryinput = true;
            while(tryinput == true)
            {
                Console.WriteLine("Введите число: ");
                if (number < 0)
                {
                    try{
                        str = Console.ReadLine();                    
                        number = int.Parse(str);
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            }
        }
    }
}
