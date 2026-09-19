# Flood Fill

## Problem

Given an image grid, a starting cell `(sr, sc)`, and a new color, recolor the start cell and every four-directionally connected cell having the original color. Return the image.

## Examples

### Example 1

```text
Input: image = [[1,1,1],[1,1,0],[1,0,1]], sr = 1, sc = 1, color = 2
Output: [[2,2,2],[2,2,0],[2,0,1]]
```

### Example 2

```text
Input: image = [[0,0,0],[0,0,0]], sr = 0, sc = 0, color = 0
Output: [[0,0,0],[0,0,0]]
```

## C# hint

Remember the original color, then use DFS or a `Queue<(int, int)>` for BFS. Recolor a cell when you visit or enqueue it so it cannot be added repeatedly.

## Watch for

- If the original color already equals the new color, return immediately.
- Only horizontal and vertical neighbors are connected.

## Target complexity

`O(rows × columns)` worst-case time and traversal space.
