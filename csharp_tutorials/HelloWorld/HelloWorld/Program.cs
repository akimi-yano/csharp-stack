using System;

namespace HelloWorld
{
    enum Mood 
    { 
        Happy = 100,
        Sad,
        Angry,
        Sleepy = 50,
    }

    public struct Book
    {
        public double price;
        public string title;
        public string author;
    }

    enum Direction
    { 
        Up,
        Down,
        Left,
        Right,
    }
    class Program
    {
        /// <summary>
        ///  this is a XML documentaiton comment 
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
            if (args.Length == 0 || (args.Length == 1 && args[0] == @"/?")) {
                Console.WriteLine("Please provide a Direction, bool and an int");
            } else if (args.Length < 2)
            {
                Console.WriteLine("Not enough arguments!");
            } else
            {
                var dirarg = Enum.Parse(typeof(Direction), args[0]);
                Console.WriteLine($"Direction: {dirarg}");
                var boolarg = bool.Parse(args[1]);
                Console.WriteLine($"Boolean: {boolarg}");
                if (args.Length == 3)
                {
                    var intarg = int.Parse(args[2]);
                    Console.WriteLine($"Int: {intarg}");
                }
                else if (args.Length > 3)
                {
                    Console.WriteLine("Too many arguments!");
                }
                }

            } catch(Exception e)
            {
                Console.WriteLine("Error! " + e);
            }

            /* this is a multi line 
             * comment 
             * wow 
             * star
             * comes 
             * automatically !
             */

            // this is a single line comment
            Console.WriteLine("Hello World!");
            //Console.ReadKey();

            // declearing variables
            bool isUsed;
            int number;
            double remainingMoney;
            char alphabet;
            string name;

            // initializing variables
            isUsed = false;
            number = 1;
            remainingMoney = 3.25;
            alphabet = 'a';
            name = "JU";

            // print
            Console.WriteLine($"{name}'s real name starts with {alphabet}, \nand the remaining money is {remainingMoney} dollars. \nThe favorite number is {number}. This computer is mine: {isUsed}!");

            int largestNumber = int.MaxValue;
            Console.WriteLine(largestNumber);
            largestNumber++;
            // integer overflow !
            Console.WriteLine(largestNumber);

            var isPalidrome = true;
            var score = 100;
            var eyeSight = 0.1;
            var yourLanguage = 'c';
            var tomorrow = "MY BD!";
            Console.WriteLine($"{isPalidrome.GetType().Name},{score.GetType().Name}, {eyeSight.GetType().Name}, {yourLanguage.GetType().Name}, {tomorrow.GetType().Name}");

            int x = 0;
            int y = 1;
            var z1 = x++;
            var z2 = ++y;
            Console.WriteLine($"{x},{y},{z1},{z2}");
            // note that ++ actually changes the value 

            int x2 = 4;
            int y2 = 4;
            int z = 4;
            int a = x2 + y2;
            int b = x2 - y2;
            int c = x2 * z;

            Console.WriteLine($"{x2},{y2},{z},{a},{b},{c}");

            int val = 2;
            int val2 = 3;
            bool isEven = val % 2 == 0;
            bool isEven2 = val2 % 2 == 0;

            Console.WriteLine(isEven);
            Console.WriteLine(isEven2);

            bool isDivisible = val % 3 != 0;
            bool isDivisible2 = val2 % 3 != 0;

            Console.WriteLine(isDivisible);
            Console.WriteLine(isDivisible2);

            double num = 3.1415926;
            double res = Math.Round(num, 3);
            Console.WriteLine(res);

            int xx = 1;
            int yy = 2;
            int zz = 3;

            double aa = 1.11;
            double bb = 2.22;
            double cc = 3.33;

            double store1 = xx;
            double store2 = yy;
            double store3 = zz;

            int store4 = (int)aa;
            int store5 = (int)bb;
            int store6 = (int)cc;

            Console.Write(store1);
            Console.Write(store2);
            Console.Write(store3);
            Console.Write(store4);
            Console.Write(store5);
            Console.Write(store6);

            Console.WriteLine("testing \nusing the escape stuff\n trying it out!");
            string literal = @"\nthis is a literal string !";
            Console.WriteLine(literal);

            string string1 = "Hello";
            string string2 = "World";
            Console.WriteLine(string1 + string2);

            string practice = "this is just a practice";
            Console.WriteLine($"the string is {practice} and its length is {practice.Length}");

            // string created = "ABCDE";
            string created = "ABCDEFG";
            int middleIdx = created.Length/2;
            Console.WriteLine($"{created[0]}{created[middleIdx]}{created[created.Length-1]}");

            string diary = "today is my birthday and I am very excited !!!!!";
            Console.WriteLine(diary.ToUpper());
            Console.WriteLine(diary.ToLower());


            //string part = "Russian Cat";
            string part = "Beautiful Princess";
            Console.WriteLine(part.Substring(1, part.Length - 2));
            string newPart1 = part.Remove(0, 1); 
            string newPart2 = newPart1.Remove(newPart1.Length - 2, 1);
            string newPart3 = part.Remove(part.Length - 2, 1).Remove(0, 1);
            Console.WriteLine(newPart2);
            Console.WriteLine(newPart3);

            string xxx = "tigers";
            char yyy = 's';

            int idx = xxx.IndexOf(yyy);
            bool isThere = xxx.Contains(yyy);
            Console.WriteLine(idx);
            Console.WriteLine(isThere);

            string fakePath = @"c:\foo\bar.txt";
            string fileName;
            int lastSlashIdx = fakePath.LastIndexOf("\\");
            int lastDotIdx = fakePath.LastIndexOf(".");
            fileName = fakePath.Substring(lastSlashIdx + 1, lastDotIdx-lastSlashIdx-1);

            //Console.WriteLine(fakePath);
            Console.WriteLine(fileName);
            //int driveIdx = fakePath.IndexOf(":");
            string drive = fakePath[0].ToString();
            Console.WriteLine(drive.ToUpper());


            string spacedOne = " hello world ! ";
            var spritted = spacedOne.Split(" ");
            //Console.WriteLine(spritted);
            Console.WriteLine("******");
            foreach (var elem in spritted) 
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine(spritted.Length);
            Console.WriteLine("******");

            Console.WriteLine("test");

            const string xxxxxxxx = "formatting tokens {0}";
            string yyyyyyyyyyy = string.Format(xxxxxxxx, "formatted");

            Console.WriteLine(yyyyyyyyyyy);



            double d = 3.123456789;
            Console.WriteLine(Math.Round(d,2));


            bool A = true;
            int B = 4;
            double C = 3.333;
            char D = 'P';
            string W = A.ToString();
            string X = B.ToString();
            string Y = C.ToString();
            string Z = D.ToString();

            bool E = bool.Parse(W);
            int F = int.Parse(X);
            double G = double.Parse(Y);
            char H = char.Parse(Z);


            Mood myMood = Mood.Happy;
            Console.WriteLine(myMood);
            Console.WriteLine(myMood.ToString());
            Console.WriteLine((int)myMood);

            Mood myMood1 = Mood.Angry;
            Console.WriteLine(myMood1);
            Console.WriteLine(myMood1.ToString());
            Console.WriteLine((int)myMood1);

            Mood myMood2 = Mood.Sad;
            Console.WriteLine(myMood2);
            Console.WriteLine(myMood2.ToString());
            Console.WriteLine((int)myMood2);

            Mood myMood3 = Mood.Sleepy;
            Console.WriteLine(myMood3);
            Console.WriteLine(myMood3.ToString());
            Console.WriteLine((int)myMood3);



            var myBook = new Book();
            myBook.title = "book title";
            myBook.author = "book author";
            myBook.price = 3.00;

            Console.WriteLine(myBook.title);

            var myBook2 = new Book();
            myBook2.title = "book title2";
            myBook2.author = "book author2";
            myBook2.price = 6.00;

            Console.WriteLine(myBook2.title);

            myBook.title = myBook2.title;
            myBook.author = myBook2.author;
            myBook.price = myBook2.price;
            Console.WriteLine(myBook.title);
            Console.WriteLine(myBook.author);
            Console.WriteLine(myBook.price);


            Console.WriteLine("Please enter your first name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Please enter your middle name");
            var middleName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            var lastName = Console.ReadLine();

            Console.WriteLine($"Your first name is: {firstName} and your middle name is: {middleName} and your last name is: {lastName} !");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
