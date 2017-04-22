angular.module('charliedogs').controller('CachorrosController', function($scope, cachorrosServices) {
	
	$scope.cachorros = [];
	$scope.nomePesquisa = '';

	cachorrosServices.getAll().then(function(response) {
        $scope.cachorros = response.data;
    }, function(erro){
		console.log(erro);
	});


	$scope.buscarPorNome = function (){

		cachorrosServices.getPorNome($scope.nomePesquisa)
						 .then(function(response) {
							$scope.cachorros = response.data;
						 }, function(erro){
							console.log(erro);
						 });

	}

	$scope.buscarPorPorte = function(porte){
		
		cachorrosServices.getPorPorte(porte)
						 .then(function(response) {
							$scope.cachorros = response.data;
						 }, function(erro){
							console.log(erro);
						 });
	}

	$scope.buscarPorPreco = function(minPreco, maxPreco){

		cachorrosServices.getPorPreco(porte)
						 .then(function(response) {
							$scope.cachorros = response.data;
						 }, function(erro){
							console.log(erro);
						 });
	}

});