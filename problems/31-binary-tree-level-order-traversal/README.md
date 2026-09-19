# Binary Tree Level Order Traversal

## Problem

Given a binary-tree root, return its values level by level from left to right.

## Examples

### Example 1

```text
Input: root = [3, 9, 20, null, null, 15, 7]
Output: [[3], [9, 20], [15, 7]]
```

### Example 2

```text
Input: root = []
Output: []
```

## C# hint

Use a `Queue<TreeNode>`. At the start of each level, capture `queue.Count`; dequeue exactly that many nodes into one list while enqueueing their children.

## Watch for

- Do not use the changing `queue.Count` as the loop limit after adding children.
- Return an empty collection for a null root.

## Target complexity

`O(n)` time and `O(w)` extra space, where `w` is maximum tree width.
