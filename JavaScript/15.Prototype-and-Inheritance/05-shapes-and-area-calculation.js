class Shape {
    calculateArea() { }
}

class Circle extends Shape {
    constructor(radius) {
        super();
        this.radius = radius;
    }

    calculateArea() {
        return Math.PI * this.radius * this.radius;
    }
}

class Square extends Shape {
    constructor(side) {
        super();
        this.side = side;
    }

    calculateArea() {
        return this.side * this.side;
    }
}

class Triangle extends Shape {
    constructor(side, height) {
        super();
        this.side = side;
        this.height = height;
    }

    calculateArea() {
        return (this.side * this.height) / 2;
    }
}

const circle = new Circle(7);
console.log(`Circle area: ${circle.calculateArea()}`);
const square = new Square(7);
console.log(`Square area: ${square.calculateArea()}`);
const triangle = new Triangle(7, 5);
console.log(`Triangle area: ${triangle.calculateArea()}`);