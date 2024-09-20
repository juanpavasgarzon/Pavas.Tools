
# Pavas.Tools.Math Library

This project provides a configurable math library that performs basic arithmetic operations such as multiplication, addition, subtraction, division, and average calculations. It supports custom configuration for behaviors such as safe division by zero and decimal rounding.

## Features

- **Multiplication**: Multiply a series of decimal numbers.
- **Addition**: Add a series of decimal numbers.
- **Subtraction**: Subtract a series of decimal numbers.
- **Division**: Divide a series of decimal numbers with optional safe division by zero handling.
- **Average**: Calculate the average of a series of numbers.
- **Configurable options**: Customize configuration

## Installation
Install the package into your project. `Pavas.Tools.Math`

## Usage

### 1. Dependency Injection Setup

The library can be injected into your project using a dependency injection manager.

```csharp
using Microsoft.Extensions.DependencyInjection;
using Pavas.Tools.Math.Contracts;
using Pavas.Tools.Math.Options;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Add MathTool with default options
        services.AddMathTool();
        
        // Or configure custom options
        services.AddMathTool(options =>
        {
            options.Decimals = 4;  // Set decimal rounding precision
            options.SafeDivisionByZero = true;  // Enable safe division by zero handling
        });
    }
}
```

### 2. Accessor Manager

The math tool can also be used without dependency injection by accessing it through an accessor.

```csharp
using Pavas.Tools.Math;

var mathTool = MathToolAccessor.UseDefault(); // Using default options

// Or configure the math tool with custom options
var customMathTool = MathToolAccessor.WithOptions(options =>
{
    options.Decimals = 3;
    options.SafeDivisionByZero = true;
});
```

### 3. Arithmetic Operations

You can perform various arithmetic operations using the `IMathTool` interface:

```csharp
// Multiplication
decimal result = mathTool.Multiply(10m, 5m, 2m);  // Result: 100.0000 (depending on decimal settings)

// Addition
decimal sum = mathTool.Addition(10m, 5m, 2m);  // Result: 17.0000

// Subtraction
decimal difference = mathTool.Subtract(10m, 5m, 2m);  // Result: 3.0000

// Division
decimal quotient = mathTool.Divide(100m, 2m);  // Result: 50.0000

// Average
decimal average = mathTool.Average(10m, 20m, 30m);  // Result: 20.0000
```

## Configuration Options

The following options are configurable:

- **Decimals**: Controls the number of decimal places for rounding results. Default is 10.
- **SafeDivisionByZero**: If set to `true`, division by zero returns `decimal.Zero`. If set to `false`, it throws a `DivideByZeroException`. Default is `false`.

## License

This project is licensed under the MIT License.
