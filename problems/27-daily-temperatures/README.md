# Daily Temperatures

## Problem

Given daily temperatures, return an array where each position contains how many days must pass before a warmer temperature. Use 0 when no warmer future day exists.

## Examples

### Example 1

```text
Input: temperatures = [73, 74, 75, 71, 69, 72, 76, 73]
Output: [1, 1, 4, 2, 1, 1, 0, 0]
```

### Example 2

```text
Input: temperatures = [30, 40, 50, 60]
Output: [1, 1, 1, 0]
```

## C# hint

Keep a decreasing `Stack<int>` of unresolved indices. When the current temperature is warmer than the temperature at the top index, pop that index and set its wait to `currentIndex - oldIndex`.

## Watch for

- Store indices in the stack, not just temperatures.
- Equal temperatures are not warmer.

## Target complexity

`O(n)` time and `O(n)` extra space.
