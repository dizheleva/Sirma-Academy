function solve() {
    const obj1 = {
        name: 'Alice',
        greet: function () {
            console.log(`Hello, my name is ${this.name}`);
        }
    };
    
    const obj2 = {
        name: 'Bob'
    };
    
    const obj2GreetBinding = obj1.greet.bind(obj2);
    obj2GreetBinding();
}

solve();