﻿// 3. Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.


Console.WriteLine($"Informe a primeira medida :");
 int m1 = int.Parse (Console.ReadLine());

 Console.WriteLine($"Informe a segunda medida :");
 int m2 = int.Parse (Console.ReadLine());

  Console.WriteLine($"Informe a terceira medida :");
 int m3 = int.Parse (Console.ReadLine());

 if (m1 == m2 && m2 == m3 && m1 == m3)
 {

  Console.WriteLine($"Equilatero");

 }
 else if (m1 != m2 && m2 != m3 && m1 != m3)
 {
    Console.WriteLine($"Escaleno");
 }

 else {
      Console.WriteLine($"Isóscele");
 }