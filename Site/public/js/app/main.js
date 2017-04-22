angular.module('charliedogs', ['ngRoute', 'apiServicos', 'painelDiretivas'])
	.config(function($routeProvider, $locationProvider) {

		$locationProvider.html5Mode(true);

		$routeProvider.when('/canil', {
			templateUrl: 'index.html',
			controller: 'CachorrosController'
		});

		$routeProvider.otherwise({redirectTo: '/canil'});

	});