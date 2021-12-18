app.controller("cus_ClearCart",function($routeParams, $location){

    localStorage.clear("cart");
    $location.path("/Customer/Cart");
    

});