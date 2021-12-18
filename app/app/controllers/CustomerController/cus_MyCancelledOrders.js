app.controller("cus_MyCancelledOrders",function($scope,$http,ajax){
    ajax.get("https://localhost:44348/api/Customer/MyCancelledOrders",success,error);
    function success(response){
      $scope.MyCancelledOrders=response.data;
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }

});