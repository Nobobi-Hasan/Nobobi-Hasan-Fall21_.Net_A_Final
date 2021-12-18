app.controller("cus_home",function($scope,$http,ajax){
    ajax.get("https://localhost:44348/api/Customer/AllBooks",success,error);
    function success(response){
      $scope.AllBooks=response.data;
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }

});