using Pavas.Tools.Math.Contracts;
using Pavas.Tools.Math.Options;

namespace Pavas.Tools.Math;

public static class MathToolAccessor
{
    public static IMathTool UseDefault()
    {
        return new MathTool(MathToolOptions.Default);
    }

    public static IMathTool WithOptions(Action<IMathToolOptions> options)
    {
        var mathToolOptions = MathToolOptions.Default;
        options.Invoke(mathToolOptions);
        return new MathTool(mathToolOptions);
    }
}