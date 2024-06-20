function generatePassword(n, m) {

    let alphabet = 'abcdefghijklmnopqrstuvwxyz';

    for (let s1 = 1; s1 <= n; s1++) {
        for (let s2 = 1; s2 <= n; s2++) {
            for (let i = 0; i < m; i++) {
                let s3 = alphabet[i];
                for (let j = 0; j < m; j++) {
                    let s4 = alphabet[j];
                    for (let s5 = 1; s5 <= n; s5++) {
                        if (s5 > s1 && s5 > s2) {
                            console.log(`${s1}${s2}${s3}${s4}${s5}`);
                        }
                    }
                }
            }
        }
    }

}

generatePassword(2, 4);
generatePassword(3, 1);