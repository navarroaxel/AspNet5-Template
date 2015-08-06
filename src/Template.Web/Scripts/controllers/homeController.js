(function () {
    'use strict';

    angular
        .module('app')
        .controller('homeController', homeController);

    homeController.$inject = ['$scope', '$http']; 

    function homeController($scope, $http) {
        $scope.title = 'homeController';

        $http.get('/api/home').success(function (data) {
            $scope.items = data;
        });
    }
})();
