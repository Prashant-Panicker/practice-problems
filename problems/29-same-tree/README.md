# Same Tree

## Problem

Given two binary-tree roots, return `true` if the trees have identical structure and equal values at corresponding nodes.

## Examples

### Example 1

```text
Input: p = [1, 2, 3], q = [1, 2, 3]
Output: true
```

### Example 2

```text
Input: p = [1, 2], q = [1, null, 2]
Output: false
```

## C# hint

Compare the roots recursively. Two null nodes match; one null node and one non-null node do not. Otherwise the values, left subtrees, and right subtrees must all match.

## Watch for

- Equal traversal values are insufficient when the structures differ.
- Handle null checks before reading node values.

## Target complexity

`O(n)` time and `O(h)` recursive stack space.
