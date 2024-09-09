function decrypt(input) {
    const pattern = /\d{2}(.|-|\/)[A-Z]{1}[a-z]{2}\1\d{4}/gm;
    const matches = input.match(pattern);

    for (const match of matches) {
        let splitter = /[.,-\/]/;
        let [day, month, year] = match.split(splitter);
        console.log(`Day: ${day}, Month: ${month}, Year: ${year}`);
    }
}

decrypt('13/Jul/1928, 10-Nov-1934, 01/Jan-1951, 25.Dec.1937, 23#09#1973, 1/Feb/2016');
decrypt('1/Jan-1951 23/October/197 11-Dec-2010 18.Jan.2014');