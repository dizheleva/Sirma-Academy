# Matrices - Exercises

### 1. Compare Matrices

Write a program that receives two integer matrices (2D arrays) and compares them element by element.

Each matrix contain a line with a positive integer number R - the number of rows in the matrix and C - the number of columns - followed by R lines containing the C numbers, separated by spaces (each line will have an equal amount of numbers).

Print &quot;equal&quot; if the matrices match and &quot;not equal&quot; if they don&#39;t match.

Input |Output
---|---
[[1,2,3], [2,1,3]], [[1,2,3], [2,1,3]] |equal
[[1,2,3], [4,5,6]], [[1,3], [4,5]] |not equal

### 2. Matrix Addition

Given two matrices of the same size, write a program to add them together.
Print new matrix with the sum of the sum of the same indices from the two matrices.

Input |Output
---|---
[[1,2],[3,4]], [[2,2],[2,2]] |3 4
||5 6
[[1,2,3],[4,3,1]], [[1,2,3],[4,2,2]] |2 4 6
||8 5 3

### 3. Intersection of Two Matrices

Write a program that receives two char matrices (A[ ][ ] and B[ ][ ]) of the same order M * N and prints the third matrix C[ ][ ], which is filled with the intersecting elements of A and B, otherwise set the element to "\*". Receive M and N, then on 2 * M lines N characters - the matrices elements.
The matrix elements may be any ASCII char except "\*".

**Examples**
Input |Output
---|---
[&quot;a b c d&quot;, &quot;a b c d&quot;, &quot;a b c d&quot;], [&quot;k b c k&quot;, &quot;a b g d&quot;, &quot;a k c d&quot;] |* b c *
||a b * d
||a * c d
[&quot;1 2&quot;, &quot;3 4&quot;, &quot;5 6&quot;, &quot;7 8&quot;, &quot;9 1&quot;], [&quot;0 2&quot;, &quot;3 1&quot;, &quot;1 6&quot;, &quot;7 4&quot;, &quot;1 1&quot;] |* 2
||3 *
||* 6
||7 *
||* 1

### 4. Sum Matrix Elements

Write a program that receive a matrix and prints:
* The count of rows
* The count of columns
* The sum of all matrix&#39;s elements

**Examples**
Input |Output
---|---
[[7, 1, 3, 3, 2, 1], [1, 3, 9, 8, 5, 6], [4, 6, 7, 9, 1, 0]] |3
||6
||76
[[10, 11, 12, 13], [14, 15, 16, 17]] |2
||4
||108

### 5. Maximum Sum of 2X2 Submatrix

Write a program that receives a matrix. Then find the biggest sum of a 2x2 submatrix.
Print the submatrix and its sum.
Input |Output
---|---
[&quot;7 1 3 3 2 1&quot;, &quot;1 3 9 8 5 6&quot;, &quot;4 6 7 9 1 0&quot;] |33
||9 8
||7 9
[&quot;10 11 12 13&quot;, &quot;14 15 16 17&quot;] |58
||12 13
||16 17

### 6. Print Diagonals of Square Matrix

Write a program that receives a matrix. Then print the diagonals. The matrix will always be square. The first diagonal should always start with the element at the first row and col. The second diagonal should start with the element at the last row and first col.

Input |Output
---|---
[&quot;1 2 3&quot;, &quot;1 2 3&quot;, &quot;1 2 3&quot;] |1 2 3
||1 2 3
[&quot;1 2 3 2&quot;, &quot;1 1 2 4&quot;, &quot;1 2 1 4&quot;, &quot;2 2 3 1&quot;] |1 1 1 1
||2 2 2 2

### 7. Matrix Diagonal Sum

Write a program to find the sum of both diagonals in a square matrix.

Input |Output
---|---
[&quot;1 2 3&quot;, &quot;4 5 6&quot;, &quot;7 8 9&quot;] |30
[&quot;10 11&quot;, &quot;14 15&quot;] |50

### 8. Fill the Matrix

Write two functions that fill a size N x N matrix in two different patterns. Both patterns are described below:
Pattern A |Pattern B
---|---
1 5 9 13 |1 8 9 16
2 6 10 14|2 7 10 15
3 7 11 15|3 6 11 14
4 8 12 16|4 5 12 13

Input |Output
---|---
3 A |1 4 7
||2 5 8
||3 6 9
3 B |1 6 7
||2 5 8
||3 4 9

### 9. Row Sum and Column Sum

Given a matrix, calculate the sum of each row and each column.

Input |Output
---|---
[&quot;1 2&quot;, &quot;3 4&quot;, &quot;5 6&quot;] |Row Sums: 3, 7, 11
||Column Sums: 9, 12
[&quot;1 2 3&quot;, &quot;4 5 6&quot;, &quot;7 8 9&quot;] |Row Sums: 6, 15, 24
||Column Sums: 12, 15, 18

### 10. Zero Matrix

If an element in a matrix is 0, set its entire row and column to 0.
Input |Output
---|---
[&quot;1 2 3&quot;, &quot;4 0 6&quot;, &quot;7 8 9&quot;]|1 0 3 
||0 0 0
||7 0 9
[&quot;1 2 3 0&quot;, &quot;4 5 6 7&quot;, &quot;0 8 9 1&quot;] |0 0 0 0
||0 5 6 0
||0 0 0 0

### 11. Matrix Boundary Sum

Write a program that calculates the sum of the boundary elements of a matrix.
Input |Output||
---|---|---
[&quot;1 2 3&quot;, &quot;4 5 6&quot;, &quot;7 8 9&quot;] |28 |// 1 + 2 + 4 + 6 + 9 + 8 + 7 + 4
[&quot;1 2 3 0&quot;, &quot;4 5 6 7&quot;, &quot;0 8 9 1&quot;] |35 |

### 12. Rotate Matrix 90 Degrees

Rotate the given matrix 90 degrees to the right (or clockwise).
Input |Output
---|---
[&quot;1 2 3&quot;, &quot;4 5 6&quot;, &quot;7 8 9&quot;] |7 4 1
||8 5 2
||9 6 3
[&quot;0 1 2 3&quot;, &quot;4 5 6 7&quot;, &quot;8 9 10 11&quot;, &quot;12 13 14 15&quot;] |12 8 4 0
||13 9 5 1
||14 10 6 2
||15 11 7 3

### 13. Excel Column Name to Number

In Excel, columns are represented by letters, starting from A for the 1st column, B for the 2nd, and so on. After Z, the columns are represented by two letters, like AA, AB, etc.
Write a program that converts an Excel column name to its corresponding column number.
Input |Output
---|---
AB |28
A |1
C |3
CZ |104
MM |351

### 14. Chessboard Checker

Given a chessboard representation where empty squares are 0 and queens are 1, determine if either two queens threaten each other.
Input |Output
---|---
[&quot;0 1 0 0&quot;, &quot;0 0 0 1&quot;, &quot;1 0 0 0&quot;, &quot;0 0 1 0&quot;] |No
[&quot;0 1 0 0&quot;, &quot;0 0 0 1&quot;, &quot;1 0 0 0&quot;, &quot;0 1 0 0&quot;] |Yes
[&quot;0 1 0 0&quot;, &quot;0 0 0 0&quot;, &quot;1 0 0 0&quot;, &quot;0 0 0 0&quot;] |No

### 15. Excel Sum Formula

Imagine an Excel sheet where each cell contains a number. Write a program that calculates the sum of a given range.
Input |Output
---|---
[[1, 2, 3], [4, 5, 6], [7, 8, 9]], &quot;A1:C2&quot; |21
[[0, 1, 0, 0], [0, 0, 0, 1], [1, 0, 0, 0], [0, 1, 0, 0]], &quot;A1:B4&quot;| 3
[[0, 1, 0, 0], [0, 0, 0, 0], [1, 0, 0, 0], [0, 0, 0, 0]], &quot;A1:C4&quot; |2

### 16. Matrix Border Flip

Given a matrix, flip its border elements in a clockwise direction.
Input |Output
---|---
[&quot;1 2 3&quot;, &quot;4 5 6&quot;, &quot;7 8 9&quot;] |4 1 2
||7 5 3
||8 9 6
[&quot;0 1 00&quot;, &quot;0 0 0 1&quot;, &quot;1 0 0 0&quot;, &quot;0 1 0 0&quot;] |0 0 1 0
||1 0 0 0
||0 0 0 1
||1 0 0 0

### 17. Magic Square Checker

Determine if a matrix is a magic square (a matrix in which the sums of every row, every column, and both main diagonals are the same).
Input |Output
---|---
[&quot;1 2 3&quot;, &quot;4 5 6&quot;, &quot;7 8 9&quot;] |False
[&quot;1 0 0 0&quot;, &quot;0 0 0 1&quot;, &quot;0 1 0 0&quot;, &quot;0 0 1 0&quot;] |True
[&quot;8 1 6&quot;, &quot;3 5 7&quot;, &quot;4 9 2&quot;]|True

### 18. Spiral Matrix Traversal

Print the elements of a matrix in spiral order.
Input |Output
---|---
[&quot;1 2 3&quot;, &quot;4 5 6&quot;, &quot;7 8 9&quot;] |1 2 3 6 9 8 7 4 5
[&quot;1 2 3 4&quot;, &quot;5 6 7 8&quot;, &quot;9 10 11 12&quot;, &quot;13 14 15 16&quot;] |True
||1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10
[&quot;1 2&quot;, &quot;3 4&quot;] |1 2 4 3

### 19. Checkerboard Pattern

Given an n x n size, generate a matrix with a checkerboard pattern using 0s (for white squares) and 1s (for black squares).
Input |Output
---|---
3 |0 1 0
||1 0 1
||0 1 0
4 |0 1 0 1
||1 0 1 0
||0 1 0 1
||1 0 1 0

### 20. Maximal Sum

Write a program that receives a rectangular integer matrix and finds the square 3 x 3 with a maximal sum of its elements.

Print the elements of the 3 x 3 square as a matrix, along with their sum. See the format of the output below.
Input |Output
---|---
[&quot;1 5 5 2 4&quot;, &quot;2 1 4 14 3&quot;, &quot;3 7 11 2 8&quot;, &quot;4 8 12 16 4&quot;] |Sum = 75
||1 4 14
||7 11 2
||8 12 16
[&quot;1 0 4 3 1 1&quot;, &quot;1 3 1 3 0 4&quot;, &quot;6 4 1 2 5 6&quot;, &quot;2 2 1 5 4 1&quot;, &quot;3 3 3 6 0 5&quot;] |Sum = 34
||2 5 6
||5 4 1
||6 0 5