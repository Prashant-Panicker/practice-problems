# Longest Consecutive Sequence

## Problem

Given an unsorted integer array, return the length of the longest sequence of consecutive values. The values only need to exist in the array; they do not need to be adjacent in the original order.

## Examples

### Example 1

```text
Input: nums = [100, 4, 200, 1, 3, 2]
Output: 4
Explanation: The sequence is [1, 2, 3, 4].
```

### Example 2

```text
Input: nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1]
Output: 9
```

## C# hint

Put all values in a `HashSet<int>`. Only start counting from a number when `number - 1` is absent; that means it is the beginning of a sequence.

## Watch for

- Duplicates must not increase the length.
- Return 0 for an empty array.

## Target complexity

`O(n)` average time and `O(n)` extra space.
