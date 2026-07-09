# 📓 Caderno de Estudos - C# & Lógica de Programação

Este caderno é o seu guia de revisão. Aqui você encontrará os conceitos explicados, vocabulário essencial em inglês destacado e links úteis de referência.

---

## 🚀 Capítulo 1: Estrutura Básica & Exibição de Dados

### 02. Baby Names (Estrutura do Programa)
* **Conceito:** Todo programa C# precisa de uma estrutura padrão contendo uma **classe** (`class`) e um **método principal** (`Main`).
* **Vocabulário em Inglês Importante:**
  * **`Class` (Classe):** Uma "caixa" ou "bloco" que organiza o seu código.
  * **`Method` (Método):** Um bloco de código que executa uma ação. O `Main()` é o método principal.
  * **`Statement` (Instrução):** Uma linha de código terminada em `;` (ponto e vírgula).
  * **`Curly Braces` (Chaves `{ }`):** Símbolos usados para delimitar onde começa e termina um bloco de código.
  * **`Output` (Saída):** A resposta/resultado exibida na tela do computador.
* **Referência:** 
  * [Documentação da estrutura básica do C# (Microsoft)](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/inside-a-program/hello-world-your-first-program)

---

### 03. Dream Journal (Textos de Múltiplas Linhas)
* **Conceito:** O comando `Console.WriteLine()` exibe o texto no console e move o cursor automaticamente para a linha de baixo.
* **Vocabulário em Inglês Importante:**
  * **`Multi-line` (Múltiplas linhas):** Código ou texto que se estende por mais de uma linha.
  * **`To print` (Imprimir):** No mundo da programação, significa "exibir na tela", não necessariamente em papel.
* **Vídeo de Referência (Meme clássico citado no exercício):** 
  * [Youtube - Kid saying: Have you ever had a dream...](https://www.youtube.com/watch?v=G7RgN9ijwE4)

---

### 04 & 05. Hot Take & Personal Billboard (Comentários)
* **Conceito:** Comentários servem para explicar o código para outros humanos (ou para você mesmo no futuro). O computador ignora tudo dentro deles.
  * `//` para comentários de **uma única linha**.
  * `/* ... */` para comentários de **múltiplas linhas** (ótimo para artes ASCII!).
* **Vocabulário em Inglês Importante:**
  * **`Comment` (Comentário):** Notas escritas no código ignoradas pelo compilador.
  * **`Ignore` (Ignorar):** O computador pula essa instrução.
  * **`ASCII Art` (Arte ASCII):** Desenhos feitos usando apenas caracteres de texto.
* **Referência:**
  * [Como usar comentários em C# (Microsoft)](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/lexical-structure#62-comments)

---

## 📊 Capítulo 2: Variáveis & Tipos de Dados

### 07. Typecast (Variáveis e Tipos)
* **Conceito:** Uma variável é uma caixa na memória onde guardamos um dado sob um rótulo. Cada variável tem um tipo específico.
* **Os 4 Tipos Básicos Praticados:**
  1. **`string` (Texto):** Armazena sequências de caracteres (ex: `"Action"`). Deve estar entre aspas duplas.
  2. **`int` (Inteiro):** Números inteiros sem casas decimais (ex: `1`, `0`, `-3`).
  3. **`double` (Decimal):** Números com casas decimais (ex: `57.9`). *Nota: Em inglês chama-se "floating-point number" (número de ponto flutuante).*
  4. **`bool` (Booleano):** Tipo lógico que só guarda verdadeiro (`true`) ou falso (`false`).
* **Vocabulário em Inglês Importante:**
  * **`Data Type` (Tipo de Dado):** A classificação do valor da variável.
  * **`Whole number` (Número inteiro):** Número sem decimais.
  * **`Floating-point` (Ponto flutuante):** Número que usa ponto para separar frações (casas decimais).
  * **`To assign` (Atribuir/Definir):** O ato de colocar um valor dentro da variável usando o sinal `=`.
* **Referência:**
  * [Tipos internos do C# (Microsoft)](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/built-in-types)

---

### 07. Party Animal (Declarar e Inicializar)
* **Conceito:** Para usar uma variável, precisamos **declarar** (dizer o tipo e o nome) e **inicializar** (dar um valor inicial usando o operador `=`). Em C#, as variáveis booleanas (`bool`) aceitam apenas `true` ou `false` em letras minúsculas.
* **Boas Práticas de Nomenclatura (Naming Conventions):**
  * **`camelCase`:** Começar com letra minúscula e capitalizar a primeira letra das palavras seguintes (ex: `partyTheme`, `guestNumber`).
  * **`Case-sensitive`:** Diferenciação de letras maiúsculas e minúsculas (ex: `True` é diferente de `true`).
* **Vocabulário em Inglês Importante:**
  * **`To declare` (Declarar):** Criar a variável definindo o tipo e o nome.
  * **`To initialize` (Inicializar):** Atribuir um valor inicial para a variável.
  * **`Case-sensitive` (Sensível a maiúsculas/minúsculas):** O sistema diferencia letras maiúsculas de minúsculas.
  * **`Keywords` (Palavras-chave):** Palavras reservadas da linguagem que não podem ser usadas como nome de variáveis (ex: `int`, `double`, `class`).

---

### 08. Celebrity Crush (Concatenar Variáveis e Strings)
* **Conceito:** Podemos combinar variáveis e textos fixos dentro de um único `Console.WriteLine` usando o operador de adição (`+`). Esse processo é chamado de **Concatenação de Strings** (*String Concatenation*).
* **Vocabulário em Inglês Importante:**
  * **`String Concatenation` (Concatenação de Strings):** O ato de juntar dois ou mais textos (ou variáveis) para formar uma nova mensagem combinada.
  * **`To log` (Registrar/Exibir):** Na programação, significa registrar uma informação para visualização no console ou arquivo de log.
  * **`Whitespace` (Espaço em branco):** Os espaços de texto que usamos para que as palavras não fiquem coladas umas nas outras.
* **Referência:**
  * [Concatenação de Strings em C# (Microsoft)](https://learn.microsoft.com/pt-br/dotnet/csharp/how-to/concatenate-multiple-strings)

---

### 09. Math Is Mathing (Operações Matemáticas & Resto)
* **Conceito:** O C# segue a ordem matemática padrão de precedência (PEMDAS). Além disso, a divisão de números inteiros descarta as frações, e o operador **Módulo (`%`)** calcula o resto (as sobras) de uma divisão inteira.
* **Ordem de Operações (PEMDAS / BODMAS):**
  1. **P**arênteses `()`
  2. **E**xpoentes `**` (ou funções de potência)
  3. **M**ultiplicação `*` / **D**ivisão `/` / **M**ódulo `%` (mesma prioridade, esquerda para direita)
  4. **A**dição `+` / **S**ubtração `-`
* **Vocabulário em Inglês Importante:**
  * **`PEMDAS`:** Sigla para *Parentheses, Exponents, Multiplication, Division, Addition, Subtraction*.
  * **`Modulo` (Módulo):** O operador `%` que calcula o resto da divisão.
  * **`Remainder` (Resto/Sobra):** O valor que "sobra" após uma divisão inteira.
  * **`Integer Division` (Divisão Inteira):** Divisão entre inteiros que resulta em um número inteiro truncado (ex: `23 / 5` resulta em `4`).
* **Referência:**
  * [Operadores aritméticos em C# (Microsoft)](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators)

---

### 10. Year of the X (Entrada de Usuário & Conversão)
* **Conceito:** O comando `Console.ReadLine()` lê dados digitados pelo usuário como um texto (`string`). Se precisarmos desses dados em formato numérico para fazer contas matemáticas, usamos o `int.Parse()` para converter de `string` para `int`. Além disso, aprendemos sobre Arrays/Vetores (`string[]`) para armazenar listas de valores ordenados.
* **Vocabulário em Inglês Importante:**
  * **`User Input` (Entrada do Usuário):** Dados enviados pelo usuário para o programa através do teclado.
  * **`To convert` (Converter):** Mudar o tipo de dado de um valor (ex: texto para número).
  * **`To parse` (Analisar/Converter):** O processo de ler um texto e convertê-lo em outro tipo de dado mais estruturado (ex: `int.Parse()`).
  * **`Array` (Vetor/Matriz):** Uma estrutura que armazena uma coleção de elementos do mesmo tipo acessíveis por um índice (começando em 0).
* **Referência:**
  * [Entrada e saída do Console em C# (Microsoft)](https://learn.microsoft.com/pt-br/dotnet/csharp/tutorials/console-telemetry)

---

### Extra. Giant Plushie (Resgatar Prêmios com Tickets)
* **Conceito:** Prática integrada de entrada de dados, conversão de tipo (`string` para `int`) e uso de divisão inteira (`/`) combinada com resto de divisão (`%`) para simular o resgate de brindes em um sistema de arcade.
* **Vocabulário em Inglês Importante:**
  * **`Plushie` (Pelúcia):** Boneco de pelúcia usado como brinde.
  * **`To redeem` (Resgatar):** Trocar tickets ou pontos por um prêmio.
  * **`Leftover` (Sobra / Restante):** O valor que sobra após o cálculo (equivalente ao operador `%`).





