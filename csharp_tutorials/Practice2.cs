using System;
// system.Linq is needed to use .Sum()
using System.Linq;
public class Test
{
	public static void Main()
	{
		Console.WriteLine("Hello");
    
    int x = 1;
    x = 100;
    x = 200;
    if (x == 100)
    {
      Console.WriteLine("x is 100");
    }
    else if (x < 100)
    {
      Console.WriteLine("x is less than 100");
    }
    else
    {
      Console.WriteLine("x is larger than 100");
    }
    
    
    
    string s = "jvnkjnvdfkjvndfkjvndfkva";
    if (((s.Length < 5) && (s.Length % 2 != 0)) || ((s.Length >= 10) && (s.Length % 2 == 0)))
    {
      Console.WriteLine("string length is less than 5 and odd or greater than or equal to 10 and even");
    }
    
    
    
    
        string s2 = "jvnkjnvdfkjvndfkjvndfkva";
    if (s2.Length < 5) 
       {
        if (s2.Length % 2 != 0)
          {        
              Console.WriteLine("string length is less than 5 and odd or greater than or equal to 10 and even");
          }
       }   
    else if   (s2.Length >= 10)
      {
        if (s2.Length % 2 == 0)
          {
             Console.WriteLine("string length is less than 5 and odd or greater than or equal to 10 and even");
          }
      }
       
    
    
    // while (true)
    // {
    //   Console.WriteLine("infinite");
    // }
    
    
    string numberStr = "0123456789";
    int idx = 0;
    while (idx < numberStr.Length)
      {
        if (idx % 2 != 0)
          {
           Console.Write(numberStr[idx]);
          }
        idx++;
      }
    
    
    string test = "0123456789";
    int ii = 0;
    do 
    {
      if (ii % 2 != 0)
      {
        Console.Write(test[ii]);
      }
      ii++;
    }
    while (ii < test.Length);
    
    
    string birthday = "IWANTEVERYTHING";
    for (int ind = 0; ind < birthday.Length; ind++ )
    {
      if (ind % 2 != 0 )
      {
      Console.Write(birthday[ind]);
      }
    }
    
    int counter = 0;
    string shopping = "ICANTWAIT";
    foreach (var elem in shopping)
    {
      if (counter % 2 != 0)
      {
        Console.Write(elem);
      }
      counter++;    
    }
    
    
    Console.WriteLine();
    Console.WriteLine("START");
    for (int i = 1; i < 6; i++)
    {
         for (int k = 1; k < 6; k++)
        {
            if (i == k)
            {
              continue;
            } 
            for (int j = 1; j < 6; j++)
            {
                if (j == i || j == k)
                {
                  continue;
                }
                for (int l = 1; l < 6; l++)
                {
                    if (l == i || l == j || l == k )
                    { 
                      continue;
                    }
                    for (int m = 1; m < 6; m++)
                    {
                      if (m == l || m == j || m == k || m == i)
                      {
                        continue;
                      }
                      Console.WriteLine($"{i},{k},{j},{l},{m}");
                      
                    } 
                } 
            } 
        } 
    }
    Console.WriteLine("DONE");
    
    
    
    string cakeType = "bananabanana";
    var firstChar = cakeType[0];
    for (int pos = 1; pos < cakeType.Length; pos++)
    {
      if (cakeType[pos] == firstChar)
      {
        Console.WriteLine(pos);
        break;
      }
    }
    
    
    int[] temp = new int[10];
    int number = 0;
    while (number < 10)
    {
      temp[number] = number+1;
      number++;
    }
    
    for(int revId = 9; revId > -1; revId--)
    {
      Console.WriteLine(temp[revId]);
    }
    
    int sum = temp.Sum();
    Console.WriteLine(sum);
    
    // print what is in the array without looping through
    Console.WriteLine(string.Join("",temp));
    
    var twoD = new int[3,3];
    Console.WriteLine(twoD);
    for (int row = 0; row < twoD.GetLength(0); row++)
    {
      for (int col = 0; col < twoD.GetLength(1); col++)
      {
        twoD[row, col] = row * col;
        Console.WriteLine(twoD[row, col]);
      }
    }
    
    Console.WriteLine("WHY");
    Console.WriteLine("********************************");
    foreach (var curRow in twoD)
    {
      Console.WriteLine(curRow);
    }
    
    
	}
}
