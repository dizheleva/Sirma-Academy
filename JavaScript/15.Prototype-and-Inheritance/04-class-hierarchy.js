function showHierarchy() {
    class Figure {
        constructor(units = 'cm') {
            this.units = units;
        }

        get area() { }

        changeUnits(value) {
            this.units = value;
        }

        toString() {
            return `Area: ${this.area.toFixed(2)} ${this.units}.`;
        }
    }

    class Circle extends Figure {
        constructor(radius, units) {
            super(units);
            this.radius = radius;
        }

        get area() {
            return Math.PI * this.radius * this.radius;
        }

        toString() {
            return `A circle with radius: ${this.radius} ${this.units}\n --> ${super.toString()}`;
        }
    }

    class Rectangle extends Figure {
        constructor(width, height, units) {
            super(units);
            this.width = width;
            this.height = height;
        }

        get area() {
            return this.width * this.height;
        }

        toString() {
            return `A rectange with width: ${this.width} ${this.units}, height: ${this.height} ${this.units}\n --> ${super.toString()}`;
        }
    }

    // const circle = new Circle(7);
    // console.log(circle.toString());

    // const rectangle = new Rectangle(8, 9);
    // rectangle.units = 'm';
    // console.log(rectangle.toString());

    return { Figure, Circle, Rectangle };
}

showHierarchy();