function findLongestWord(arr) {
    const senteseSigns = ',.?;:!"';
    let longest = '';
    
    for (const word of arr) {
        let counter = 0;
        for (const character of word) {
            if (!senteseSigns.includes(character)) {
                counter++;
            }
        }

        if (counter > longest.length) {
            longest = word;
        }
    }

    return longest;
}

function findShortestWord(arr) {
    const senteseSigns = ',.?;:!"';
    let shortest = arr[0];    
    
    for (const word of arr) {  
        let counter = 0;      
        for (const character of word) {            

            if (!senteseSigns.includes(character)) {
                counter++;
            }
        }

        if (counter < shortest.length) {
            shortest = word;            
        }
    }

    return shortest;
}

function printShortestAndLongest(input) {
    const arr = input.trim().split(' ');

    let longestWord = findLongestWord(arr);
    console.log(`Longest -> ${longestWord}`);

    let shortestWord = findShortestWord(arr);
    console.log(`Shortest -> ${shortestWord}`);
}

printShortestAndLongest('Hello how are you today? I hope you are fine ');
printShortestAndLongest('Lorem Ipsum is dummy text of the typesetting industry.');