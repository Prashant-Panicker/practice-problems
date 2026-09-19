# Coin Change

## Problem

Given coin denominations and a target `amount`, return the fewest coins needed to make exactly that amount. Each denomination may be used any number of times. Return -1 when the amount cannot be formed.

## Examples

### Example 1

```text
Input: coins = [1, 2, 5], amount = 11
Output: 3
Explanation: 5 + 5 + 1.
```

### Example 2

```text
Input: coins = [2], amount = 3
Output: -1
```

## C# hint

Create `dp[0..amount]`, fill it with an unreachable sentinel such as `amount + 1`, and set `dp[0] = 0`. For every total, try each coin and update with `Math.Min(dp[total], dp[total - coin] + 1)` when the coin fits.

## Watch for

- Amount 0 requires 0 coins.
- A greedy choice is not correct for arbitrary denominations.

## Target complexity

`O(amount × numberOfCoins)` time and `O(amount)` space.
