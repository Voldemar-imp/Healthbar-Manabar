using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroHealth;
            int heroHealthMax = 10;
            int enemyHealth;
            int enemyHealthMax = 10;
            int heroMana;
            int heroManaMax = 10;
            int enemyMana;
            int enemyManaMax = 10;
            int heroBarPositionX = 2;
            int heroBarPositionY = 27;
            int enemyBarPositionX = 106;
            int enemyBarPositionY = 27;
            bool testIsContinue = true; 
            Random random = new Random();

            Console.CursorVisible = false;
            while (testIsContinue)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Тест отрисовки Healthbar и Manabar для двух оппонентов");
                Console.WriteLine("Продолжить?\n" +
                    "Нажмите любую клавишу, чтобы задать случайные значения для Healthbar и Manabar обоих оппонентов\n" +
                    "Нажмите: Escape - для выхода из программы");

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    testIsContinue = false;
                    Console.Clear();
                    break;
                }

                heroHealth = random.Next(heroHealthMax+1);
                heroMana = random.Next(heroManaMax + 1);
                enemyHealth = random.Next(enemyHealthMax+1);
                enemyMana = random.Next(enemyManaMax + 1);
                DrawBar(heroHealth, heroHealthMax, ConsoleColor.Red, heroBarPositionX, heroBarPositionY, '$');
                DrawBar(heroMana, heroManaMax, ConsoleColor.Blue, heroBarPositionX, heroBarPositionY+1, '.');
                DrawBar(enemyHealth, enemyHealthMax, ConsoleColor.Green, enemyBarPositionX, enemyBarPositionY, '&');
                DrawBar(enemyMana, enemyManaMax, ConsoleColor.DarkCyan, enemyBarPositionX, enemyBarPositionY +1, '?');              
            }

        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int positionX, int pozitonY, char simbol = ' ')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += simbol;
            }

            Console.SetCursorPosition(positionX, pozitonY);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += "_";
            }

            Console.Write(bar);
            Console.Write("]");
        }   
    }
}
