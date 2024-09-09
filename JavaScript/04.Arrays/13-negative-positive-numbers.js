function solve(arr) {
    let outputArr = [];
 
    for (const number of arr) {
        if (number < 0) {
            outputArr.unshift(number);
          } else {
            outputArr.push(number);
          }
    }
  
    for (const currentElement of outputArr) {
        console.log(currentElement);
    }
}
 
solve([7, -2, 8, 9]);
solve([3, -2, 0, -1]);