const buttons = document.querySelectorAll(".btn-delete-cart");

buttons.forEach(button => {
    button.addEventListener("click", function () {
        const customerID = parseInt(document.getElementById("customerID").value);

        const row = this.closest("tr");

        // Kiểm tra xem có thể tìm thấy phần tử cha <tr> hay không trước khi xóa
        if (row) {
            //chỉnh sửa giao diện
            row.remove();

            //gửi qua post
            $.ajax({
                url: "/Cart/deleteCart",
                type: "POST",
                data: {
                    productID: $(this).data("id"),
                    customerID: customerID,
                    type: "ajax",
                },
                success: function (data) {
                    console.log(data);
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Bạn đã xóa sản phẩm khỏi giỏ hàng thành công',
                        showConfirmButton: false,
                        timer: 3000
                    });
                    $("#cart-count").html(data.soLuong);
                    $("#cart-total-price").html(data.totalPrice);
                    $("#total-price").html(data.totalPrice);

                },
                error: function (data) {
                    console.log(data);
                    Swal.fire({
                        icon: 'error',
                        title: 'Thêm giỏ hàng thất bại',
                        text: 'Xóa sản phẩm khỏi giỏ hàng thất bại',
                    });
                }
            });

        }
    })
})