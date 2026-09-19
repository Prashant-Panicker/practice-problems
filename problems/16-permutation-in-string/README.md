# Permutation in String

## Problem

Given strings `s1` and `s2`, return `true` if `s2` contains a contiguous substring that is a permutation of `s1`.

## Examples

### Example 1

```text
Input: s1 = "ab", s2 = "eidbaooo"
Output: true
Explanation: "ba" is a permutation of "ab".
```

### Example 2

```text
Input: s1 = "ab", s2 = "eidboaoo"
Output: false
```

## C# hint

Use a fixed-size sliding window of length `s1.Length`. Maintain character-frequency arrays for `s1` and the current window, updating one entering and one leaving character each step.

## Watch for

- Return false immediately if `s1` is longer than `s2`.
- A permutation must match character counts, not character order.

## Target complexity

`O(n + alphabet)` time and `O(alphabet)` space.
