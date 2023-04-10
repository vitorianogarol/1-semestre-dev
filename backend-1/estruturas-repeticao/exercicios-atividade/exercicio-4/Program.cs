// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.


char sexo;
char gostouDoProduto;

int pessoasS = 0;
int pessoasN = 0;

int femS = 0;
int fem = 0;

int mascN = 0;
int masc = 0;

float porcentagemHomemNao;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Informe o sexo da pessoa. (m) para Masculino e (f) para feminino");
    sexo = char.Parse (Console.ReadLine());
    
    if (sexo == 'f') {
        fem++;

    }

    else {
        masc++;
    }

    Console.WriteLine($"A pessoa gostou do lançamento? (s) para sim e (n) para não.");
    gostouDoProduto = char.Parse (Console.ReadLine());
    
    if (gostouDoProduto == 's') {
        pessoasS ++; 

        if (sexo == 'f')
        {
                femS++;
        }
    }
     else {
        pessoasN++;

        if (sexo == 'm'){
            mascN++;
        }
     }
}

porcentagemHomemNao = ((float)mascN / (float) masc )* 100;

Console.WriteLine($"A porcentagem de homens que responderam que não gostaram do produto é de {porcentagemHomemNao}. O numero de pessoas que responderam sim foi de {pessoasS}. O numero de pessoas que responderam não foi de {pessoasN}. O numero de mulheres que responderam sim foi de {femS}");


// char sexo;
// char gostouDoProduto;

// int pessoasS = 0;
// int pessoasN = 0;

// int femS = 0;
// int fem = 0;

// int mascN = 0;
// int masc = 0;

// float porcentagemHomemNao;

// for (int contador = 1; contador <= 3; contador++)
// {
//     Console.WriteLine($"Qual seu genero? Insira 1 para masculino, e 2 para feminino.");
//     char genero = char.Parse(Console.ReadLine());

//     Console.WriteLine($"Gostou do produto lançado? Insira 1 para sim, 2 para não.");
//     char produto = char.Parse(Console.ReadLine());

//     switch (produto)
//     {
//         case 's':
//             pessoasS++;

//             if (genero == 'f')
//             {
//                 femS++;
//             }
//             break;

//         case 'n':
//             pessoasN++;

//             if (genero == 'm')
//             {
//                 mascN++;
//                 masc++;
                
//             }
//             break;

            

//             // default:
//     }

// }

// Console.WriteLine($"O numero de pessoas que responderam sim, foi: {pessoasS}. O numero de pessoas que responderam nao, foi: {pessoasN}. Numero de mulheres que responderam sim, foi: {femS}. E a porcentagem de homens que responderam nao, foi {mascN}");