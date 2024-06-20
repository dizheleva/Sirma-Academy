# Basic Syntax - Exercises

### 1. Create new project

Create a blank project in **Visual Studio Code**. We will combine the solutions of all tasks in the form of separate files in this project. This is extremely convenient when we want to work on several projects and quickly switch between them or we want to logically merge several interrelated projects. This helps us to keep the solutions of the tasks separate and keep them to use for other tasks or review.
* 1. Run Visual Studio Code
* 2. Create a new folder that will hold the individual solutions. A dialog box will open in which you will need to select its directory. It is recommended to name the folder according to the topic of the job, example &quot;Basic Syntax&quot;

* 3. Then select the folder as your desktop environment to add the JavaScript solution files to your tasks.

### 2. Hello world

The first task of this topic is to write a function that prints on the console: &quot;Hello, World!&quot;
* Create a new **JavaScript** file in the existing folder and name it appropriately. It is recommended that each script file be given the name of the task whose solution it contains.
* The contents of the new file will open in the window on the right.
* Go to the hello file.js and create the **function hello()**. You can help yourself with the code below:
```
function hello(){
console.log("Hello, World!")
}
hello();
```
* Start the program with **Ctrl + [F5]**. To get a result, we need to &quot;call&quot; the function:
We can see the result in the console below.

### 3. Different data types

Create a variable to which you assign a value of 100. Print the value of the variable.
Create a variable to which you assign a value of 3.15. Print the value of the variable.
Tip - use the code to print &quot;Hello World!&quot; (Instead of the text in parentheses, call the name of the variable).
```
function hello(){
let num = 100;
console.log(num);
let num2 = 3.15;
console.log(num2);
}
hello();
```
**Sample input:**

| Input | Output |
|---|---|
| | 100 |
| | 3.15 |

### 4. Read User Input - Name

Write a function that receives a parameter (name) and then prints it.
Print by calling the name of the variable.
```
function printName(name){
console.log(name);
}
```

**Sample input:**
Input | Output
---|---
printName (&quot;Ivan&quot;) | Ivan
printName (&quot;Andrei&quot;) | Andrey
printName (&quot;Maria&quot;) | Maria

### 5. Read different data

Write a program that receives 3 parameters:
* Text
* Integer
* Real number

**Sample input:**
Input | Output
---|---
f(&quot;Ivan&quot;, 100, 3.14) |
f(&quot;George&quot;, 200, 6.00) | 
f(&quot;Mary&quot;, 1, 12.12) |

\* **Attention:** depending on the regional settings of the  perating system, it is possible to use a decimal point (US settings) instead of a decimal comma (BG settings).
It is recommended that you **change your computer&#39;s settings** so that a **decimal point** is used

### 6. Printing

Write a function that uses the parameters of problem 5 and prints them.

**Sample input:**
Input | Output
---|---
f(&quot;Ivan&quot;, 100, 3.14)  | Ivan
| | 100
| | 3.14
f(&quot;George&quot;, 200, 6.00)  | George
| | 200
| | 6.00
f(&quot;Mary&quot;, 1, 12.12)  | Mary
| | 1
| | 12.12

### 7. Weather Forecast

Write a function that takes as parameters city (text) and degrees (integer) and displays the following message on the console: **&quot;Today in {city} it is {degrees} degrees.&quot;**.
Tip: use **string concatenation**.

**Sample input:**
Input | Output
---|---
f(&quot;Sofia&quot;, 29) | Today in Sofia it is 29 degrees.
f(&quot;Varna&quot;, 32) | Today in Varna it is 32 degrees.
f(&quot;Plovdiv&quot;, 18) | Today in Plovdiv it is 18 degrees.

### 8. Kilometers in miles

Write a function that takes a parameter kilometer (real number) and converts them to miles. Print the result on the console.
Note **1 kilometer = 0.621371 miles**.

**Sample input:**
Input | Output
---|---
f(5) | 3.106855
f(10.5) | 6.5243955
f(42) | 26.097582
f(123.5) | 76.7393185

### 9. Calculate

Write a function that accepts two **integers** &quot;numOne&quot; and &quot;numTwo&quot;. Following the described sequence, find and print in the shown format:
* Sum of numbers
* Difference Between Numbers
* Multiplication
* Arithmetic mean
Tip: use **Math.abs()** to calculate the **absolute value of the difference**.

**Sample input:**
Input | Output
---|---
f(25, 5) | Sum: 30
| | Difference: 20
| | Product: 125
| | Average: 15
f(7, 14) | Sum: 21
| | Difference: 7
| | Product: 98
| | Average: 10.5
f(12, 1) | Sum: 13
| | Difference: 11
| | Product: 12
| |Average: 6.5

### 10. Square face

Write a function that takes integer **&#39;a&#39;** and calculates the square area with side **&#39;a&#39;**.

**Sample input:**
Input | output
---|---
f(5) | 25
f(10) | 100

**Guidelines**

**Initialize an area variable** in which to record the value for the rectangle face obtained by the side*side **formula**. Print the result.

### 11. Time

Write a function that takes minutes (integer) and converts them into hours and minutes.
Print the result in the format H:M.

**Sample input:**
entrance | exit
---|---
f(60) | 1:0
f(90) | 1:30
f(325) | 5:25

### 12. Time v2***

Write a program that reads minutes (integer) and converts them into hours and minutes.
Print the result in the format of HH: MM

**Sample input:**
Input | Output
---|---
60 | 01:00
90 | 01:30
325 | 05:25

Try to find a solution here:
https://www.google.com/search?q=js+print+number+with+leading+zeros

### 13. Painting

X liters of paint are used to paint a room. To obtain the desired color, yellow, red and white paint is mixed. Yellow paint is 4 times more than red and 2 times less than white.
How many liters of each color have they spent on painting a room?
As a parameter you take the liters of yellow paint - integer [10,100]

**Sample input:**
Input | Output
---|---
f(10) | Red: 2.5
| | Yellow: 10
| | White: 20
| | Total: 32.5
f(17) | Red: 4.25
| | Yellow: 17
| | White: 34
| | Total: 55.25
f(42) | Red: 10.5
| | Yellow: 42
| | White: 84
| | Total: 136.5

### 14. Console converter: EUR to BGN

Write a function to **convert euro** (EUR) to **Bulgarian leva** (BGN).
**Format** the result to **2 decimal places**.
Use a fixed **rate** between the euro and lev: **1 EUR = 1.95583 BGN**.

**Sample input:**
Input | Output
---|---
f(1) | 1.96
f(15) | 29.34
f(123) | 240.57
f(0.5) | 0.98
f(0.51) | 1.00

### 15. Speed

Write a program that calculates the speed in meters per second and displays the result on the console.
The input data are integers as follows:
* Distance in meters
* Hours
* Minutes
* Seconds

Use the formula **V = S/T** where **V - speed**, **S - distance**, **T - time**

INPUT | OUTPUT
---|---
100, 1, 20, 20  | 0.020747
2500, 5, 56, 23 |0.116915
600, 7, 35, 55 |0.021934

### 16. Office

For the furnishing of the office purchased 3 cabinets. One cabinet cost **$n**, the second was 20% cheaper than the first, and the third cost 15% more than the other two combined.
On the console print the total cost of the three cabinets - a real number.
The output must be rounded to the third decimal point.

INPUT |OUTPUT
---|---
380 |1470.600
720.50 |2788.335
455.30 |1762.011

### 17. Journey

A car started from the city of Sofia to the city of Berlin at a speed of x km / h, and 2 hours later another car went to the same destination at a speed y km / h. How many kilometers will be the distance between the two cars 3 hours after the departure of the
second car?

INPUT |OUTPUT
---|---
81, 120 |45
100, 90 |230
75, 90 |105

### 18. Body Mass Index (BMI)

Calculate the Body Mass Index (BMI) based on the given weight (in kilograms) and height (in meters).

Use the formula **BMI= Weight / Height 2**.

INPUT |OUTPUT
---|---
70, 1.73 |22.96
60, 1.75 |20.76
85, 1.80 |27.68

### 19. Water Consumption

Calculate the daily water consumption per person in a household. Given the total water consumption in liters for a week and the number of people in the household, find out the daily consumption per person.

Use the formula: **Daily consumption per person = Total weekly consumption / 7 * Number of people**

INPUT |OUTPUT
---|---
2450, 7 |50.00
3150, 10 |45.00
980, 7 |20.0

### 20. Electricity Bill

Calculate the monthly electricity bill based on the number of units consumed and the rate per unit. Additionally, a fixed charge of $10 is added to the bill.

Use the formula: **Total Bill = ( Units consumed x Rate per unit ) + 10**

INPUT |OUTPUT
---|---
100, 1.0 |110.00
200, 1.0 |220.00
150, 1.1 |175.5

### 21. Average Speed

Calculate the average speed of a vehicle that has traveled a certain distance D in kilometers over a given time T in hours.

Use the formula: **Average Speed = D / T**.

On the first line, you receive the distance D in kilometers.
On the second line, you receive the time T in hours.

INPUT |OUTPUT
---|---
200, 2 |100.00
150, 3 |50.00
300, 5 |60.00

### 22. Fuel Efficiency

Calculate the fuel efficiency of a car given the total distance traveled D in kilometers and the total fuel consumed F in liters.

Use the formula: **Fuel Efficiency = D / F**

On the first line, you receive the distance D in kilometers.
On the second line, you receive the fuel F in liters.

INPUT |OUTPUT
---|---
500, 40 |12.50
600, 40 |15.00
750, 40 |18.75

### 23. Circle Circumference

Calculate the circumference of a circle given its radius R.

Use the formula: **Circumference = 2 * pi * R**

On the first line, you receive the radius R.

INPUT |OUTPUT
---|---
5 |31.42
7 |43.96
10 |62.83