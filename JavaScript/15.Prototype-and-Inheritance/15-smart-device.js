function createSmartDeviceHierarchy() {
    class Device {
        constructor(brand, model, batteryLife) {
            this.brand = brand;
            this.model = model;
            this.batteryLife = batteryLife;
        }

        charge() {
            this.batteryLife = 100;
            console.log('The battery is fully charged.');
        }

        turnOn() {
            console.log(`${this.brand} ${this.model} is turned on.`);
        }
    }

    class Smartphone extends Device {
        chargingTime = 1.5;

        constructor(brand, model, batteryLife, screenSize, os) {
            super(brand, model, batteryLife);
            this.screenSize = screenSize;
            this.os = os;
        }

        charge() {
            super.charge();
            console.log(`Charging time was ${this.chargingTime} hours.`);
        }
    }

    class Smartwatch extends Device {
        chargingTime = 2.5;

        constructor(brand, model, batteryLife, strapMaterial, waterResistance) {
            super(brand, model, batteryLife);
            this.strapMaterial = strapMaterial;
            this.waterResistance = waterResistance;
        }

        charge() {
            super.charge();
            console.log(`Charging time was ${this.chargingTime} hours.`);
        }
    }

    return {Device, Smartphone, Smartwatch};
}

createSmartDeviceHierarchy();