function decrypt(text, words) {
    words.sort((a, b) => b.length - a.length);

    let result = text;

    for (const word of words) {
        const hole = '_'.repeat(word.length);
        result = result.replaceAll(hole, word);
    }

    console.log(result);
}

decrypt(
    'Hi, grandma! I\'m so ____ to write to you. ______ the winter vacation, so many _______ things happened. My dad bought me a sled. Mom started a new job as a __________. My brother\'s ankle is ________, and now it bothers me even more. Every night Mom cooks ___ on your recipe because it is the most delicious. I hope this year Santa will _____ me a robot.',
    ['pie', 'bring', 'glad', 'During', 'amazing', 'pharmacist', 'sprained']
);