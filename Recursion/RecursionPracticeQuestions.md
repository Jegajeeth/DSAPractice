# Recursion Practice Questions

Work through these in order. For each problem, first write:

1. The base case.
2. How the input becomes smaller.
3. What the current call must do before or after the recursive call.

Try not to use loops inside the recursive method until you have solved the exercise.

## Warm-up: Understand the Calls

### 1. CountDown(n)

Print numbers from `n` down to `1`.

Example: `CountDown(4)` prints `4 3 2 1`.

### 2. CountUp(n)

Print numbers from `1` up to `n`.

Example: `CountUp(4)` prints `1 2 3 4`.

Hint: The print statement belongs in a different place than it does in countdown.

### 3. Trace CountDown(3)

Trace `CountDown(3)` on paper. Write every function call and return in order.

## Beginner Number Problems

### 4. SumTo(n)

Return the sum from `1` through `n`.

Example: `SumTo(5)` returns `15`.

### 5. Factorial(n)

Return the factorial of a non-negative integer.

Example: `Factorial(5)` returns `120`.

Base-case question: What should `0!` return?

### 6. Power(baseNumber, exponent)

Calculate a number raised to a power without `Math.Pow`.

Example: `Power(2, 4)` returns `16`.

### 7. Multiply(firstNumber, secondNumber)

Multiply using repeated addition only.

Example: `Multiply(4, 3)` returns `12`.

Think: `4 * 3` is `4 + (4 * 2)`.

### 8. CountDigits(number)

Return the number of digits in a non-negative integer.

Example: `CountDigits(12345)` returns `5`.

Hint: Remove the last digit with `/ 10`.

### 9. SumDigits(number)

Return the sum of all digits in a non-negative integer.

Example: `SumDigits(1234)` returns `10`.

Hint: The final digit is `number % 10`.

## Arrays and Strings

Use an `index` parameter so each call works on one smaller part of an array or string.

```csharp
static int SumArray(int[] numbers, int index)
```

### 10. SumArray(numbers, index)

Return the sum of the values from `index` to the end of the array.

Example: `[2, 4, 6]` returns `12`.

### 11. FindMax(numbers, index)

Return the largest value in an array.

Example: `[5, 2, 9, 3]` returns `9`.

Think: Compare the current value to the maximum of the remaining elements.

### 12. Contains(numbers, index, target)

Return `true` when the target exists in the array, otherwise return `false`.

Example: `[3, 8, 1]`, target `8`, returns `true`.

### 13. IsSorted(numbers, index)

Return whether an array is sorted in ascending order.

Example: `[1, 3, 5, 8]` returns `true`, while `[1, 5, 3]` returns `false`.

Each call only needs to compare two neighboring elements, then check the rest.

### 14. ReverseString(word)

Return a reversed string.

Example: `"hello"` returns `"olleh"`.

Think: The first character moves to the end while the rest is reversed.

### 15. IsPalindrome(word, left, right)

Return whether a word reads the same forward and backward.

Example: `"madam"` returns `true`; `"apple"` returns `false`.

Smaller problem: Compare the outer characters, then move inward.

## Intermediate Recursive Problems

### 16. BinarySearch(numbers, target, left, right)

Find a number in a sorted array by recursively searching one half.

Example: `[1, 3, 6, 9, 12]`, target `9`, returns index `3`.

### 17. Fibonacci(n)

Return the nth Fibonacci number.

Example: `Fibonacci(6)` returns `8`.

This uses two recursive calls:

```text
F(n) = F(n - 1) + F(n - 2)
```

After solving it, notice that the same values are calculated repeatedly. This leads to memoization later.

### 18. PrintSubsets(text)

Print every subset of a string's characters.

Example: `"ab"` produces `""`, `"a"`, `"b"`, and `"ab"`.

At each character, choose whether to include it or exclude it.

### 19. TowerOfHanoi(disks, source, helper, destination)

Print the steps that move disks according to the Tower of Hanoi rules.

This teaches how one large problem can use the same smaller problem twice.

### 20. MergeSort(numbers)

Split an array into two halves, recursively sort each half, then merge them.

- Base case: An array with `0` or `1` element is already sorted.
- Recursive case: Sort the left half and right half.
- Combine: Merge the two sorted halves.

## Recursion Checklist

For every problem, answer these questions:

```text
What is the smallest valid input?
What should happen for that input?
What exact smaller input will I pass to the next call?
Does every call get closer to the base case?
What should this call do when the smaller call returns?
```

The core idea is: solve one small part now, then let the recursive call solve the rest.
