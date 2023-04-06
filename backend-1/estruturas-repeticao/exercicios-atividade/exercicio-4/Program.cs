// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.


int pessoasS = 0;
int pessoasN = 0;
int femS = 0; 
int mascN = 0;

for ( int contador = 1; contador <= 10; contador ++)
{
    Console.WriteLine($"Qual seu genero? Insira m para masculino, e f para feminino.");
    char genero = char.Parse(Console.ReadLine());

    Console.WriteLine($"Gostou do produto lançado? Insira s para sim, e n para não.");
    char produto = char.Parse(Console.ReadLine());

    switch (produto)
    {
        case 's':
        pessoasS ++;

        if (genero == 'f' ) {
            femS ++;
        }
        break;

        case 'n':
        pessoasN ++;

        if (genero == 'm') {
            mascN ++;
        }
        break;

        // default:
    }
  
}

    Console.WriteLine($"O numero de pessoas que responderam sim, foi: {pessoasS}. O numero de pessoas que responderam nao, foi: {pessoasN}. Numero de mulheres que responderam sim, foi: {femS}. E a porcentagem de homens que responderam nao, foi {mascN }");