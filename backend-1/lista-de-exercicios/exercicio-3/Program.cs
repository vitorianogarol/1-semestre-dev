// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else

//ler a descricao do produto 
//ler a quantidade adquirida 
//preco unitario

Console.WriteLine($"Insira o nome do produto.");
string nome = Console.ReadLine();

Console.WriteLine($"Insira a quantidade adquirida");
float quantidade = int.Parse (Console.ReadLine() );

Console.WriteLine($"Insira o preço unitario");
float preco = float.Parse (Console.ReadLine());

float valorinteiro = (quantidade * preco);

Console.WriteLine($"O produto {nome} com desconto ficara R${Conta (quantidade, preco)} E sem desconto ficara {valorinteiro}");

static float Conta(float quantidade, float preco){

    if(quantidade <= 5){
        return (quantidade * preco) * 0.98F;
    }
    else if (quantidade > 5 && quantidade <= 10){
        return (quantidade * preco) * 0.97F;
    }
    else {
         return (quantidade * preco) * 0.95F;
    }
}





