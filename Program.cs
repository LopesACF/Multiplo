double numero1, numero2;

Console.WriteLine("--- Múltiplo ---");

Console.WriteLine("Digite um numero...");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Avaliar se é múltiplo de...");
numero2 = Convert.ToDouble(Console.ReadLine());

if (numero1 % numero2 == 0){
    Console.WriteLine($"{numero1} é múltiplo de {numero2}");
    }
    else
    {
        Console.WriteLine($"{numero1} não é múltiplo de {numero2}");
    }



