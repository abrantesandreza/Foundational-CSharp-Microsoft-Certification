// Combinar cadeias de caracteres usando sequências de escape de caracteres

Console.WriteLine("Generating invoices for costumer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Literal de cadeia de caracteres verbatim

Console.WriteLine(@"      c:\source\repos 
            (this is where your code goes)");

// Formatar a saída usando literais de cadeia de caracteres verbatim

Console.WriteLine("Generating invoices for costumer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.Write(@"c:\invoices");

// Caracteres de escape Unicode

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

/* Recapitulação
Veja o que você aprendeu sobre a formatação de cadeias de caracteres literais até agora:

- Use as sequências de escape de caractere quando precisar inserir um caractere especial em uma cadeia de caracteres literal, como uma tabulação \t, uma nova linha \n ou uma aspa dupla \".
- Use um caractere de escape para a barra invertida \\ quando precisar usar uma barra invertida em todos os outros cenários.
- Use a diretiva @ para criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço em branco e caracteres de barra invertida em uma cadeia de caracteres.
- Use o \u mais um código de quatro caracteres para representar caracteres Unicode (UTF-16) em uma cadeia de caracteres.
- Os caracteres Unicode podem não ser impressos corretamente dependendo do aplicativo. */

// Concatenar uma cadeia de caracteres literal e uma variável

string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

// Concatenar diversas variáveis e cadeias de caracteres literais

string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

/* Recapitulação
Veja o que você aprendeu sobre a concatenação de cadeias de caracteress até agora:

- A concatenação de cadeia de caracteres permite combinar cadeias de caracteres literais menores e variáveis em uma única cadeia de caracteres.
- Evite criar variáveis intermediárias se adicioná-las não aumentar a legibilidade.
 */

// Combinar cadeias de caracteres usando a interpolação de cadeias de caracteres

string message = greeting + " " + firstName + "!";
string message = $"{greeting} {firstName}!";

// Usar a interpolação de cadeia de caracteres com diversas cadeias de caracteres literais e variáveis

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

// Evitar variáveis intermediárias

int version = 11;
string updateText = "Update to Windows";
//string message = $"{updateText} {version}";
Console.WriteLine($"{updateText} {version}!");

// Combinar literais textuais e interpolação de cadeia de caracteres

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

/* Recapitulação
Veja o que você aprendeu até agora sobre a interpolação de cadeias de caracteres:

- A interpolação de cadeia de caracteres fornece uma melhoria na concatenação de cadeia de caracteres, reduzindo o número de caracteres necessários em algumas situações.
- Você pode combinar a interpolação de cadeias de caracteres e literais textuais combinando os símbolos para cada um e usando-o como um prefixo para o modelo de cadeia de caracteres.
 */

// Desafio: formatar e exibir instruções

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
    c:\Exercise\{projectName}\data.txt");

Console.WriteLine($@"{russianMessage}:
    c:\Exercise\{projectName}ru-RU\data.txt");

// Realizar adição com conversão implícita de dados

// adicionar dois valores numéricos

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber); // 19

// misturar tipos de dados para forçar as conversões de tipo implícitas

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets."); // Bob sold 7 widgets.

// tentar um caso mais avançado de adição de números e concatenação de cadeias de caracteres

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // Bob sold 77 widgets.

// Adicionar parênteses para esclarecer sua intenção ao compilador

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // OuBob sold 14 widgets.

// Executar operações matemáticas

// Escrever o código para realizar a adição, subtração, multiplicação e divisão com inteiros

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

/* Sum: 12
Difference: 2
Product: 35
Quotient: 1
 */

/*  Como você pode ver:

+ é o operador de adição
- é o operador de subtração
* é o operador de multiplicação
/ é o operador de divisão
 */

// Adicionar o código para realizar uma divisão usando dados decimais literais

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}"); // 1.4


// Incrementar e decrementar

int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.

/* Operadores como +=, -=, *=, ++ e -- são conhecidos como operadores de 
atribuição composta porque compõem uma operação além de atribuir o resultado à variável. 
O operador += é chamado especificamente de operador de atribuição de adição. */

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);


// First increment: 2
// Second increment: 3
// Third increment: 4
// First decrement: 3
// Second decrement: 2
// Third decrement: 1

// Usar o operador de incremento antes e depois do valor

int value = 1; // atribui
value++; // incrementa
Console.WriteLine("First: " + value); // 2
Console.WriteLine($"Second: {value++}"); // recupera o valor e atribui a variavel o inccremento - 2
Console.WriteLine("Third: " + value); // recupera o valor - 3
Console.WriteLine("Fourth: " + (++value)); // incrementa, primeiro, e recupera o valor incrementado - 4

// First: 2
// Second: 2
// Third: 3
// Fourth: 4

// Desafio: calcular em Celsius uma temperatura dada em Fahrenheit
int fahrenheit = 94;

double temperatureCelsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine($"The temperature is {temperatureCelsius} approximately."); 

// Saída: 
The temperature is 34 approximately.

// Microsoft
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");


// Exercício – Calcular a média das pontuações das tarefas do aluno

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

// Output
Student         Grade

Sophia:         94.6    A
Nicolas:        83.6    B
Zahirah:        83.4    B
Jeong:          95.4    A

// Calcular final GPA
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10 ) % 10;
int secondDigit = (int) (gradePointAverage * 100 ) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

// Output
Student: Sophia Johnson

Course              Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4

Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35

// Exercício – Criar lógica de decisão com instruções if

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

// Output
Dice roll: 3 + 6 + 1 = 10
Sorry, you lose.

// Output
Dice roll: 1 + 4 + 4 = 9
You rolled doubles! +2 bonus to total!
Sorry, you lose.

// Output
Dice roll: 5 + 6 + 4 = 15
You win!

// Output
Dice roll: 6 + 6 + 6 = 18
You rolled doubles! +2 bonus to total!
You rolled triples! +6 bonus to total!
You win!

/* Use uma instrução if para ramificar sua lógica de código. A instrução de decisão if executará o código em seu bloco de código se sua expressão booliana for verdadeira. Caso contrário, o runtime ignorará o bloco de código e continuará para a próxima linha de código após o bloco de código.
Uma expressão booliana é qualquer expressão que retorna um valor booliano.
Os operadores boolianos comparam os dois valores, à esquerda e à direita, em termos de igualdade, comparação e muito mais.
Um bloco de código é definido por chaves { }. Ele coleta linhas de código que devem ser tratadas como uma única unidade.
O operador lógico AND && agrega duas expressões de forma que as duas subexpressões devam ser verdadeiras para que toda a expressão seja verdadeira.
O operador lógico OR || agrega duas expressões de forma que, se alguma das subexpressões for verdadeira, toda a expressão será verdadeira.
 */

 Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

// As instruções if, else if e else permitem criar várias condições exclusivas como expressões boolianas. Em outras palavras, quando quiser que apenas um resultado aconteça, mas tiver várias condições e resultados possíveis, use quantas instruções else if você quiser. Se as instruções if e else if não se aplicarem, o bloco de código else final será executado. O else é opcional, mas deve ficar por último se você optar por incluí-lo.

/* A combinação de instruções if e else permite testar uma condição e executar um dos dois resultados possíveis. O bloco de código de if será executado quando a expressão booliana for true, e o bloco de código de else será executado quando a expressão booliana for false.
Você pode aninhar instruções if para restringir uma condição possível. No entanto, considere o uso das instruções if, else if e else.
Use instruções else if para criar várias condições exclusivas.
O else é opcional, mas deve sempre ficar por último quando utilizado. */

// Desafio Subscription
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

// Array Basics

// declarar
string[] fraudulentOrderIDs = new string[3];

/* O operador new cria uma instância de uma matriz na memória do computador que pode conter três valores de cadeia de caracteres. Para saber mais sobre a palavra-chave new, confira o módulo "Chamar métodos da Biblioteca de Classes .NET usando C#".

Observe que o primeiro conjunto de colchetes [] simplesmente indica ao compilador que a variável de nome fraudulentOrderIDs é uma matriz. Já o segundo conjunto de colchetes [3] indica o número de elementos que a matriz conterá.
 */

// Atribuindo valores
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

/* Observe que você usa o nome da matriz para acessar os elementos dela. Cada elemento é acessado individualmente, especificando dentro dos colchetes o número do índice, que começa no zero.

Como sua matriz é declarada como uma matriz de cadeia de caracteres, os valores atribuídos aos elementos da matriz devem ser cadeias de caracteres. Nesse cenário, você está atribuindo IDs de pedido aos elementos da matriz. */


// Tentando acessar um indice fora dos limites da array
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
fraudulentOrderIDs[3] = "D000";

// Output
Build succeeded.        
    0 Warning(s)        
    0 Error(s)

/* Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.     
   at Program.<Main>$(String[] args) in C:\Users\someuser\Desktop\CsharpProjects\TestProject\Program.cs:line 6
 */

// Recuperando valores em uma array
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Outuput
First: A123
Second: B456
Third: C789

// Reatribuindo valor
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Output
First: A123
Second: B456
Third: C789
Reassign First: F000

// Declarar e inicializar em uma so instruçao
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Outuput
First: A123
Second: B456
Third: C789
Reassign First: F000


// Length
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Output
First: A123
Second: B456
Third: C789
Reassign First: F000
There are 3 fraudulent orders to process.

/* Uma matriz é uma variável especial que contém uma sequência de elementos de dados relacionados.
Você deve memorizar o formato básico de uma declaração de variável de matriz.
Acesse cada elemento de uma matriz para definir ou obter seus valores usando um índice baseado em zero dentro de colchetes.
Se você tentar acessar um índice fora dos limites da matriz, será gerada uma exceção de runtime.
A propriedade Length é uma maneira programática de determinar o número de elementos em uma matriz.
 */

// foreach
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Output
Rowena
Robin
Bao

// Criar e inicializar
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");

// Output
We have 1775 items in inventory.

/* Use a instrução foreach para iterar em cada elemento de uma matriz, executando o bloco de código associado uma vez para cada elemento da matriz.
A instrução foreach define o valor do elemento atual na matriz como uma variável temporária, que pode ser usada no corpo do bloco de código.
Use o operador de incremento ++ para adicionar 1 ao valor atual de uma variável.
 */

// Desafio dos pedidos fraudulentos
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

// Nomenclatura
char userOption;

int gameScore;

float particlesPerMillion;

bool processedCustomer;

/* Os comentários de código explicam desnecessariamente a funcionalidade óbvia de linhas de código individuais. Eles são considerados comentários de baixa qualidade, porque apenas explicam como o C# ou os métodos da biblioteca de classes do .NET funcionam. Se os leitores não estiverem familiarizados com essas ideias, poderão pesquisar sobre elas usando o learn.microsoft.com ou o IntelliSense.
Os comentários de código não fornecem nenhum contexto para o problema que está sendo resolvido pelo código. Eles são considerados comentários de baixa qualidade porque o leitor não obtém nenhuma informação sobre a finalidade desse código, especialmente sobre como ele se relaciona com o sistema maior.
 */

/* Use comentários de código a fim de deixar observações significativas para si mesmo sobre os problemas que cada trecho de código específico resolve.
Não use os comentários de código para explicar como funciona o C# ou a biblioteca de classes do .NET.
Use comentários de código ao experimentar temporariamente soluções alternativas até que você esteja pronto para confirmar a nova solução de código; nesse ponto, você poderá excluir o código antigo.
Nunca confie em comentários. Eles podem não refletir o estado atual do código após muitas alterações e atualizações.
 */

// Espaço em branco
/* O espaço em branco não importa para o compilador. No entanto,...
O espaço em branco, quando usado corretamente, pode aumentar sua capacidade de ler e compreender o código.
 */

/* Cada comando completo (uma instrução) pertence a uma linha separada.
Se uma única linha de código se tornar longa, você poderá dividi-la. No entanto, você deve evitar dividir uma única instrução arbitrariamente em várias linhas até ter um bom motivo para fazer isso.
Use um espaço à esquerda e à direita do operador de atribuição.
 */

// Melhor espaçamento
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

/* Use espaço em branco criteriosamente para ajudar a melhorar a legibilidade do código.
Use alimentações de linha para criar linhas vazias a fim de separar frases de código. Uma frase é composta por linhas de código semelhantes ou que funcionam em conjunto.
Use alimentações de linha para separar símbolos de bloco de código para que cada símbolo fique na sua própria linha de código.
Use a chave tab para alinhar um bloco de código com a palavra-chave com a qual ele está associado.
Recue o código dentro de um bloco de código para mostrar a propriedade.
 */

// Desafio - Melhorar legibilidade

// Codigo ruim
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

// Codigo legivel
/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");









