
    $(document).ready(function () {
        productList();
    });

    var Product = {
        ProductId: 0,
    ProductName: "",
    IntroductionDate: "",
    Url: ""
    }

  

    function addClick() {
        formClear();
    }

  

    function productAdd(product) {
        // Call Web API to add a new product
        $.ajax({
            url: "/api/Product/CreateProduct",
            type: 'POST',
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(product),
            success: function (product) {
                productAddSuccess(product);
            },
            error: function (request, message, error) {
                handleException(request, message, error);
            }
        });
    }

    function productAddSuccess(product) {
        productAddRow(product);
    formClear();
    }

  
            function productGet(ctl) {
      // Get product id from data- attribute
      var id = $(ctl).data("id");

            // Store product id in hidden field
            $("#productid").val(id);

            // Call Web API to get a Product
            $.ajax({
                url: "/api/V1/Product/GetProductById/" + id,
            type: 'GET',
            dataType: 'json',
            success: function (product) {
                productToFields(product);
                $('#productDetailModal').modal('show');
                $("#ProductPriceDetails").append(
                    productBuildDetails(product));
        },
            error: function (request, message, error) {
                handleException(request, message, error);
        }
      });
    }

function productBuildDetails(product) {
    var ret = "<div class='text-center'>" +

        "<h5>" + product.name + "</h5>" +
        "<p class='text-muted mb-4'>" + product.description + "</p>" +
        +"</div>" +
        +"<div>" +
        "<div>" +
        "<span>Price</span><span>" + product.produtPriceDetails.price + "</span><span>$</span></div>" +

        "<div>" +
        "<span>ActualCost</span><span>" + product.produtPriceDetails.actualCost + "</span><span>$</span> </div>";
               
                
          
    return ret;
}
            function productToFields(product) {
                $("#productname").val(product.ProductName);
            $("#introdate").val(product.IntroductionDate);
            $("#url").val(product.Url);
    }

            // Get all Products to display
            function productList() {
                // Call Web API to get a list of Products
                $.ajax({
                    url: '/api/v1/Product/GetProducts/',
                    type: 'GET',
                    dataType: 'json',
                    success: function (products) {
                        productListSuccess(products);
                    },
                    error: function (request, message, error) {
                        handleException(request, message, error);
                    }
                });
    }

            // Display all Products returned from Web API call
            function productListSuccess(products) {
                // Iterate over the collection of data
                $.each(products, function (index, product) {
                    // Add a row to the Product table
                    productAddRow(product);
                });
    }

    // Add Product row to <table>
                function productAddRow(product) {
      // First check if a <tbody> tag exists, add one if not
      if ($("#productTable tbody").length == 0) {
                        $("#productTable").append("<tbody></tbody>");
      }

      // Append row to <table>
                        $("#productTable tbody").append(
                        productBuildTableRow(product));
    }

    // Build a <tr> for a row of table data
                            function productBuildTableRow(product) {
      var ret = "<tr>" +
                               
                            "<td>" + product.name + "</td>" +
                            "<td>" + product.description + "</td>" +
                            "<td>" + product.color + "</td>" +
                            "<td>" + product.categoryName + "</td>" +
                            "<td>" + product.imageUrl + "</td>" +
                            "<td>" +
                                "<button type='button' " +
                                "onclick='productGet(this);' " +
                                "class='btn btn-default' " +
                      "data-id='" + product.productId + "'>" +
                                "<span>Details</span>" +
                                "</button>" +
                            "</td>" +
                        "</tr>";

                    return ret;
}




                        // Clear form fields
                        function formClear() {
                            $("#productname").val("");
                        $("#introdate").val("");
                        $("#url").val("");
    }

                        // Handle exceptions from AJAX calls
                        function handleException(request, message, error) {
      var msg = "";

                        msg += "Code: " + request.status + "\n";
                        msg += "Text: " + request.statusText + "\n";
                        if (request.responseJSON != null) {
                            msg += "Message" + request.responseJSON.Message + "\n";
      }

                        alert(msg);
    }
