const buttonMinus = document.querySelector(".button-minus");
const buttonPlus = document.querySelector(".button-plus");

const quantity = document.querySelector(".quantity-text");

buttonMinus.addEventListener("click", function (e) {
    e.preventDefault();
    let number = parseInt(quantity.value);
    if (number > 1) {
        --number;
        quantity.value = number;
    }
});

buttonPlus.addEventListener("click", function (e) {
    e.preventDefault();
    let number = parseInt(quantity.value);
    if (number >= 1) {
        ++number;
        quantity.value = number;
    }
});