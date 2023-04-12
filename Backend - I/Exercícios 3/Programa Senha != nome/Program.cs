// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

string nome = "";
string senha = "";

while (nome == senha)
{

    Console.WriteLine($"Infome seu nome de usuário :");
    nome = Console.ReadLine();
    
    Console.WriteLine($"Informe a Senha :");
    senha = Console.ReadLine();
    
    
if(senha == nome)
{
    Console.WriteLine($"Senha Incorreta, informe novamente !");
    // senha = Console.ReadLine();
    
}
else
{
Console.WriteLine($"Login Sucesso !");
}

}


