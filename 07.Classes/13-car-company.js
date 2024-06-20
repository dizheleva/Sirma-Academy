class CarCompany {
    #carRegister = {};

    addToRegister(carBrand, carModel, producedCars) {
        if (!this.#carRegister.hasOwnProperty(carBrand)) {
            this.#carRegister[carBrand] = {};
        }

        if (!this.#carRegister[carBrand].hasOwnProperty(carModel)) {
            this.#carRegister[carBrand][carModel] = producedCars;
        } else {
            this.#carRegister[carBrand][carModel] += producedCars;
        }        
    }

    printRegister() {
        for (const carBrand in this.#carRegister) {
            console.log(carBrand);
            
            const carModels = this.#carRegister[carBrand];
            for (const carModel in carModels) {
                console.log(`###${carModel} -> ${carModels[carModel]}`);
            }
        }
    }
}

function solve(inputArr) {
    const myCompany = new CarCompany();

    inputArr.forEach(line => {
        let [carBrand, carModel, producedCars] = line.split(' | ');
        myCompany.addToRegister(carBrand, carModel, Number(producedCars));
    });

    myCompany.printRegister();
}

solve(['Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10']);