# Subarray Sum Equals K

## Problem

Given an integer array `nums` and an integer `k`, return the number of contiguous, non-empty subarrays whose sum equals `k`.

## Examples

### Example 1

```text
Input: nums = [1, 1, 1], k = 2
Output: 2
```

### Example 2

```text
Input: nums = [1, -1, 0], k = 0
Output: 3
```

## C# hint

Keep a running prefix sum and a `Dictionary<int, int>` containing how often each earlier prefix sum occurred. If the current prefix is `sum`, every earlier prefix equal to `sum - k` creates a valid subarray. Start with prefix sum 0 occurring once.

## Watch for

- Negative values mean a sliding window is not generally valid.
- Store prefix frequencies, not just whether a prefix exists.

## Target complexity

`O(n)` time and `O(n)` extra space.
