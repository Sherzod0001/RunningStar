# RunningStar!

## This program is used to move the * character on the console to the right, left, up and down by the user. The user can move the star using keyboard keys.

![Alt text](images/image-1.png)

----------------------------------

### Basic Functions

- The star can be moved using the user keys.
- Issue an error message if the user enters an invalid key.
- If the star exits the console, the program will stop and issue an error message.

---

### Code Explanation

1. When the program starts, the console is cleared and a welcome message is displayed to the user.

```cs
...
Console.Clear();

Console.WriteLine("Welcome to our Running Star program");
...
```
2. I set the starting position of the asterisk (\*) to (1, 1).


```cs
int axisX = 1;
int axisY = 1;

Console.SetCursorPosition(axisX, axisY);
Console.Write('*');
```

3. While Loop

```cs
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
}
catch (Exception exception)
{
    GetExceptionMessage();
}

```
Let me explain the code:

- Working with console keys: If the key is pressed (Console.KeyAvailable), we read the pressed key (Console.ReadKey(true)).

- Delete old star: Delete the star from the old position (Console.SetCursorPosition(axisX, axisY) and Console.Write(' ')).

- Check keys:
    - ConsoleKey.RightArrow: Move axisX to the right.
    - ConsoleKey.LeftArrow: Move axisX to the left.
    - ConsoleKey.UpArrow: Move axisX up.
    - ConsoleKey.DownArrow: Move axisX down.
    - If another key is pressed, output the message "You pressed the wrong key".

- Draw a star at a new position: Draw a star at a new position (Console.SetCursorPosition(axisX, axisY) and Console.Write('*')).

4. Throw an exception using the method to the console.

```cs
static void GetExceptionMessage()
{
    Console.WriteLine("You are out of console !!!");
    Console.WriteLine("Please start the program again !!!");
}

```
5. Run the program if you want to see the result !!!

