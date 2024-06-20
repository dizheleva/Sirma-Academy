function solve (figure, a, b) {
    let area = 0;

    switch (figure) {        
        case "square":
            area = a * a;        
            break;                 
        case "rectangle":
            area = a * b;       
            break;
        case "triangle":
            area = a * b / 2;        
            break;
        case "circle":
            area = Math.PI * a * a;        
            break; 
    }
    
    console.log(area.toFixed(2)); 
}

solve("square", 5);
solve("rectangle", 10, 3.5);
solve("triangle", 4.5, 20);
solve("circle", 10);