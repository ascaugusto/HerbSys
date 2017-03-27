# TRABALHO INTEGRADO: HerbSys

Trabalho desenvolvido durante as disciplinas de:
- Engenharia de Software, 
- Projeto de Sistemas

**INTEGRANTES DO GRUPO:** 
- Augusto Santos Coelho 
- Wagner Colombo Dias
        
# Sumário

#Gerência de Requisitos

## 1	Motivação e Propósito do Sistema 
escrever os motivos, necessidades e benefícios do projeto.

Controle de cliente, produtos e vendas da Herbalife. Com possíveis relatórios de finanças.

## 2	Personas
Representante de Herbalife sem automatização de controle de clientes, produtos e vendas.

## 3	Minimundo 
O sistema HerbSys deve cadastrar o seus clientes da Herbalife persistindo seu cpf(ID), nome, endereço(CEP,Rua,Bairro,Cidade) e telefone. O sistema também deverá cadastras seus produtos persistindo seu nome, valor de custo e valor de venda. O sistema deverá cadastrar as vendas realizadas persistindo o cliente que efetuou a compra, os produtos vendidos e seus valores.

## 4	Requisitos de Usuários
### 4.1	Requisitos Funcionais (Histórias de Usuário)

| ID | Categoria| História de Usuário| Importância | MosCoW| Estimativa | Real| Pronto?| Sprint|
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| RF01 | Cadastro de dados |EU, COMO  USUÁRIO DO HERBSYS, QUERO INSERIR/ALTERAR/REMOVER TODOS MEUS CLIENTES HERBALIFE, PARA QUE EU POSSA TER UM CONTROLE E O REGISTRO DOS MESMOS. |35| Must| 3 | 3 | Sim | 1|
| RF02 | Cadastro de dados |EU, COMO  USUÁRIO DO HERBSYS, QUERO INSERIR/ALTERAR/REMOVER TODOS MEUS PRODUTOS HERBALIFE, PARA QUE EU POSSA TER UM CONTROLE E O REGISTRO DOS MESMOS.| 35| Must | 3 |3| Não| 2|
| RF03 | Cadastro de dados |EU, COMO  USUÁRIO DO HERBSYS, QUERO INSERIR/ALTERAR/REMOVER TODAS MINHAS VENDAS HERBALIFE, PARA QUE EU POSSA TER UM CONTROLE E O REGISTRO DOS MESMOS.| 35| Must | 3 |3| Não| 3|

### 4.2	Requisitos Não Funcionais
| ID | Categoria| Descrição |MosCoW | Estimativa Planejada | Estimativa Real|Pronto?| Sprint|Histórias relacionadas |
| --- | --- | --- | --- | --- |--- |--- |--- |--- |
| RNF01 |Facilidade de Operação |  A entrada de dados de cadastrar clientes pelo usuário deverá ser realizada em no máximo 30 segundos | Must | 2 | 5| Sim| 10|RF01|
| RNF02 | Eficiência de Tempo | O tempo de resposta de cadastrar um cliente dever ser de no máximo 2 segundos a partir da entrada correta de dados | Should | 3 | ?| Não| -|RF01 e RF02|
| RNF03 |Facilidade de Operação |  A entrada de dados de cadastrar produtos pelo usuário deverá ser realizada em no máximo 30 segundos | Must | 2 | 5| Não| 10|RF01|
| RNF04 | Eficiência de Tempo | O tempo de resposta de cadastrar um produto dever ser de no máximo 2 segundos a partir da entrada correta de dados | Should | 3 | ?| Não| -|RF03 e RF04|
| RNF05 |Facilidade de Operação |  A entrada de dados de registro de uma venda pelo usuário deverá ser realizada em no máximo 60 segundos | Must | 2 | 5| Não| 10|RF01|
| RNF06 | Eficiência de Tempo | O tempo de resposta de registro de uma venda dever ser de no máximo 2 segundos a partir da entrada correta de dados | Should | 3 | ?| Não| -|RF05 e RF06|

### 4.3	Regras de Negócio

| ID | Descrição | MosCoW | Estimativa Planejada| Estimativa Real| Pronto?| Sprint|Histórias relacionadas |
| --- | --- | --- | --- | --- | --- | --- | --- |
| RN01 | O sistema deve inserir/alterar/remover os clientes na base de dados| Must |1|5|Sim|2|RF01|
| RN02 | O sistema deve inserir/alterar/remover os produtos na base de dados| Must |1|5|Sim|2|RF02|
| RN03 | O sistema deve inserir/alterar/remover as vendas na base de dados| Must |1|5|Sim|2|RF03|

# Desenvolvimento do Sistema
## 1.    Análise de Sistemas:
### 1.1  Subsistemas
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/Archtecture_Diagram.jpg?raw=true "Modelo Conceitual")
### 1.2  Modelagem de Casos de uso 
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/useCase.jpg?raw=true "Modelo Conceitual")
O Distruibuidor(Usuáro) mantém o cliente e o produto. O Distruibuidor(Usuário) cadastra uma compra ou uma venda. O Distruibuidor(Usuário) consulta uma compra ou uma venda e pode gerar relatório de compras ou de uma vendas em um determinado período. 
### 1.3  Modelagem Estrutural (Modelo Conceitual)
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/ClassDiagram.jpg?raw=true "Modelo Conceitual")
### 1.4  Modelagem Comportamental
inserir principais diagramas comportamentais da análise (principalmente, estados)
### 1.5  Dicionário de Dados
   FormPrincipal: Classe referente a tela principal do HerbSys
   FormCadastroCliente:  Classe referente a tela de formulário de cadastro de cliente.
   DataController: Entidade responsável por controlar o as requisições das telas a base de dados
   FormController: Entidade responsável por controlar as trocas de Telas.
   DadosCliente: Estrutura que contém as informações relativas ao cliente.
        cpf_cnpj: Dado de cadastro do cliente.
        nome: Dado de cadastro do cliente.
        endereco: Dado de cadastro do cliente.
        bairro: Dado de cadastro do cliente.
        cep: Dado de cadastro do cliente.
        cidade: Dado de cadastro do cliente.
        uf: Dado de cadastro do cliente.
        telefone: Dado de cadastro do cliente.
   Venda: Estrutura que contém as informações da venda.
        data: Dado de cadastro da venda.
        valor:  Dado de cadastro da venda.
   Produto: Estrutura que contém as informações do Produto
        nome: Dados de cadastro do produto.
        valor: Dado de cadastro do produto.
   ClienteBD: Entidade responsável por acessar a base de dados do cliente.
   VendaBD: Entidade responsável por acessar a base de dados da venda.
   ProdutoBD: Entidade responsável por acessar a base de dados do produto.
        
## 2.    Projeto de Sistemas:
### 2.1  Projeto Arquitetural 
#### 2.1.1   Plataforma de Implementação e Tecnologias
Foi utilizada a linguagem de programação C#: Uma linguagem de fácil entendimento e intuitividade. Possui um ótimo IDE.
Foi utulizada a base de dados SQLite: Sistema requer uma pequena quantidade de dados estará disponível na máquina do cliente sem precisar estar em um servidor online.

#### 2.1.2   Atributos de Qualidade e Táticas
 CATEGORIAS | RNF'S | TÁTICAS | 
| --- | --- | --- |
| Facilidade de Operação |RNF01, RNF03, RNF05| Prover ao usuário a capacidade de entrar com comandos que permitam operar o sistema de modo mais eficiente. Para tal, as interfaces do sistema devem permitir, sempre que possível, um design de entendimento rápido e direto para que o usuário já insira suas informações. | 


#### 2.1.3   Arquitetura de Software
Diagrama de Arquitetura.

![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/Archtecture_Diagram.jpg?raw=true "Modelo Conceitual")

Foi aplicado o padrão MVC no HerbSys para que o código fonte do sistema fique bem organizado de maneira em que facilite manutenções futuras na camada de Interface com o Usuário sem comprometer os modelos de vice e versa. 

### 2.2. Projeto Detalhado
#### 2.2.1.   Projeto da Lógica de Negócio
##### Projeto do Domínio
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/ClassDiagram.jpg?raw=true "Modelo Conceitual")
##### Projeto da Aplicação
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/useCase.jpg?raw=true "Modelo Conceitual")
*** Falta Diagrama de Sequência  ***
#### 2.2.2.  Projeto da Interface com Usuário
##### Projeto da Visão
Diagrama de Classes:
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/ClassDiagram.jpg?raw=true "Modelo Conceitual")
Tela principal:
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/TelaPrincipal.jpg?raw=true "Modelo Conceitual")
Tela de cadastro de clientes:
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/TelaCadastrarUsuario.jpg?raw=true "Modelo Conceitual")


##### Projeto da Interação Humana
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/ClassDiagram.jpg?raw=true "Modelo Conceitual")
#### 2.2.3.  Projeto da Persistência de Dados
![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/ClassDiagram.jpg?raw=true "Modelo Conceitual")

#### 2.4.   Padrões
##### Padrões Arquiteturais
##### Padrões de Projeto

No diagrama abaixo é destacado o padrão MVC que organiza o código fonte do sistema e auxilia futuras manutenções ou mudanças de IU sem afetar a regra de negócio do sistema.

![Alt text](https://github.com/ascaugusto/HerbSys/blob/master/ClassDiagram.jpg?raw=true "Modelo Conceitual")


O padrão foi utilizado para resolver o problema de organização e manutenção.


## 3.    Banco de Dados (BD)


### 3.1 Decisões do Projeto 
    [atributo]: [descrição da decisão]
    
    EXEMPLO:
    a) Campo endereço: em nosso projeto optamos por um campo multivalorado e composto, pois a empresa 
    pode possuir para cada departamento mais de uma localização... 
    b) justifique!


### 3.2	Modelo Lógico<br>
### 3.3	MODELO FÍSICO<br>
### 3.4	INSERT APLICADO NAS TABELAS DO BANCO DE DADOS<br>
#### 3.4.1 DETALHAMENTO DAS INFORMAÇÕES
        Detalhamento sobre as informações e processo de obtenção ou geração dos dados.
        Informar/referenciar todas as fontes usadas para:
        a) obtenção dos dados
        b) obtenção de códigos reutilizados (caso tenha feito uso destes)
        c) fontes de estudo para desenvolvimento do projeto
        
#### 3.4.2 INCLUSÃO DO SCRIPT PARA CRIAÇÃO DE TABELAS E INSERÇÃO DOS DADOS (ARQUIVO ÚNICO COM):
        a) inclusão das instruções para criação das tabelas e estruturas de amazenamento do BD
        b) inclusão das instruções de inserção dos dados nas referidas tabelas
        c) inclusão das instruções para execução de outros procedimentos necessários

### 3.5	TABELAS E PRINCIPAIS CONSULTAS<br>
#### 3.5.1	GERACAO DE DADOS (MÍNIMO DE 1,5 MILHÃO DE REGISTROS PARA PRINCIPAL RELAÇAO)<br>
    Data de Entrega: (Data a ser definida)
<br>
OBS: Incluir para os tópicos 3.5.2 e 3.5.3 as instruções SQL + imagens (print da tela) mostrando os resultados.<br>

#### 3.5.2	SELECT DAS TABELAS COM PRIMEIROS 10 REGISTROS INSERIDOS<br> 
    Data de Entrega: (Data a ser definida)
<br>
#### 3.5.3	SELECT DAS VISÕES COM PRIMEIROS 10 REGISTROS<br>
        a) Descrição da view sobre que grupos de usuários (operacional/estratégico) <br>
        e necessidade ela contempla.
        b) Descrição das permissões de acesso e usuários correlacionados (após definição <br>
        destas características)
    Data de Entrega: (Data a ser definida)
<br>
#### 3.5.4	LISTA DE CODIGOS DAS FUNÇÕES, ASSERÇOES E TRIGGERS<br>
        Detalhamento sobre funcionalidade de cada código.
        a) Objetivo
        b) Código do objeto (função/trigger/asserção)
        c) exemplo de dados para aplicação
        d) resultados em forma de tabela/imagem
<br>
#### 3.5.5	Administração do banco de dados<br>
        Descrição detalhada sobre como serão executadas no banco de dados as <br>
        seguintes atividades.
        a) Segurança e autorização de acesso:
        b) Estimativas de aquisição de recursos para armazenamento e processamento da informação
        c) Planejamento de rotinas de manutenção e monitoramento do banco
        d) Plano com frequencia de análises visando otimização de performance
<br>
#### 3.5.6	Backup do Banco de Dados<br>
        Detalhamento do backup.
        a) Tempo
        b) Tamanho
        c) Teste de restauração (backup)
        d) Tempo para restauração
        e) Teste de restauração (script sql)
        f) Tempo para restauração (script sql)
<br>

#### 3.5.7	APLICAÇAO DE ÍNDICES E TESTES DE PERFORMANCE<br>
    a) Lista de índices, tipos de índices com explicação de porque foram implementados
    b) Performance esperada VS Resultados obtidos
    c) Tabela de resultados comparando velocidades antes e depois da aplicação dos índices.
<br>
    Data de Entrega: (Data a ser definida)
<br>   
#### 3.5.8	ANÁLISE DOS DADOS COM ORANGE<br>    
    a) aplicação de algoritmos e interpretação dos resultados
<br>
    Data de Entrega: (Data a ser definida)
<br>
### 3.6	ATUALIZAÇÃO DA DOCUMENTAÇÃO/ SLIDES E ENTREGA FINAL<br>
<br>
    Data de Entrega: (Data a ser definida)
<br>
### 3.7	DIFICULDADES ENCONTRADAS PELO GRUPO<br>  




# Gestão de Configuração
## 1.    Metodologia
descrever metodologias e políticas que serão usadas para realizar a gestão de configuração como, por exemplo, Gitflow, rastreabilidade de requisitos e mudanças. É necessário descrever em detalhes os procedimentos.
## 2.    Arquitetura
descrever ferramentas e a integração dessas para a arquitetura. 
## 3.    Integração Contínua e Delivery Contínua
Descrever como será aplicado esses conceitos.

# Gestão de Projetos
## 1.    Project Model Canvas (PMC)
Visão geral do projeto.
## 2.    Cronograma macro de sprints 
datas dos sprints.
## 3.    Backlog de histórias de Usuário 
lista de histórias de usuário categorizadas, priorizadas e com o esforço. A categorização deve utilizar a técnica MoSCoW. 
Acompanhamento do projeto: o grupo deve apresentar histórico, por sprint,  do acompanhamento do projeto da seguinte forma:
- Apresentando o Burndown do projeto.
- Apresentando a velocidade do time.
- Modificações do backlog.
## 4.    Burn down dos sprints
acompanhamento dos sprints. Cada Sprint deve ter uma seção descrevendo o que foi realizado e o planejado (por meio do  o gráfico e Burndown do Sprint).
## 5.    Retrospectiva 
Apresentar a retrospectiva da equipe do sprint realizado.

# Gerência de Qualidade
## 1.    Métricas de qualidade 
definir métricas de qualidade para cada artefato do projeto como, por exemplo, quantidade de codesmell, complexidade ciclomática e outras. 
## 2.    Classes de equivalência e particionamento de equivalência 
defina as classes de equivalências para as métricas de qualidade. 

## 3.    Medição 
seção que escreve como as métricas estão sendo atingidas. Essa seção deve ser atualizada por sprint. 
## 4.    Testes
Técnicas utilizadas para os testes: apresentar as técnicas utilizadas para o planejamento e execução de testes como, por exemplo, teste funcional sistemático e testes estruturais. 
## 5.    Cenário de Teste
apresentar todos os cenários de teste sucesso e falhas das histórias de usuário.  
## 6.    Histórico  
O grupo deve apresentar a evolução da qualidade dos itens ao longo das entregas, ou seja, em outras palavras, o grupo deve apresentar o histórico de evolução da qualidade dos artefatos de software e discursar o motivo da evolução.

# Diário de Bordo

o grupo deve apresentar semanalmente um relato da atividade do grupo. O relato pode conter qualquer tipo de informação (fotos, vídeos) que possam auxiliar no entendimento das atividades do grupo. 

OBS: organize o diário para que não se misture com a documentação. de preferência, coloque-o em outra página.

**FORMATACAO NO GIT:** https://help.github.com/articles/basic-writing-and-formatting-syntax/
