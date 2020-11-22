using System;
// system.Linq is needed to use .Sum()
using System.Linq;

namespace HelloWorld2
{

    public enum Mood
    { 
        Happy, 
        Sad, 
        Angry, 
        Undefined,
    }
    class Program
    {
        static void Test(string a)
        {
            Console.WriteLine(a);
        }

        static string Test2(string A, string B, string C)
        {
            return A+B+C;
        }
        static int[] Test3(int[] arr, int index, int value)
        {
            if (index < arr.Length && index >= 0)
            {
                arr[index] = value;
            }
            return arr;
        }
        static string Test4(string oldStr)
        {
            var splittedArr = oldStr.Split();
            string newString = "";
            for (int skipId = 0; skipId < splittedArr.Length; skipId += 2)
            {
                newString += splittedArr[skipId] + " ";
         
            }
            return newString.TrimEnd();
        }

        static string Test5(string inputStr, int inputIdx = 0, int inputLength = 0)
        {
            if (inputLength != 0)
            {
                return inputStr.Substring(inputIdx, inputLength);
            }

            else
            {
                return inputStr.Substring(inputIdx);
            }
        }
        static bool AreArraysEqual(int[] array1, int[] array2)
        { 
            if (array1.Length != array2.Length)
            {
                return false;
             }
            for (int idx = 0; idx < array1.Length; idx++)
            { 
                if (array1[idx]!=array2[idx])
                {
                    return false;
                }
            }
            return true;
        }
        static void outParameters(int num1, int num2, out int sum, out int diff, out int prod, out int quot)
        {
            sum = num1 + num2;
            diff = num1 - num2;
            prod = num1 * num2;
            quot = num1 / num2;
        }
        static char referenceParameters(string STR, ref int REFIDX)
        {
            if (REFIDX < 0)
            {
                REFIDX = 0;
            }
            else if (REFIDX > STR.Length-1)
             {
                REFIDX = STR.Length - 1;
            }
            return STR[REFIDX];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
            else if (s2.Length >= 10)
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
            for (int ind = 0; ind < birthday.Length; ind++)
            {
                if (ind % 2 != 0)
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
                            if (l == i || l == j || l == k)
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
                temp[number] = number + 1;
                number++;
            }

            for (int revId = 9; revId > -1; revId--)
            {
                Console.WriteLine(temp[revId]);
            }

            int sum = temp.Sum();
            Console.WriteLine(sum);

            // print what is in the array without looping through
            Console.WriteLine(string.Join(",", temp));

            var twoD = new int[3, 3];
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



            var myMood = Mood.Sad;

            switch (myMood)
            {
                case Mood.Happy:
                    Console.WriteLine("HAPPY");
                    break;
                case Mood.Angry:
                    Console.WriteLine("ANGRY");
                    break;
                case Mood.Sad:
                    Console.WriteLine("SAD");
                    break;
                default:
                    Console.WriteLine("NOTHING");
                    break;
            }

            Test("testing to see if this works");
            Console.WriteLine(Test2("AB", "CD", "EF"));

            int[] array = { 1, 2, 3 };
            int I = 1;
            int Val = 5;
            var tempArr = Test3(array, I, Val);
            Console.WriteLine(string.Join(",", tempArr));

            Console.WriteLine(Test4("to be or not to be"));
            Console.WriteLine(Test5("I just wanna eat my cake!", 10, 5));
            Console.WriteLine(Test5("I just wanna eat my cake!", 0, 5));
            Console.WriteLine(Test5("I just wanna eat my cake!", 10));
            Console.WriteLine(Test5("I just wanna eat my cake!"));


            int[] temp1 = new int[] { 1, 2, 3, 4, 5 };
            int[] temp2 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] temp3 = new int[] { 1, 2, 6,3, 6 };
            int[] temp4 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(AreArraysEqual(temp1, temp2));
            Console.WriteLine(AreArraysEqual(temp1, temp3));
            Console.WriteLine(AreArraysEqual(temp1, temp4));


            int total = 0;
            int difference = 0;
            int product = 0;
            int quotient = 0;
            Console.WriteLine($"Parameters before: {total},{difference},{product},{quotient}");
            outParameters(1, 2, out total, out difference, out product,out quotient);
            Console.WriteLine($"Parameters after: {total},{difference},{product},{quotient}");

            int refint = 9001;
            string str = "abc";

            Console.WriteLine($"Parameters before ref: {refint}");
            char chr = referenceParameters(str, ref refint);
            Console.WriteLine($"Parameters after ref: {refint}");
            Console.WriteLine($"Char: {chr}");
        }
    }

}
