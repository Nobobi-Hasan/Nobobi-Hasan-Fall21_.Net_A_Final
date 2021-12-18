app.controller("cus_Checkout",function(ajax, $location){

    var o = JSON.parse(localStorage.getItem("cart"));
    var user = "cus1";

    var data = {
        Od: o,
        Uname: user
    }

    console.log(data);
    localStorage.clear("cart");


    ajax.post("https://localhost:44348/api/Customer/Checkout", data, success, error)
        function success(response){
            console.log(response);
            alert("Order placed successfully.");
        }
        function error(error){
            alert("Order not placed !!!!");
        }



    $location.path("/Customer/Home");
    

});