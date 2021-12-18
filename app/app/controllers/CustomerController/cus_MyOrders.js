app.controller("cus_MyOrders",function($scope,$http,ajax){
    ajax.get("https://localhost:44348/api/Customer/MyOrders",success,error);
    function success(response){
      $scope.MyOrders=response.data;
      console.log(data);
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }

});