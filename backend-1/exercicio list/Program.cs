using exercicio_list;

List<Carro> carros = new List<Carro>();

for (var i = 0; i < 2; i++)
{
    Console.WriteLine($"Digite o nome da marca do {i + 1}º carro:");
    string marca = Console.ReadLine();

    Console.WriteLine($"Digite a cor do {i + 1}º carro:");
    string cor = Console.ReadLine();

    Carro resposta = new Carro(marca, cor);
    carros.Add(resposta);
}

foreach (var item in carros)
{
    Console.WriteLine($@"
    {carros.IndexOf(item)+1}º Carro:
    Marca: {item.Marca}
    Cor: {item.Cor}
    ");
    
}


