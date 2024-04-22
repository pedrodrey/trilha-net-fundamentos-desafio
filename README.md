# DIO - Estacionamento - Trilha .NET


## Sobre o projeto 📚
Este projeto foi proposto no Bootcamp .NET Developer da [DIO](www.dio.me), na trilha "Fundamentos .NET".

A proposta inicial era construir um sistema para um estacionamento, para gerenciar os veículos estacionados e realizar suas operações.

Tendo as funções: adicionar veículo, remover veículo (e exibir o valor cobrado durante o período) e listar os veículos, a partir de um código que estava pela metade.

O Diagrama da proposta inicial, se encontra no diretório do projeto.


## Implementações ✨
Além das implementações necessárias para que a aplicação funcionasse de acordo com a proposta inicial, foram feitas outras implementações adicionais para que o programa ficasse mais completo.

Dentre essas implementações estão:
  - Criação da classe: "Veiculo";
  - Criação de Construtores para a classe "Veiculo";
  - Alterações na classe "Estacionamento", para obter informações da classe "Veiculo";
  - Implementação do projeto de testes unitários xUnit.

Na criação da classe Veiculo, todas as informações do veículo e do condutor foram transferidas para esta classe, deixando o código mais organizado e limpo.
Antes a única informação sobre o veículo era a numeração da placa, que estava declarada na classe "Estacionamento", agora além da placa, todas as informações do veículo estão na sua respectiva classe.

Além das alterações nas classes e constrtures do veículo, também foram implementados testes unitários xUnit, para validar a placa e também dados nulos ou vazios.

## Como funciona? 🤔
Para executar a aplicação, basta utilizar a IDE da sua preferência, Ex: Visual Studio ou Visual Studio Code.

**Abaixo, segue exemplo para a execução da aplicação no Visual Studio:**

**Passo 1:** No Visual Studio, clique no botão "Run"(destacado em vermelho), ou na tecla "F5" do teclado para executar a aplicação:

![image](https://github.com/pedrodrey/trilha-net-fundamentos-desafio/assets/158003477/8835c69f-e632-40ce-8514-1dbd80a5dbf7)

**Passo 2:**

Após isso será aberta uma janela do Console, executando a aplicação. Inicialmente será solicitado a entrada de dados referente ao preço inicial e preço por hora dos veículos a serem estacionados.

![image](https://github.com/pedrodrey/trilha-net-fundamentos-desafio/assets/158003477/31bfc70f-424f-4eb0-93dc-046cccb2e16f)

**Passo 3:**

Em seguida, será aberto o menu inicial contendo 4 opções. Na imagem abaixo, é realizado o cadastro do veículo (opção 1).
![image](https://github.com/pedrodrey/trilha-net-fundamentos-desafio/assets/158003477/3070cfd0-6cdb-4b3f-bd25-03bce4b1d519)

**Passo 4:**

Após cadastrar um veículo, é possivel visualizar as informações do mesmo na opção 3 "Listar Veiculos":
![image](https://github.com/pedrodrey/trilha-net-fundamentos-desafio/assets/158003477/bffb2745-6637-4894-96f4-532778f5dad2)

**Passo 5:**

Por fim, para remover um veículo basta selecionar a opção 2 "Remover Veiculo", informando a placa do veículo a ser removido. Para encerrar o programa basta selecionar a opção 4.
![image](https://github.com/pedrodrey/trilha-net-fundamentos-desafio/assets/158003477/ba39201b-4813-48e4-ab0e-371aac75c27c)


## Executando Testes xUnit ✅

Para executar as validações dos testes unitários, clique na aba "Test" e em seguida selecione a opção "Test Explorer":

![image](https://github.com/pedrodrey/trilha-net-fundamentos-desafio/assets/158003477/ac46ac9d-45ab-48ba-b9ec-93c17fb282a7)

Após isso, clique no botão "Run" para rodar os testes:

![image](https://github.com/pedrodrey/trilha-net-fundamentos-desafio/assets/158003477/2dfd8755-bc59-43e9-abc4-898e333b150b)

Por fim, serão exibidos os resultados dos testes na tela:
![image](https://github.com/pedrodrey/trilha-net-fundamentos-desafio/assets/158003477/a6129be8-4a70-4d72-9762-76e78ce8bc88)


## Links Úteis🔗

Download [Visual Studio](link)

Download [Visual Studio Code](https://code.visualstudio.com/docs/?dv=win)
