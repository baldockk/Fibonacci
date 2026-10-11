using Fibonacci;
using Xunit;

namespace Fibonacci.Tests;

public class UnitTest1
{
    [Fact]
    public void FibonacciTest()
    {
        var fib = new Fibonacci();
        int result = fib.GetIth(5);
        Assert.Equal(5, result);
    }
}
