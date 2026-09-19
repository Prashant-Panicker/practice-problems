# Contains Duplicate

## Problem

Given an integer array `nums`, return `true` if any value appears at least twice. Return `false` if every value is unique.

## Examples

### Example 1

```text
Input: nums = [1, 2, 3, 1]
Output: true
```

### Example 2

```text
Input: nums = [1, 2, 3, 4]
Output: false
```

## C# hint

Create a `HashSet<int>`. Walk through the array and call `Add`. In C#, `Add` returns `false` when the value is already present.

## Watch for

- An empty array and a one-element array have no duplicates.
- Negative numbers are handled exactly like positive numbers.

## Target complexity

`O(n)` average time and `O(n)` extra space.
