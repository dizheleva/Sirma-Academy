# Basic Syntax - Exercises

### 1. Create a new project

* Create a blank project in **Visual Studio Code**. We will combine the solutions of all tasks in the form of separate files in this project.
* Create a new folder that will hold the individual solutions. A dialog box will open in which you will need to select its directory. It is recommended to name the folder according to the topic of the job, example **&quot;conditional-statements&quot;**
* Then select the folder as your desktop environment to add the JavaScript solutions to your tasks.

### 2. Check for an excellent rating

Write a console program that reads a **rating (decimal number)** entered by the user and prints **&quot;Excellent!&quot;** if the rating is 5.50 or higher.

Input | Output
---|---
f(6) |Excellent!
f(5) |no output
f(5.51) |Excellent!
f(5.501) |Excellent!

**Guidelines:**
* Create a new **JavaScript file** in the existing folder and name it appropriately. It is recommended that each script file be given the name of the task whose solution it contains.
* The contents of the new file will open in the window on the right.
* Go to the **isExcellent.js** file and create the ```isExcellent(grade)``` function.
* Check the value of the rating. If it is greater than or equal to 5.50 print the output by condition.

### 3. Larger number

Write a function that reads accepts two integers and prints the larger of the two.

Input |Output
---|---
f(2, 4) |4
f(7, 12) |12
f(-1, -5) |-1

### 4. Number from 0 to 9 in words

Write a function that gets an integer in the **range [0... 9]** and spells it out in words in English. If the number is out of range, it spells out **&quot;too big&quot;**.

Input |Output
---|---
f(7) |seven
f(5) |five
f(10) |too big

**Guidelines:**
* Check for the **size** of the number. Print with text any of the **words [&quot;zero&quot;, &quot;one&quot;, &quot;two&quot;, &quot;three&quot;... &quot;nine&quot;]** depending on the value.
* Print **&quot;too big&quot;** if the number is greater than 9

### 5. Face of figures

Write a function that takes the look and dimensions of a geometric figure and calculates its face.
The figures are of four types: square, rectangle, circle, and triangle. The first parameter is the type of figure (square, rectangle, circle, or triangle).
* If the figure is a square, the next parameter is a number - the length of its side.
* If the figure is a rectangle, the next two parameters produce two numbers - the lengths of its sides.
* If the figure is a circle, the next parameter is a number - the radius of the circle.
* If the figure is a triangle, the next two parameters produce two numbers - the length of its side and the length of the height to it.

Round the result to 2 decimal places.

**Sample input:**
Input |Output
---|---
f(&quot;square&quot;, 5) |25.00
f(&quot;rectangle&quot;, 10, 3.5) |35.00
f(&quot;triangle&quot;, 4.5, 20) |45.00
f(&quot;circle&quot;, 10) |314.16

**Guidelines:**
* You can search for the face formulas of the different shapes on the Internet. 
* Use **Math.PI** to use the number **pi** when calculating the face of a circle.
```
function f (figure, a, b) {
    let area = 0;
    switch (figure) {
        case "square":
            TODO
        break;
        case "rectangle":
            TODO
        break;
        case "circle":
            let radius = a;
            area = Math.PI * radius * radius;
        break;
        case "triangle":
            TODO
        break;
    }
}
```

### 6. Day of the week

Write a function that receives an integer and prints a **day of the week (in English)**, within the limits **[1...7]** or prints **&quot;Error&quot;** in case the entered number is invalid.

**Sample input:**
Input |Output
---|---
f(1) |Monday
f(2) |Tuesday
f(3) |Wednesday
f(4) |Thursday
f(5) |Friday
f(6) |Saturday
f(7) |Sunday
f(8) |Error

### 7. Even or odd

Write a function that receives an integer and prints on the console, whether even or odd.

**Sample input:**
Input |Output
---|---
f(2) |even
f(3) |odd
f(25) |odd
f(1024) |even

**Guidelines:**
* Check what is **% (operator modulo)** https://www.google.com/search?q=modulo
* Check whether the number is even by dividing it by 2 and check whether there is a remainder of the division. Print the output by condition - the text **&quot;even&quot;**:
```
function solve (num) {
    if (num % 2 == 0) {
        console.log("even");
    }
}
```
* Otherwise, print **&quot;odd&quot;**

### 8. Speed

Write a program that receives speed (real number) and prints speed information.
* At speeds up to 10 (inclusive) print &quot;slow&quot;.
* At speeds above 10 and up to 60 print &quot;average&quot;.
* At speeds above 60 and up to 120, print &quot;fast&quot;.
* At speeds above 120 and up to 160 MHz, print &quot;super-fast&quot;.
* At higher speeds, print &quot;turbo-fast&quot;.

**Sample input:**
Input |Output
---|---
f(10) |slow
f(59) |average
f(120) |fast
f(121) |super-fast
f(183) |turbo-fast
f(59.99) |average
f(60.001) |fast

### 9. Alarm after 15 minutes

Write a function that takes an hour and minutes of a 24-hour day and calculates what time it will be after 15 minutes. Print the result in **hours:minutes** format.
Hours are always between 0 and 23, and minutes are always between 0 and 59. Hours are written in one or two digits.
Minutes are always written with two digits, with a leading zero when necessary.
Try to find out how to add 0s in front of a number here: https://www.google.com/search?q=js+print+number+with+leading+zeros

**Sample input:**
Input |Output
---|---
f(1, 47) |2:02
f(0, 2) |0:17
f(23, 59) |0:14
f(11, 07) |11:22
f(12, 48) |13:03

### 10. Address by age and gender

Write a console program that assumes **age** (real number) and **gender** (&#39;m&#39; or &#39;f&#39;), and
prints a reference among the following:
* &quot;Mr.&quot; - male (sex &#39;m&#39;) 16 years of age or older
* &quot;Master&quot; - boy (gender &#39;m&#39;) under 16 years
* &quot;Ms.&quot; - woman (sex &#39;f&#39;) 16 years of age or older
* &quot;Miss&quot; - girl (gender &#39;f&#39;) under 16

**Sample input:**
Input |Output
---|---
f(14, &quot;f&quot;) |Miss
f(17, &quot;m&quot;) |Mr.
f(10, &quot;m&quot;) |Master
f(32, &quot;f&quot;) |Ms.

```
if (gender == "f") {
    if (age <= 16) {
        console.log("Miss");
    } else {
        console.log("Ms.");
    }
} else {
    if (age <= 16) {
        TODO
    } else {
        TODO
    }
}
```

### 11. Grocery

A chain of stores opens groceries in several cities and sells at different prices according to the city:

**City / Product**
| |tea |water |juice |sweets |chips
---|---|---|---|---|---
**Sofia** |0.50 |0.80 |1.20 |1.45 |1.60
**Plovdiv** |0.40 |0.70 |1.15 |1.30 |1.50
**Varna** |0.45 |0.70 |1.10 |1.35 |1.55

Write a program that accepts a **product** (string), **city** (string) and **quantity** (decimal number) and calculates and prints how much the corresponding quantity of the selected product **costs** in the specified city.

**Sample input:**
Input |Output
---|---
f(&quot;tea&quot;, &quot;Varna&quot;, 2) |0.90
f(&quot;chips&quot;, &quot;Plovdiv&quot;, 1) |1.50
f(&quot;juice&quot;, &quot;Sofia&quot;, 6) |7.20
f(&quot;sweets&quot;, &quot;Plovdiv&quot;, 1) |1.50

### 12. Number in the range

Write a program that checks whether the received number is in the **range [-100, 100]** and is different from **0** and outputs **&quot;Yes&quot;** if it meets the conditions, or **&quot;No&quot;** if it is outside them.

**Sample input:**
Input |Output
---|---
f(-25) |Yes
f(0) |No
f(25) |Yes

### 13. Simple Calculator

Write a function that receives two numbers and an operation and prints the result of it.
* add +
* subtract -
* divide /
* multiply *

Format the result to **two decimal places**.

**Sample input:**
Input |Output
---|---
f(5, 5, &quot;add&quot;) |10
f(10, 12, &quot;subtract&quot;) |-2
f(9, 3, &quot;divide&quot;) |3
f(5, 2, &quot;divide&quot;) |2.5
f(3.1, 0.1, &quot;multiply&quot;) |0.31

### 14. Vegetable Market

The vegetable market works on **working days** at the following prices:
vegetable |tomato |onion |lettuce |cucumber |pepper
---|---|---|---|---|---
**price**|2.50 |1.20 |0.85 |1.45 |5.50

**Saturday and Sunday** the stock exchange operates at higher prices:
vegetable |tomato |onion |lettuce |cucumber |pepper
---|---|---|---|---|---
**price** |2.80 |1.30 |0.85 |1.75 |3.50

Write a program that accepts **vegetable** (tomato / onion / lettuce / cucumber / pepper), **day of the week** (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) and **quantity** (real number) and calculates the **price** according to the prices in the tables above.
* Print the result rounded by **2 decimal places**.
* In case of an **invalid day** of the week or **invalid vegetable name**, print **&quot;error&quot;**.

**Sample input:**
Input |Output
---|---
f(&quot;tomato&quot;, &quot;Tuesday&quot;, 2) |5.00
f(&quot;onion&quot;, &quot;Sunday&quot;, 3) |3.90
f(&quot;pepper&quot;, &quot;Monday&quot;, 10) |55.00
f(&quot;banana&quot;, &quot;Friday&quot;, 5) |error

### 15. Holiday

A young programmer has a certain budget and free time in each season. Write a program that accepts the budget and the season and calculates where the programmer will go on vacation and how much he will spend from his budget.
The budget determines the destination, and the season determines how much of the budget he will spend. If it&#39;s summer, he&#39;ll be camping, in winter he is going to a hotel.
If he is in Asia, regardless of the season he will rest in a hotel. Each campsite or hotel, according to the destination, has its own price which corresponds to a given percentage of the budget:
* At 100lv. or less - somewhere in Bulgaria
    - Summer - 30% of the budget
    - Winter - 70% of the budget
* At 1000lv. Somewhere in Europe, somewhere in Europe.
    - Summer - 40% of the budget
    - Winter - 80% of the budget
* With more than 1000lv. Somewhere in Asia
    - On vacation in Asia, regardless of the season will spend 90% of the budget.

**Input:**
The function takes 2 parameters:
* First parameter - Budget, real number in the range [10.00...5000.00].
* Second parameter - One of two possible seasons: &quot;summer&quot; or &quot;winter&quot;

**Output:**
Two lines must be printed on the console.
* First line - &quot;Somewhere in [destination]&quot; among &quot;Bulgaria&quot;, &quot;Europe&quot; and &quot;Asia&quot;
* Second line - &quot;{Type of holiday} - {Amount spent}&quot;
The holiday can be at a &quot;Camp&quot; or &quot;Hotel&quot;. The sum must be rounded to the nearest second character after the comma.

**Sample input:**
Input |Output
---|---
f(50, &quot;summer&quot;) |Somewhere in Bulgaria
| |Camp - 15.00
f(75, &quot;winter&quot;) |Somewhere in Bulgaria
| |Hotel - 52.50
f(312, &quot;summer&quot;) |Somewhere in Europe
| |Camp - 124.80
f(678.53, &quot;winter&quot;) |Somewhere in Bulgaria
| |Hotel - 542.82
f(1500, &quot;summer&quot;) |Somewhere in Asia
| |Hotel - 1350.00

### 16. Makeup Shop

Write a program that calculates the profit from the order in a makeup shop.

**Makeup prices:**
* powder - 2.60 lv.
* lipstick - 3 lv.
* spiral - 4.10 lv.
* shadows - 8.20 lv.
* concealer - 2 lv.

If the ordered products count is 50 or more, the store makes a discount of 25% of the total price. Of the money earned, the shop must give 10% off the rent of the store. Find out if the money will be enough to do the renovation of the shop, needed to stay in business.

**Input**
You get 6 parameters:
* Price of the renovation - a real number in the range [1.00 ... 10000.00]
* Count of powders - integer in the range [0... 1000]
* Count of lipsticks - an integer in the range [0 ... 1000]
* Count of spirals - an integer in the range [0 ... 1000]
* Count of shadows - an integer in the range [0 ... 1000]
* Count of correctors - integer in the range [0 ... 1000]

**Output**
Print on the Console:
* If the money is enough, print:
    - &quot;Yes! {remaining money} BGN left.&quot;
* If the money is NOT enough, print:
    - &quot;Not enough money! {the lack of money} BGN needed.&quot;

The result must be formatted to two decimal places.

**Sample input:**
|Input |Output |explanation
---|---|---
f(40.8, 20, 25, 30, 50, 10) |Yes! 418.20 BGN left. |Amount: 20 * 2.60 + 25 * 3 + 30 * 4.10 + 50 * 8.20 + 10 * 2 = 680 BGN; Count of products: 20 + 25 + 30 + 50 + 10 = 135; 135 &gt; 50 =&gt; 25% discount; 25% of 680 = 170 BGN discount ; End price: 680 - 170 = 510 BGN. Rent: 10% from 510 BGN = 51; Profit: 510 - 51 = 459 BGN; 459 &gt; 40.8 =&gt; 459 - 40.8 = 418.20 BGN Remain 
f(320, 8, 2, 5, 5, 1)       |Not enough money! 238.73 BGN needed. |Total: 90.3 BGN; Makeup count: 21; 21 &lt; 50 =&gt; no discount; Rent: 10% from 90.3 = 9.03 BGN; Profit: 90.3 - 9.03 = 81.27 BGN; 81.27 &lt; 320 =&gt; 320 - 81.27 = 238.73 BGN

### 17. At sea

Calculate how much will cost a vacation. There are the following types of accommodation, with the following prices for staying:
* &quot;single room&quot; - 25.00 BGN per night
* &quot;apartment&quot; - 50.00 BGN per night
* &quot;presidential&quot; - 100.00 BGN per night

Regarding the number of days of the vacation (example: 11 days = 10 nights) and the type of room chosen, there is a different discount. The discounts are as follows:
room |under 10 days|between 10 and 15|over 15 days
---|---|---|---
**single room**|No discount |No discount |No discount
**apartment** |30% of the final price|35% of the final price|50% of the final price
**presidential**|10% of the final price|15% of the final price|20% of the final price

After the stay, the assessment of the hotel&#39;s services may be positive or negative.
* If the assessment is positive, add 25% to the price with the already deducted discount.
* If the assessment is negative, deduct 10% from the price.

**Input:**
You take 3 parameters:
* First - days to stay - integer in the range [0...365]
* Second - type of room - &quot;single room&quot;, &quot;apartment&quot; or &quot;president apartment&quot;
* Third - assessment - &quot;positive&quot; or &quot;negative&quot;

**Output:**
One line should be printed on the console:
* The price for the stay at the hotel, formatted to two decimal places.

**Sample input:**
Input |Output |explanation
---|---|---
f(11, &quot;apartment&quot;, &quot;positive&quot;) |264.06 |11 days =&gt; 10 nights =&gt; 10 * 50.00 = 500 BGN; discount for days =&gt; 500 - 175 = 325; Rating positive -&gt; 325 + 81.25; Total: 406.25
f(30, &quot;president apartment&quot;, &quot;negative&quot;) |2088.00|
f(12, &quot;single room&quot;, &quot;positive&quot;) |343.75|
f(2, &quot;apartment&quot;, &quot;positive&quot;) |43.75|

```
case  "apartment":
    totalPrice = (days - 1) * 50.00;
    if (days < 10) {
        totalPrice = totalPrice - totalPrice * 30 / 100;
    } else if (days <= 15) {
        totalPrice = totalPrice - totalPrice * 35 / 100;
    } else {
        totalPrice = totalPrice - totalPrice * 50 / 100;
    }
break;
```

### 18. Grade Calculator

Write a console program that takes a percentage score (0 to 100) as input and outputs the corresponding grade:
* A: 90-100%
* B: 80-89%
* C: 70-79%
* D: 60-69%
* F: 0-59%

Input |Output
---|---
95 |A
82 |B
76 |C
65 |D
45 |F

### 19. Leap Year Checker

Write a console program that takes a year as input and tells the user if it&#39;s a leap year or not.
**Note:** A leap year is divisible by 4. However, years divisible by 100 are not leap years, unless they are also divisible by 400.

Input |Output
---|---
2020 |It's a leap year!
1900 |It's not a leap year.
2000 |It's a leap year!
2023 |It's not a leap year.
1600 |It's a leap year!

### 20. Movie Ticket Price

Write a console program that determines the price of a movie ticket based on age:
* Child (0-12 years): $5
* Teen (13-19 years): $8
* Adult (20+ years): $10

Input |Output
---|---
10 |$5
16 |$8
25 |$10
13 |$8

### 21. Days in a Month

Write a console program that takes a month number (1 to 12) as input and outputs the number of days in that month. Assume it&#39;s not a leap year.

Input |Output
---|---
1 |31
2 |28
4 |30
7 |31

### 22. University Admissions

Write a console program to determine if a student is admitted to the university based on their score and extracurricular activities:
* Score &gt;= 90: Admitted regardless of extracurriculars.
* Score 80-89: Admitted if they have &gt;= 2 extracurriculars.
* Score &lt; 80: Not admitted.

Input |Output
---|---
85, 3 |Admitted
88, 1 |Not admitted
91, 0 |Admitted
75, 12 |Not admitted

### 23. Discount Calculator

Write a console program that calculates the discount a customer receives based on their age and if they have a membership card:
* Age &lt; 18: 10% discount.
* Age 18-64:
    - With membership: 20% discount.
    - Without membership: 10% discount.
* Age 65+: 30% discount.

Input |Output
---|---
20, &quot;Yes&quot; |20% discount
15, &quot;No&quot; |10% discount
70, &quot;No&quot; |30% discount

### 24. Movie Classification

Determine the movie category a person can watch based on their age:
* Age &lt; 13: Only U-rated movies.
* Age 13-17: U and PG-13 rated movies.
* Age 18+: All movies.

Input |Output
---|---
10 |U-rated movies
16 |U and PG-13 rated movies
21 |All movies

### 25. Airline Luggage Charges

Write a console program that calculates luggage charges based on weight and dimensions:
* If weight &gt; 50kg: $100 overweight fee.
* If the sum of all dimensions (length + width + height) &gt; 158cm:
    - If the sum exceeds by 1-20cm: $50 oversize fee.
    - If the sum exceeds by 21-50cm: $100 oversize fee.
    - If the sum exceeds by more than 50cm: $200 oversize fee.
* If both overweight and oversize: additional $50 handling fee.

Input |Output
---|---
52, 160 |$150 (Overweight + Slightly oversize)
48, 180 |$100 (Oversize)
55, 190 |$250 (Overweight + Oversize + Handling)

### 26. Adventure Game: Path Decision

You&#39;re designing a text-based adventure game. At a certain point, players have to choose a path based on the tools they have in right and left hand:
* If they have a &#39;sword&#39;:
    - If they also have a &#39;shield&#39;: Take the path to the castle.
    - Else: Take the path to the forest.
* If they have a &#39;map&#39;:
    - If they also have &#39;coins&#39;: Go to the town.
    - Else: Camp at the current spot and prepare for the next day.
* If they don&#39;t have any of these tools: Wander aimlessly.

Input |Output
---|---
&quot;sword&quot;, &quot;shield&quot; |Path to the castle
&quot;map&quot;, &quot;coins&quot; |Go to the town
&quot;torch&quot;, &quot;flower&quot; |Wander aimlessly
&quot;sword&quot;, &quot;pouch&quot; |Path to the forest
&quot;map&quot;, &quot;compass&quot; |Camp

### 27. Potion Brewing Decision

Players have 2 ingredients to brew potions. Decide which potion they can brew:
* If they have &#39;herbs&#39;:
    - If they also have &#39;water&#39;: Brew a health potion.
    - Else if they have &#39;oil&#39;: Brew a stealth potion.
    - Else: Brew a minor stamina potion.
* If they have &#39;berries&#39;:
    - If they also have &#39;sugar&#39;: Brew a speed potion.
    - Else: Brew a minor energy potion.
* Else: Can&#39;t brew any potion.

Input |Output
---|---
&quot;herbs&quot;, &quot;water&quot; |Health potion
&quot;herbs&quot;, &quot;oil&quot; |Stealth potion
&quot;herbs&quot;, &quot;banana&quot; |Minor stamina potion
&quot;berries&quot;, &quot;sugar&quot; |Speed potion
&quot;berries&quot;, &quot;banana&quot; |Minor energy potion
&quot;herbs&quot;, &quot;sugar&quot; |Minor stamina potion
&quot;sugar&quot;, &quot;salt&quot; |No potion

### 28. Survival in the Wilderness

Players need to decide on their course of action based on time of day, environment, and items:
* If it&#39;s &#39;day&#39;:
    - If they&#39;re in a &#39;forest&#39;:
* If they have &#39;knife&#39;: Hunt for food.
* Else if they have &#39;container&#39;: Collect berries.
* Else: Explore.
    - If they&#39;re in a &#39;desert&#39;:
* If they have &#39;hat&#39;: Search for water.
* Else: Find shade.
* If it&#39;s &#39;night&#39;:
    - If they&#39;re in a &#39;forest&#39;:
* If they have &#39;firestarter&#39;: Make a campfire.
* Else: Climb a tree for safety.
    - If they&#39;re in a &#39;desert&#39;:
* If they have &#39;blanket&#39;: Sleep.
* Else: Keep moving to stay warm.

Input |Output
---|---
&quot;day&quot;, &quot;forest&quot;, &quot;knife&quot; |Hunt for food
&quot;day&quot;, &quot;forest&quot;, &quot;container&quot; |Collect berries
&quot;night&quot;, &quot;forest&quot;, &quot;firestarter&quot; |Make a campfire
&quot;day&quot;, &quot;forest&quot;, &quot;bag&quot; |Explore
&quot;night&quot;, &quot;desert&quot;, &quot;blanket&quot; |Sleep
&quot;day&quot;, &quot;desert&quot;, &quot;hat&quot; |Search for water
&quot;night&quot;, &quot;desert&quot;, &quot;sword&quot; |Keep moving to stay warm
&quot;night&quot;, &quot;forest&quot;, &quot;hat&quot; |Climb on a tree

### 29. Climate Zone Identifier

Different areas on Earth have specific climate zones based on latitude. The first line contains a latitude value (between -90 and 90). The second line contains either &quot;N&quot; for Northern Hemisphere or &quot;S&quot; for Southern Hemisphere. The application should identify the climate zone.
* Arctic Zone: greater than 66.5° (N/S)
* Temperate Zone: between 23.5° and 66.5° (N/S)
* Tropic Zone: between 0° and 23.5° (N/S)
* Equator: exactly 0°

Input |Output
---|---
70, &quot;N&quot; |Arctic Zone
45, &quot;S&quot; |Temperate Zone
10, &quot;N&quot; |Tropic Zone
0, &quot;N&quot; |Equator
-85, &quot;S&quot; |Arctic Zone

### 30. Architectural Era Identifier

Different eras in history had specific architectural styles. The first line contains the year a building was constructed. The second line contains the primary material used in the building (&quot;wood&quot;, &quot;stone&quot;, or &quot;steel&quot;). The application should attempt to guess the architectural era.
* Ancient: year &lt; 500 and material = &quot;stone&quot;
* Medieval: year between 500 and 1500 and material = &quot;stone&quot;
* Colonial: year between 1500 and 1800 and material = &quot;wood&quot;
* Industrial: year between 1800 and 1900 and material = &quot;steel&quot;
* Modern: year &gt; 1900 and material = &quot;steel&quot;
* Uncertain: Any other combinations

Input |Output
---|---
300, &quot;stone&quot; |Ancient
1500, &quot;wood&quot; |Colonial
1500, &quot;stone&quot; |Medieval
2000, &quot;steel&quot; |Modern
1100, &quot;wood&quot; |Uncertain