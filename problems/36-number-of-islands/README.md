# Number of Islands

## Problem

Given a grid of `'1'` (land) and `'0'` (water), return the number of islands. Land connects horizontally and vertically, not diagonally.

## Examples

### Example 1

```text
Input:
11110
11010
11000
00000
Output: 1
```

### Example 2

```text
Input:
11000
11000
00100
00011
Output: 3
```

## C# hint

Scan every cell. When you find unvisited land, increment the answer and run DFS or BFS to mark all four-directionally connected land. In C#, a `Queue<(int row, int col)>` works well for BFS.

## Watch for

- Check row and column bounds before accessing a neighbor.
- You may mark visited cells in the grid if mutation is allowed.

## Target complexity

`O(rows × columns)` time and up to `O(rows × columns)` traversal space.
