# DOM - Exercise

### 1. Modify the style of the paragraph text through javascript code.

**Starter code**
```
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>JS DOM paragraph style</title>
</head>

<body>
    <p id="text">JavaScript Exercises</p>
    <div>
        <button onclick="restyle()">Style</button>
    </div>
</body>

</html>
```
Clicking on the button the font, font size, and color of the paragraph text will be changed.

### 2. Write a JavaScript function to get the values of First and Last names of the following form.

**Starter code**
```
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>Return first and last name from a form</title>
</head>

<body>
    <form id="form1" onsubmit="getFormvalue()">
        First name: <input type="text" name="fname" value="David"><br>
        Last name: <input type="text" name="lname" value="Beckham"><br>
        <input type="submit" value="Submit">
    </form>

</body>

</html>
```

### 3. Write a JavaScript program to set paragraph background color.

### 4. Write a JavaScript function to get the value of the href, hreflang, rel, target, and type attributes of the specified link.

```
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
</head>

<body>
    <p>
        <a id="someId" type="text/html" hreflang="bg-bg" rel="nofollow" target="_blank" href="#">resources</a>
    </p>
    <button onclick="getAttributes()">Click here to get attributes value</button>
</body>

</html>
```

### 5. Write a JavaScript function to add rows to a table.

```
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>Insert row in a table</title>
</head>

<body>
    <table id="sampleTable" border="1">
        <tr>
            <td>Row1 cell1</td>
            <td>Row1 cell2</td>
        </tr>
        <tr>
            <td>Row2 cell1</td>
            <td>Row2 cell2</td>
        </tr>
    </table>
    <br>
    <input type="button" onclick="insertRow()" value="Insert row">
</body>

</html>
```

### 6. Write a JavaScript function that accepts a row, column (to identify a particular cell) and a string to update the cell's contents.

```
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>Change the content of a cell</title>
</head>

<body>
    <table id="myTable" border="1">
        <tr>
            <td>Row1 cell1</td>
            <td>Row1 cell2</td>
        </tr>
        <tr>
            <td>Row2 cell1</td>
            <td>Row2 cell2</td>
        </tr>
        <tr>
            <td>Row3 cell1</td>
            <td>Row3 cell2</td>
        </tr>
    </table>
    <form>
        <input type="button" onclick="changeContent()" value="Change content">
    </form>
</body>

</html>

```

### 7. Write a JavaScript function to create a table, accept row and column numbers, and input row-column numbers as cell content (e.g. Row-0 Column-0).

```
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>Change the content of a cell</title>
    <style type="text/css">
        body {
            margin: 30px;
        }
    </style>
</head>

<body>
    <table id="myTable" border="1">
    </table>
    <form>
        <input type="button" onclick="createTable()" value="Create the table">
    </form>
</body>

</html>
```

### 8. Write a JavaScript program to remove items from a drop-down list.

```
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>Remove items from a dropdown list</title>
</head>

<body>
    <form>
        <select id="colorSelect">
            <option>Red</option>
            <option>Green</option>
            <option>White</option>
            <option>Black</option>
        </select>
        <input type="button" onclick="removecolor()" value="Select and Remove">
    </form>
</body>

</html>
```

### 9. Write a JavaScript program to count and display dropdown list items in an alert window.

```
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <style type="text/css">
        body {
            margin: 30px;
        }
    </style>
    <title>Count and display items of a dropdown list</title>
</head>

<body>
    <form>
        Select your favorite Color: 
        <select id="mySelect">
            <option>Red</option>
            <option>Green</option>
            <option>Blue</option>
            <option>White</option>
        </select>
        <input type="button" onclick="getOptions()" value="Count and Output all items">
    </form>
</body>

</html>
```

### 10. Write a JavaScript program to calculate sphere volume.

![Task Illustration](https://github.com/dizheleva/Sirma-Academy/blob/main/19.DOM-Manipulations/assets/task10.png "task 10")

### 11. Write a JavaScript program to highlight the bold words of the following paragraph, on mouse over the link.
__link__

**We** have just started **this** section for the users (beginner to intermediate) who **want** to
work with **various** JavaScript **problems** and write scripts online to **test** their
JavaScript **skill**.

### 12. Write a JavaScript program to get the window width and height (any time the window is resized).

### 13.

### 14. You are building a web page that displays a list of items. The user should be able to add new items to the list and edit the text of the items. Your task is to use the DOM API to create the necessary elements, add event listeners to them, and manipulate the elements as the user interacts with the page.

![Task Illustration](https://github.com/dizheleva/Sirma-Academy/blob/main/19.DOM-Manipulations/assets/task14.png "task 14")

```
<div id="list-app">
    <p>Click on the item to change the text, or click on the button to create a new item.</p>
    <ul id="items">

    </ul>
    <input type="text" value="">
    <button type="button">Create New</button>
</div>
```