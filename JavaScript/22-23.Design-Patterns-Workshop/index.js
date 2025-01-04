// Factory Pattern workshop

// class Car {
// 	constructor(model) {  this.model = model; }
// }
// class Bike {
// 	constructor(model) { this.model = model; }
// }
// class VehicleFactory {
// 	static createVehicle(type, model) {
// 		if (type === "car") return new Car(model);
// 		if (type === "bike") return new Bike(model);
// 		throw new Error("Unknown vehicle type");
// 	}
// }

(() => {
    class Book {
        constructor(productType, name, description, price) {
            this.productType = productType;
            this.name = name;
            this.description = description;
            this.price = price;
        }

        perform() {
            console.log("I'm reading");
        }
    }

    class Game {
        constructor(productType, name, description, price) {
            this.productType = productType;
            this.name = name;
            this.description = description;
            this.price = price;
        }

        perform() {
            console.log("I'm gaming");
        }
    }

    class Headphones {
        constructor(productType, name, description, price) {
            this.productType = productType;
            this.name = name;
            this.description = description;
            this.price = price;
        }

        perform() {
            console.log("I'm headphoning");
        }
    }

    class ProductFactory {
        static createProduct(type, name, description, price) {
            switch (type) {
                case "book":
                    return new Book(type, name, description, price);
                case "game":
                    return new Game(type, name, description, price);
                case "headphones":
                    return new Headphones(type, name, description, price);
            }
        }
    }

    let productList = [];

    const form = document.getElementById("form");
    const cardContainer = document.getElementById("card-container");

    const mapOverProducts = (list, isFromLocalStorage) => {
        list.map((product) => {
            let parsedProduct;
            if (list && isFromLocalStorage) {
                parsedProduct = ProductFactory.createProduct(
                    product.productType,
                    product.name,
                    product.description,
                    product.price
                );
            }
            const card = document.createElement("div");
            card.classList.add("card");
            const content = createCardContent(
                isFromLocalStorage ? parsedProduct : product
            );
            content.map((el) => card.appendChild(el));
            cardContainer.appendChild(card);

            card.addEventListener("click", () =>
                isFromLocalStorage ? parsedProduct.perform() : product.perform()
            );
            isFromLocalStorage && productList.push(parsedProduct);
        });
    };
    const createCardContent = (product) => {
        const h4 = document.createElement("h4");
        const nameP = document.createElement("p");
        const descriptionP = document.createElement("p");
        const priceP = document.createElement("p");

        h4.innerHTML = `Product Type: ${product.productType}`;
        nameP.innerHTML = `Product Name: ${product.name}`;
        descriptionP.innerHTML = `Product Description: ${product.description}`;
        priceP.innerHTML = `Product Price: ${product.price}`;

        return [h4, nameP, descriptionP, priceP];
    };

    const handleFormSubmit = (e) => {
        e.preventDefault();
        const productType = document.getElementById("product-type"),
            productName = document.getElementById("name"),
            productPrice = document.getElementById("price"),
            productDescr = document.getElementById("description");

        const newProduct = ProductFactory.createProduct(
            productType.value,
            productName.value,
            productDescr.value,
            productPrice.value
        );

        productList.push(newProduct);

        localStorage.setItem("productList", JSON.stringify(productList));
        cardContainer.innerHTML = "";
        mapOverProducts(productList);

        form.reset();
    };

    const fillProductsFromLocalStorage = () => {
        if (!cardContainer.innerHTML) {
            const list = JSON.parse(localStorage.getItem("productList"));
            mapOverProducts(list, true);
        }
    };

    document.addEventListener("DOMContentLoaded", fillProductsFromLocalStorage);
    form.addEventListener("submit", handleFormSubmit);
})();