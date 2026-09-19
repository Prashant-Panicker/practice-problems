# Maximum Subarray

## Problem

Given an integer array `nums`, find the contiguous non-empty subarray with the largest sum and return that sum.

## Examples

### Example 1

```text
Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
Output: 6
Explanation: [4, -1, 2, 1] has sum 6.
```

### Example 2

```text
Input: nums = [-3, -2, -5]
Output: -2
```

## C# hint

Track the best sum ending at the current index and the best sum seen overall. At each value, decide whether to extend the previous subarray or start a new one: `current = Math.Max(value, current + value)`.

## Watch for

- The subarray must be non-empty.
- All numbers may be negative, so do not initialize the answer to zero.

## Target complexity

`O(n)` time and `O(1)` extra space.
