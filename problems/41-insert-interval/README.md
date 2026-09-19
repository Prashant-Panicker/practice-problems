# Insert Interval

## Problem

Given sorted, non-overlapping intervals and one new interval, insert it in order and merge any overlaps. Return the resulting intervals.

## Examples

### Example 1

```text
Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]
```

### Example 2

```text
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
```

## C# hint

Process three phases: append intervals ending before the new interval, merge all intervals whose starts are at most the new end, then append the remaining intervals. A `List<int[]>` is convenient for the result.

## Watch for

- The new interval may belong at the beginning or end.
- Treat touching boundaries as overlap.

## Target complexity

`O(n)` time and `O(n)` output space.
