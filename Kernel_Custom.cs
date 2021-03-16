using System;

namespace ConsoleApp1
{
    class Program
    {
        static void drawfigures(string probeltext_1, int krug_x_1, int krug_y_1, int krug_x, int krug_y, int probel, int maxprobel, string textprobel, string probelmax, string probelmax_1, string probelmax_2, string probelmax_3, string probelmax_4, string probelmax_5, string probelmax_6, string probelmax_7, string probelmax_8, int kru, int kr, int kru0, int kr0, int kru1, int kr1, int kru2, int kr2, int kru3, int kr3, int kru4, int kr4, int kru5, int kr5, int kru6, int kr6, string t, string e, string x, string i, int krug_text_x, int krug_text_y, string input, string input0, string input1, string input2)
        {
            Console.SetCursorPosition(krug_x, krug_y);
            Console.ForegroundColor = ConsoleColor.Red;
            string probeltext = textprobel + probelmax + input;
            Console.WriteLine(probeltext);
            if (probel <= maxprobel)
            {
                probeltext += textprobel;
                Console.Clear();
                Console.Write(probeltext);
            }
            // \\ правый угол
            // / левый угол
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n" + probelmax_1 + input1);
            Console.WriteLine(probelmax_2 + input1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(probelmax_3 + input1);
            Console.WriteLine(probelmax_4 + input1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(probeltext_1 + input2);
            Console.WriteLine(probelmax_5 + input2);
            Console.WriteLine(probelmax_6 + input2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(probelmax_7 + input2);
            Console.SetCursorPosition(kru0, kr0);
            Console.Write(probelmax_8 + input1);
            Console.SetCursorPosition(kru1, kr1);
            Console.WriteLine(input1);
            Console.SetCursorPosition(kru2, kr2);
            Console.WriteLine(input1);
            Console.SetCursorPosition(kru3, kr3);
            Console.WriteLine(input2);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(kru4, kr4);
            Console.WriteLine(input2);
            Console.SetCursorPosition(kru5, kr5);
            Console.WriteLine(input2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(kru6, kr6);
            Console.WriteLine(input2);
            Console.SetCursorPosition(kru, kr);
            Console.WriteLine(input1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(krug_x_1, krug_y_1);
            Console.WriteLine(input1 + input0 + input2);
            Console.SetCursorPosition(krug_text_x, krug_text_y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(t);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(e);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(x);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(i);
            Console.SetCursorPosition(0, 9);
        }
        static void Main(string[] args)
        {
            //Програмируем отрисовку нашей фигуры
            //Сделаем фигуру по дефолту
            string d = "_____";
            string d0 = d;
            string d1 = "\\";
            //Левая сторона
            string d2 = "/";
            //Радиус всей фигуры
            string d3 = "   ";
//Можно добавить радужный текст в середине фигуры :P
            string d4 = "";
            string d5 = "";
            string d6 = "";
            string d7 = "";
            drawfigures("             ", 4, 8, 5, 5, 5, 5, "", d3 + "  ", d3 + "       ", d3 + "        ", d3 + "         ", d3 + "          ", d3 + "         ", d3 + "        ", d3 + "       ", d3, 2, 6, 0, 7, 1, 5, 1, 5, 1, 4, 2, 3, 3, 2, 4, 1, d4, d5, d6, d7, 4, 4, d, d0, d1, d2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Здравствуйте мы оставили этот код потому-что у некоторых могут возникнуть проблемы с другими кодами и с понятным кодом для тех кто учил c# не полностью но учил.");
            Console.SetCursorPosition(1,10);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
