//************************************************************************

//crie um metodo para multiplicar 2 numeros 
static float Multiplicar(float n1, float n2)
{
    return (n1 * n2);
}

Console.WriteLine($"Digite o primeiro numero para multiplicar");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero para multiplicar");
float n2 = float.Parse(Console.ReadLine());


float resultadoM = Multiplicar(n1, n2);
Console.WriteLine($"Resultado {resultadoM}");

//crie um metodo para dividir 2 numeros

static float Dividir(float n1, float n2)
{
    return (n1 / n2);
}

Console.WriteLine($"Digite o primeiro numero para dividir");
float dividir1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero para dividir");
float dividir2 = float.Parse(Console.ReadLine());


float resultadoD = Dividir(dividir1, dividir2);
Console.WriteLine($"Resultado {resultadoD}");

//crie um metodo para subtrair 2 numeros 

static float Subtrair(float n1, float n2)
{
    return (n1 - n2);
}

Console.WriteLine($"Digite o primeiro numero para subtrair");
float subtrair1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero para subtrair");
float subtrair2 = float.Parse(Console.ReadLine());


float resultadoS = Subtrair(subtrair1, subtrair2);
Console.WriteLine($"Resultado {resultadoS}");
