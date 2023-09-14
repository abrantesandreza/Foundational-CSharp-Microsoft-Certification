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





