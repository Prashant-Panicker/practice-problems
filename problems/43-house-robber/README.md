# House Robber

## Problem

Given the money in houses along a street, return the maximum amount you can rob without robbing two adjacent houses.

## Examples

### Example 1

```text
Input: nums = [1, 2, 3, 1]
Output: 4
Explanation: Rob houses with 1 and 3.
```

### Example 2

```text
Input: nums = [2, 7, 9, 3, 1]
Output: 12
```

## C# hint

At each house, compare skipping it (`previousBest`) with taking it (`bestBeforePrevious + money`). Keep just those two earlier DP values while scanning.

## Watch for

- Greedily choosing the largest nearby house does not always produce the global optimum.
- Handle empty and one-house inputs if allowed.

## Target complexity

`O(n)` time and `O(1)` extra space.
