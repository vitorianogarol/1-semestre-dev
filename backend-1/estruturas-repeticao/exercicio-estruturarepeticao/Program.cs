bool nomeCerto = true;

do {

    Console.WriteLine($"Digite seu nome?");
    string nome = Console.ReadLine();
    
    if (nome != "")
     {
        nomeCerto = true;
        Console.WriteLine($"Certo, prossiga.");
        
        
    }

    else {
        nomeCerto = false;
        Console.WriteLine($"Falha, tente novamente.");
        
    }
}
while (nomeCerto == false);

bool idadeCerta = true; 
do {
    Console.WriteLine($"Qual a sua idade?");
    int idade = int.Parse(Console.ReadLine());
    

    if (idade <= 100 && idade >= 0)
     {
        idadeCerta = true;
        Console.WriteLine($"Certo, prossiga.");
    }

    else {
        idadeCerta = false;
         Console.WriteLine($"Falha, tente novamente.");
    }
    
}
while (idadeCerta = false);

bool salarioCerto = true;

do {
    Console.WriteLine($"Qual o seu salario?");
    float salario = float.Parse (Console.ReadLine());
    
    if (salario > 0)
    {
        salarioCerto = true;
       Console.WriteLine($"Certo, prossiga.");
        

    }

    else {
        salarioCerto = false;
        Console.WriteLine($"Falha, tente novamente.");
    }
}
while(salarioCerto = false);

bool civilCerto = true;

do {
    Console.WriteLine($"Qual o seu estado civil?");
    char civil = char.Parse (Console.ReadLine());

    if (civil != 's' && civil != 'c' && civil != 'v' && civil != 'd')
     {
        civilCerto = true;
        Console.WriteLine($"Certo, prossiga.");
    }

    else 
    {
        civilCerto = false;
        Console.WriteLine($"Falha, tente novamente.");

    }
    
}
while (civilCerto = false);
