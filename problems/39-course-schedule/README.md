# Course Schedule

## Problem

There are `numCourses` courses numbered from 0. Each prerequisite pair `[course, prerequisite]` means the prerequisite must be completed first. Return `true` if all courses can be completed.

## Examples

### Example 1

```text
Input: numCourses = 2, prerequisites = [[1, 0]]
Output: true
```

### Example 2

```text
Input: numCourses = 2, prerequisites = [[1, 0], [0, 1]]
Output: false
```

## C# hint

Model courses as a directed graph. With Kahn's algorithm, keep an `int[] indegree`, enqueue every zero-indegree course, and remove its outgoing edges. All courses are possible only if the processed count reaches `numCourses`.

## Watch for

- A directed cycle makes completion impossible.
- Courses with no prerequisites still count and should be processed.

## Target complexity

`O(V + E)` time and `O(V + E)` space.
