# Functions - Exercises

### 1. Smallest of Three Numbers

Write a JS function which receive three integer numbers to print the smallest of the three integer numbers. Use appropriate name for the function.

**Examples**
Input |Output
---|---
2, 5, 3 |2
600, 342, 123 |123
25, 21, 4 |4

### 2. Add and Subtract

You will receive 3 integers. Write a JS function sum to get the sum of the first two integers and subtract function that subtracts the third integer from the result from the Sum function.

**Examples**
Input |Output
---|---
23, 6, 10 |19
1, 17, 30 |-12
42, 58, 100 |0

### 3. Characters in Range

Write a JS function that receives two characters and prints on a single line all the characters in between them according to the ASCII code.

**Examples**
Input |Output
---|---
&#39;a&#39;, &#39;d&#39; |b c
&#39;#&#39;, &#39;:&#39; |$ % &amp; &#39; ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9
&#39;C&#39;, &#39;#&#39; |$ % &amp; &#39; ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; &lt; = &gt; ? @ A B

### 4. Odd and Even Sum

You will receive a single number.
You have to write a JS function, that returns the sum of all even and all odds digits from that number.

**Examples**
Input |Output
---|---
1000435 |Odd sum = 9, Even sum = 4
3495892137259234 |Odd sum = 54, Even sum = 22

### 5. Palindrome Numbers

A palindrome is a number which reads the same backward as forward, such as 323 or 1001. Write a JS function which receives an array of positive integer and checks if each integer is a palindrome or not.

Write **isPalindrome** function.

Input |Output
---|---
[123,323,421,121] |false
||true
||false
||true
[32,2,232,1010] |false
||true
||true
||false

### 6. Password Validator

Write a JS function that checks if a given password is valid. Password rules are:
* 6 - 10 characters (inclusive)
* Consists only of letters and digits
* Have at least 2 digits

If a password is valid print &quot;Password is valid&quot;. If it is not valid, for every unfulfilled rule print a message:
* &quot;Password must be between 6 and 10 characters&quot;
* &quot;Password must consist only of letters and digits&quot;
* &quot;Password must have at least 2 digits&quot;

Write a function for each rule.

Input |Output
---|---
&#39;pass&#39; |Password must be between 6 and 10 characters
||Password must have at least 2 digits
&#39;APass123&#39; |Password is valid
&#39;Pa$s$s&#39; |Password must consist only of letters and digits
||Password must have at least 2 digits

### 7. Shortest and Longest Word

You will receive a single string. This string will be a sentence. Your task here is to create JS function to find:
The longest and the shortest word in that sentence. If two words have equal length take the first occurrence.

**Examples**
Input |Output
---|---
&#39;Hello how are you today? I hope you are fine &#39; |Longest -&gt; Hello
||Shortest -&gt; I
&#39;Lorem Ipsum is dummy text of the typesetting industry.&#39; |Longest -&gt; typesetting
||Shortest -&gt; is

### 8. Perfect Number

Write a JS function that receive a number and return if this number is perfect or not.

A perfect number is a positive integer that is equal to the sum of its proper positive divisors. That is the sum of its positive divisors excluding the number itself (also known as its aliquot sum).

Equivalently, a perfect number is a number that is half the sum of all of its positive divisors (including itself) =&gt; 6 is a perfect number, because it is the sum of 1 + 2 + 3 (all of which are divided without remainder).

**Examples**
Input |Output
---|---
6 |Perfect number!
||1 + 2 + 3
28 |Perfect number!
||1 + 2 + 4 + 7 + 14
1236498 |It's not so perfect.

### 9. Progress Bar

You will receive a single number between 0 and 100 which is divided with 10 without residue (0, 10, 20, 30...).

Your task is to create a JS function that visualize a loading bar depending on that number you have received in the input. See examples for more clarity.

**Examples**
Input |Output
---|---
30 |30% [%%%.......]
||Loading...
50 |50% [%%%%%.....]
||Loading...
100 |[%%%%%%%%%%]
||Complete!

### 10. Factorial Division

Write a JS Function that reaceives two integer numbers. Calculate factorial of each number. Divide the first result by the second and print the division formatted to the second decimal point.

**Examples**
Input |Output
---|---
5, 2 |60.00 
6, 2 |360.00

**Hints:**
Try to use recursion