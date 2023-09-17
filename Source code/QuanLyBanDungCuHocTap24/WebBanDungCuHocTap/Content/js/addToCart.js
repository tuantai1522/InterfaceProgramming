
const buttonAddToCart = document.querySelector(".add_to_cart_button");

buttonAddToCart.addEventListener("click", function (e) {
    e.preventDefault();

    const productID = parseInt(document.getElementById("productID").value);
    const customerID = parseInt(document.getElementById("customerID").value);
    const Quantity = parseInt(document.getElementById("quantity").value);

    $.ajax({
        url: "/Cart/addtoCart",
        type: "POST",
        data: {
            productID: productID,
            customerID: customerID,
            quantity: Quantity,
            type: "ajax",
        },
        success: function (data) {
            console.log(data);
            Swal.fire({
                position: 'top-end',
                icon: 'success',
                title: 'Bạn đã thêm vào giỏ hàng thành công',
                showConfirmButton: false,
                timer: 3000
            });
            $("#cart-count").html(data.soLuong);
            $("#cart-total-price").html(data.totalPrice);
            
        },
        error: function (data) {
            console.log(data);
            Swal.fire({
                icon: 'error',
                title: 'Thêm giỏ hàng thất bại',
                text: 'Bạn đã thêm vào giỏ hàng thất bại',
            });
        }
    });
});