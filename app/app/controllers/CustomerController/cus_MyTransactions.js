app.controller("cus_MyTransactions",function($scope,$http,ajax){
    ajax.get("https://localhost:44348/api/Customer/MyTransactions",success,error);
    function success(response){
      $scope.MyTransactions=response.data;
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }

});