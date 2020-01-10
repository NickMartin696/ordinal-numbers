using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Max: ");
    //Console.WriteLine(UInt32.MaxValue);
    string input = Console.ReadLine();

    try {
      uint max = uint.Parse(input);

      for (int i = 1; i <= max; i++)
      {
        if (i == 0)
        {
          Console.WriteLine(i);
          continue;
        }
        switch(i % 100)
        {
          case 11:
          case 12:
          case 13:
          Console.WriteLine($"{i}th");
          continue;
        }
        switch(i % 10) {
          case 1:
          Console.WriteLine($"{i}st");
          continue;
          case 2:
          Console.WriteLine($"{i}nd");
          continue;
          case 3:
          Console.WriteLine($"{i}rd");
          continue;
          default:
          Console.WriteLine($"{i}th");
          continue;
        }
      }
    }
    catch(OverflowException)
    {
      Console.WriteLine($"Hey pal...{input} is out of range of the Uint 32 type!!!");
    }
    catch(FormatException)
    {
      
    }
  }
}