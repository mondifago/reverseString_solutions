namespace Reverse_String_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Type the word you want to reverse and press enter:");
        Console.WriteLine("\n");

        string userInput = Console.ReadLine();
        char[] charUserInput = userInput.ToCharArray();

        Array.Reverse(charUserInput);

        string reversedStr = new string(charUserInput);

        Console.Write($"Actual String is : {userInput} \n");
        Console.Write($"Reversed String is : {reversedStr} \n");
      
    }
}

