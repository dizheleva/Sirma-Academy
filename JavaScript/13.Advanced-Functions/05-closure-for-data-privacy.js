function solve() {
    function createPrivateCounter() {
        let count = 0;
    
        return {
            getCount() { return count; },
            increment() { count++; }
        }
    } 

    const counter = createPrivateCounter();
    counter.increment();
    console.log(counter.getCount());
}

solve();