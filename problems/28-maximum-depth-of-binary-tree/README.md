# Maximum Depth of Binary Tree

## Problem

Given the root of a binary tree, return its maximum depth: the number of nodes on the longest path from the root to a leaf.

## Examples

### Example 1

```text
Input: root = [3, 9, 20, null, null, 15, 7]
Output: 3
```

### Example 2

```text
Input: root = []
Output: 0
```

## C# hint

For recursion, return 0 for `null`; otherwise return `1 + Math.Max(depth(left), depth(right))`. An iterative BFS can count queue levels instead.

## Watch for

- Depth is counted in nodes here, so a single-node tree has depth 1.
- An empty tree has depth 0.

## Target complexity

`O(n)` time and `O(h)` recursive stack space, where `h` is tree height.
