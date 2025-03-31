# Robô Tupiniquim
![](https://i.imgur.com/wyM0H52.gif)
## Introdução 
O Projeto Robo Tupiniquim, é um programa onde o o usuário manda comandos de movimentação para o robô tupiniquim em uma certa área  
## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio)](https://skillicons.dev)
## Detalhes
O sistema solicita ao usuário digitar uma certa área, a posição inical e quais movimentações realizar para o 1° e do 2° robô, em seguida é mostrada a posição atual dos robôs

## Funcionalidades
**Tratamento de Entrada** - O sistema irá mandar uma mensagem caso o usuário digite alguma informação incorreta, solicitando o dado novamente

**Direções** - Os robôs tem capacidade para se moverem nos sentidos Norte, Sul, Leste e Oeste, onde sua limitação é a "borda" do mapa, estipulada pelo usuário

**Comandos de Movimento** - O usuário possui acesso a três comando de movimento: E - virar a esquerda; D - virar a direita; M - Continuar em frente

**Fim da Área** - Caso o Robô chegue ao final da área e tente ultrapassa-lá, é mandando uma mensagem de erro, e solicitado os comandos novamente ao usuário

**Laço de Repetição** - Caso o usuário deseje, é possível realizar a mesma operação infinitas vezes que desejar

## Requisitos para uso
.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto

## Como utilizar
Clone o Repositório
```
git clone https://github.com/bernardo-dos-santos/RoboTupiniquim
```
Navegue até a pasta raiz da solução
```
cd RoboTupiniquim
```
Restaure as dependências
```
dotnet restore
```
Navegue até a pasta do projeto
```
cd RoboTupiniquim.ConsoleApp
```
Execute o projeto
```
dotnet run
```