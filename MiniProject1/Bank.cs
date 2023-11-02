namespace MiniProject1;

public class Bank
{
    public readonly (string customerName, decimal balance)[] Accounts =
    {
        ("Alice Smith", 50m),
        ("Bob Jones", 200m),
        ("Charlie Taylor", 100m),
        ("David Brown", 70m),
        ("Eve Williams", 20m),
        ("Frank Wilson", 250m),
        ("Grace Johnson", 150m),
        ("Heidi Davies", 125m),
        ("Ivan Patel", 175m),
        ("Judy Robinson", 220m),
        ("Mallory Wright", 30m),
    };

    public int GetQueueLength()
    {
        throw new NotImplementedException();
    }

    public void ServeCustomers(int customerCount)
    {
        throw new NotImplementedException();
    }

    public virtual void ServeCustomer(int customerNumber)
    {
        throw new NotImplementedException();
    }

    public virtual void Deposit((string customerName, decimal balance) account)
    {
        throw new NotImplementedException();
    }

    public virtual void Withdraw((string customerName, decimal balance) account)
    {
        throw new NotImplementedException();
    }
}
