using listsobjetos;

//criar lista de objetos (produtos)
List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(2563, "camiseta QuickSilver", 19.90f)
);

produtos.Add(
    new Produto(1025, "tenis Naiki", 50f)
);

Produto calcaDisel = new Produto(1526, "calca Disel", 15f);
produtos.Add(calcaDisel);

Console.WriteLine($@"
=============================
Lista antiga
=============================");

foreach (var item in produtos)
{
    Console.WriteLine($@"
    Codigo: {item.Codigo}
     Nome: {item.Nome}
    Preço: {item.Preco:C}
    {produtos.IndexOf(item)+1}");

}


Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563); 
int index = produtos.IndexOf(produtoBuscado); 
produtoBuscado.Preco = 199.90f;
produtos.RemoveAt(index);

produtos.Insert(index, produtoBuscado );

//lista atualizada

Console.WriteLine($@"
=============================
Lista Nova
=============================");

foreach (var item in produtos)
{
    Console.WriteLine($@"
    Codigo: {item.Codigo}
    Nome: {item.Nome}
    Preço: {item.Preco:C}
    {produtos.IndexOf(item)+1}");

}
