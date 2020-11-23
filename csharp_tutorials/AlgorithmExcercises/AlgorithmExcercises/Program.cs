using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AlgorithmExcercises
{
    class Program
    {

        static void Main(string[] args)
        {
            // Unit Test
            TestIsFirstCharRepeated();
            TestReverseString();
            TestRecursiveReverseString();
            TestRecursiveReverseString2();
            TestGetSumBetweenNumbers();
            TestRecursiceGetSumBetweenNumbers();
            TestXToTheYPower();
            TestRecursiveXToTheYPower();
            TestMultiplyList();
            TestRecursiveMultiplyList();
            TestFillRoomWithBoxes();
        }

        static bool IsFirstCharRepeated(string word)
        {
            if (word.Length < 2)
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

        static string ReverseString(string word)
        {
            string answer = "";
            for (int index = word.Length - 1; index > -1; index--)
            {
                answer += word[index];
            }
            return answer;
        }

        static string RecursiveReverseString(string word, int idx)
        {
            if (word.Length == 0)
            {
                return "";
            }
            if (idx == word.Length - 1)
            {
                return word[idx].ToString();
            }
            return RecursiveReverseString(word, idx + 1) + word[idx];
        }

        static string RecursiveReverseString2(string word)
        {
            if (word.Length == 0)
            {
                return "";
            }
            return word[word.Length - 1] + RecursiveReverseString2(word.Substring(0, word.Length - 1));
        }

        static int GetSumBetweenNumbers(int min, int max)
        {
            if (min > max)
            {
                return 0;
            }
            int sum = 0;
            for (int num = min; num <= max; num++)
            {
                sum += num;
            }
            return sum;
        }

        static int RecursiveGetSumBetweenNumbers(int cur, int max)
        {
            if (max < cur)
            {
                return 0;
            }
            return RecursiveGetSumBetweenNumbers(cur + 1, max) + cur;
        }


        static int XToTheYPower(int x, int y)
        {
            bool shouldMultiply = true;
            if (y < 0)
            {
                y = -y;
                shouldMultiply = false;
            }
            int prod = 1;
            for (int times = 0; times < y; times++)
            {
                if (shouldMultiply)
                {
                    prod *= x;
                }
                else
                {
                    prod /= x;
                }
            }
            return prod;
        }
        static int RecursiveXToTheYPower(int x, int y)
        {
            if (y < 0)
            {
                return RecursiveXToTheYPower(1 / x, -y);
            }
            if (y == 0)
            {
                return 1;
            }
            return RecursiveXToTheYPower(x, y - 1) * x;
        }

        static int MultiplyList(List<int> numbers)
        {
            int prod = 1;
            foreach (var num in numbers)
            {
                prod *= num;
            }
            return prod;
        }

        // Divie (Warizan) and Conquer
        static int RecursiveMultiplyList(List<int> numbers)
        {
            if (numbers.Count < 1)
            {
                return 1;
            }
            else if (numbers.Count == 1)
            {
                return numbers[0];
            }
            int mid = numbers.Count / 2;
            return RecursiveMultiplyList(numbers.GetRange(0, mid)) * RecursiveMultiplyList(numbers.GetRange(mid, numbers.Count - mid));
        }

        static void FillRoomWithBoxes(int roomSize, List<int> possibleSizes, List<int> boxes)
        {
            // possibleSized is list containing all possible box sizes - the list is sorted in descending order
            // possible sizes [7,3,1]
            // roomSize 25
            // boxes [7,7,7,3,1]

            // if the roomSize ( remaining becomes less than the current value, move on to the next smaller value
            if (possibleSizes.Count < 1)
            {
                return;
            }
            else if (roomSize < possibleSizes[0])
            {
                FillRoomWithBoxes(roomSize, possibleSizes.GetRange(1, possibleSizes.Count - 1), boxes);
            }
            else
            {
                boxes.Add(possibleSizes[0]);
                FillRoomWithBoxes(roomSize - possibleSizes[0], possibleSizes, boxes);
            } 
             
        }

        // TESTS

        static void TestIsFirstCharRepeated()
        {
            Debug.Assert(IsFirstCharRepeated("abcda"));
            Debug.Assert(!IsFirstCharRepeated("zbcda"));
        }
        static void TestReverseString()
        {
            Console.WriteLine(ReverseString("abcdefg"));
            Console.WriteLine(ReverseString(""));
        }
        static void TestRecursiveReverseString()
        {
            Console.WriteLine(RecursiveReverseString("abcdefg", 0));
            Console.WriteLine(RecursiveReverseString("", 0));
        }
        static void TestRecursiveReverseString2()
        {
            Console.WriteLine(RecursiveReverseString2("abcdefg"));
            Console.WriteLine(RecursiveReverseString2(""));
        }
        static void TestGetSumBetweenNumbers()
        {
            Console.WriteLine(GetSumBetweenNumbers(1, 10));
            Console.WriteLine(GetSumBetweenNumbers(50, 5));
        }
        static void TestRecursiceGetSumBetweenNumbers()
        {
            Console.WriteLine(RecursiveGetSumBetweenNumbers(1, 10));
            Console.WriteLine(RecursiveGetSumBetweenNumbers(50, 5));
        }
        static void TestXToTheYPower()
        {
            Console.WriteLine(XToTheYPower(2, 10));
            Console.WriteLine(XToTheYPower(2, 11));
            Console.WriteLine(XToTheYPower(2, 12));
            Console.WriteLine(XToTheYPower(2, 13));
            Console.WriteLine(XToTheYPower(2, -10));
            Console.WriteLine(XToTheYPower(2, -11));
            Console.WriteLine(XToTheYPower(2, -12));
            Console.WriteLine(XToTheYPower(2, -13));
        }
        static void TestRecursiveXToTheYPower()
        {
            Console.WriteLine(RecursiveXToTheYPower(2, 10));
            Console.WriteLine(RecursiveXToTheYPower(2, 11));
            Console.WriteLine(RecursiveXToTheYPower(2, 12));
            Console.WriteLine(RecursiveXToTheYPower(2, 13));
            Console.WriteLine(RecursiveXToTheYPower(2, -10));
            Console.WriteLine(RecursiveXToTheYPower(2, -11));
            Console.WriteLine(RecursiveXToTheYPower(2, -12));
            Console.WriteLine(RecursiveXToTheYPower(2, -13));
        }
        static void TestMultiplyList()
        {
            Console.WriteLine(MultiplyList(new List<int>() { 1, 2, 3, 4, 5 }));
            Console.WriteLine(MultiplyList(new List<int>() { 1, 2, 3, 0 }));

        }
        static void TestRecursiveMultiplyList()
        {
            Console.WriteLine(RecursiveMultiplyList(new List<int>() { 1, 2, 3, 4, 5 }));
            Console.WriteLine(RecursiveMultiplyList(new List<int>() { 1, 2, 3, 0 }));

        }
        static void TestFillRoomWithBoxes()
        {
            List<int> output = new List<int> { };
            FillRoomWithBoxes(25, new List<int>() { 7, 3, 1 }, output);
            Console.WriteLine(string.Join(",", output));


            List<int> output2 = new List<int> { };
            FillRoomWithBoxes(25, new List<int>() { 7, 3 }, output2);
            Console.WriteLine(string.Join(",", output2));
        }
    }
}
