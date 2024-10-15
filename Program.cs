using System;

public class Program
{
    public static string name;
    public static int inputAge;
    public static string eyeColor;
    public static string hairColor;
    public static int shoeSize;
    public static string favoriteColor;
    public static string favoriteTVorMovie;
    public static string favoriteTeacher;
    public static string favoriteClass;
    public static string favoriteHoliday;
    public static string favoriteSeason;
    public static string dreamJob;
    public static int numberOfSiblings;
    public static int ageIn5Years;
    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(inputAge);
        AskNumberOfSiblings();
        DisplaySummaryMessage();
    }
    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
    }
    public static void AskAge()
    {
        Console.WriteLine("What is your age?");
        inputAge = int.Parse(Console.ReadLine());
    }
    public static void AskEyeColor()
    {
        Console.WriteLine("What is your eye color?");
        eyeColor = Console.ReadLine();
    }
    public static void AskHairColor()
    {
        Console.WriteLine("What is your hair color?");
        hairColor = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
        Console.WriteLine("What is your shoe size?");
        shoeSize = int.Parse(Console.ReadLine());
    }
    public static void AskFavoriteColor()
    {
        Console.WriteLine("What is your favorite color?");
        favoriteColor = Console.ReadLine();
    }
    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("What is your favorite tv show or movie?");
        favoriteTVorMovie = Console.ReadLine();
    }
    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("Who is your favorite teacher?");
        favoriteTeacher = Console.ReadLine();
    }
    public static void AskFavoriteClass()
    {
        Console.WriteLine("What is your favorite class?");
        favoriteClass = Console.ReadLine();
    }
    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What is your favorite holiday?");
        favoriteHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason()
    {
        Console.WriteLine("What is your favorite season?");
        favoriteSeason = Console.ReadLine();
    }
    public static void AskDreamJob()
    {
        Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine();
    }
    public static void CalculateAgeIn5Years(int inputAge)
    {
        ageIn5Years = inputAge + 5;
    }
    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        numberOfSiblings = int.Parse(Console.ReadLine());
    }
    public static void DisplaySummaryMessage()
    {
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + inputAge + " years old. " + name + "'s eye color is " + eyeColor + " while their hair color is " + hairColor + ". Their shoe size is a size " + shoeSize + ". Meanwhile their favorite color is " + favoriteColor + ", their favorite TV show or movie is " + favoriteTVorMovie + ", their favorite teacher is " + favoriteTeacher + ", their favorite class is " + favoriteClass + ", their favorite holiday is " + favoriteHoliday + ", and their dream job is " + dreamJob + ". Their age in 5 years will be " + ageIn5Years + ", and at the moment they have " + numberOfSiblings + " siblings.");
    }
}