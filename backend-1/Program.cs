// // variaveis e constantes 
// // //declarando uma variavel 
// // string  name = "vitoria" ;
// // name = "Enzo";
// // Console.WriteLine(name);

// // const int idade = 36;
// // Console.WriteLine(idade);

// // Console.WriteLine("A idade do " + name + " e de " + idade + " anos");


// // //tipos de dados
// // int quantidade = 10;
// // double preco = 4.99D;
// // float altura = 1.8F;
// // bool careca = true;
// // string texto = "Hello World";
// // char letra = 'C'

// //operador de atribuicao 
// int idade = 36;
// //operadores aritimetricos 

// //soma 
// // Console.WriteLine(4+4);

// //subtracao 
// // Console.WriteLine(10-8);

// // //multiplicacao 
// // Console.WriteLine(5 * 9);

// // //divisao
// // Console.WriteLine(10 / 2);

// // //modular 
// // Console.WriteLine(5 % 2);


// //operadres de comparacao - true ou false

// // igual a
// Console.WriteLine(5 == 5);

// //maior ou igual a 
// Console.WriteLine(5 >= 4);

// //menor ou igual a 
// Console.WriteLine(4 <= 3);

// //maior que 
// Console.WriteLine(5 > 1);

// //menor que 
// Console.WriteLine(5 < 2);

// // diferente de 
// Console.WriteLine(5 != 8);

// operadores logicos e tabela verdade
// && : e
//|| : ou 
// // !

// Console.WriteLine(5 == 5 && 8 == 8); //true && true = true 
// Console.WriteLine(5 == 5 && 8 == 9); //true && false = false
// Console.WriteLine(5 == 6 && 8 == 8).; //false && true = false
// Console.WriteLine(5 == 6 && 8 == 9); //false && false = false

// Console.WriteLine(2 == 2 || 3 == 3); //true || true = true 
// Console.WriteLine(2 == 2 || 3 == 4); //true || false = true 
// Console.WriteLine(2 == 3 || 3 == 3); //false || true = true 
// Console.WriteLine(1 == 2 || 3 == 5); //false || false = false

// Console.WriteLine(!(2 == 2 || 3 == 3)); //ira negar a condicao 


//crie um programa para calcular o imc de uma pessoa 

// //entradas
// string nome = "Carlos";
// float peso = 89.9F;
// float altura = 1.80F;

// //processamento 
// float imc = peso / (altura * altura);
// Console.WriteLine("o imc do " + nome + " e de : " + Math.Round (imc,2 ));
