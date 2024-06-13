using System;

Console.WriteLine("Welcome to our Running Star program");

Console.Clear();



int axisX = 1;
int axisY = 1;

Console.SetCursorPosition(axisX, axisY);
Console.Write('*');

try
{
    while (true)
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
                default:
                    Console.WriteLine("You pressed the wrong key");
                    break;
            }

            Console.SetCursorPosition(axisX, axisY);
            Console.Write('*');
        }
    }

}catch (Exception exception)
{
    GetExceptionMessage();
}

static void GetExceptionMessage()
{   
    int axisYTwo = 0;
    int axisXTwo = 0;
    Console.SetCursorPosition(axisXTwo, axisYTwo);
    Console.WriteLine("You are out of console!!");
    Console.WriteLine("Please start the program again!!!");
}