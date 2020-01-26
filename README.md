# CSharp-From-Zero-To-Hero

# Homework 5

## Task
Implement the following operations with array:
1) Sort array in ascending order
2) Inverse array
3) Remove first element from array
4) Remove last element from array
5) Remove element at a given index from array
6) Insert element at the start of array
7) Insert element at the end of array
8) Insert element at specified index of array

## Tests Summary
The test results should be as pointed out below.
Note that except for null and empty these are only examples to visualize what happens!

!IMPORANT!
Some of the tests below need extra validation.
Format: Input -> Output


1) Sort array in ascending order
	null -> null
	empty -> empty
	{ 1, 2, 3, 4, 5 } -> { 1, 2, 3, 4, 5 }
	{ 5, 4, 3, 2, 1 } -> { 1, 2, 3, 4, 5 }

2) Inverse array
	null -> null
	empty -> empty
	{ 1, 2, 3, 4, 5 } -> { 5, 4, 3, 2, 1 }
	{ 5, 4, 3, 2, 1 } -> { 1, 2, 3, 4, 5 }

3) Remove first element from array
	null -> null
	empty -> empty
	{ 1, 2, 3, 4, 5 } -> { 2, 3, 4, 5 }
	{ 5, 4, 3, 2, 1 } -> { 4, 3, 2, 1 }

4) Remove last element from array
	null -> null
	empty -> empty
	{ 1, 2, 3, 4, 5 } -> { 1, 2, 3, 4 }
	{ 5, 4, 3, 2, 1 } -> { 5, 4, 3, 2 }

5) Remove element at a given index from array
	null -> null
	empty -> empty
	{ 1, 2, 3, 4, 5 } -> { 1, 2, 4, 5 }  (index = 2)
	{ 5, 4, 3, 2, 1 } -> { 5, 4, 2, 1 }  (index = 2)

6) Insert element at the start of array
	null -> { 0 }
	empty -> { 0 }
	{ 1, 2, 3, 4, 5 } -> { 0, 1, 2, 3, 4, 5 }
	{ 5, 4, 3, 2, 1 } -> { 0, 5, 4, 3, 2, 1 }

7) Insert element at the end of array
	null -> { 0 }
	empty -> { 0 }
	{ 1, 2, 3, 4, 5 } -> { 1, 2, 3, 4, 5, 0 }
	{ 5, 4, 3, 2, 1 } -> { 5, 4, 3, 2, 1, 0 }

8) Insert element at specified index of array
	null -> { 0 }
	empty -> { 0 }
	{ 1, 2, 3, 4, 5 } -> { 1, 2, 0, 3, 4, 5 }  (index = 2)
	{ 5, 4, 3, 2, 1 } -> { 5, 4, 0, 3, 2, 1 }  (index = 2)
