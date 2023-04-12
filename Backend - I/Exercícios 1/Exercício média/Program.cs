// Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.

Console.WriteLine($"Informe a frequência do aluno:");
int diasPresença = int.Parse(Console.ReadLine());

if(diasPresença < 75)
{    
    Console.WriteLine($"Aluno Reprovado !");
    return;
    
}




Console.WriteLine($"Informe a nota 1");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a nota 2");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a nota 3");
float nota3 = float.Parse(Console.ReadLine());


float mediaNotas = ((nota1 + nota2 + nota3) /3);
Console.WriteLine($"A média do aluno é : {mediaNotas}");

if( mediaNotas >= 7 && diasPresença >= 75)
{
    Console.WriteLine($"Aluno Aprovado !");
    
}
else if (mediaNotas >= 3 && diasPresença >= 75)
{
  Console.WriteLine($"Aluno tem direito a uma última avaliação de recuperação !");
    
}
else
{
    Console.WriteLine($"Aluno Reprovado !");
    
}






