using FakeItEasy;
using FluentAssertions;

namespace MiniProject1.Test;

public class TestBank
{
    [Theory]
    [InlineData(2)]
    [InlineData(17)]
    public void GetQueueLength_Called_ReturnsExpectedQueueLength(int expectedQueueLength)
    {
        // Arrange
        var bank = new Bank();
        var stringReader = new StringReader($"{expectedQueueLength}\n");
        Console.SetIn(stringReader);

        // Act
        var queueLength = bank.GetQueueLength();

        // Assert
        queueLength.Should().Be(expectedQueueLength);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(12)]
    public void ServeCustomers_CalledWithCustomerCount_CallsServeCustomerMethodExpectedNumberOfTimes(
        int customerCount
    )
    {
        // Arrange
        var bank = A.Fake<Bank>();

        // Act
        bank.ServeCustomers(customerCount);

        // Assert
        A.CallTo(() => bank.ServeCustomer(A<int>.Ignored))
            .MustHaveHappenedANumberOfTimesMatching(number => number == customerCount);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void ServeCustomer_CalledWithAnyCustomerNumber_CallsDepositMethodIfCustomerSelectsOptionD(
        int customerIndex
    )
    {
        // Arrange
        var bank = A.Fake<Bank>();
        A.CallTo(() => bank.ServeCustomer(A<int>.Ignored)).CallsBaseMethod();
        var stringReader = new StringReader($"{bank.Accounts[customerIndex].customerName}\nD\n");
        Console.SetIn(stringReader);

        // Act
        bank.ServeCustomer(2);

        // Assert
        A.CallTo(() => bank.Deposit(bank.Accounts[customerIndex])).MustHaveHappenedOnceExactly();
        A.CallTo(() => bank.Withdraw(bank.Accounts[customerIndex])).MustNotHaveHappened();
    }
}
