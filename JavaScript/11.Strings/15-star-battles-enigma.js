function decrypt(input) {
    const result = [];

    for (const message of input) {
        let key = 0;
        for (const char of message.toLowerCase()) {
            if (char === 's' || char === 'a' || char === 't' || char === 'r') {
                key++;
            }
        }

        let decryptedMessage = '';
        for (const char in message) {
            decryptedMessage += String.fromCharCode(message.charCodeAt(char) - key);
        }

        const validMessagePattern = /@(?<planet>[A-z]+)([^@\-!:>]*):(?<population>\d+)([^@\-!:>]*)!(?<attack>(A|D))!([^@\-!:>]*)(?<soldiers>->\d+)/g;
        const matchedMessage = validMessagePattern.exec(decryptedMessage);

        if (matchedMessage) {
            const data = [matchedMessage.groups.planet, matchedMessage.groups.attack]
            result.push(data)
        }
    }

    const attacked = result.filter(e => e[1] === 'A');
    console.log(`Attacked planets: ${attacked.length}`);
    if (attacked) {
        attacked.forEach(e => console.log(`-> ${e[0]}`));
    }

    const destroyed = result.filter(e => e[1] === 'D');
    console.log(`Destroyed planets: ${destroyed.length}`);
    if (destroyed) {
        destroyed.forEach(e => console.log(`-> ${e[0]}`));
    }
}

decrypt(['STCDoghudd4=53333$D$0A53333', 'EHfsytsnhf?8555&I&2C9555SR']);
decrypt(["tt(''DGsvywgerx>6444444444%H%1B9444", 'GQhrr|A977777(H(TTTT', 'EHfsytsnhf?8555&I&2C9555SR']);