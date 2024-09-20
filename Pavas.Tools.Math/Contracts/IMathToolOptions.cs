namespace Pavas.Tools.Math.Contracts;

public interface IMathToolOptions
{
    public int Decimals { get; set; }
    public bool SafeDivisionByZero { get; set; }
}