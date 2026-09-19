# Container With Most Water

## Problem

Given an array `height`, where each value is the height of a vertical line at that index, choose two lines that hold the most water. Return the maximum area. The container cannot be tilted.

## Examples

### Example 1

```text
Input: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
Output: 49
```

### Example 2

```text
Input: height = [1, 1]
Output: 1
```

## C# hint

Start one pointer at each end. The area is `Math.Min(height[left], height[right]) * (right - left)`. Move the pointer at the shorter line because moving the taller one cannot improve the limiting height.

## Watch for

- Width is the difference between indices.
- Use `long` if the constraints allow the area to exceed `int`.

## Target complexity

`O(n)` time and `O(1)` extra space.
