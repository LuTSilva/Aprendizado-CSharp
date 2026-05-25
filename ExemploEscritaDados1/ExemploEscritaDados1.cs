Console.WriteLine("Informe um cumprimento inicial");
string frase = Console.ReadLine();

Console.WriteLine("Informe três cores!");
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

Console.WriteLine("Informe outras três cores separando com espaço!!");
string[] cores = Console.ReadLine().Split(' ');
string a = cores[0];
string b = cores[1];
string c = cores[2];

Console.WriteLine("Você digitou:");
Console.WriteLine(frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);