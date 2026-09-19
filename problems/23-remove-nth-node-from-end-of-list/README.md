# Remove Nth Node From End of List

## Problem

Given the head of a linked list and an integer `n`, remove the nth node from the end and return the updated head.

## Examples

### Example 1

```text
Input: head = [1, 2, 3, 4, 5], n = 2
Output: [1, 2, 3, 5]
```

### Example 2

```text
Input: head = [1], n = 1
Output: []
```

## C# hint

Place a dummy node before the head. Move `fast` ahead by `n + 1` links from the dummy, then move `fast` and `slow` together. `slow.next` will be the node to remove.

## Watch for

- A dummy node makes removal of the original head ordinary.
- Assume `n` is valid unless the problem states otherwise.

## Target complexity

`O(n)` time and `O(1)` extra space in one pass.
