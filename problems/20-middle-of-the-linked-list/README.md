# Middle of the Linked List

## Problem

Given the head of a singly linked list, return its middle node. If there are two middle nodes, return the second one.

## Examples

### Example 1

```text
Input: head = [1, 2, 3, 4, 5]
Output: node 3
```

### Example 2

```text
Input: head = [1, 2, 3, 4, 5, 6]
Output: node 4
```

## C# hint

Start `slow` and `fast` at the head. Move `slow` one node and `fast` two nodes each iteration. When `fast` reaches the end, `slow` is at the required middle.

## Watch for

- The chosen loop condition should naturally return the second middle for an even-length list.
- Return the node, not merely its value.

## Target complexity

`O(n)` time and `O(1)` extra space.
