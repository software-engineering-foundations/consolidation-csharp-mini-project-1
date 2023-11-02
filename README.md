# Mini-Project 1: Bank Branch Customer Service

Before starting the mini-project, make sure you have CSharpier and Husky installed:

```
dotnet tool install --global csharpier
dotnet tool install --global husky
```

Finally, run `husky install` at the root of the repository.

## Functionality (30 points)

### The `Accounts` array

This array contains records for each of the bank's customers. You should not edit the `accounts` array except to change the balances programatically.

### The `GetQueueLength` method

This method should do the following:
- Ask the user how many customers are in the queue and attempt to convert the response to an integer
- If the conversion failed or if the number provided is less than zero, keep asking the user until a suitable answer is provided
- Once a suitable answer is provided, return the number that results from the conversion

### The `ServeCustomers` method and beyond

This method should accept a customer count and then, for each number between 1 and the customer count (inclusive), do the following:
- Call a customer by their number (e.g. by outputting `"Customer number ___, please!"`) and ask for their name
- If their name matches an existing customer from the `accounts` array, tell them their current balance, ask them if they would like to deposit or withdraw from their account, ask them for an amount to deposit/withdraw, and process their transaction if it is valid. If it isn't valid, explain why not, and give them more chances to provide a valid amount. Reasons why a transaction might not be valid include:
  - Trying to deposit/withdraw a non-numeric amount
  - Trying to deposit/withdraw a negative amount
  - Trying to deposit/withdraw an amount with too many decimal places
  - Trying to withdraw an amount greater than the available balance
- If the name doesn't match an existing customer from the `accounts` array, explain that the bank is only working with existing customers at this time
This functionality should be appropriately split between the `ServeCustomers` method itself as well as the `ServeCustomer`, `Deposit` and `Withdraw` methods.

### The code in `Program.cs`
This code gets the queue length and uses this to serve all the waiting customers. You may edit this block for testing purposes, but it is not recommended to commit any changes to it.

## Code cleanliness (20 points)
Revisit your code once you're done. How much of a mess has it become? Try to streamline it as far as possible. If clear opportunities arise to extract pieces of complex functionality into their own methods, try doing so in order to make the code more readable and testable.

## Testing (50 points)
There are already example tests for the `GetQueueLength`, `ServeCustomers` and `ServeCustomer` methods, though you should consider adding more to cover other pieces of as-yet-untested functionality within these methods. You should also add more tests for the other methods. Remember to consider error paths as well as success paths.
