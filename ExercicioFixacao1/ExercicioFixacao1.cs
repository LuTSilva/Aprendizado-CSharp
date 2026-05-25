/*
Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em aspas, 
e depois mostrar os dados na tela:
Entre com seu nome completo:
'Alex Green'
Quantos quartos tem na sua casa?
'3'
Entre com o preço de um produto:
'500.50'
Entre seu último nome, idade e altura (mesma linha):
'Green 21 1.73'
 */
using System.Globalization;

Console.WriteLine("Entre com seu nome completo:");
string nome = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto:");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
string[] pessoa = Console.ReadLine().Split(' ');
string ultimoNome = pessoa[0];
int idade = int.Parse(pessoa[1]);
double altura = double.Parse(pessoa[2], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));