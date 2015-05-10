using System;



class LastNumberDigit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(num));
    }

    static string GetLastDigitAsWord(int num)
    {
        int result = num % 10;
        string lastDigit = "";
        switch (result)
        {
            case 1:
                lastDigit = "one";
                break;
            case 2:
                lastDigit = "two";
                break;
            case 3:
                lastDigit = "three";
                break;
            case 4:
                lastDigit = "four";
                break;
            case 5:
                lastDigit = "five";
                break;
            case 6:
                lastDigit = "six";
                break;
            case 7:
                lastDigit = "seven";
                break;
            case 8:
                lastDigit = "eight";
                break;
            case 9:
                lastDigit = "nine";
                break;
        }

        return lastDigit;
    }
}
