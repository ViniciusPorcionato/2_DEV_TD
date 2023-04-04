// bool idadeCerta = false;

// while (idadeCerta == false) //while
// {
//     Console.WriteLine($"Qual a idade do Adulto Ney ? ");
//     int idade = int.Parse(Console.ReadLine());

//     if (idade == 31)
//     {
//         idadeCerta = true;
//     }
    
    
// }

bool idadeCerta = false;

do
{

Console.WriteLine($"Qual a idade do Adulto Ney ?");
int idade =int.Parse(Console.ReadLine());

if (idade == 31)
{
    Console.WriteLine($"Acertou !!S");
    idadeCerta = true;
    
}
else
{
    Console.WriteLine($"Errou feio ! Tente novamente ");
    
}
    


} while (idadeCerta == false);