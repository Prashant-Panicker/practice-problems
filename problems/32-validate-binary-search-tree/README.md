# Validate Binary Search Tree

## Problem

Given a binary-tree root, return `true` if it is a valid binary search tree. Every node in a left subtree must be strictly smaller than its ancestor, and every node in a right subtree strictly larger.

## Examples

### Example 1

```text
Input: root = [2, 1, 3]
Output: true
```

### Example 2

```text
Input: root = [5, 1, 4, null, null, 3, 6]
Output: false
```

## C# hint

Pass an allowed lower and upper bound through recursion. A node must lie strictly inside both bounds; its value becomes the upper bound for the left child and the lower bound for the right child. Nullable bounds or `long` bounds avoid `int` edge issues.

## Watch for

- Checking only a node against its direct children is not enough.
- Duplicate values make the BST invalid under strict ordering.

## Target complexity

`O(n)` time and `O(h)` recursive stack space.
