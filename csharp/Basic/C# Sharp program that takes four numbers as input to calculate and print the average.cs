using System;
public class Exercise9
{
    public static void Main()
    {
        int number1,number2,number3,number4;
        Console.Write("Enter the First number: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Second number: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third number: ");
        number3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the four number: ");
        number4 = Convert.ToInt32(Console.ReadLine());
        int result = (number1 + number2 + number3 + number4) / 4;
        Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4} ",
                          number1, number2, number3, number4, result);
    }
}