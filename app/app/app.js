var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })


    //Customer ############################################


    .when("/Customer/Home", {
        templateUrl : "views/pages/Customer/Home.html",
        controller: 'cus_home'
    })
    .when("/Customer/Book/AddToCart/:id", {
        templateUrl : "views/pages/Customer/Home.html",
        controller: 'cus_AddCart'
    })


    

    .when("/Customer/Cart", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_cart'
    })
    .when("/Customer/Cart/PlusCart/:id", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_PlusCart'
    })
    .when("/Customer/Cart/MinusCart/:id", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_MinusCart'
    })
    .when("/Customer/Cart/DeleteCart/:id", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_DeleteCart'
    })
    .when("/Customer/Cart/ClearCart", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_ClearCart'
    })
    .when("/Customer/Cart/Checkout", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_Checkout'
    })
    



    .when("/Customer/MyOrders", {
        templateUrl : "views/pages/Customer/MyOrders.html",
        controller: 'cus_MyOrders'
    })
    .when("/Customer/MyCancelledOrders", {
        templateUrl : "views/pages/Customer/MyCancelledOrders.html",
        controller: 'cus_MyCancelledOrders'
    })
    .when("/Customer/MyOrders/Details/:id", {
        templateUrl : "views/pages/Customer/OrderDetails.html",
        controller: 'cus_OrderDetails'
    })
    .when("/Customer/MyOrders/Cancel/:id", {
        templateUrl : "views/pages/Customer/MyOrders.html",
        controller: 'cus_CancelReqOrder'
    })


    

    .when("/Customer/MyTransactions", {
        templateUrl : "views/pages/Customer/MyTransactions.html",
        controller: 'cus_MyTransactions'
    })

    .when("/Customer/Support", {
        templateUrl : "views/pages/Customer/AddSupport.html",
        controller: 'cus_AddSupport'
    })

    .when("/Customer/Profile", {
        templateUrl : "views/pages/Customer/Profile.html",
        controller: 'cus_Profile'
    })
    .when("/Customer/DeleteProfile", {
        templateUrl : "views/pages/Customer/DeleteProfile.html",
        controller: 'cus_DeleteProfile'
    })





    //Otherwise ###########################################

    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
