# Merge Intervals

## Problem

Given intervals `[start, end]`, merge every pair that overlaps and return the non-overlapping intervals covering the same ranges.

## Examples

### Example 1

```text
Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
```

### Example 2

```text
Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
```

## C# hint

Sort intervals by start using `Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]))`. Compare each interval with the last merged interval; extend its end when they overlap, otherwise append a new interval.

## Watch for

- Touching endpoints such as `[1,4]` and `[4,5]` overlap.
- Do not assume the input is already sorted.

## Target complexity

`O(n log n)` time due to sorting.
