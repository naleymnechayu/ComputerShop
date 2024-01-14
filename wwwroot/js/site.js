var selectElem = document.getElementById("inputGroupSelect01");
var nameProduct = document.getElementById("nameProduct");
var priceProdcut = document.getElementById("priceProduct");
var imgProduct = document.querySelector('img');

class Product {
    constructor(price, count, name, imgProduct) {
        this.price = price;
        this.count = count;
        this.name = name;
        this.img = imgProduct;
    }
}

function addProductToCart() {
    var countProduct = selectElem.value;
    var product = new Product(priceProdcut.textContent, countProduct, nameProduct.textContent, imgProduct.src);


    if (localStorage.getItem("products")) {
        var storedProducts = JSON.parse(localStorage.getItem("products"));
        storedProducts.push(product); // Добавляем новый продукт
        localStorage.setItem("products", JSON.stringify(storedProducts));
    } else {
        var newProducts = [product];
        localStorage.setItem("products", JSON.stringify(newProducts));
    }
}



function displayProductsFromLocalStorage() {
    var shoppingCartDiv = document.getElementById("cartContainer");
    var storedProducts = JSON.parse(localStorage.getItem("products"));

    if (storedProducts) {
        shoppingCartDiv.innerHTML = ""; 
        var totalResult = 0;
        storedProducts.forEach(function (product) {
            var productDiv = document.createElement("div");
            productDiv.classList.add("item");
            var imageDiv = document.createElement("div");
            imageDiv.classList.add("image");
            var img = document.createElement("img");
            img.src = product.img;
            img.alt = product.name;
            imageDiv.appendChild(img);
            productDiv.appendChild(imageDiv);
            var buttonsDiv = document.createElement("div");
            buttonsDiv.classList.add("buttons");
            buttonsDiv.innerHTML = "<div>" + product.name + "</div><div>" + product.price + "</div><div>" + product.count + "</div>";
            productDiv.appendChild(buttonsDiv);
            var totalPriceDiv = document.createElement("div");
            totalPriceDiv.classList.add("total-price");
            var totalPrice = parseInt(product.price) * parseInt(product.count);
            totalPriceDiv.textContent = "$" + totalPrice;
            productDiv.appendChild(totalPriceDiv);
            shoppingCartDiv.appendChild(productDiv);
            totalResult += totalPrice;
        });

        var totalDiv = document.createElement("div");
        totalDiv.classList.add("total");
        totalDiv.textContent = "Total: $" + totalResult;
        shoppingCartDiv.appendChild(totalDiv);
    }
}


document.addEventListener("DOMContentLoaded", function () {
    displayProductsFromLocalStorage();
});

function clearCart() {
    localStorage.removeItem("products");
    var shoppingCartDiv = document.querySelector(".shopping-cart");
    shoppingCartDiv.innerHTML = ""; 
}
(function ($) {

    "use strict";

    // прелаод
    $(window).load(function () {
        $('.preloader').delay(500).slideUp('slow'); // Задерживаем отображение элемента на 500 мс, а затем плавно его скрываем
    });

    // NAVBAR
    $(".navbar").headroom();

    $('.navbar-collapse a').click(function () {
        $(".navbar-collapse").collapse('hide');
    });

    //Slick это плагин для создания адаптивных слайдеров (каруселей) на веб-странице.
    $('.slick-slideshow').slick({
        autoplay: true,
        infinite: true,
        arrows: false,
        fade: true,
        dots: true,
    });

    $('.slick-testimonial').slick({
        arrows: false,
        dots: true,
    });

})(window.jQuery);
