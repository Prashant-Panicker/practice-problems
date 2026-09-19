# Reverse Linked List

## Problem

Given the head of a singly linked list, reverse the links and return the new head.

## Examples

### Example 1

```text
Input: head = [1, 2, 3, 4, 5]
Output: [5, 4, 3, 2, 1]
```

### Example 2

```text
Input: head = []
Output: []
```

## C# hint

Use three references: `previous`, `current`, and `next`. Save `current.next` before changing it, point `current.next` to `previous`, then advance both working references.

## Watch for

- Saving the next node before rewiring prevents losing the rest of the list.
- Both an empty list and a one-node list are already reversed.

## Target complexity

`O(n)` time and `O(1)` extra space.
