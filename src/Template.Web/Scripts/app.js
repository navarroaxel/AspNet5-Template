(function () {
    'use strict';

    angular.module('app', [
        // Angular modules 
        'ngRoute'

        // 3rd Party Modules

        // Custom modules 

    ]).config(configRoutes);

    configRoutes.$inject = ['$routeProvider'];

    function configRoutes($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'templates/home.html',
                controller: 'homeController'
            })
            .otherwise('/');
    }
})();