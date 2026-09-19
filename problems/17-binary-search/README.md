# Binary Search

## Problem

Given a sorted integer array `nums` and a `target`, return the target's index. Return -1 if it does not exist.

## Examples

### Example 1

```text
Input: nums = [-1, 0, 3, 5, 9, 12], target = 9
Output: 4
```

### Example 2

```text
Input: nums = [-1, 0, 3, 5, 9, 12], target = 2
Output: -1
```

## C# hint

Keep inclusive `left` and `right` boundaries. Calculate the midpoint as `left + (right - left) / 2`, compare it with the target, and discard half of the remaining range.

## Watch for

- The input must be sorted for binary search to work.
- Choose boundary updates that always reduce the search range.

## Target complexity

`O(log n)` time and `O(1)` extra space.
