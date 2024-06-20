function build(floors, aparatments) {
    for (let f = floors; f > 0; f--) {
        let floor = '';

        for (let a = 0; a < aparatments; a++) {
            let type;
            let isLastFloor = f === floors;

            if (isLastFloor) {
                type = 'L';
            } else if (f % 2 === 0) {
                type = 'O';
            } else {
                type = 'A';
            }

            floor += type + f + a + ' ';
        }

        console.log(floor.trim());
    }
}

build(6, 4);
build(3, 3);
build(4, 4);