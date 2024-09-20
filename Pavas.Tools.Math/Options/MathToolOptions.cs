using Pavas.Tools.Math.Contracts;

namespace Pavas.Tools.Math.Options;

internal class MathToolOptions : IMathToolOptions
{
    public required int Decimals { get; set; }
    public required bool SafeDivisionByZero { get; set; }

    public static IMathToolOptions Default => new MathToolOptions
    {
        Decimals = 10,
        SafeDivisionByZero = false
    };
}