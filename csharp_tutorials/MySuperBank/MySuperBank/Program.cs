using System;

// OOP is a way for a computer to mimic the real world
// by grouping 

// You're going to create new types that represent a bank account. 
// Typically developers define each class in a different text file. 
// That makes it easier to manage as a program grows in size. 
// Create a new file named BankAccount.cs in the classes directory.

// This file will contain the definition of a bank account. 
// Object Oriented programming organizes code by creating types in the form of classes. 
// These classes contain the code that represents a specific entity. 
// The BankAccount class represents a bank account. 
// The code implements specific operations through methods and properties. 
// In this tutorial, the bank account supports this behavior:

// 1 It has a 10-digit number that uniquely identifies the bank account.
// 2 It has a string that stores the name or names of the owners.
// 3 The balance can be retrieved.

// 4 It accepts deposits.
// 5 It accepts withdrawals.

// 6 The initial balance must be positive.
// 7 Withdrawals cannot result in a negative balance.

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Tensai", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}. ");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());









            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }



            //account.MakeDeposit(-300, DateTime.Now, "stealing");

            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }


        }
    }
}
