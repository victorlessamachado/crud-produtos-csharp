# CRUD de Produtos em C#

## Sobre o projeto

 Este projeto consiste em um sistema CRUD para gerenciamento de produtos,
desenvolvido em C# como prática de lógica de programação e algoritmos.
 O projeto foi desenvolvido sem utilização de Programação Orientada a Objetos (POO),
com foco no aprendizado de estruturas de controle, coleções, validações e regras
de negócio.

## Funcionalidades

- Cadastrar produtos
- Listar produtos
- Filtrar produtos por marca
- Filtrar produtos por segmento
- Alterar produtos
- Remover produtos
- Menu interativo
- Validação de entradas

## Dados dos produtos

Cada produto possui:

- Nome
- Segmento
- Marca
- Valor

## Tecnologias e conceitos utilizados

- C#
- .NET
- `List<T>`
- `if / else if / else`
- `switch`
- `for`
- `do while`
- `TryParse`
- `Trim()`
- `IsNullOrWhiteSpace()`
- `ToLower()`
- `RemoveAt()`

## Estrutura de dados

Foi utilizada a estrutura `List<T>` para armazenar os produtos.

A escolha da `List<T>` foi feita por permitir uma coleção dinâmica e tipada,
facilitando operações como cadastro, acesso por índice e remoção de elementos,
sem a necessidade de definir previamente um tamanho fixo.

Foram utilizadas listas separadas para armazenar:

- Nome
- Segmento
- Marca
- Valor

As posições das listas representam o mesmo produto.

## Validações e regras de negócio

O sistema possui validações para melhorar a confiabilidade das entradas:

- Nome do produto não pode ficar vazio.
- Segmento não pode ficar vazio.
- Marca não pode ficar vazia.
- Espaços no início e no final são removidos.
- O valor precisa ser numérico.
- O valor precisa ser maior que zero.
- Pesquisas ignoram diferenças entre letras maiúsculas e minúsculas.
- O sistema informa quando não existem produtos cadastrados.
- O sistema informa quando um produto não é encontrado.
- Opções inválidas do menu são tratadas.

## Objetivo

Este projeto foi desenvolvido para consolidar os conhecimentos de lógica e
algoritmos em C#, servindo como primeiro projeto prático de CRUD.

O objetivo principal foi desenvolver a solução utilizando lógica de programação,
sem classes e objetos, como preparação para projetos futuros utilizando POO.