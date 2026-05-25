using System.Globalization;

Console.WriteLine("Informe um numero inteiro!");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe uma letra!");
char ch = char.Parse(Console.ReadLine());
Console.WriteLine("Informe um numero com casas decimais, separado por ponto!");
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Informe Nome, Sexo (uma letra), Idade e Altura, separados por espaço!");
string[] pessoa = Console.ReadLine().Split(' ');
string nome = pessoa[0];
char sexo = char.Parse(pessoa[1]);
int idade = int.Parse(pessoa[2]);
double altura = double.Parse(pessoa[3], CultureInfo.InvariantCulture);

Console.WriteLine("Você digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine(sexo);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
