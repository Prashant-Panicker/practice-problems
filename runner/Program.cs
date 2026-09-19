using System.Reflection;
using System.Text.Json;

var problemDirectory = Path.GetFullPath(
    Environment.GetEnvironmentVariable("PROBLEM_DIR") ?? Directory.GetCurrentDirectory());
var inputPath = Path.Combine(problemDirectory, "input.txt");
var outputPath = Path.Combine(problemDirectory, "output.txt");

if (!File.Exists(inputPath))
{
    Console.Error.WriteLine($"Input file not found: {inputPath}");
    return 1;
}

try
{
    var solutionMethods = typeof(Solution)
        .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
        .Where(method => !method.IsSpecialName)
        .ToArray();

    if (solutionMethods.Length == 0)
    {
        throw new InvalidOperationException(
            "No public method was found in Solution.cs. Paste or implement the LeetCode method, then run again.");
    }

    if (solutionMethods.Length > 1)
    {
        throw new InvalidOperationException(
            "Solution.cs must contain exactly one public method so the runner knows which method to call.");
    }

    var solutionMethod = solutionMethods[0];
    var parameters = solutionMethod.GetParameters();
    var inputCases = new List<List<string>> { new() };

    foreach (var line in await File.ReadAllLinesAsync(inputPath))
    {
        var trimmedLine = line.Trim();
        if (trimmedLine == "---")
        {
            inputCases.Add(new List<string>());
        }
        else if (trimmedLine.Length > 0)
        {
            inputCases[^1].Add(trimmedLine);
        }
    }

    var outputs = new List<string>(inputCases.Count);
    for (var caseIndex = 0; caseIndex < inputCases.Count; caseIndex++)
    {
        var inputCase = inputCases[caseIndex];
        if (inputCase.Count != parameters.Length)
        {
            throw new InvalidOperationException(
                $"Case {caseIndex + 1}: {solutionMethod.Name} expects {parameters.Length} input line(s), but found {inputCase.Count}.");
        }

        var arguments = new object?[parameters.Length];
        for (var parameterIndex = 0; parameterIndex < parameters.Length; parameterIndex++)
        {
            arguments[parameterIndex] = JsonSerializer.Deserialize(
                inputCase[parameterIndex],
                parameters[parameterIndex].ParameterType);
        }

        var result = solutionMethod.Invoke(new Solution(), arguments);
        outputs.Add(JsonSerializer.Serialize(result, solutionMethod.ReturnType));
    }

    var output = string.Join(Environment.NewLine, outputs) + Environment.NewLine;
    await File.WriteAllTextAsync(outputPath, output);
    Console.Write(output);
    return 0;
}
catch (Exception exception)
{
    var cause = exception is TargetInvocationException { InnerException: not null }
        ? exception.InnerException
        : exception;
    Console.Error.WriteLine($"Solution failed: {cause.Message}");
    return 1;
}