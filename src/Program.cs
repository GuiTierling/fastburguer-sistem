Console.Write("Digite o seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite a sua idade: ");
int idade = int.TryParse(Console.ReadLine());

if (idade >= 18)
{
    Console.Write($"Você é maior de idade!");
} else
{
    Console.Write($"O {nome} ainda é de menor");
}
