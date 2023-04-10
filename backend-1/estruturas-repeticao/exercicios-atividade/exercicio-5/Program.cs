// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:

// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.


// algoritmo 

//saber a idade
//saber o peso 
//saber o sexo 

//saber o total de homens 
//saber o total de mulheres 

//fazer a media de idade dos homens 
// fazer a media de idade das mulheres

int idades = 0;
int idadeDosHomens = 0;
int idadeDasMulheres = 0;
// int pesos = 0;

char sexo;

int totalDasMulheres = 0;
int totalDosHomens = 0;

int mediaDosHomens = 0;
int mediaDasMulheres = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Informe o sexo da pessoa. (m) para Masculino e (f) para feminino");
    sexo = char.Parse(Console.ReadLine());

    Console.WriteLine($"Informe sua idade.");
    idades = int.Parse(Console.ReadLine());

    switch (sexo)
    {
        case 'm':
            totalDosHomens++;
            idadeDosHomens += idades;

            break;

        case 'f':
            totalDasMulheres++;
            idadeDasMulheres += idades;
            break;
    }
}

mediaDasMulheres = idadeDasMulheres / totalDasMulheres;
mediaDosHomens = idadeDosHomens / totalDosHomens;

Console.WriteLine($@"

A.Total de Homens: {totalDosHomens}
B.Total de Mulheres: {totalDasMulheres}
C.Média de idade dos Homens: {mediaDasMulheres}     
D.Média de idade das mulheres: {mediaDosHomens}

");






