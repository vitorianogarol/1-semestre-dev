int inicio = 0;
int inicio1 = 1;

for (int i = 0; i <= 500;)
{
    i = inicio + inicio1;
    Console.WriteLine(i);
    inicio = inicio1;
    inicio1 = i;

  
}


