﻿using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            myAccount.Deposit(amountToDeposit);
            Console.WriteLine($"Thnak you. Your new balance is ${myAccount.GetBalance()}");
        }
    }
}
