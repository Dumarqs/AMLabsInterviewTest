(function (angular) {
    "use strict";

    angular
        .module("todoApp")
        .directive("todoPaginatedList", [todoPaginatedList])

    function todoPaginatedList() {
        var directive = {
            restrict: "E", // example setup as an element only
            templateUrl: "app/templates/todo.list.paginated.html",
            scope: {}, // example empty isolate scope
            controller: ["$scope", "$http", controller]
        };

        function controller($scope, $http) { // example controller creating the scope bindings
            $scope.all = [];

            $scope.maxSize = 5;     // Limit number for pagination display number.  
            $scope.totalCount = 0;  // Total number of items in all pages. initialize as a zero  
            $scope.pageIndex = 1;   // Current page number. First page is 1.-->  
            $scope.pageSizeSelected = 20; // Maximum number of items per page. 

            $scope.DropDownList = [
                {
                    Value: 0,
                    Name: 'All',
                    Selected: false
                }, {
                    Value: 10,
                    Name: '10',
                    Selected: false
                }, {
                    Value: 20,
                    Name: '20',
                    Selected: true
                }, {
                    Value: 30,
                    Name: '30',
                    Selected: false
                }]; // Set dropdownlist values

            $scope.getAll = function() {
                $http.get("api/Todo/All").then(response => $scope.todos = response.data);
            }

            $scope.getByPage = function() {
                $http.get("api/Todo/ByPage?page=" + $scope.pageIndex + "&pageSize=" + $scope.pageSizeSelected).then(
                    function(response) {
                        $scope.todos = response.data;
                    });
            }

            //Loading todo list
            $scope.getAll();  

            //This method is called when the page is changed
            $scope.pageChanged = function () {
                $scope.getByPage();
            }; 

            //This method is calling from dropDown  
            $scope.changePageSize = function () {
                $scope.pageIndex = 1;
                if ($scope.pageSizeSelected === "0") {
                    $scope.getAll();
                } else {
                    $scope.getByPage();
                }
                
            }; 
        }

        return directive;
    }

})(angular);

