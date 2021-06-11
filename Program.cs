/*
* Program: Employee Info Saver
* Description: A program to Save your employees personal info
* Author: Adrian Sanchez
* Company: Edinburgh College
* Version: 1.0
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeFileWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberEmployees = 0;
            string[,] table = new string[numberEmployees, 4];
            string userInput = "1";
            while (userInput!="0")
            {
                
                userInput = Intro();
               
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        table = UserInput();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        ShowUp(table);
                        Console.WriteLine("\nPress Any Key To Continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "0":
                        Console.Clear();
                        break;

                    default:
                        {
                            Console.Clear();
                            DefaultCase();
                            break;
                        }
                }
            }
            Console.WriteLine("Thanks for using the app!");
            Console.ReadLine();
        }
        public static string Intro()
        {
            Console.WriteLine("[-------------------------------------------------------------------------------]");
            Console.WriteLine("                        Welcome to the Edinburgh College App \n                             What would you like to do?\n                                   1:Add User\n                                   2:Show User Info\n                                   0:Exit");
            Console.WriteLine("[-------------------------------------------------------------------------------]");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static void DefaultCase ()
        {
            Console.Clear();
            Console.WriteLine("[-------------------------------------------------------------------------------]");
            Console.WriteLine("              The option that you entered is invalid. Please try again.              ");
            Console.WriteLine("[-------------------------------------------------------------------------------]");
        }
        public static string[,] UserInput()
        {
            Console.WriteLine("How many employees does your company have?");
            int numberEmployees = Convert.ToInt32(Console.ReadLine());
            string[,] table = new string[numberEmployees, 4];
            for (int row = 0; row < numberEmployees; row++)
                        {
                            Console.WriteLine("Write the Forename of user " + (row + 1));
                            string forename = Console.ReadLine();
                            table[row, 0] = forename;
                            Console.WriteLine("Write the Surname of user " + (row + 1));
                            string surname = Console.ReadLine();
                            table[row, 1] = surname;

                            while (true)
                            {
                                Console.WriteLine("Write the Phone of user " + (row + 1));
                                string phone = Console.ReadLine();
                                if (phone.Length == 11)
                                {
                                    table[row, 2] = phone;
                                    break;
                                }
                                else
                                {
                                        Console.WriteLine("Invalid Phone Number. Please Try Again");
                                        continue;
                                }
                            }
                            while (true)
                            {
                                    Console.WriteLine("Write the Email of user " + (row + 1));
                                string email = Console.ReadLine();
                                int charPos = email.IndexOf('@');
                                if (charPos > 0)
                                {
                                    table[row, 3] = email;
                                    break;
                                }
                                else
                                {
                                        Console.WriteLine("Invalid Email. Please Try Again");
                                    continue;
                                }
                            }

                        }
            return table;
        }
        public static void ShowUp (string[,]table)
        {
            for (int user = 0; user < table.GetLength(0); user++)
            {
                Console.WriteLine("     User " + (user + 1));
                for (int row = 0; row < table.GetLength(1); row++)
                {
                    Console.Write(table[user, row] + "\n");
                }
                Console.WriteLine("");
            }
        }
    }
    
}
