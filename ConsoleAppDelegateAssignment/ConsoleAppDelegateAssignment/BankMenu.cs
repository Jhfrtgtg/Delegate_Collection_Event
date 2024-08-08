/* Create a C# program to simulate a banking system. Implement 
a delegate named TransactionDelegate that represents a 
method signature for performing transactions. The banking 
system should allow customers to deposit, withdraw, and 
check balance. Use the delegate to handle transactions and 
ensure that withdrawal transactions do not result in negative 
balances.
Additional Requirement:
------------------------
* Implement a BankAccount class with properties for account 
number and balance.
* Create a Bank class responsible for managing bank 
accounts and handling transactions.
* Provide a menu-driven console for customers to perform 
operations like deposit, withdraw, and check balance
Hints:
------
* Use a dictionary to store bank accounts, where the account 
number serves as the key.
* Implement methods in the Bank class for depositing, 
withdrawing, and checking balance.
* Use the TransactionDelegate to handle transaction logic.
* Ensure proper error handling and validation for user input
* */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDelegateAssignment.Bank;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleAppDelegateAssignment.Service
{
    delegate void TransferMoney(double accountno,double account);
    public class Program
    {
     
        static void Main(string[] args)
        {
            
            BankClass Menu = new BankClass();
            TransferMoney Transfer = new TransferMoney(Menu.Withdraw);
         

            int choice1 = 0;
            while (choice1 != 7)
            {
                Console.WriteLine("\n Library Management");
                Console.WriteLine("1. Add  Account");
                Console.WriteLine("2. display account");
                Console.WriteLine("3.  remove account");
                Console.WriteLine("4.  withdraw money");
                Console.WriteLine("5.  add money");
                Console.WriteLine("6.  transfer money");
                Console.WriteLine("7 - exit");
                Console.WriteLine("8.  transfer money through delegate logic ");
                Console.WriteLine("Enter your choice  :");
                // Validate Choice
                choice1 = ValidatedInt();
                //Condition check
                switch (choice1)
                {
                    case 1:
                        // Add  Employee
                        BankAccount Account = new BankAccount();
                        Console.WriteLine("Making the isbn number");
                        Account.AccountNo = Menu.RandomNo();
                        Console.WriteLine($" Account No : " +
                            $"{Account.AccountNo} ");
                        Console.WriteLine(" would you lke savings account 1  for yes 2 for  no ");
                        int status = int.Parse(Console.ReadLine());
                        Account.CheckingAccount = 3000;
                        Account.SavingsAccount = 0;
                        Account.accountsavings = (status == 1) ? true : false;

                        Menu.AddAccount(Account.AccountNo, Account);
                        break;
                    case 2:
                        Console.WriteLine("Enter the  Account Number ");
                        double accountno = ValidatedDouble();
                        Menu.DisplayAccount(accountno);
                        break;
                    // Add Employee

                    case 3:
                        Console.WriteLine("Enter the Account no ");
                        double accountn = ValidatedDouble();
                        Menu.RemoveAccount(accountn);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Account no ");
                        double accountnm = ValidatedDouble();
                        Console.WriteLine("Enter the Account no");
                        double amount = ValidatedDouble();
                        Menu.Withdraw(accountnm, amount);
                        break;
                    case 5:
                        Console.WriteLine("Enter the Account no ");
                        double accountnm1 = ValidatedDouble();
                        Console.WriteLine("Enter  the amount to deposit ");
                        double amount1 = ValidatedDouble();
                        Menu.AddMoney(accountnm1, amount1);
                        break;
                    case 6:
                        Console.WriteLine("Enter the Account no from there money need to be withdrawn");
                        double accountnm2 = ValidatedDouble();
                        Console.WriteLine("Enter the Account to  be deposited ");
                        double accountnm3 = ValidatedDouble();
                        Console.WriteLine("Enter  the amount to deposit ");
                        double amount2 = ValidatedDouble();
                        Menu.Transfer(accountnm2, accountnm3, amount2);
                        break;

                    case 7:

                        break;
                    case 8:
                        Console.WriteLine("Enter the Account no from there money need to be withdrawn");
                        double accountnm4 = ValidatedDouble();
                        Console.WriteLine("Enter the Account to  be deposited ");
                        double accountnm5 = ValidatedDouble();
                        Console.WriteLine("Enter  the amount to deposit ");
                        double amount3 = ValidatedDouble();
                        Transfer(accountnm4, amount3);
                        Transfer += Menu.AddMoney;
                        Transfer -= Menu.Withdraw;
                        Transfer(accountnm5, amount3);
                        break;
                    default:
                        break;

                }
            }

            double ValidatedDouble()
            {
                double num; ;
                while (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Enter a  valid  number");
                }
                return num;
            }
            int ValidatedInt()
            {
                int num; ;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Enter a  valid  number");
                }
                return num;
            }
            



        }

    }
  }
