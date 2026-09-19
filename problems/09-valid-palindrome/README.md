# Valid Palindrome

## Problem

Given a string, return `true` if it reads the same forward and backward after ignoring non-alphanumeric characters and letter case.

## Examples

### Example 1

```text
Input: s = "A man, a plan, a canal: Panama"
Output: true
```

### Example 2

```text
Input: s = "race a car"
Output: false
```

## C# hint

Use two indices moving inward. Skip characters with `char.IsLetterOrDigit`, then compare normalized characters with `char.ToLowerInvariant`.

## Watch for

- Spaces and punctuation do not participate in the comparison.
- After removing non-alphanumeric characters, an empty string is a palindrome.

## Target complexity

`O(n)` time and `O(1)` extra space.
