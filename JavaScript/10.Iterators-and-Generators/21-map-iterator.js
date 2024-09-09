function solve(map) {

    map[Symbol.iterator] = function () {
        let values = Object.values(this);
        let keys = Object.keys(this);
        let pairs = [];
        for (let i = 0; i < keys.length; i++) {
            const element = keys[i] + '-' + values[i];
            pairs.push(element);
        }
        let index = 0;

        return {
            next() {
                return {
                    value: pairs[index++],
                    done: index > pairs.length,
                };
            }
        }
    }

    let result = [];

    for (const value of map) {
        result.push(value);
    }

    console.log(result.join(', '));
}

solve({1:'a', 2:'b', 3:'c'});
solve({a:1, b:2, c:3});
solve({x:'apple', y:'banana', z:'cherry'});