# Getting started

JLib Tools can be added as a dependency to applications that require its shared utilities.

## Calculator

The `Calculator` class provides basic mathematical operations.

For example, an application can use the calculator to add two values:

```csharp
var calculator = new Calculator();

var result = calculator.Add(10, 20);
```

The calculator can also calculate the total of a collection of numbers using its Total method.

## Text transformation

The TextTransformer class provides simple text transformation operations. The v1.0 release includes a method for converting text to uppercase:

```csharp
var transformer = new TextTransformer();

var result = transformer.ToUpper("hello world");
// HELLO WORLD
```

See the [API reference](../api/index.html) for the complete list of available types and members.