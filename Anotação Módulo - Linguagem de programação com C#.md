# Linguagem de programação com C#

**Tipos de projetos** 
    **Class library -** o resultado final é uma DLL, não possui interface.
    **Console Aplication -** o resultado final é uma aplicação que roda no terminal, pode receber dados e esperar input do usuário.
    **Projeto Web -** O resultado final é uma aplicação com interface onde pode receber dados e o usuário pode interagir.
    **Projeto Testes -** o resultado final é um projeto que ao ser rodado irá fazer os testes das funcionalidades da aplicação.

**Namespace -** Divisão lógica é um contêiner que armazena uma coleção de identificadores, como variáveis, funções e classes. Ele ajuda a organizar e gerenciar o código, fornecendo uma maneira de evitar conflitos de nomes entre diferentes partes de um programa. Ao usar namespaces, os desenvolvedores podem criar código modular e reutilizável que é mais fácil de manter e depurar. Namespaces são comumente usados em linguagens de programação como C++, C# e Java.- São separações lógicas

**Using -** É utilizado para fazer as importações das bibliotecas sejam internas ou externas. Ela é feita no começo do programa.

**Variáveis -** É algo que utilzamos para armazenar uma informção, sempre que criamos uma variável dizemos que estamos inicializando ela. A primeira letra deve ser minuscula.

**Constantes -** Mesma coisa que variavel, porém elas não podem ter seus valores alterados apartir do momento que foi inicializada, são mais otimizadas que as variaveis, recomendadas para usos frequentes. Caso não seja informado um valor, ela vai assumir o valor padrão do tipo. Uma recomendação e sempre declarar elas em maisculas.

**Palavras Reservadas -** Não podemos utilizar esses nomes na criação de constantes, variaveis e afins. São palavras reservadas exclusivamente ao sistema. Ex: var, int, internal, continue, default, add...

**Tipos Primitivos -** Conhecidos como *built-in types* são os tipos básicos do c#, definir o tipo correto otimiza a execução do programa, armazenam o valor e nao a referência para um item na memória. São classificados em Tipos simples, Enumeradores, Estrruturas, Tipos Nulos.

Cada tipo possui uma capacidade e caso exceda o programa gera um erro, esta capacidade pré-definida ajuda na otimização do seu programa. 

**System -** Tipo base do .NET, todo e qualquer tipo seja built-in ou complexo derivam do system, ele é a base de todos os objetos do .NET, **seu uso já é implicíto.**

**Byte -** É utilizado para representar um byte de fato, caso precisamos da cadeia de bytres de um arquivo por exemplo iremos ter um rray de byte. Temos tbnm o sbyte que permite valores negativos.

**Números inteiros (Short, Int, Long) -** São os numeros sem pontuação podem ser definidos pelos tipos *short/ushort int/uint, long/ulong.* Os tipos que começam com *U* significam que são *UNSIGNED* e não poderam receber valores negativos.

**Números Reais (Float, Double, Decimal) -** São os números que tem ponto flutuante, podem ser os tipos *float (Notação F), double, decimal  (Notação M),* possuem assimilação negativa e positiva por padrão, dispensando o uso do signed/unsioigned em seus tipos.

**void -** siginifica que não terá retorno dentro daquela método.

**Boolean -** armazena apenas true ou false e é definido pela palavra reservada bool

**Char -** armazena apenas um caracter no formato unicode é definido pela palavra reservada **char**, a atribuição é dada por aspas simples.

**String -** Armazena uma cadeia de caracteres, definido pela palavra reservada **string**. A atribuição é feita por aspas duplas.

**Var -** Será do tipo do primeiro valor atribuído a ela, se o primeiro valor for uma string a variavel é do tipo string, se receber um int e é do tipo int e assim por diante. Apartir a atribuição inicial a variavel será eternamente daquele tipo.

**Object -** Tipo genérico que recebe qualquer valor ou objeto, funciona como se fosse o Var porém ela podera receber valores de diferentes tipos do iniciado. Não possui Intelisense por ser um tipo desconhecido. **EVITE USAR ESTE TIPO, USE SOMENTE EM ULTIMO CASO QUANDO NÃO SOUBER O VALOR QUE IRÁ RECEBER.**

**Nullable Types(?) -** Significa vazio ou nada, diferente de zero ou uma string vazia, todo tipo primitivo ou complexo pode receber o valor null, o tipo deve ser marcado como Nullable type. Podemos atribuir *null* a um objeto desde que o mesmo seja marcado com nullable (usando o **?** na frente), se uma chamada com um valor nulo for feita um erro será apresentado.

**Alias -** Alias é um apelido que todo tipo no .NET tem, por exemplo *System.String* tem o alias *string,* como o C# é Case Sensitive tanto faz escrevermos um ou outro porém o recomendo é sempre usar o alias, com alias escrevemos menos.

**Valores Padrões -** Todo tipo built-in(Tipo primitivo) já possui um valor padrão, se nenhum valor for informado o valor padrão sera utilizado.

**int** ⇒ 0 - **float** ⇒ 0 - **decimal** ⇒ 0 - **bool** ⇒ false - **char** = ‘\0’ ⇒ **string** = “”

**Conversão Implícita -** As implícitas são conversões que podem ser executadas apenas com passagem de dados, possuem tipos compatívies, a conversão so ocorre se o tipo de dado for compativel. A conversão no caso abaixo ocorreu pois um numero real pode receber um numero inteiro porém o contrario iria dar erro.

**Conversão Explicita -** Ocorre quando os tipos não são compativeis é dada pelo uso do tipo entre parenteses antes da atribuição.

**Parse -** Usado para converter um caractere ou string para um tipo qualquer, caso haja alguma incompatibilidade gera um erro.

**Convert -** Similar ao parse porém permite converter vários tipos de valor não apenas string, devemos informar o tipo na chamada da conversão.

**Operadores Aritméticos**
Soma ⇒ +
Subtração ⇒ -
Multiplicação ⇒ *
Divisão ⇒ /
Multiplicação e divisão são executadas primeiro, caso queira executar em outra ordem deve colocar entre parenteses.

**Operadores de Atibuição -** Utilizamos igual para atribuir um valor, porém podemos utilizar igual junto a um operador aritemético.

**Operadores de comparação -** Podemos comparar qualquer tipo de dado, a comparação sempre retorna *Verdadeiro* ou *Falso*.
- Igual ==
- Diferente ! =
- Maior que >
- Menor que <
- Maior ou igual a > =
- Menor ou igual que  < =

**Operadores Logicos** - São usados para operações condicionais, retorna sempre **Verdadeiro** ou **Falso**
- **&& (E)** - Deve atender todas as condições
- **|| (Ou) -** Se atende uma condição ja retorna verdadeiro
- **! (Negação) -** Nega o resultado da condição se der true vira false se der false vira true.

**Operador Condicional**
- **If** (Se) - “Caso alguma condição seja atendida”, caso não seja atendida ela pode ser complementada com **Else** e/ou **Else IF**. Não a limites de Else If porém por questão de perfomance não é bom utilizar várias.
- **Switch -** Utilizado quando temos muitas condições, executado em cascata devemos parar manualmente a execução com o comando **break**, Caso nenhum condição seja atendida ira cair na opção **Default**.

**Laços de repetição -** Irá repetir o código de acordo com uma determinada condição.
- **For -** Para cada item em um valor, executada uma determinada ação várias vezes, definido pela palavra for, exige 3 parametros (**Contador, Condição, Incremento**).
- **Sintaxe ⇒** for **(var int = 0; int ≤ 10;  i++)**

- **While -** Executa uma determinada ação **ENQUANTO** uma condição for verdadeira, exige apenas uma condição, checa a condição antes de executar.
- **Sintaxe ⇒** while(Valor ≤ 5) {}

- **do/while -** “Faça uma ação enquanto…” Executa o bloco que esta no **do** e só checa a condição depois, caso o **while** não atenda a condição volta para exeucar o **do** até o **while** atender a condição especificada.
- **Sintaxe ⇒** Do{} While(Condição) {}

**Métodos ou Funções -** Podemos segmentar nosso programa em funções, também conhecidos como metodos, **possui um retorno**(Nem sempre), **um nome** e **parametro**, esta composição é chamada de assinatura, começam sempre com maiuscula. O **main** é um exemplo de método. **Metodo == Função** são formas diferentes para se reverir a mesma coisa.