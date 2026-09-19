# Product of Array Except Self

## Problem

Given an integer array `nums`, return an array where `answer[i]` equals the product of every element except `nums[i]`. Solve it without division.

## Examples

### Example 1

```text
Input: nums = [1, 2, 3, 4]
Output: [24, 12, 8, 6]
```

### Example 2

```text
Input: nums = [-1, 1, 0, -3, 3]
Output: [0, 0, 9, 0, 0]
```

## C# hint

Make one pass left to right, storing the product before each index. Then make a right-to-left pass with a running suffix product and multiply it into the result. The output array can hold the prefix products.

## Watch for

- Zeros make division-based solutions fail.
- Use the numeric type required by the problem constraints to avoid overflow.

## Target complexity

`O(n)` time and `O(1)` extra space excluding the output array.
