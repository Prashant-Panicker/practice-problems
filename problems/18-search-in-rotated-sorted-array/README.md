# Search in Rotated Sorted Array

## Problem

A sorted array of distinct integers has been rotated at an unknown position. Given the array and a target, return its index or -1 if absent.

## Examples

### Example 1

```text
Input: nums = [4, 5, 6, 7, 0, 1, 2], target = 0
Output: 4
```

### Example 2

```text
Input: nums = [4, 5, 6, 7, 0, 1, 2], target = 3
Output: -1
```

## C# hint

Use binary search. At every midpoint, at least one half is sorted. Identify that half, check whether the target lies inside its value range, and keep either that half or the other half.

## Watch for

- This version assumes distinct values.
- A one-element array is already a valid rotated array.

## Target complexity

`O(log n)` time and `O(1)` extra space.
