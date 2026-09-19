# Kth Largest Element in an Array

## Problem

Given an unsorted integer array and an integer `k`, return the kth largest element by sorted order. It is the kth position including duplicates, not the kth distinct value.

## Examples

### Example 1

```text
Input: nums = [3, 2, 1, 5, 6, 4], k = 2
Output: 5
```

### Example 2

```text
Input: nums = [3, 2, 3, 1, 2, 4, 5, 5, 6], k = 4
Output: 4
```

## C# hint

Maintain a min-heap of at most `k` items using `PriorityQueue<int, int>`. Enqueue each number with itself as priority; when the heap exceeds size `k`, dequeue the smallest. The remaining minimum is the kth largest.

## Watch for

- Duplicates count as separate positions.
- Validate that `1 <= k <= nums.Length` if required.

## Target complexity

Heap approach: `O(n log k)` time and `O(k)` space.
