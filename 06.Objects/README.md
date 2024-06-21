# Objects - Exercises

### 1. Person Data

Write a function that takes 3 parameters (name, surname and age) and returns an object.

Input |Output
---|---
&quot;Ivan&quot;,&quot;Ivanov&quot;, 29 |{
||firstName: &quot;Ivan&quot;,
||lastName: &quot;Ivanov&quot;,
||age: 20
||}
&quot;Maria&quot;, &quot;Marinova&quot;, 13 |{
||firstName: &quot;Maria&quot;,
||lastName: &quot;Marinova&quot;,
||age: 13
||}

### 2. Town

Create a function that accepts an object, traverses it, and prints all properties and values 
Input |Output
---|---
{ name: &quot;Sofia&quot;, population: 1234567, country: &quot;Bulgaria&quot;, postcode: &quot;1000&quot; } |name -&gt; Sofia
||population -&gt; 1234567
||country -&gt; Bulgaria
||postcode -&gt; 1000

### 3. Convert to Object

Write a function that accepts text in JSON format and converts it to an object. Print all values in the following format: {key}: {value}

Input |Output
---|---
&#39;{&quot;name&quot;: &quot;Ivan&quot;, &quot;age&quot;: 40, &quot;town&quot;: &quot;Sofia&quot;}&#39; |name: Ivan
||age: 40
||town: Sofia
&#39;{&quot;firstName&quot;: &quot;Ivan&quot;, &quot;lastName&quot;: &quot;Ivanov&quot;}&#39; |firstName: Ivan
||lastName: Ivanov

### 4. Convert to JSON

Write a function that gets a name, surname, and eye color and saves them in an object.
The created object must be converted to JSON and printed.

Input |Output
---|---
&quot;Ivan&quot;, &quot;Ivanov&quot;, &quot;blue&quot; |&#39;{&quot;name&quot;: &quot;Ivan&quot;, &quot;lastName&quot;: &quot;Ivanov&quot;, &quot;eyeColor&quot;: &quot;blue&quot;}&#39;
&quot;Maria&quot;, &quot;Petrova&quot;, &quot;brown&quot; |&#39;{&quot;name&quot;: &quot;Maria&quot;, &quot;lastName&quot;: &quot;Petrova&quot;, &quot;eyeColor&quot;: &quot;brown&quot;}&#39;

### 5. Phonebook

Write a function that accepts an array of names and phone numbers. Write down all the names in the phone book. If you get an existing name, replace the number with the new one.

Input |Output
---|---
[&quot;Peter 0888 657 212&quot;, &quot;Bob 0899 657 212&quot;, &quot;Peter 123123&quot;] |Peter -&gt; 123123
||Bob -&gt; 0899 657 212
[&quot;Maria 123&quot;, &quot;Samantha 456&quot;, &quot;Nicole 789&quot;] |Maria -&gt; 123
||Samantha -&gt; 456
||Nicole -&gt; 789

### 6. Movies

Write a function that stores information about movies inside an array. The movie&#39;s object have name, director, and date. You can receive several commands:
* &quot;addMovie {movie name}&quot; - adds a movie
* &quot;{movie name} directedBy {director}&quot; - checks if the movie exists and then adds the director
* &quot;{movie name} onDate {date}&quot; - checks if the movie exists and adds date

Print only the movies that have full info (director, name and date) in JSON format.

Input |Output
---|---
[&#39;addMovie Fast and Furious&#39;, &#39;addMovie Godfather&#39;, &#39;Inception directedBy Christopher Nolan&#39;, &#39;Godfather directedBy Francis Ford Coppola&#39;, &#39;Godfather onDate 29.07.2018&#39;, &#39;Fast and Furious onDate 30.07.2018&#39;, &#39; Spinderman 2 onDate 01.08.2018&#39;, &#39;Fast and Furious directedBy Rob Cohen&#39;] |{&quot;name&quot;:&quot;Fast and Furious&quot;,&quot;date&quot;:&quot;30.07.2018&quot;,&quot;director &quot;:&quot;Rob Cohen&quot;}
||{&quot;name&quot;:&quot;Godfather&quot;,&quot;director&quot;:&quot;Franc is Ford Coppola&quot;,&quot;date&quot;:&quot;29.07.2018&quot;}
[&#39;addMovie The Avengers&#39;, &#39;addMovie Spiderman&#39;, &#39;The Avengers directedBy Pesho Peshov&#39;, &#39;The Avengers onDate 30.07.2010&#39;, &#39;Captain America onDate 30.07.2010&#39;, &#39;Captain America directedBy Joe Russo&#39;, &#39;The Avengers directedBy Anthony Russo&#39;,] |{&quot;name&quot;:&quot;The Avengers&quot;,&quot;director&quot;:&quot;Anthony Russo&quot;,&quot;date&quot;:&quot;30.07.2010&quot;}