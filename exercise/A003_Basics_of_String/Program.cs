// See https://aka.ms/new-console-template for more information
using System;

namespace A003_Basic_of_String 
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFriend = "Scott";
            string secondFriend = "Kendra";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name{firstFriend} has {firstFriend.Length} letters. ");
            Console.WriteLine($"The name{secondFriend} has {secondFriend.Length} letters. ");
        }
    }
}

