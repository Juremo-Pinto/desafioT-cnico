# Desafio Técnico – Simulação de Batalha

## 📌 Descrição

Este projeto consiste em um programa desenvolvido em C# como parte do **Desafio Técnico (10 pontos)** do **Primeiro Trimestre** da disciplina **Linguagem de Programações**.

O objetivo do programa é simular uma batalha simples entre dois personagens, utilizando atributos básicos para determinar o vencedor com base em uma prova de resistência.

## 👥 Integrantes da Dupla

* Brayan
* Frederico

## ⚙️ Funcionamento do Programa

O sistema define dois personagens com os seguintes atributos:

* Nome
* Força
* Agilidade
* Inteligência
* Vida

Após a inicialização, o programa:

1. Exibe uma contagem regressiva para início da batalha
2. Mostra os atributos de ambos os personagens
3. Executa a função `provaResistencia`, que calcula:

   * Resistência total = Vida + Agilidade
4. Compara os valores de resistência dos dois personagens
5. Determina e exibe o vencedor

## 🧠 Lógica de Decisão

A função central do programa utiliza a seguinte regra:

* Se a resistência do Personagem 1 for maior → ele vence
* Caso contrário → o Personagem 2 vence

## ▶️ Exemplo de Execução

```
Iniciando batalha!
3!
2!
1!
Personagem 1: Gojo, Força: 18, Agilidade: 20, Inteligência: 20, Vida: 30
Personagem 2: Sukuna, Força: 20, Agilidade: 16, Inteligência: 21, Vida: 40
Em uma batalha estratégica, o vencedor foi: Sukuna!
```

## 🛠️ Tecnologias Utilizadas

* Linguagem: C#
* Plataforma: .NET

## 🎯 Objetivo Acadêmico

Este projeto tem como finalidade aplicar conceitos fundamentais de programação, incluindo:

* Declaração e uso de variáveis
* Estruturas condicionais (`if`, `switch`)
* Estruturas de repetição (`for`)
* Organização de código em funções
* Lógica de comparação e tomada de decisão

## 📎 Observações

O programa foi desenvolvido com foco em clareza e simplicidade, servindo como base para compreensão de lógica de programação e estrutura de aplicações em C#.
