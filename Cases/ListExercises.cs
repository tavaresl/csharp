using System;
using System.Collections.Generic;

namespace Cases
{
  public class ListExercises
  {
    public void ShowLikersNames()
    {
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
        Console.WriteLine("{0}, {1} and {2} others like your post",
          names[0], names[1], names.Count - 2);
      else if (names.Count == 2)
        Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
      else if (names.Count == 1)
        Console.WriteLine("{0} likes your post", names[0]);
    }

    public void ShowReversedName()
    {
      Console.WriteLine("Enter your name:");

      var username = Console.ReadLine();
      var nameLength = username.Length;
      var chars = new char[nameLength];

      for (var i = nameLength; i > 0 ; i--)
        chars[nameLength - i] = username[i - 1];

      var reversedName = new string(chars);

      Console.WriteLine("Your reversed name: {0}", reversedName);
    }

    public void Run()
    {
      Console.WriteLine(@"Choose an exercise:
        1 - Show name of people who liked your post
        2 - Show the reversed name of the user"
      );

      var exerciseNumber = Console.ReadLine();

      switch (exerciseNumber)
      {
        case "1":
          ShowLikersNames();
          break;

        case "2":
          ShowReversedName();
          break;

        default:
          Console.WriteLine("Invalid exercise");
          break;
      }
    }
  }
}
