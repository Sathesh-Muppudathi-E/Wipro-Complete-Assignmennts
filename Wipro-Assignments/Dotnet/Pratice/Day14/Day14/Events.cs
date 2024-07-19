

using System;

public class Account
{
    public double Balance { get; private set; }
    public string AccountType { get; private set; }

    public event Action<Account> ProcessingTransaction;
    public event Action<Account> TransactionComplete;

    public Account(double balance, string accountType)
    {
        Balance = balance;
        AccountType = accountType;
    }

    public void ProcessTransaction(double amount)
    {
        OnProcessingTransaction();
        Balance += amount;
        OnTransactionComplete();
    }

    protected virtual void OnProcessingTransaction()
    {
        ProcessingTransaction?.Invoke(this);
    }

    protected virtual void OnTransactionComplete()
    {
        TransactionComplete?.Invoke(this);
    }
}

public class Subscriber
{
    public void OnProcessingTransaction(Account account)
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Processing transaction on account type: {account.AccountType} with current balance: {account.Balance}");
    }

    public void OnTransactionComplete(Account account)
    {
        Console.WriteLine("Transaction complete. ");
        Console.WriteLine($" New balance: {account.Balance}");
        Console.WriteLine($"Account type: {account.AccountType} ");
    }

}

public class Event
{
    public static void Main()
    {
        Account account = new Account(2000.0, "Savings");
        Subscriber subscriber = new Subscriber();

        account.ProcessingTransaction += subscriber.OnProcessingTransaction;
        account.TransactionComplete += subscriber.OnTransactionComplete;

        account.ProcessTransaction(300.0);
        account.ProcessTransaction(-100.0);
    }
}











