# Longest Substring Without Repeating Characters

## Problem

Given a string `s`, return the length of its longest contiguous substring containing no repeated characters.

## Examples

### Example 1

```text
Input: s = "abcabcbb"
Output: 3
Explanation: "abc" is a longest valid substring.
```

### Example 2

```text
Input: s = "bbbbb"
Output: 1
```

## C# hint

Use a sliding window and a `Dictionary<char, int>` containing each character's latest index. When a repeated character lies inside the current window, move `left` to one position after its old index.

## Watch for

- A substring is contiguous; a subsequence is not.
- Never move the left boundary backward.

## Target complexity

`O(n)` time and `O(min(n, alphabet))` extra space.
