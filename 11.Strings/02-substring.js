function decrypt(input, start, count) {
    const end = start + count;
    const result = input.substring(start, end);
    console.log(result);
}

decrypt('ESentence', 1, 8);
decrypt('DropWord', 4, 7);