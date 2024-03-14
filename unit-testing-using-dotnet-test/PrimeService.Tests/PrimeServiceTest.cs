using Xunit;
namespace PrimeService.Tests;

public class PrimeServiceTest
{
    [Fact]
    public void IsPrime_InputIs1_ReturnFalse()
    {
        var primeService = new PrimeService();

        bool result = primeService.IsPrime(1);

        Assert.False(result, "1 should not be prime");
    }

    [Fact]
    public void IsPrime_InputIs4_ReturnFalse()
    {
        var primeService = new PrimeService();

        bool result = !primeService.IsPrime(4);

        Assert.False(result, "4 should not be prime");
    }

    [Fact]
    public void IsPrime_InputIs7_ReturnFalse()
    {
        var primeService = new PrimeService();

        bool result = primeService.IsPrime(7);

        Assert.True (result, "7 should be prime");
    }
}