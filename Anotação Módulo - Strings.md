**GUIDS** (Identificador) - Identificador único, cria uma hash que não se repete.
- Guid.NewGuid() - Para gerar um guid

**Interpolação -** Uma forma de colocarmos valores nas nossas string.
**Exemplo:** var texto = “O preço do produto é ” + variavel
- var texto = string.format(”O preço do produto é {0}”, variavel) 
- var texto = $”O preço do produto é {variavel}”

**Comparação de strings -** Uma forma de comparar os valores dentro de um string.
**Exemplo:** 
- var texto = “Testando”;
- var teste = texto.compareTo(”Testando”); 
- var teste = texto.Contains(”Testando”);
- var teste = texto.Contains(”Testando”, stringcomparison.ordinalignorecase);  //Para ignorar o case sensitive.

**StarsWith/EndsWith -** Verifica se o texto começa com o parametro informado ou se termina com com o parametro informado.
**Exemplo:** 
- var texto = “Este texto é um teste”;
- var teste = texto.**StartsWith**(”Este”);  /Resultado é **True** 
- var teste = texto.**StartsWith**(”texto”);  /Resultado é **False**
- var teste = texto.**EndsWith**(”Este”);  /Resultado é **False**
- var teste = texto.**EndsWith**(”teste”);  /Resultado é **True** 

**Equals -** Compara se os textos são iguais.
**Exemplo:** 
- var texto = “Este texto é um teste”;
- var teste = texto.**Equals**(”Este texto é um teste”);  /Resultado é **True** 
- var teste = texto.**Equals**(”Este este”);  /Resultado é **False**

**Indices -** Indica uma posição de um caracter dentro de uma lista ou array, quando a letra se repete se for com IndexOf pega a primeira e usa o LastIndexOf pega a ultima posição.
**Exemplo:** 
- var texto = “Este texto é um teste”;
- var teste = texto**.IndexOf**(”é”);  /Resultado a letra “é” esta na posição 11 da nossa string texto
- var teste = texto**.LastIndexOf**(”s”); 

**Metodos Adicionais -** ToUpper (Converte o texto todo para maiuscula) ou ToLower converte o texto todo para minuscula.
**Exemplo:** 
- var texto = “Este Texto é um Teste”;
- var teste = texto**.ToUpper()**; 
- var teste = texto**.ToLower()**; 
- var teste = texto**.Insert(5, “Aqui”)**; /Adiciona o texto “Aqui” depois da quinta posição 
- var teste = texto**.Remove(5, 5)**; /Depois da quinta posição remove os proximos 5 caracteres
- var teste = texto**.Length()**; /Conta a quantidade de caracteres do texto 
- var teste = texto**.Replace(”Este”, “Isto”)**; /Troca no texto a palavra Este por Isto
- var teste = texto**.Split(” ”)**; /Separa o texto de acordo com o parametro, nesse caso a cada espaço vai virar um texto diferente, se eu passase virgula e o texto tivesse virgula ele iria separar em textos - diferentes a cada virgula
- var teste = texto**.SubString(5, 5)**; /Vai ate a posição 5 e pega os proximos 5 caracteres
- var teste = texto**.Trim()**; /Remove os espaços no começo e no fim do texto.

**StringBuilder -** Por questão de performance e não estourar memória sempre que precisarmos ficar concatenando muita informação em um texto podemos utilizar o StringBuilder pois ele irá ficar fazendo dentro da mesma variavel e não criando uma nova.