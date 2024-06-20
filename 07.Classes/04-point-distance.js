class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    static distance(pointA, pointB) {
        const xDistance = Math.abs(pointA.x - pointB.x);
        const yDistance = Math.abs(pointA.y - pointB.y);
        
        const result = Math.sqrt(xDistance ** 2 + yDistance ** 2);

        return result;
    }
}

let p1 = new Point(5, 5);
let p2 = new Point(9, 8);
console.log(Point.distance(p1, p2));