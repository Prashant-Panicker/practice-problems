# Group Anagrams

## Problem

Given an array of strings, group together strings that are anagrams. Two strings are anagrams when they contain the same characters with the same frequencies. The groups may be returned in any order.

## Examples

### Example 1

```text
Input: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
Output: [["eat", "tea", "ate"], ["tan", "nat"], ["bat"]]
```

### Example 2

```text
Input: strs = [""]
Output: [[""]]
```

## C# hint

Build a stable key for every word, such as its sorted characters, and store groups in a `Dictionary<string, List<string>>`. In C#, `new string(word.OrderBy(c => c).ToArray())` is a simple key; a 26-count key avoids sorting.

## Watch for

- The order of groups and words inside groups usually does not matter.
- The empty string is a valid value.

## Target complexity

With sorted keys: `O(n × k log k)` time, where `k` is the longest word.
