using MiniProject1;

// Try out your application here
var bank = new Bank();
var queueLength = bank.GetQueueLength();
bank.ServeCustomers(queueLength);
Console.WriteLine("Time for a break!");
