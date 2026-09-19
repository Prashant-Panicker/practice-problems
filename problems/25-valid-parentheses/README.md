# Valid Parentheses

## Problem

Given a string containing only `()[]{}`, return `true` when every opening bracket is closed by the same bracket type in the correct nested order.

## Examples

### Example 1

```text
Input: s = "()[]{}"
Output: true
```

### Example 2

```text
Input: s = "([)]"
Output: false
```

## C# hint

Push opening brackets onto a `Stack<char>`. For a closing bracket, the stack must be non-empty and its top must be the matching opening bracket. The stack must be empty at the end.

## Watch for

- Correct counts alone are insufficient; nesting order matters.
- A closing bracket cannot appear before its opener.

## Target complexity

`O(n)` time and `O(n)` extra space.
