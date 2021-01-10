<p align="center">
<img width="200" src="docs/images/test-icon.png">
</p>
<h1 align="center">Desafios TDD</h1>
<h4 align="center">Projeto com 3 desafios diversos, com o foco no desenvolvimento guiado por testes (TDD). Desenvolvido no programa Start, da GFT Brasil</h4>

# 🏆 Desafios

- [X] [**Exercícios de POO**](https://git.gft.com/lscc/desafio-tdd/-/tree/master/Desafio1)

- [X] [**Jokenpo**](https://git.gft.com/lscc/desafio-tdd/-/tree/master/Desafio2)

- [X]  [**(Extra) Linguagem de Celular**](https://git.gft.com/lscc/desafio-tdd/-/tree/master/Desafio3)

# 🤔 Curiosidades

### O que é TDD?
Test Driven Development (TDD) ou em português Desenvolvimento guiado por testes é uma técnica de desenvolvimento de software que se relaciona com o conceito de verificação e validação e se baseia em um ciclo curto de repetições: Primeiramente o desenvolvedor escreve um caso de teste automatizado que define uma melhoria desejada ou uma nova funcionalidade

### O que é o programa Start?

Criado pela GFT, o Programa START foi concebido com o objetivo de formar e desenvolver jovens profissionais segundo os valores e competências da GFT. Durante o estágio, os STARTERS, como nossos estagiários são chamados, irão passar por diferentes etapas, de forma a se tornar um profissional preparado a enfrentar os mais diversos desafios.

# 📐 Arquitetura

A arquitetura dos desafios é basicamente dividida em duas camadas:

#### 📁 Src
* Contem todo o código fonte do desafio

#### 🧪 Tests
* Contem todos os testes de unidade do desafio

# 🧪 Executando os Testes

###  Desafio 1 - Exercícios de POO
```bash
# Entre nos Testes do Desafio:
$ cd Desafio1/tests/

# Escolha o exercício que deseja testar, e entre no projeto do mesmo:
$ cd Exercicio1.Tests/

# Digite o comando a seguir, para restaurar as dependências:
$ dotnet restore

# Por ultimo, digite o comando para testar:
# (Obs: o código abaixo possui parâmetros que ajudam a visualização)
$ dotnet test -l "console;verbosity=detailed"
```

###  Desafio 2 - Jokenpo
```bash
# Entre nos Testes do Desafio:
$ cd Desafio2/tests/

# Digite o comando a seguir, para restaurar as dependências:
$ dotnet restore

# Por ultimo, digite o comando para testar:
# (O código abaixo possui parâmetros que ajudam a visualização)
$ dotnet test -l "console;verbosity=detailed"
```

###  (Extra) Desafio 3 - Linguagem de Celular
```bash
# Entre nos Testes do Desafio:
$ cd Desafio3/tests/

# Digite o comando a seguir, para restaurar as dependências:
$ dotnet restore

# Por ultimo, digite o comando para testar:
# (O código abaixo possui parâmetros que ajudam a visualização)
$ dotnet test -l "console;verbosity=detailed"
```


# 💡 Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- [DotNet Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
 - [xUnit](https://xunit.net/)
- [Bogus](https://github.com/bchavez/Bogus)


<hr>

<img width="200" src="docs/images/gft-logo.png">

