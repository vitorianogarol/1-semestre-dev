// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Infome o ano que nasceu");
int anoNascimento = int.Parse (Console.ReadLine());

int idade = (DateTime.Now.Year - anoNascimento);
if (idade >= 16 ) {
    Console.WriteLine($"Você poderá votar.");
}
else {
    Console.WriteLine($"Você não poderá votar.");
    
}