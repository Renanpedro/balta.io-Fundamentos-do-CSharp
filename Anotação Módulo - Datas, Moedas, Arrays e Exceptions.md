# Datas
**DateTime -** Tipo especifico do c# para datas
**var data = new DateTime(); -** a variavel data vai ter o valor default do tipo datetime 1/1/0001
**var data = new DateTime.Now -** Pega a data e hora atual
**var data = new DateTime(2025,04,14) -** Cria a data com base nos parametros passados
**Formatando a data para padrão brasileiro**
- var formatada = string.Format(”{0:dd-MM-yyyy hh:mm:ss z}”, data) - o z é para indicar o timezone.
- var formatada = string.Format(”{0:t}”, data) - Mostra somente a hora
- var formatada = string.Format(”{0:d}”, data) - Mostra somente a data sem as horas
- var formatada = string.Format(”{0:D}”, data) -Mostra a data por extenso
- var formatada = string.Format(”{0:f}”, data) - Mostra data e hora
- var formatada = string.Format(”{0:R}”, data) - Mostra a data apreviando o dia da semana
- var formatada = string.Format(”{0:u}”, data) - Mostra a data no padrão universal

**Adicionando valores em uma data**
**var data = datetime.Now;**
- data.AddDays(12) - Adiciona 12 dias na data
- data.AddDays(-12) - Subtrai 12 dias na data
- data.AddMonths(1) - Adiciona um mes na data
- data.AddYear(1) - Adiciona um ano

**Comparando datas**
**var data = datetime.Now;**
- if(data.Date == datetime.Now.Date )  - Posso alterar o == por <, >, ≠, ! e afins.
- console.Writeline(”As datas são iguais”)

**CultureInfo(Globalização)**
**var data = datetime.Now;**
- var **padraoEUA**= new cultureinfo(”en-US”);
- var atual = cultureinfo.CurrentCulture - Pega a cultura atual da máquina
- var dataFormatada = data.ToString(”D”, **padraoEUA**);

**TimeZone**
- var data = Datetime.UtcNow; - Irá pegar a data sem contar o timezone. seria o horário global.
- data.ToLocalTime() - Irá aplicar o timezone com base na localidade do servidor.

# Moedas
**decimal valor = 10.25m;** Decimal para ter mais precisão nas casas decimais
**valor.ToString(”C”, CultureInfo.CreateSpecificCulture(”pt-BR”));** - Alterando o valor para o padrão brasileiro. **C** padrão moeda **R$** dolar **$** depende do culture infomado, **G** coloca o separador de milhar, **F** coloca uma a casa a mais nos centavos, **N** formatada para numero sem o **R$**, **P** formata para porcentagem.

**Math-** Metodo de operações matematicas
- **Math.Round() -** Arredonda o valor para a media
- **Math.Ceiling() -** Arredonda o valor pra cima
- **Math.Floor() -** Arredonda o valor pra baixo

# Arrays (Objetos de Referência)
**Array(vetor) -** Lista de uma posição, posição inicial é o 0.
- var meuArray = new int[5];

**Percorrendo um array -** Para percorrer um array posso utilizar algum laço de repetição como **For**, **Foreach** e afins.

# Exceptions
**Exceptions -** Erros que não deveriam acontecer na aplicação, algo que não estava previsto ou mapeado.
**Try/Catch -** **Try** executa o que esta dentro dele e caso gere alguma execeção irá cair no **catch** para pegarmos o erro.
**Finally -** Após finalizar o try/catch sempre irá cair no finally caso eu declare ele. Posso utilizar isso para informar que um processo foi finalizado. Caso eu esteja lendo um arquivo e de uma exceção posso usar o finally para fechar o arquivo.