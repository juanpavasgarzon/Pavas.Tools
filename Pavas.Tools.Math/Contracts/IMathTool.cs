namespace Pavas.Tools.Math.Contracts;

public interface IMathTool
{
    public decimal Addition(decimal first, decimal second, params decimal[] others);
    public decimal Subtract(decimal first, decimal second, params decimal[] others);
    public decimal Multiply(decimal first, decimal second, params decimal[] others);
    public decimal Divide(decimal first, decimal second, params decimal[] others);
    public decimal Average(decimal first, decimal second, params decimal[] others);
}