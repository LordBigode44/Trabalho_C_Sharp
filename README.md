# Atividades Avaliativas - Programação em C#

## 👥 Integrantes do Grupo
- Ellison Erik Robertty Pedroso de Oliveira

---

## 📌 Questões Resolvidas

1. Validador de Senha
2. Tabuada
3. Fatorial
4. Conversor de Temperatura
5. Verificador de Palíndromo
6. Cadastro de Produtos
7. Soma de Números Pares
8. Cálculo de IMC
9. Jogo da Adivinhação
10. Lista de Tarefas

---

## 📝 Descrição Funcional de Cada Exercício

| Exercício | Descrição |
|----------|-----------|
| **ValidadorDeSenha.cs** | Verifica se a senha atende critérios de segurança (mínimo 8 caracteres, letra maiúscula, número, caractere especial). |
| **Tabuada.cs** | Mostra a tabuada de multiplicação de um número inserido. |
| **Fatorial.cs** | Calcula o fatorial de um número inteiro. |
| **ConversorTemperatura.cs** | Converte entre Celsius e Fahrenheit com base na escolha do usuário. |
| **VerificadorDePalindromo.cs** | Detecta se a entrada do usuário é um palíndromo. |
| **CadastroDeProdutos.cs** | Permite o cadastro de 3 produtos e calcula o valor total em estoque. |
| **SomaNumerosPares.cs** | Soma apenas os números pares de um conjunto de 10 valores informados. |
| **CalculoIMC.cs** | Calcula o IMC do usuário e exibe sua classificação conforme a faixa. |
| **JogoAdivinhacao.cs** | Jogo onde o usuário tenta adivinhar um número aleatório entre 1 e 100. |
| **ListaDeTarefas.cs** | Permite ao usuário adicionar tarefas a uma lista até digitar "sair". |

---

## 📚 Documentação Detalhada

### 1. Cálculo de IMC

**Objetivo:** Calcular o Índice de Massa Corporal (IMC) com base no peso e altura do usuário.

---

**🧠 Passo a Passo Lógico:**

1. O programa solicita ao usuário o **peso** (em kg).
2. Em seguida, pede a **altura** (em metros).
3. O cálculo é feito pela fórmula:

   \[
   \text{IMC} = \frac{\text{peso}}{(\text{altura} \times \text{altura})}
   \]

4. O resultado é classificado conforme as faixas:

   - Abaixo de 18.5: Abaixo do peso
   - Entre 18.5 e 24.9: Peso normal
   - Entre 25.0 e 29.9: Sobrepeso
   - 30.0 ou mais: Obesidade

---

**💻 Estruturas Utilizadas:**

- `Console.ReadLine()` e `double.Parse()` para entrada de dados.
- Operações aritméticas básicas.
- Condicional `if / else if / else` para classificar o IMC.

---

**✅ Justificativa:**

O IMC é amplamente utilizado como referência de saúde e é fácil de calcular com lógica básica. A aplicação permite que qualquer usuário insira seus dados e receba rapidamente um diagnóstico.

---

### 2. Gerenciador de Tarefas (Lista de Tarefas)

**Objetivo:** Criar uma lista de tarefas simples onde o usuário pode adicionar quantas quiser.

---

**🧠 Passo a Passo Lógico:**

1. Inicializa uma lista de strings (`List<string>`) para armazenar as tarefas.
2. Exibe um prompt pedindo uma nova tarefa.
3. Enquanto o usuário não digitar **"sair"**, a tarefa é adicionada à lista.
4. Ao sair, todas as tarefas são listadas no terminal.

---

**💻 Estruturas Utilizadas:**

- `List<string>` para armazenar múltiplas entradas.
- Estrutura de repetição `do-while` para permitir entrada indefinida.
- Comparação de strings usando `.ToLower()` para aceitar “Sair”, “SAIR” etc.
- `foreach` para exibir cada tarefa adicionada.

---

**✅ Justificativa:**

O uso de uma lista dinâmica permite ao usuário criar um número indefinido de tarefas. A lógica é simples, mas muito prática, funcionando como uma base para sistemas mais complexos de gerenciamento pessoal.
