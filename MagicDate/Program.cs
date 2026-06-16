using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Two Digit Year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (day * month == year)
        {
            Console.WriteLine("THE DATE IS MAGIC");
        }
        else
        {
            Console.WriteLine("NOT A MAGIC DATE");
        }
    }
}