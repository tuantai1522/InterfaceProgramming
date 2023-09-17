const button = document.querySelector(".btn-add-to-order");

button.addEventListener("click", function () {
    const products = document.querySelectorAll('.input-products')
    const quantities = document.querySelectorAll('.input-quantities')
    const unitPrices = document.querySelectorAll('.input-unit-price')

    const productValues = [];

    products.forEach(productElement => {
        const productValue = parseFloat(productElement.value);
        if (!isNaN(productValue)) {
            productValues.push(productValue);
        }
    });

    const quantityValues = [];

    quantities.forEach(quantityElement => {
        const quantityValue = parseFloat(quantityElement.value);
        if (!isNaN(quantityValue)) {
            quantityValues.push(quantityValue);
        }
    });

    const unitPriceValues = [];
    unitPrices.forEach(unitPriceElement => {
        const unitPriceValue = parseFloat(unitPriceElement.textContent);

        if (!isNaN(unitPriceValue)) {
            unitPriceValues.push(unitPriceValue);
        }
    });

    const shipAddress = document.querySelector(".address-input").value;
    const shipCity = document.querySelector(".city-input").value;
    const shipCountry = document.querySelector(".country-input").value;
    const customerID = parseInt(document.getElementById("customerID").value);

    var dataToSend = {
        customerID: customerID,
        shipAddress: shipAddress,
        shipCity: shipCity,
        shipCountry: shipCountry,
        productValues: productValues,
        quantityValues: quantityValues,
        unitPriceValues: unitPriceValues,
    };

    // Fetch request
    fetch('/Order/addToOrder', {
        method: 'POST',
        body: JSON.stringify(dataToSend),
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(data => {
            if (data.success) {
                console.log(data);
                Swal.fire({
                    position: 'top-end',
                    icon: 'success',
                    title: 'Bạn đã đặt hàng thành công. Bạn sẽ chuyển về trang chủ trong 3 giây nữa.',
                    showConfirmButton: false,
                    timer: 3000
                });
            } else {
                console.error(data.error);
            }
        })
        .catch(error => {
            Swal.fire({
                position: 'top-end',
                icon: 'success',
                title: 'Bạn đã đặt hàng thành công. Bạn sẽ chuyển về trang chủ trong 3 giây nữa.',
                showConfirmButton: false,
                timer: 3000
            });
        });


    //Chuyển sang trang chủ
    setTimeout(function () {
        window.location.href = '/Home/Index';
    }, 3000);
});

