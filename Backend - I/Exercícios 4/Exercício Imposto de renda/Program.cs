//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto
// ****************************************************************************************
//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda

using System.Globalization;

static float ImpostoRenda(float rendimento){

    if (rendimento <= 1500)
    {
        Console.WriteLine($"Isento");
        return rendimento * 0;
    }
    else if(rendimento <= 3500)
    {
        Console.WriteLine($"20% = {rendimento * 0.20F}");
        return rendimento * 0.20F;
    }
    else if(rendimento <= 6000)
    {
        Console.WriteLine($"25% ={rendimento * 0.25F}");
        return rendimento * 0.25F;
    }
    else
    {
        Console.WriteLine($"35% ={rendimento * 0.35F}");
        return rendimento * 0.35F;
    }
}


Console.Write($"Informe seu Rendimento :");
float rendimento = float.Parse(Console.ReadLine());

float imposto = ImpostoRenda(rendimento);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Seu rendimento é: {rendimento.ToString("C", new CultureInfo("pt-BR"))}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Seu imposto é : {imposto.ToString("C", new CultureInfo("pt-BR"))}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Seu salário com imposto de renda é igual a : {(rendimento - imposto).ToString("C", new CultureInfo("pt-BR"))}");
Console.ResetColor();





