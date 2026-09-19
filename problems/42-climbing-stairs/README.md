# Climbing Stairs

## Problem

You can climb either 1 or 2 steps at a time. Given `n` steps, return the number of distinct ways to reach the top.

## Examples

### Example 1

```text
Input: n = 2
Output: 2
Explanation: 1+1 or 2.
```

### Example 2

```text
Input: n = 5
Output: 8
```

## C# hint

The last move came from step `n - 1` or `n - 2`, so the counts follow the Fibonacci pattern. Keep only the previous two counts instead of an entire DP array.

## Watch for

- Establish base cases consistently for small `n`.
- Use a wider numeric type if the constraints can exceed `int`.

## Target complexity

`O(n)` time and `O(1)` extra space.
