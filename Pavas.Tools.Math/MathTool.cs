using Pavas.Tools.Math.Contracts;

namespace Pavas.Tools.Math;

internal class MathTool(IMathToolOptions options) : IMathTool
{
    public decimal Multiply(decimal first, decimal second, params decimal[] others)
    {
        var numbers = others.Prepend(second);
        var product = numbers.Aggregate(first, (multiplicand, multiplier) => multiplicand * multiplier);

        return System.Math.Round(product, options.Decimals);
    }

    public decimal Addition(decimal first, decimal second, params decimal[] others)
    {
        var numbers = others.Prepend(second);
        var total = numbers.Aggregate(first, (addendOne, addendTwo) => addendOne + addendTwo);

        return System.Math.Round(total, options.Decimals);
    }

    public decimal Subtract(decimal first, decimal second, params decimal[] others)
    {
        var numbers = others.Prepend(second);
        var difference = numbers.Aggregate(first, (minuend, subtrahend) => minuend - subtrahend);

        return System.Math.Round(difference, options.Decimals);
    }

    public decimal Divide(decimal first, decimal second, params decimal[] others)
    {
        var numbers = others.Prepend(second).ToArray();
        if (Array.Exists(numbers, divisor => divisor == decimal.Zero))
            return options.SafeDivisionByZero ? decimal.Zero : throw new DivideByZeroException();

        var quotient = numbers.Aggregate(first, (dividend, divisor) => dividend / divisor);

        return System.Math.Round(quotient, options.Decimals);
    }

    public decimal Average(decimal first, decimal second, params decimal[] others)
    {
        var total = Addition(first, second, others);
        var average = Divide(total, others.Length + 2m);

        return System.Math.Round(average, options.Decimals);
    }
}