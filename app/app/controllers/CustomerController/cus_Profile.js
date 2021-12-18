app.controller("cus_Profile",function($scope,$http,ajax){

    ajax.get("https://localhost:44348/api/Customer/Profile",success,error);
    function success(response){
      $scope.Id=response.data.Id;
      $scope.FirstName=response.data.FirstName;
      $scope.LastName=response.data.LastName;
      $scope.Gender=response.data.Gender;
      $scope.Dob=response.data.Dob;
      $scope.Nid=response.data.Nid;
      $scope.Email=response.data.Email;
      $scope.Username=response.data.Username;
      $scope.Password=response.data.Password;

      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }


    $scope.submit = function(){
        var data = {
            Id: $scope.Id,
            FirstName: $scope.FirstName,
            LastName: $scope.LastName,
            Gender: $scope.Gender,
            Dob: $scope.Dob,
            Nid: $scope.Nid,
            Email: $scope.Email,
            Username: $scope.Username,
            Password: $scope.Password,
        }

        ajax.post("https://localhost:44348/api/Customer/EditProfile", data, success, error)
        function success(response){
            alert("Profile Updated");
        }
        function error(error){
            alert("Profile Not Updated!!!!");
        }
    }
});
