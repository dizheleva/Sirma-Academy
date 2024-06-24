# CSS Selectors - Exercises 

### 1. Type Selector

Define a CSS rule to style all paragraph elements to have blue text and bold font weight.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Type Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <p>This is a paragraph.</p>
    <p>Style me with CSS!</p>
</body>
</html>
```

```
p {
    /* Write your rule here */
}
```

Define a type selector to style all heading elements to have green text.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Type Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <h1>This is a heading.</h1>
    <h2>This is a subheading.</h2>
</body>
</html>
```

```
h1, h2 {

}
```

Style different HTML elements (h1, p, div) using type selectors.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Type Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <h1>Heading 1</h1>
    <p>Paragraph text.</p>
    <div>Div content.</div>
</body>
</html>
```

```
h1 {
}
p {
}
div {
}
```

### 2. Class Selector

Use a class selector to change the color of text inside elements with a specific class to red.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Class Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="highlight">This text should be red.</div>
    <p class="highlight">This text should also be red.</p>
    <p class="not-highlight">This should not be red.</p>
    <p>This text should not be red.</p>
</body>
</html>
```
```
.highlight {
}
```

Write an example CSS rule using a class selector to change the background color of elements with a specific class.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Class Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="highlight">This should have a background color.</div>
    <p class="highlight">This too!</p>
    <p class="red">This is just a text!</p>
</body>
</html>
```

Apply a common style to multiple elements using a class selector.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Class Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="common-style">Element 1</div>
    <p class="common-style">Element 2</p>
    <p>Element 3</p>
</body>
</html>
```
```
.common-style {
}
```

Change the background color of elements with a specific class.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Class Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="highlight">This should have a different background color.</div>
    <p class="highlight">So should this!</p>
    <p>Hello World!</p>
</body>
</html>
```
```
.highlight {
}
```

### 3. Percentage Width

Set the width of a div to 50% and observe how it changes with the browser window size.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Percentage Width Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="percentage-width">Resize the window to see me change!</div>
</body>
</html>
```
```
.percentage-width {
}
```

### 4. Nested Divs

Create a parent div with 60% width and a child div with 50% width of its parent. Apply some colors to better see the difference.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Nested Divs Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="parent">
        <div class="child">I'm 50% of my parent.</div>
    </div>
</body>
</html>
```

### 5. Pixel Width

Set the width of a div to 300px and observe its behavior when resizing the browser.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pixel Width Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="fixed-width">I have a fixed width of 300px.</div>
</body>
</html>
```
```
.fixed-width {
    /* Set width to 300px */
}
```

### 6. Pixel vs Percentage Width

Create two divs, one with a width set in pixels and the other in percentages.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pixel vs Percentage Width Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="pixel-width">I have a fixed width of 300px.</div>
    <div class="percentage-width">I have a width of 50%.</div>
</body>
</html>
```
```
.pixel-width {
    /* Set width to 300px */
}
.percentage-width {
    /* Set width to 50% */
}
```

### 7. EM Units

Set the font-size of a parent div to 20px and a child div to 1.5em.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>EM Units Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="parent">
        <div class="child">I am 1.5em of my parent.</div>
    </div>
</body>
</html>
```
```
.parent {
    /* Set font-size to 20px */
}
.child {
    /* Set font-size to 1.5em */
}
```

Change the parent div&#39;s font-size to 10px and observe the change in the child div&#39;s font-size.

```
.parent {
    /* Set font-size to 10px */
}
.child {
    /* Set font-size to 1.5em */
}
```

### 8. REM Units

Set the root element&#39;s font-size to 16px and a div element&#39;s font-size to 2rem.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>REM Units Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="rem-size">I am 2rem.</div>
</body>
</html>
```
```
html {
    /* Set font-size to 16px */
}
.rem-size {
    /* Set font-size to 2rem */
}
```

Change the root element&#39;s font-size to 20px and observe the change in the div element&#39;s font-size.

### 9. Specificity

Use a class and a type selector on the same element and see which style is applied.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Specificity Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <p class="highlight">This is a paragraph.</p>
</body>
</html>
```
```
p {
    /* Style for type selector */
}
.highlight {
    /* Style for class selector */
}
```

Apply both a class and an ID selector to the same element and see which style takes precedence.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Specificity Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <p id="unique" class="highlight">This is a paragraph.</p>
</body>
</html>
```
```
#unique {
    /* Style for ID selector */
}
.highlight {
    /* Style for class selector */
}
```

### 10. ID Selector

Style elements with unique IDs.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ID Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div id="unique-element">Unique Element</div>
    <div>Element</div>
</body>
</html>
```

### 11. Attribute Selector

Style input elements based on their type attribute.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Attribute Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <input type="text" placeholder="Text input">
    <input type="submit" value="Submit">
</body>
</html>
```
```
input[type="text"] {
    /* Style for text input */
}
input[type="submit"] {
    /* Style for submit input */
}
```

Change the text color of links with a specific href attribute.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Attribute Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <a href="https://example.com">Example Link</a>
    <a href="https://another.com">Another Link</a>
</body>
</html>
```
```
a[href="https://example.com"] {
}
```

### 12. Universal Selector

Use the universal selector to set a default margin and padding for all elements.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Universal Selector Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div>Content with default margin and padding.</div>
</body>
</html>
```
```
* {
}
```

Use the universal selector to set a default font-family and color for all elements.

### 13. Descendant Combinator

Style nested elements using a descendant combinator.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Descendant Combinator Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div>
        <p>Descendant of div</p>
    </div>
</body>
</html>
```
```
div p {
}
```

### 14. Combinator Comparison

Compare descendant combinator and child combinator.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Combinator Comparison Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div>
        <p>Descendant of div</p>
        <div>
            <p>Child</p>
        </div>
    </div>
</body>
</html>
```
```
div p {
    /* Style for descendant combinator */
}
div > p {
    /* Style for child combinator */
}
```

### 15. Selector List

Use a selector list to apply the same style to multiple elements.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Selector List Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <h1>Heading</h1>
    <p>Paragraph</p>
    <div>Div content</div>
</body>
</html>
```
```
h1, p, div {
}
```

Style both paragraph and heading elements using a selector list.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Selector List Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <h1>Heading</h1>
    <p>Paragraph</p>
</body>
</html>
```

### 16. Child Combinator

Use a child combinator to style direct children of a div element.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Child Combinator Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div>
        <p>Direct child of div</p>
        <div>
            <p>Nested child</p>
        </div>
    </div>
</body>
</html>
```
```
div > p {
}
```

Use a child combinator to style direct children of a specific class.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Child Combinator Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="parent">
        <p>Direct child of .parent</p>
        <div>
            <p>Nested child of .parent</p>
        </div>
    </div>
</body>
</html>
```
```
.parent > p {
}
```

### 17. Box Model

Use CSS to demonstrate the box model by setting margin, border, padding, and content area values.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Box Model Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="box">Box Model Example</div>
</body>
</html>
```
```
.box {
    /* margin, border, padding, and content area */
}
```

Calculate the total width of an element with specific width, padding, border, and margin values.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Box Model Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="box">Calculate my total width</div>
</body>
</html>
```
```
.box {
    width: 200px;
    padding: 20px;
    border: 5px solid black;
    margin: 10px;
}
```

### 18. Display Property

Set different display properties (block, inline, inline-block) for elements.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Display Property Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="block">Block element</div>
    <span class="inline">Inline element</span>
    <div class="inline-block">Inline-block element</div>
</body>
</html>
```
```
.block {
}
.inline {
}
.inline-block {
}
```

### 19. Width Properties

Set the width, min-width, and max-width of a div element.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Width Properties Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="width-example">Resize the window to see me change!</div>
</body>
</html>
```
```
.width-example {
    /* Set width, min-width, and max-width */
}
```

### 20. Height Properties

Set the height, min-height, and max-height of a div element.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Height Properties Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="height-example">Resize the window to see me change!</div>
</body>
</html>
```
```
.height-example {
}
```

### 21. Margin, Border, Padding
Set different margin, border, and padding values for a div element.
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Margin, Border, Padding Exercise</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="box-model">Box Model Example</div>
</body>
</html>
```
```
.box-model {
}
```