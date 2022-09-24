System.Console.WriteLine("Média Aritimética de 3 números\n");

System.Console.Write("Digite o primeiro número: ");
decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite o segundo número: ");
decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite o terceiro número: ");
decimal terceiroNumero = Convert.ToDecimal(Console.ReadLine());

decimal media = (primeiroNumero + segundoNumero + terceiroNumero) / 3;
System.Console.WriteLine($"\nMédia: {media:N2}");

    System.Console.WriteLine("Pressione uma tecla para fechar...");
Console.ReadKey();


