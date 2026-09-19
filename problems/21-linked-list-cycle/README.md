# Linked List Cycle

## Problem

Given the head of a linked list, return `true` if following `next` references eventually visits a node that was already visited. Otherwise return `false`.

## Examples

### Example 1

```text
Input: values = [3, 2, 0, -4], tail connects to index 1
Output: true
```

### Example 2

```text
Input: values = [1, 2], tail connects to no node
Output: false
```

## C# hint

Use Floyd's cycle detection with a slow pointer moving one step and a fast pointer moving two steps. If a cycle exists, the references will eventually be equal.

## Watch for

- Compare node references, not node values.
- Check `fast` and `fast.next` before advancing two steps.

## Target complexity

`O(n)` time and `O(1)` extra space.
