# String Processing - Exercises

### 1. Print Characters

Write a function that receives a string and prints all the characters on separate lines.
Input |Output
---|---
&#39;AWord&#39; |A
||W
||o
||r
||d
&#39;Sentence&#39; |S
||e
||n
||t
||e
||n
||c
||e

### 2. Substring

Write a function that receives a string and two numbers. The numbers will be a starting index and count of elements to substring. Print the result.
Input |Output
---|---
&#39;ESentence&#39;, 1, 8 |Sentence
&#39;DropWord&#39;, 4, 7 |Word

### 3. Censor

Write a function that receives a text as a first parameter and a single word as a second. Find all occurrences of that word in the text and replace them with the corresponding count of &#39;*&#39;.
The repeat() function should take the length of the word and return that amount of stars &#39;*&#39;.

Input |Output
---|---
&#39;A small sentence with some words&#39;, &#39;small&#39; |A ***** sentence with some words
&#39;Find the hidden word&#39;, &#39;hidden&#39; |Find the ****** word
&#39;A small sentence with small words&#39;, &#39;small&#39; |A ***** sentence with ***** words

### 4. Reveal Words

Write a function, which receives two parameters.
The first parameter will be a string with some words separated by &#39;, &#39;.
The second parameter will be a string that contains templates containing &#39;*&#39;.
Find the word with the same length as the template and replace it.
Input |Output
---|---
&#39;great&#39;, &#39;JavaScript* is ***** programming language&#39; |JavaScript* is great programming language
&#39;the, best, learn&#39;, &#39;JavaScript is *** **** language to *****&#39; |JavaScript is the best language to learn

### 5. #HashTag

Receive a single string. Find all special words starting with #. If the found special word does not consist only of letters, then it is invalid and should not be printed.
Finally, print out all the hashtags you found without the label (#) on a new line.

Input |Output
---|---
&#39;Everyone uses # to tag a #special word in #facebook&#39; |special
||facebook
&#39;The symbol # is known #variously in English-speaking #regions as the #number sign&#39; |variously
||regions
||number

### 6. Extract File

Write a function that receives a single string - the path to a file (the &#39;\&#39; character is escaped)
Your task is to subtract the file name and its extension. (Beware of files like template.error.pptx, as template.error should be the file name, while pptx is the extension).
Input |Output
---|---
&#39;C:\\desktop\\academy\\template.pptx&#39; |File name: template
||File extension: pptx
&#39;C:\\Projects\\website.folder\\file.name.js&#39; |File name: file.name
||File extension: js

### 7. Substring

The input will be given as two separate strings (a word as a first parameter and a text as a second).
Write a function that checks the text for the given word. The comparison should be case insensitive. Once you find a match, print the word.
If you don&#39;t find the word print: &quot;{word} not found!&quot;
Input |Output
---|---
&#39;javascript&#39;, &#39;JavaScript is the best programming language&#39; |javascript
&#39;python&#39;, &#39;JavaScript is the best programming language&#39; |python not found!

### 8. Replace Repeating Symbols

Write a function that receives a single string and replace any sequence of the same symbols with a single corresponding letter.
Input |Output
---|---
&#39;aaaaabbbbbcdddeeeedssaa&#39; |abcdedsa
&#39;qqqwerqwecccwd&#39; |qwerqwecwd

### 9. Pascal-Case Splitter

You will receive a single string.
This string is written in PascalCase format. Your task here is to split this string by every word in it.
Print them joined by comma and space.
Input |Output
---|---
&#39;SplitMeIfYouCan&#39; |Split, Me, If, You, Can
&#39;HoldTheDoor&#39; |Hodor
&#39;ThisIsSoAnnoying&#39; |This, Is, So, Annoying

### 10. Cut and Reverse

Write a function that cuts the given string into half and reverses the two halves.
Print each half on a separate line.
Input |Output
---|---
&#39;tluciffiDsIsihTgnizamAoSsIsihT&#39; |ThisIsDifficult
||ThisIsSoAmazing
&#39;sihToDtnaCuoYteBIboJsihTtAdooGoSmI&#39; |IBetYouCantDoThis
||ImSoGoodAtThisJob

### 11. Letter

You will receive an array, which holds the string and another array.
The string is a letter which has a few holes, you must fill with strings from the array you receive at the second index.

If the length of the hole is 4 you must replace it with string with the same length and so on...

**Examples:**

**Input**
```
'Hi, grandma! I\'m so ____ to write to you. ______ the winter vacation,
so many _______ things happened. My dad bought me a sled. Mom
started a new job as a __________. My brother\'s ankle is ________, and
now it bothers me even more. Every night Mom cooks ___ on your recipe
because it is the most delicious. I hope this year Santa will _____ me a
robot.',
['pie', 'bring', 'glad', 'During', 'amazing', 'pharmacist', 'sprained']
```
**Output**
```
Hi, grandma! I'm so glad to write to you. During the winter vacation, so
many amazing things happened. My dad bought me a sled. Mom started a
new job as a pharmacist. My brother's ankle is sprained, and now it
bothers me even more. Every night Mom cooks pie on your recipe because
it is the most delicious. I hope this year Santa will bring me a robot.
```

### 12. Match Full Name

Write a JavaScript function to match full names from a list of names and print them on the console.

||
|---|
**Input:** 
&quot;Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov&quot;
**Output:** 
Ivan Ivanov, Test Testov

### 13. Match Phone Number

Write a regular expression to match a valid phone number from Sofia. After you find all valid phones, print them on the console, separated by a comma and a space &quot;, &quot;.

Compose the Regular Expression

A valid number has the following characteristics:
* It starts with &quot;+359&quot;
* Then, it is followed by the area code (always 2)
* After that, it's followed by the number itself:
    - The number consists of 7 digits (separated into two groups of 3 and 4 digits respectively).
* The different parts are separated by either a space or a hyphen (&#39;-&#39;).

You can use the following RegEx properties to help with the matching:
* Use quantifiers to match a specific number of digits
* Use a capturing group to make sure the delimiter is only one of the allowed characters (space or hyphen) and not a combination of both (e.g. +359 2-111 111 has mixed delimiters, it is invalid). Use a group backreference to achieve this.
* Add a word boundary at the end of the match to avoid partial matches
* Ensure that before the &#39;+&#39; sign there is either a space or the beginning of the string.

||
|---|
**Input**
[&#39;+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222
+359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222&#39;]
**Output**
+359 2 222 2222, +359-2-222-2222
||
**Input**
[&#39;+359 2 357 3351 +359 2 22 2222 +359 2 173 3408 +359-2-789-2584 +359 2
193 3953 +359-2-961-0248 +359-2-789-2584 +359 2 222 222 +360 2 222
2222 +359 2 727 9740 +359-2-854-2280 +359 2 193 3953 +359 2 357 3351
+359 2 558 8560 +359 2 222 222&#39;]
**Output**
+359 2 357 3351, +359 2 173 3408, +359-2-789-2584, +359 2 193 3953,
+359-2-961-0248, +359-2-789-2584, +359 2 727 9740, +359-2-854-2280,
+359 2 193 3953, +359 2 357 3351, +359 2 558 8560

### 14. Match Dates

Write a program, which matches a date in the format &quot;dd{separator}MMM{separator}yyyy&quot;.
Every valid date has the following characteristics:
* Always starts with two digits, followed by a separator
* After that, it has one uppercase and two lowercase letters (e.g. Jan, Mar).
* After that, it has a separator and exactly 4 digits (for the year).
* The separator could be either of three things: a period (&quot;.&quot;), a hyphen (&quot;-&quot;) or a forward-slash (&quot;/&quot;)
* The separator needs to be the same for the whole date (e.g. 13.03.2016 is valid, 13.03/2016 is NOT).

||
|---|
|**Input**|
[&#39;13/Jul/1928, 10-Nov-1934, 01/Jan-1951, 25.Dec.1937, 23#09#1973, 1/Feb/2016&#39;]
|**Output**|
Day: 13, Month: Jul, Year: 1928
Day: 10, Month: Nov, Year: 1934
Day: 25, Month: Dec, Year: 1937
||
|**Input**|
[&#39;1/Jan-1951 23/October/197 11-Dec-2010 18.Jan.2014&#39;]
|**Output**|
Day: 11, Month: Dec, Year: 2010
Day: 18, Month: Jan, Year: 2014

### 15. Star Battles Enigma

The war is at its peak, but you, young Padawan, can turn the tides with your programming skills. You are tasked to create a program to decrypt the messages of The Order and prevent the death of hundreds of innocents.

You will receive several messages, which are encrypted using the legendary star enigma.

You should decrypt the messages, following these rules:

To properly decrypt a message, you should count all the letters [s, t, a, r] - case insensitive and remove the count from the current ASCII value of each symbol of the encrypted message.

After decryption:

Each message should have a planet name, population, attack type (&#39;A&#39;, as an attack or &#39;D&#39;, as destruction), and soldier count.

The planet name starts after &#39;@&#39; and contains only letters from the Latin alphabet.

The planet population starts after &#39;:&#39; and is an Integer;

The attack type may be &quot;A&quot;(attack) or &quot;D&quot;(destruction) and must be surrounded by &quot;!&quot; (exclamation mark (lightsaber)).

The soldier count starts after &quot;-&gt;&quot; and should be an Integer.

The order in the message should be: planet name -&gt; planet population -&gt; attack type -&gt; soldier count. Each part can be separated from the others by any character except: &#39;@&#39;, &#39;-&#39;, &#39;!&#39;, &#39;:&#39; and &#39;&gt;&#39;. 

After decrypting all messages, you should print the decrypted information in the following format:

First print the attacked planets, then the destroyed planets.

```
Attacked planets: {attackedPlanetsCount}
-> {planetName}
Destroyed planets: {destroyedPlanetsCount}
-> {planetName}
```

Input |Output |Comments
---|---|---
[&#39;STCDoghudd4=53333$D$0A53333&#39;, &#39;EHfsytsnhf?8555&amp;I&amp;2C95 55SR&#39;] |Attacked planets: 1|We receive two messages, to decrypt them we calculate the key: The first message has decryption key 3. we subtract from each character's code 3. PQ@Alderaa1:20000!A!-&gt;20000 The second message has key 5. @Cantonica:3000!D!-&gt;4000NM Both messages are valid
||-&gt; Alderaa|
||Destroyed planets: 1|
||-&gt; Cantonica|

Input |Output
---|---
[&quot;tt(&#39;&#39;DGsvywgerx&gt;6444444444%H%1B9444&quot;, &#39;GQhrr\|A977777(H(TTTT&#39;, &#39;EHfsytsnhf?8555&amp;I&amp;2C9555SR&#39;] |Attacked planets: 0
||Destroyed planets: 2
||-&gt; Coruscant
||-&gt; Cantonica