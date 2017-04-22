angular.module('apiServicos', ['http'])
	.factory('CachorrosServices', function($http) {

		var servico = {};
		var apiUrl = 'api/cachorros/';

		servico.getAll = function (){

			var promise = $http.get(apiUrl)
							   .then(function (response) {
        							return response.data;
      							});
			return promise;

		};

		servico.getPorNome = function (nome){

			var promise = $http.get(apiUrl + "getPorNome?nome=" + nome)
							   .then(function (response) {
        							return response.data;
      							});
			return promise;
			
		};

		servico.getPorPreco = function (minValor, maxValor){

			var promise = $http.get(apiUrl + "getPorPreco?minValor=" + minValor + "&maxValor=" + maxValor)
							   .then(function (response) {
        							return response.data;
      							});
			return promise;
			
		};

		servico.getPorPorte = function (porte){
			var promise = $http.get(apiUrl + "getPorPorte?porte=" + porte)
							   .then(function (response) {
        							return response.data;
      							});
			return promise;
		}

		return servico;
	})
	.factory('ComprasServices', function($http) {

		var servico = {};
		var apiUrl = 'api/compras/';

		servico.comprar = function(nome, cpf, enderecoEntrega, idsCachorros){
			
			var dados = {
				cpf: nome,
				cpf: cpf,
				enderecoEntrega: enderecoEntrega,
				idsCachorros: idsCachorros
			};

			var promise = $http.post(apiUrl, dados)
							   .then(function(response){
								   return response.data;
								});
			
			return promise;
		};

		return servico;
	});