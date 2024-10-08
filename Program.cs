using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your eye color?");
        string eyeColor = Console.ReadLine();

        Console.WriteLine("What is your hair color?");
        string hairColor = Console.ReadLine();

        Console.WriteLine("What is your shoe size?");
        int shoeSize = int.Parse(Console.ReadLine());
        
        Console.WriteLine("What is your favorite color?");
        string favColor = Console.ReadLine();

        Console.WriteLine("What is your favorite tv show or movie?");
        string favTV = Console.ReadLine();

        Console.WriteLine("Who is your favorite teacher?");
        string favTeacher = Console.ReadLine();

        Console.WriteLine("What is your favorite class?");
        string favClass = Console.ReadLine();

        Console.WriteLine("What is your favorite holiday?");
        string favHoliday = Console.ReadLine();

        Console.WriteLine("What is your favorite season?");
        string favSeason = Console.ReadLine();

        Console.WriteLine("What is your dream job?");
        string dreamJob = Console.ReadLine();

        Console.WriteLine("How many siblings do you have?");
        int siblings = int.Parse(Console.ReadLine());

        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + " while their hair color is " + hairColor + ". Their shoe size is a size " + shoeSize + ". Meanwhile their favorite color is " + favColor + ", their favorite TV show or movie is " + favTV + ", their favorite teacher is " + favTeacher + ", their favorite class is " + favClass + ", their favorite holiday is " + favHoliday + ", and their dream job is " + dreamJob + ". Their age in 5 years will be " + (age + 5) + ", and at the moment they have " + siblings + " siblings.");
    }
}