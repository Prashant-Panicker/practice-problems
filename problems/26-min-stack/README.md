# Min Stack

## Problem

Design a stack supporting `Push`, `Pop`, `Top`, and `GetMin`, with every operation running in constant time.

## Examples

### Example 1

```text
Operations: Push(-2), Push(0), Push(-3), GetMin(), Pop(), Top(), GetMin()
Output: -3, 0, -2
```

### Example 2

```text
Operations: Push(2), Push(2), GetMin(), Pop(), GetMin()
Output: 2, 2
```

## C# hint

Keep a second `Stack<int>` for minimums. On push, also push to the minimum stack when the new value is less than or equal to its current top. On pop, remove from both stacks when their top values match.

## Watch for

- Use `<=`, not only `<`, so duplicate minimum values are tracked.
- Define behavior for empty-stack operations if your harness requires it.

## Target complexity

`O(1)` time per operation and `O(n)` total space.
