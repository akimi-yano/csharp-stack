using System;
using System.Collections.Generic;

public class Test
{
	public static void Main()
	{
		int score = 0;
int threshold = 15;

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
score += total;

if ((roll1 == roll2) && (roll2 == roll3))
{
    score += 6;
}
else if  ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    score += 2;
}

if (score >= threshold)
{
    Console.WriteLine("YOU WIN !");
}
else
{
    Console.WriteLine("YOU LOSE !");
};
	}
}
