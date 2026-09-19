# Invert Binary Tree

## Problem

Given the root of a binary tree, swap every node's left and right children and return the root.

## Examples

### Example 1

```text
Input: root = [4, 2, 7, 1, 3, 6, 9]
Output: [4, 7, 2, 9, 6, 3, 1]
```

### Example 2

```text
Input: root = []
Output: []
```

## C# hint

At each non-null node, swap `left` and `right`, then process both children. A temporary `TreeNode` reference avoids losing one side.

## Watch for

- The tree may be empty.
- Either recursive DFS or iterative BFS/DFS is valid.

## Target complexity

`O(n)` time and `O(h)` recursive stack space.
