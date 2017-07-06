Feature: CadastraCliente

@CadastraCliente
Scenario Outline:Cadastro com dados validos
	Given Eu estou na tela de cadastro de cliente 
	And eu informei <cpf_cnpj>
	And eu informei <nome>
	And eu informei <endereco>
	And eu informei <cep>
	And eu informei <bairro>
	And eu informei <cidade>
	And eu informei <uf>
	And eu informei <telefone>
	When Eu finalizei o cadastro do cliente
	Then o cadastro deve ser realizado com sucesso

	Examples: 
	| cpf_cnpj         | nome                    | endereco             | cep        | bairro            | cidade    | uf   | telefone        |
	| '0990263018'     | 'Augusto Santos Coelho' | 'Rua Dr Dido Fontes' | '29060280' | 'Jardim da Penha' | 'Vitoria' | 'ES' | '(27)997015055' |
	| '31850435000159' | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |

Scenario Outline:Cadastro com dados invalidos
	Given Eu estou na tela de cadastro de cliente 
	And eu informei <cpf_cnpj>
	And eu informei <nome>
	And eu informei <endereco>
	And eu informei <cep>
	And eu informei <bairro>
	And eu informei <cidade>
	And eu informei <uf>
	And eu informei <telefone>
	When Eu finalizei o cadastro do cliente
	Then o cadastro deve ser bloquado

	Examples: 
	| cpf_cnpj     | nome                    | endereco             | cep        | bairro            | cidade    | uf   | telefone        |
	|			   | 'Augusto Santos Coelho' | 'Rua Dr Dido Fontes' | '29060280' | 'Jardim da Penha' | 'Vitoria' | 'ES' | '(27)997015055' |
	| '1'		   | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	| '12'		   | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	| '123'		   | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	| '1234'	   | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	| '12345'	   | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	| '123456'	   | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	| '1234567'	   | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	| '12345678'   | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	| '123456789'  | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	| '1234567899' | 'Churrasquinho de Gato' | 'Avenidas das Prima' | '29060010' | 'Centro'          | 'Caraiva' | 'BA' | '(73)33606669'  |
	
 