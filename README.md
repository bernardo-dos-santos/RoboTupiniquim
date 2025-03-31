# Rob� Tupiniquim
![](https://i.imgur.com/wyM0H52.gif)
## Introdu��o 
O Projeto Robo Tupiniquim, � um programa onde o o usu�rio manda comandos de movimenta��o para o rob� tupiniquim em uma certa �rea  
## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio)](https://skillicons.dev)
## Detalhes
O sistema solicita ao usu�rio digitar uma certa �rea, a posi��o inical e quais movimenta��es realizar para o 1� e do 2� rob�, em seguida � mostrada a posi��o atual dos rob�s

## Funcionalidades
**Tratamento de Entrada** - O sistema ir� mandar uma mensagem caso o usu�rio digite alguma informa��o incorreta, solicitando o dado novamente

**Dire��es** - Os rob�s tem capacidade para se moverem nos sentidos Norte, Sul, Leste e Oeste, onde sua limita��o � a "borda" do mapa, estipulada pelo usu�rio

**Comandos de Movimento** - O usu�rio possui acesso a tr�s comando de movimento: E - virar a esquerda; D - virar a direita; M - Continuar em frente

**Fim da �rea** - Caso o Rob� chegue ao final da �rea e tente ultrapassa-l�, � mandando uma mensagem de erro, e solicitado os comandos novamente ao usu�rio

**La�o de Repeti��o** - Caso o usu�rio deseje, � poss�vel realizar a mesma opera��o infinitas vezes que desejar

## Requisitos para uso
.NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto

## Como utilizar
Clone o Reposit�rio
```
git clone https://github.com/bernardo-dos-santos/RoboTupiniquim
```
Navegue at� a pasta raiz da solu��o
```
cd RoboTupiniquim
```
Restaure as depend�ncias
```
dotnet restore
```
Navegue at� a pasta do projeto
```
cd RoboTupiniquim.ConsoleApp
```
Execute o projeto
```
dotnet run
```