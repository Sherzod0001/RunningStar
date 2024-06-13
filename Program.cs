using System;

Console.Clear();

Console.WriteLine("Welcome to our Running Star program");

int axisX = 1;
int axisY = 1;

Console.SetCursorPosition(axisX, axisY);
Console.Write('*');

while (true)
{
    if (axisX > 0 || axisY > 0)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInput = Console.ReadKey(true);

            Console.SetCursorPosition(axisX, axisY);
            Console.Write(' ');

            switch (keyInput.Key)
            {
                case ConsoleKey.RightArrow:
                    axisX++;
                    break;
                case ConsoleKey.LeftArrow:
                    axisX--;
                    break;
                case ConsoleKey.UpArrow:
                    axisY--;
                    break;
                case ConsoleKey.DownArrow:
                    axisY++;
                    break;
            }

            Console.SetCursorPosition(axisX, axisY);
            Console.Write('*');
        }
    }
    else 
    {
        Console.WriteLine("An error key was entered !!! ");
        Console.WriteLine("Please enter only '➡️' '⬅️' '⬆️' '⬇️' ");
    }
    
}