namespace HorsePowerStore {

    angular.module('HorsePowerStore', ['ui.router', 'ngResource', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('homeLong', {
                url: '/home',
                onEnter: ($state) => {
                    $state.go('home');
                }
            })
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/views/home.html',
                controller: HorsePowerStore.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('about', {
                url: '/about',
                templateUrl: '/ngApp/views/about.html',
                controller: HorsePowerStore.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('searchForm', {
                url: '/searchForm',
                templateUrl: '/ngApp/views/SearchForm.html',
                controller: HorsePowerStore.Controllers.SearchFormController,
                controllerAs: 'controller'
            })
            .state('result', {
                url: '/result',
                templateUrl: '/ngApp/views/result.html',
                controller: HorsePowerStore.Controllers.ResultController,
                controllerAs: 'controller'
            })
            .state('resultLoad', {
                url: '/result/:id',
                templateUrl: '/ngApp/views/result.html',
                controller: HorsePowerStore.Controllers.ResultController,
                controllerAs: 'controller'
            })
            .state('carInstances', {
                url: '/savedCars',
                templateUrl: '/ngApp/views/savedCarInstances.html',
                controller: HorsePowerStore.Controllers.CarInstanceController,
                controllerAs: 'controller'
            })
            .state('externalRegister', {
                url: '/externalRegister',
                templateUrl: '/ngApp/views/externalRegister.html',
                controller: HorsePowerStore.Controllers.ExternalRegisterController,
                controllerAs: 'controller'
            })
            .state('productRatings', {
                url: '/products/:id/:page',
                templateUrl: '/ngApp/views/product.html',
                controller: HorsePowerStore.Controllers.ProductsController,
                controllerAs: 'controller'
            })
            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/views/notFound.html'
            });

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });

    
    angular.module('HorsePowerStore').factory('authInterceptor', (
        $q: ng.IQService,
        $window: ng.IWindowService,
        $location: ng.ILocationService
    ) =>
        ({
            request: function (config) {
                config.headers = config.headers || {};
                config.headers['X-Requested-With'] = 'XMLHttpRequest';
                return config;
            },
            responseError: function (rejection) {
                if (rejection.status === 401 || rejection.status === 403) {
                    $location.path('/login');
                }
                return $q.reject(rejection);
            }
        })
    );

    angular.module('HorsePowerStore').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });

    

}
