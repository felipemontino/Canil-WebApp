angular.module('painelDiretivas', [])
	.directive('CachorroPainel', function() {

		var ddo = {};

		ddo.restrict = "E";

		ddo.scope = {
            nome: '@',
			idade: '@',
			caminhoArquivo: '@',
			preco: '@'
        };

        ddo.templateUrl = 'js/directives/painel.html';

		return ddo;
	});