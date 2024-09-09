function decrypt(input) {
    let resultA = input.substring(0, input.length / 2).split('').reverse().join('');
    let resultB = input.substring(input.length / 2).split('').reverse().join('');
    
    console.log(resultA);
    console.log(resultB);
}

decrypt('tluciffiDsIsihTgnizamAoSsIsihT');
decrypt('sihToDtnaCuoYteBIboJsihTtAdooGoSmI');