# Top K Frequent Elements

## Problem

Given an integer array `nums` and an integer `k`, return the `k` values that occur most often. The answer may be returned in any order.

## Examples

### Example 1

```text
Input: nums = [1, 1, 1, 2, 2, 3], k = 2
Output: [1, 2]
```

### Example 2

```text
Input: nums = [1], k = 1
Output: [1]
```

## C# hint

First count occurrences with a `Dictionary<int, int>`. Then either keep a size-`k` `PriorityQueue<int, int>` prioritized by frequency, or place values into frequency buckets indexed from 1 to `nums.Length`.

## Watch for

- Return values, not frequencies.
- The order of the returned values usually does not matter.

## Target complexity

Heap: `O(n log k)` time; buckets: `O(n)` time.
