# Two Sum

## Problem

Given an integer array `nums` and an integer `target`, return the indices of two different elements whose values add up to `target`. Assume exactly one valid pair exists. Return the indices in any order.

## Examples

### Example 1

```text
Input: nums = [2, 7, 11, 15], target = 9
Output: [0, 1]
Explanation: nums[0] + nums[1] = 9.
```

### Example 2

```text
Input: nums = [3, 2, 4], target = 6
Output: [1, 2]
```

## C# hint

Keep a `Dictionary<int, int>` from each value to its index. For every number, calculate `target - nums[i]` and check it with `TryGetValue` before inserting the current number.

## Watch for

- Do not use the same array element twice.
- Duplicate values may form the answer, such as `[3, 3]`.
- Return indices, not values.

## Target complexity

`O(n)` time and `O(n)` extra space.
