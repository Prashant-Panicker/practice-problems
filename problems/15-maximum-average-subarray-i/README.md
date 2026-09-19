# Maximum Average Subarray I

## Problem

Given an integer array `nums` and an integer `k`, find the contiguous subarray of exactly length `k` with the greatest average and return that average.

## Examples

### Example 1

```text
Input: nums = [1, 12, -5, -6, 50, 3], k = 4
Output: 12.75
```

### Example 2

```text
Input: nums = [-1], k = 1
Output: -1.0
```

## C# hint

Compute the sum of the first `k` values. Slide the fixed-size window by adding the new right value and subtracting the value that leaves on the left. Convert to `double` when dividing.

## Watch for

- The window length is exactly `k`.
- Avoid integer division: use `(double)bestSum / k`.

## Target complexity

`O(n)` time and `O(1)` extra space.
