// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.Write($"Insira o ano de nascimento : ");
int anoNascimento = int.Parse(Console.ReadLine());

int anoAtual = DateTime.Now.Year;

int anos = anoAtual - anoNascimento;



if(anos >= 60 || anos == 16 || anos == 17 ){
Console.WriteLine($"Você pode votar, porém opicional !");

}
else if(anos > 18)
{
    Console.WriteLine($"Você não pode votar !");
    
}
else
{
    Console.WriteLine($"Você pode votar ! Vote consciente ");
    
}

