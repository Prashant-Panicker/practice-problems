# Clone Graph

## Problem

Given a reference to a node in a connected undirected graph, return a deep copy. Every cloned node must be new, with the same value and equivalent neighbor relationships.

## Examples

### Example 1

```text
Input adjacency list: [[2,4],[1,3],[2,4],[1,3]]
Output: an equivalent graph made from new node objects
```

### Example 2

```text
Input adjacency list: []
Output: null
```

## C# hint

Use a `Dictionary<Node, Node>` mapping each original node reference to its clone. Create a clone the first time a node is visited, then recursively or iteratively clone and attach each neighbor.

## Watch for

- Graphs may contain cycles, so record a clone before visiting its neighbors.
- Copy references between cloned nodes, never back to original nodes.

## Target complexity

`O(V + E)` time and `O(V)` extra space.
