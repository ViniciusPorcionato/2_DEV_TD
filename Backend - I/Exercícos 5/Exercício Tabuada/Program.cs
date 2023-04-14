// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

for (int t = 0; t <=10; t++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Tabuada : {t}");
        Console.ResetColor();
        

        for (int i = 0; i <= 10; i++)
        {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Tabuada : {t} * {i} = {t * i}");
        Console.ResetColor();
    
        }
    }