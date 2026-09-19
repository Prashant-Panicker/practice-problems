# Lowest Common Ancestor of a Binary Tree

## Problem

Given a binary-tree root and two existing nodes `p` and `q`, return their lowest common ancestor: the deepest node whose subtree contains both nodes. A node may be an ancestor of itself.

## Examples

### Example 1

```text
Input: root = [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4], p = 5, q = 1
Output: node 3
```

### Example 2

```text
Input: same tree, p = 5, q = 4
Output: node 5
```

## C# hint

Recursively search left and right. Return the current node when it is `null`, `p`, or `q`. If both recursive sides return a node, the current node is the LCA; otherwise return the non-null side.

## Watch for

- Compare the target node references when node values are not guaranteed unique.
- One target can be an ancestor of the other.

## Target complexity

`O(n)` time and `O(h)` recursive stack space.
