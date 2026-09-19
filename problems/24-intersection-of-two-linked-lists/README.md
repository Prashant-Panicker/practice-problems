# Intersection of Two Linked Lists

## Problem

Given the heads of two singly linked lists, return the node where they intersect, or `null` if they do not. Intersection means both lists share the exact same node object and all nodes after it.

## Examples

### Example 1

```text
Input: listA = [4, 1, 8, 4, 5], listB = [5, 6, 1, 8, 4, 5], shared node value = 8
Output: node with value 8
```

### Example 2

```text
Input: listA = [2, 6, 4], listB = [1, 5]
Output: null
```

## C# hint

Use two pointers. When pointer A reaches the end, redirect it to head B; redirect pointer B to head A. After both traverse equal total distance, they meet at the shared node or both become `null`.

## Watch for

- Equal values do not prove intersection; compare references.
- Do not modify either list.

## Target complexity

`O(n + m)` time and `O(1)` extra space.
