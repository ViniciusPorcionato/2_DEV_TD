// 3. Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Informe o número :");
int num = int.Parse(Console.ReadLine());

while (num < 0)
{

 if (num < 0)
 {
    Console.WriteLine($"Valor incorreto, informe o valor navamente !");
    num = int.Parse(Console.ReadLine());
 }  

}


for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Tabuada : {num} * {i} = {num * i}");
    
}
