# 3Sum

## Problem

Given an integer array `nums`, return all unique triplets `[a, b, c]` whose sum is zero. The same array element cannot be used more than once in a triplet.

## Examples

### Example 1

```text
Input: nums = [-1, 0, 1, 2, -1, -4]
Output: [[-1, -1, 2], [-1, 0, 1]]
```

### Example 2

```text
Input: nums = [0, 0, 0, 0]
Output: [[0, 0, 0]]
```

## C# hint

Sort the array. Fix one index, then use left and right pointers to find pairs that complete the sum. Skip equal values after recording a triplet, and also skip duplicate fixed values.

## Watch for

- The result must not contain duplicate triplets.
- Sorting changes index order, but this problem asks for values, not original indices.

## Target complexity

`O(n²)` time; sorting may use additional space.
