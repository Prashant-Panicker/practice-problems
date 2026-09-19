# Maximum Size Subarray Sum Equals K

## Problem

Given an integer array `nums` and an integer `k`, return the maximum length of a contiguous subarray whose sum equals `k`. Return 0 if no such subarray exists.

## Examples

### Example 1

```text
Input: nums = [1, -1, 5, -2, 3], k = 3
Output: 4
Explanation: [1, -1, 5, -2] sums to 3.
```

### Example 2

```text
Input: nums = [-2, -1, 2, 1], k = 1
Output: 2
```

## C# hint

Store the earliest index where each prefix sum occurs in a `Dictionary<int, int>`. At index `i`, if `prefix - k` was first seen at index `j`, the subarray length is `i - j`. Seed sum 0 at index -1 and never overwrite an earlier index.

## Watch for

- Keeping the first occurrence is what maximizes the length.
- Negative numbers prevent a normal sliding-window solution.

## Target complexity

`O(n)` time and `O(n)` extra space.
