using System;

public class ExceptionHandler
{
    public static void Main()
    {
        string input = "2";
        int index = 15;

        HandleMultipleExceptions(input, index);
    }

    public static void HandleMultipleExceptions(string input, int index)
    {
        try
        {
            int.Parse(input);
            Console.WriteLine(GetArrayElement(index));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range.");
        }
    }

    private static int GetArrayElement(int index) => Numbers[index];

    private static int[] Numbers => new int[] { 1, 2, 3 };
}


