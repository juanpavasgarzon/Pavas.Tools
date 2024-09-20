using Microsoft.Extensions.DependencyInjection;
using Pavas.Tools.Math.Contracts;
using Pavas.Tools.Math.Options;

namespace Pavas.Tools.Math.DependencyInjection;

public static class Extensions
{
    public static void AddMathTool(this IServiceCollection services)
    {
        var toolOptions = MathToolOptions.Default;
        services.AddMathTool(toolOptions);
    }

    public static void AddMathTool(this IServiceCollection services, Action<IMathToolOptions> configure)
    {
        var toolOptions = MathToolOptions.Default;
        configure.Invoke(toolOptions);
        services.AddMathTool(toolOptions);
    }

    private static void AddMathTool(this IServiceCollection services, IMathToolOptions options)
    {
        services.AddSingleton(options);
        services.AddSingleton<IMathTool, MathTool>();
    }
}