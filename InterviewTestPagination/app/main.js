(function (angular) {
    "use strict";

    angular
        .module("todoApp", ['ui.bootstrap'])
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
            $scope.DropDownList = [
                {
                    Value: 0,
                    Name: 'All'
                }, {
                    Value: 10,
                    Name: '10'
                }, {
                    Value: 20,
                    Name: '20'
                }, {
                    Value: 30,
                    Name: '30'
                }]; // Set dropdownlist values
            $scope.pageSizeSelected = $scope.DropDownList[2]; // Maximum number of items per page. 

            $scope.getAll = function() {
                $http.get("api/Todo/All").then(
                    function(response) {
                        $scope.todos = response.data.todos;
                        $scope.totalCount = response.data.count;
                    }
                );
            }

            $scope.getByPage = function() {
                $http.get("api/Todo/ByPage?page=" + $scope.pageIndex + "&pageSize=" + $scope.pageSizeSelected.Value).then(
                    function(response) {
                        $scope.todos = response.data.todos;
                        $scope.totalCount = response.data.count;
                    });
            }

            //Loading todo list by page
            $scope.getByPage();  

            //This method is called when the page is changed
            $scope.pageChanged = function () {
                $scope.getByPage();
            }; 

            //This method is calling from dropDown  
            $scope.changePageSize = function () {
                $scope.pageIndex = 1;
                if ($scope.pageSizeSelected.Value === 0) {
                    $scope.getAll();
                } else {
                    $scope.getByPage();
                }
            }; 
        }

        return directive;
    }

})(angular);

