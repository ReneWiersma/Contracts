# Preconditions

This Preconditions library provides methods to check on a precondition and throws an error if the precondition is not met. 

Overloads are provided for custom exception messages and custom exceptions.

## Installation

Available on [nuget](https://www.nuget.org/packages/ReneWiersma.Preconditions/)

	PM> Install-Package ReneWiersma.Preconditions

### Example of use

```csharp
public class Example
{
    public void Execute(string input, int value)
    {
        // Throw an ArgumentException with the message 'Precondition failed'
        Precondition.Requires(input != null);
        
        // Specify a custom message if a more descriptive exception message is needed
        Precondition.Requires(input != "TST", "Test input is not allowed");
        
        // Throw a specific exception if needed
        Precondition.Requires(value > 0, () => new ArgumentOutOfRangeException("value")); 
        
        // The rest of the code
    }
}
```
