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
            int heroHealth, heroHealthMax = 10, enemyHealth, enemyHealthMax = 10;
            int heroMana, heroManaMax = 10, enemyMana, enemyManaMax = 10;
            int heroBarPositionX = 2, heroBarPositionY = 27;
            int enemyBarPositionX = 106, enemyBarPositionY = 27;
            Random random = new Random();

            Console.CursorVisible = false;
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Тест отрисовки Healthbar и Manabar для двух оппонентов");
                heroHealth = random.Next(heroHealthMax+1);
                heroMana = random.Next(heroManaMax + 1);
                enemyHealth = random.Next(enemyHealthMax+1);
                enemyMana = random.Next(enemyManaMax + 1);
                DrawBar(heroHealth, heroHealthMax, ConsoleColor.Red, heroBarPositionX, heroBarPositionY, '$');
                DrawBar(heroMana, heroManaMax, ConsoleColor.Blue, heroBarPositionX, heroBarPositionY+1, '.');
                DrawBar(enemyHealth, enemyHealthMax, ConsoleColor.Green, enemyBarPositionX, enemyBarPositionY, '&');
                DrawBar(enemyMana, enemyManaMax, ConsoleColor.DarkCyan, enemyBarPositionX, enemyBarPositionY +1, '?');
                Console.ReadKey();
                Console.Clear();
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
