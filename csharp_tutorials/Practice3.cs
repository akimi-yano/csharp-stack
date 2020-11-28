using System;

public class Test
{
  static bool IsFirstCharRepeated(string word)
    {
      if (word.Length < 1)
      {
        return false;
      }
      char firstChar = word[0];
      for (int i = 1; i < word.Length; i++)
      {
        if (word[i] == firstChar)
        {
          return true;
        }
      }
      return false;
    }
    
	public static void Main()
	{
		Console.WriteLine("Hello");
    Console.WriteLine(IsFirstCharRepeated("abcda"));
    
	}
}
