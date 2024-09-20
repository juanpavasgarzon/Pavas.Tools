using Pavas.Tools.Math;

const decimal first = 15.34003445432324m;
const decimal second = 76.34003434320m;
const decimal other = 4.12345678901234567890m;

var defaultMathTool = MathToolAccessor.UseDefault();

var defaultAddition = defaultMathTool.Addition(first, second, other);
Console.WriteLine("Default Addition Result {0}", defaultAddition);

var defaultSubtract = defaultMathTool.Subtract(first, second, other);
Console.WriteLine("Default Subtract Result {0}", defaultSubtract);

var defaultMultiply = defaultMathTool.Multiply(first, second, other);
Console.WriteLine("Default Multiply Result {0}", defaultMultiply);

var defaultDivide = defaultMathTool.Divide(first, second, other);
Console.WriteLine("Default Divide Result {0}", defaultDivide);

var defaultAverage = defaultMathTool.Average(first, second, other);
Console.WriteLine("Default Average Result {0}", defaultAverage);


var configuredMathTool = MathToolAccessor.WithOptions(options =>
{
    options.SafeDivisionByZero = true;
    options.Decimals = 2;
});

var configuredAddition = configuredMathTool.Addition(first, second, other);
Console.WriteLine("Configured Addition Result {0}", configuredAddition);

var configuredSubtract = configuredMathTool.Subtract(first, second, other);
Console.WriteLine("Configured Subtract Result {0}", configuredSubtract);

var configuredMultiply = configuredMathTool.Multiply(first, second, other);
Console.WriteLine("Configured Multiply Result {0}", configuredMultiply);

var configuredDivide = configuredMathTool.Divide(first, second, other);
Console.WriteLine("Configured Divide Result {0}", configuredDivide);

var configuredAverage = configuredMathTool.Average(first, second, other);
Console.WriteLine("Configured Average Result {0}", configuredAverage);