using System;
using System.Linq;
using System.Collections.Generic;

namespace Cases
{
  public class ArraysAndLists
  {
    private const string QUIT = "quit";

    public void ShowLikersNames()
    {
      Console.Clear();
      Console.WriteLine("Show your likers' names\n");

      var names = new List<string>();
      
      while (true)
      {
        Console.WriteLine("Enter a name");
        var name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
          break;

        names.Add(name);
      }

      if (names.Count > 2)
        Console.WriteLine("\n{0}, {1} and {2} others like your post",
          names[0], names[1], names.Count - 2);
      else if (names.Count == 2)
        Console.WriteLine("\n{0} and {1} like your post", names[0], names[1]);
      else if (names.Count == 1)
        Console.WriteLine("\n{0} likes your post", names[0]);
    }

    public void ShowReversedName()
    {
      Console.Clear();
      Console.WriteLine("Show your reversed name\n");
      Console.WriteLine("Enter your name:");

      var username = Console.ReadLine();
      var nameLength = username.Length;
      var chars = new char[nameLength];

      for (var i = nameLength; i > 0 ; i--)
        chars[nameLength - i] = username[i - 1];

      var reversedName = new string(chars);

      Console.WriteLine("\nYour reversed name: {0}", reversedName);
    }

    public void ShowSortedNumbers()
    {
      Console.Clear();
      Console.WriteLine("Show unique numbers in a set\n");

      var numbers = new int[5];

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine("Enter a number");
        string number = null;

        while(string.IsNullOrWhiteSpace(number))
        {
          number = Console.ReadLine();

          if (numbers.Contains(int.Parse(number)))
          {
            number = null;
            Console.WriteLine("Cannot insert duplicated numbers");
          }
        }

        numbers[i] = int.Parse(number);
      }

      Array.Sort(numbers);

      Console.WriteLine("Sorted numbers:");

      foreach(int number in numbers)
        Console.WriteLine(number);
    }

    public void ShowUniqueInputtedNumbers()
    {
      Console.Clear();
      Console.WriteLine("Show unique numbers in a set\n");

      var numbers = new HashSet<int>();
      var numberToAdd = "";

      while (true)
      {
        Console.WriteLine("Enter a number (or type \"quit\" to stop)");
        numberToAdd = Console.ReadLine();

        if (numberToAdd.ToLower().Equals(QUIT))
          break;
        
        numbers.Add(int.Parse(numberToAdd));
      }

      Console.WriteLine("\nNumbers you've entered:");
      
      foreach (int number in numbers)
        Console.WriteLine(number);
    }

    public void DisplayLowestThreeValues()
    {
      Console.Clear();
      Console.WriteLine("Display the lowest three values in a group of five\n");
      Console.WriteLine("Enter 5 values, separeted by comma");
      while (true)
      {
        var inputtedValues = Console.ReadLine();
        var values = inputtedValues.Split(',');

        if (values.Count() < 5)
        {
          Console.WriteLine("Invalid List\n");
          continue;
        }

        Array.Sort(values);

        Console.WriteLine("\nSmallest three values:");
        
        for (int i = 0; i < 3; i++)
          Console.WriteLine(values[i]);

        break;
      }
    }
    public void Run()
    {
      Console.Clear();
      Console.WriteLine("Arrays and Lists\n");
      Console.WriteLine("Choose an exercise");
      Console.WriteLine(@"
        1 - Show your likers' names
        2 - Show the reversed user's name
        3 - Sort numbers in a list
        4 - Show unique numbers in a set
        5 - Display lowest three values
      ");

      var exerciseNumber = Console.ReadLine();

      switch (exerciseNumber)
      {
        case "1":
          ShowLikersNames();
          break;

        case "2":
          ShowReversedName();
          break;

        case "3":
          ShowSortedNumbers();
          break;

        case "4":
          ShowUniqueInputtedNumbers();
          break;
        
        case "5":
          DisplayLowestThreeValues();
          break;

        default:
          Console.WriteLine("Invalid exercise");
          break;
      }
    }
  }
}
