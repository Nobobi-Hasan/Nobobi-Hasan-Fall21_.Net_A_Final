app.controller("Home",function($scope,$http,ajax,$routeParams){
    ajax.get("https://localhost:44348/api/Customer/AllBooks",success,error);
    function success(response){
      $scope.AllBooks=response.data;
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }

    if($routeParams!= null)
    {
        ajax.get("https://localhost:44348/api/Customer/OneBook/"+$routeParams.id,success,error);
        function success(response){

            var findItemById = function(items, id) {
                return _.find(items, function(item) {
                  return item.Id === id;
                });
              };



            let products = [];

            if(localStorage.getItem('products')){
                products = JSON.parse(localStorage.getItem('products'));
    
            }

            products.push(JSON.stringify(response.data));
            // products.push({'productId' :" productId + 1", image : 'vaaaa'}); 
            localStorage.setItem("products", JSON.stringify(products));
            // localStorage.clear("products");
            $scope.cart=  localStorage.getItem("products");


            // var found = findItemById(localStorage.getItem("products"), 1);
            // $scope.cart=  found;

        
        }
        function error(error){
        }

    }
});