
using System;
using System.Threading;

public class Account
{
    public int AccountId { get; set; }        // Unique identifier for the account
    public decimal AccountBalance { get; set; } // Current balance of the account
}

public class AccountManager
{
    private static readonly object LockObject = new object(); // Lock object to ensure thread safety

    public void Transfer(Account from, Account to, decimal amount)
    {
        lock (LockObject) // Acquire the lock to ensure exclusive access to the accounts
        {
            // Check if the 'from' account has sufficient balance for the transfer
            if (from.AccountBalance < amount)
            {
                Console.WriteLine($"Insufficient balance in Account {from.AccountId}. Transfer failed.");
            }
            else
            {
                // Deduct the amount from the 'from' account and add it to the 'to' account
                from.AccountBalance -= amount;
                to.AccountBalance += amount;
                Console.WriteLine($"Transferred {amount:C} from Account {from.AccountId} to Account {to.AccountId}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Initialize two accounts with IDs and initial balances
        var accountA = new Account { AccountId = 1, AccountBalance = 1000m };
        var accountB = new Account { AccountId = 2, AccountBalance = 500m };

        var accountManager = new AccountManager();

        // Create two threads to simulate concurrent transfers
        var transferThreadA = new Thread(() => accountManager.Transfer(accountA, accountB, 200m));
        var transferThreadB = new Thread(() => accountManager.Transfer(accountB, accountA, 150m));

        // Start the threads
        transferThreadA.Start();
        transferThreadB.Start();

        // Wait for both threads to complete
        transferThreadA.Join();
        transferThreadB.Join();

        // Display the final balances of both accounts
        Console.WriteLine($"Account A balance: {accountA.AccountBalance}");
        Console.WriteLine($"Account B balance: {accountB.AccountBalance}");
    }
}