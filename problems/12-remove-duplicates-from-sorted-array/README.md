# Remove Duplicates From Sorted Array

## Problem

Given a sorted integer array, remove duplicates in place so each unique value appears once. Return the number `k` of unique values; the first `k` positions must contain them in sorted order.

## Examples

### Example 1

```text
Input: nums = [1, 1, 2]
Output: k = 2, nums starts with [1, 2]
```

### Example 2

```text
Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
Output: k = 5, nums starts with [0, 1, 2, 3, 4]
```

## C# hint

Use a read index to scan and a write index for the next unique value. Because the array is sorted, compare the current value with the most recently written unique value.

## Watch for

- Values after index `k - 1` do not matter.
- Handle an empty array before reading its first element.

## Target complexity

`O(n)` time and `O(1)` extra space.
