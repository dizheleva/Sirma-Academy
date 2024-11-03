# Basic Syntax - Exercises

### 1. Create new project

Create new project in **Visual Studio**:
1. Start Visual Studio
2. From the menu, select **&quot;New Project&quot;**.
3. Select C# Console App as a Template
4. Name you project with
5. Our new project is ready

### 2. First Program

Write a program that prints **&quot;Hello, world!&quot;**.
* 1. Between the opening and closing shape brackets of the **&quot;Main&quot;** method, type the print command.
* 2. In the brackets of the command, in quotation marks write – **&quot;Hello, world!&quot;**
* 3. SStart the program with **Ctrl + [F5]**.

### 3. Different data types

1. Create an **int** type variable to which you assign a **value of 100**. Print the value of the variable.
2. Create a variable of type **&quot;double&quot;** to which you assign a **value of 3.15**. Print the value of the variable.

### 4. Read User Input - Name

Write a program that reads a name (text) from the console and then prints it.
1. Create a variable of type string and assign it the value that will be entered on the console.
2. Print by calling the name of the variable.

### 5. Read different data

Write a program that reads the following data sequentially on separate lines:
* Text
* Symbol
* Integer
* Real number
For each data type, create a separate variable and read from the console by a command corresponding to the specific type – string, char, int, double.

### 6. Printing

Write a program that uses the data from task 5 and prints:
1. Each variable on a new line, in the order in which they are read.
2. All variables on one line (each in a separate command).

### 7. Weather Forecast

Write a program that reads from the console city (text) and degrees (integer) and displays the following message on the console: **&quot;Today in {city} it is {degrees} degrees.&quot;**.

### 8. Kilometers in miles

Write a program that reads kilometers (real number) from the console and converts them to miles. Print the result on the console. 
Note: **1 kilometer = 0.621371192 miles**.

**Examples:**
**Input** | **Output**
---|---
10 | 6.21371192
23 | 14.291537416
115 | 71.45768708

### 9. Calculate

Write a program that reads two **integers** &quot;numOne&quot; and &quot;numTwo&quot;. Following the described sequence, find and print:
* Sum of numbers
* Difference Between Numbers
* Multiplication
* Moderately arrhythmic

**Input** | **Output**
---|---
25  | The sum is: 30
5   | The difference is: 20
|    | The product is: 125
|    | The average is: 15.000000
| | |
7   | The sum is: 9
2   | The difference is: 5
|    | The product is: 14
|    | The average is: 4.500000
|   |   |
26158 | The sum is: 26177
19    | The difference is: 26139
|    | The product is: 497002
|    | The average is: 13088.500000
|   |   |
3   | The sum is: 49
46  | The difference is: 43
|    | The product is: 138
|    | The sum is: 24

### 10. Time

Write a program that reads minutes (integer) and converts them into hours and minutes. Print the result in **HR:MM** format.

**Input** | **Output**
---|---
60 | 01:00
90 | 01:30
325| 05:25

### 11. Speed

Write a program that calculates the speed in meters per second and displays the result on the console.
The input data are integers as follows:
* Distance in meters
* Hours
* Minutes
* Seconds

Use the formula **V = S/T** where **V - speed**, **S - distance**, **T - time**

**Input** | **Output**
---|---
100 | 0.020747
1   |
20  |
20  |
|   |   |
2500 | 0.116915
5   |
56  |
23  |
|   |   |
600 | 0.021934
7   |   
35  |
55  |

### 12. Painting

For the painting of 3 rooms they spent n kg of paint (equally for each room). To get the desired color, they mixed yellow, red and white paint. The yellow paint was 4 times more than the red and 2 times less than the white. How many kilograms of each color did they spend on painting a room?
From the console read **n** -> total paint consumed.
The output must be rounded to the **fourth** decimal point.

**Input** | **Output**
---|---
150 | Red: 11.5385
|   | Yellow: 46.1538
|   | White: 92.3077
|   |   |
120 | Red: 9.2308
|   | Yellow: 36.9231
|   | White: 73.8462
|   |   |
630 | Red: 48.4615
|   | Yellow: 193.8462
|   | White: 387.6923

### 13. Office

For the furnishing of the office purchased 3 cabinets. One cabinet cost **$n**, the second was 20% cheaper than the first, and the third cost 15% more than the other two combined.
From the console read the cost of the first cabinet – a real number.
The output must be rounded to the third decimal point.

**Input** | **Output**
---|---
380 |1470.600
720.50 |2788.335
455.30 |1762.011

### 14. Journey

A car started from the city of Sofia to the city of Berlin at a speed of **x** km / h, and 2 hours later another car went to the same destination at a speed y km / h. How many kilometers will be the distance between the two cars 3 hours after the departure of the second car?

**Input** | **Output**
---|---
81  |45
120 |
|   |   |
100 |230
90  |
|   |   |
75  |105
90  |

### 15. Body Mass Index (BMI)

Calculate the Body Mass Index (BMI) based on the given weight (in kilograms) and height (in meters).

Use the formula **BMI = Weight / Height^2**.

**Input** | **Output**
---|---
70  |23.38
1.73 |
|   |   |
60  | 19.59
1.75 |
|   |   |
85   |26.23
1.80 |

### 16. Water Consumption

Calculate the daily water consumption per person in a household. Given the total water consumption in liters for a week and the number of people in the household, find out the daily consumption per person.

Use the formula: **Daily consumption per person = Total weekly consumption / 7 * Number of people**

**Input** | **Output**
---|---
2450 |50.00
7|
|   |   |
3150|45.00
10|
|   |   |
980 |20.0
7|

### 17. Electricity Bill

Calculate the monthly electricity bill based on the number of units consumed and the rate per unit. Additionally, a fixed charge of $10 is added to the bill.

Use the formula: **Total Bill = ( Units consumed x Rate per unit ) + 10**

**Input** | **Output**
---|---
100 |110.00
1.0|
|   |   |
200 |210.00
1.0|
|||
150 |175
1.1|

### 18. Average Speed

Calculate the average speed of a vehicle that has traveled a certain distance D in kilometers over a given time T in hours.

Use the formula: **Average Speed = D / T**.

On the first line, you receive the distance D in kilometers.
On the second line, you receive the time T in hours.

**Input** | **Output**
---|---
200 |100.00
2|
|||
150 |50.00
3|
|||
300 |60.00
5|

### 19. Fuel Efficiency

Calculate the fuel efficiency of a car given the total distance traveled D in kilometers and the total fuel consumed F in liters.

Use the formula: **Fuel Efficiency = D / F**

On the first line, you receive the distance D in kilometers.
On the second line, you receive the fuel F in liters.

**Input** | **Output**
---|---
500 |125
40|
|||
600 |150
40|
|||
750 |18.75
40|

### 20. Circle Circumference

Calculate the circumference of a circle given its radius R.

Use the formula: **Circumference = 2 * pi * R**

On the first line, you receive the radius R.

**Input** | **Output**
---|---
5 |31.42
7 |43.98
10 |62.83