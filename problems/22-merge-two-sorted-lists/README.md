# Merge Two Sorted Lists

## Problem

Given the heads of two sorted singly linked lists, merge their existing nodes into one sorted list and return its head.

## Examples

### Example 1

```text
Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
Output: [1, 1, 2, 3, 4, 4]
```

### Example 2

```text
Input: list1 = [], list2 = [0]
Output: [0]
```

## C# hint

Use a dummy node and a `tail` reference. Repeatedly attach the smaller current node, advance that list, and finally attach whichever list remains.

## Watch for

- Either input list may be empty.
- Move `tail` after every attachment.

## Target complexity

`O(n + m)` time and `O(1)` extra space.
