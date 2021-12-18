app.controller("cus_AddSupport",function($scope,$http,ajax){

    $scope.submit = function(){
        var data = {
            Name: $scope.Name,
            Phone: $scope.Phone,
            Email: $scope.Email,
            Message: $scope.Message,
        }

        ajax.post("https://localhost:44348/api/Customer/AddSupport", data, success, error)
        function success(response){
            alert("Message Sent");
        }
        function error(error){
            alert("Message Not Sent!!!!");
        }
    }
});
