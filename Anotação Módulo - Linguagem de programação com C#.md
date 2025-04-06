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

**Números inteiros -** São os numeros sem pontuação podem ser definidos pelos tipos *short/ushort int/uint, long/ulong.* Os tipos que começam com *U* significam que são *UNSIGNED* e não poderam receber valores negativos.

**Números Reais -** São os números que tem ponto flutuante, podem ser os tipos *float (Notação F), double, decimal  (Notação M),* possuem assimilação negativa e positiva por padrão, dispensando o uso do signed/unsioigned em seus tipos.

**Object -** Ela funciona como se fosse uma variavel no javascript será uma variavel que irá receber qualquer tipo de dado, diferente do var que irá receber somente dados de acordo com o inserido na inicialização da variável.

**void -** siginifica que não terá retorno dentro daquela método.

**Conversão Implícita -** As implícitas são conversões que podem ser executadas apenas com passagem de dados, possuem tipos compatívies, a conversão so ocoirre se o tipo de dado for compativel.
