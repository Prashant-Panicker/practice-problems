# Minimum Size Subarray Sum

## Problem

Given an array of positive integers `nums` and a positive integer `target`, return the minimum length of a contiguous subarray whose sum is at least `target`. Return 0 if none exists.

## Examples

### Example 1

```text
Input: target = 7, nums = [2, 3, 1, 2, 4, 3]
Output: 2
Explanation: [4, 3] is the shortest qualifying subarray.
```

### Example 2

```text
Input: target = 11, nums = [1, 1, 1, 1, 1]
Output: 0
```

## C# hint

Use a sliding window. Expand the right side and add values. While the sum is at least the target, update the answer and remove `nums[left]` to shrink the window.

## Watch for

- This standard sliding-window approach relies on every value being positive.
- Return 0 rather than a large sentinel when no window qualifies.

## Target complexity

`O(n)` time and `O(1)` extra space.
