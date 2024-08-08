using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateAssignment.Bank
{
    public class BankAccount
    {
    public double AccountNo{get; set;}
     public double CheckingAccount { get; set; }
     public double SavingsAccount { get; set; }
       public  bool accountsavings { get; set; }

    }
}
/*Create a C# program to simulate a banking system. Implement 
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