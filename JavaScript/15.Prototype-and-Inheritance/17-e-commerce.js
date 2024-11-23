function createEcommerceSystem() {
    class Product {
        constructor(id, name, price) {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        applyDiscount(discount) {
            return this.price -= discount;
        }
    }

    class Electronics extends Product {
        constructor(id, name, price, warrantyPeriod, brand) {
            super(id, name, price);
            this.warrantyPeriod = warrantyPeriod;
            this.brand = brand;
        }
    }

    class Clothing extends Product {
        constructor(id, name, price, warrantyPeriod, size, material) {
            super(id, name, price);
            this.warrantyPeriod = warrantyPeriod;
            this.size = size;
            this.material = material;
        }
    }
    
    return {Product, Electronics, Clothing};
}