# C# Practice Problems

Each problem is self-contained for editing and uses the shared runner in `runner/Program.cs`.

## Create a problem

From the repository root:

```sh
./problem new valid-parentheses
```

If you already created the folder yourself:

```sh
mkdir -p problems/valid-parentheses
./problem init valid-parentheses
```

This creates:

```text
problems/
└── 45-valid-parentheses/
	├── Problem.csproj
	├── Solution.cs
	├── input.txt
	└── output.txt
```

Numeric prefixes keep the folders in study-plan order. Commands accept the name without its prefix.

Paste the LeetCode `Solution` class into `Solution.cs` unchanged. Keep exactly one public method in the class.

In `input.txt`, put one JSON-formatted value on each line, in the same order as the method parameters. For example, this method:

```csharp
public int[] TwoSum(int[] nums, int target)
```

uses this input:

```text
[2, 7, 11, 15]
9
```

Add more test cases by separating them with `---`:

```text
[2, 7, 11, 15]
9
---
[-3, 4, 3, 90]
0
```

The shared runner converts each case to `int[]` and `int`, calls `TwoSum` with a fresh `Solution` instance, and writes one serialized result per line to `output.txt`. Parsing and serialization stay outside `Solution.cs`.

## Run a problem

From inside its folder:

```sh
cd problems/45-valid-parentheses
dotnet run
```

Or from the repository root:

```sh
./problem run valid-parentheses
```

You can also run a problem by its sequence number:

```sh
./problem run 4
```

Both commands print the result and replace that problem's `output.txt`. See `problems/00-sample-two-sum` for a working example.