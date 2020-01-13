using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace ConsoleGame19
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Default;

            Console.Title = "Приключения Ивана в армии";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;            
            Console.SetWindowSize(100, 25);
            Console.BufferHeight = 500;
            Console.BufferWidth = 100;

            StreamReader a = new StreamReader(@"Text\0.txt");
            Act act = new Act();
            int actChoice1 = 6, actChoice2 = 6, actChoice3 = 6, actChoice4 = 6, actChoice5 = 6, actChoice6 = 6;

            // НАЧАЛО
            ActTextPresents.TextPresents(a.ReadToEnd());

            //ПЕРВЫЙ ВЫБОР
            act.TextСhoice("-Меня Ваня звать, я сюда не пирожки есть пришел, а чтоб служить!", "Ответить взаимностью", "Уебать с ноги одного из старослужащих");

            // Первый АКТ

            actChoice1 = act.TextInput(actChoice1);
            act.TextOut(actChoice1);

            // Второй АКТ
            actChoice2 = act.TextInput(actChoice2);
            act.TextOut(actChoice1, actChoice2);

            // Третий АКТ
            actChoice3 = act.TextInput(actChoice3);
            act.TextOut(actChoice1, actChoice2, actChoice3);

            // Четвертый АКТ
            actChoice4 = act.TextInput(actChoice4);
            act.TextOut(actChoice1, actChoice2, actChoice3, actChoice4);
        }
    }
}
