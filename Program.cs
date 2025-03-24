string frase;
Console.Write("Digite uma frase: ");
frase=Console.ReadLine()!.Replace('r','l').Replace('R','L');
// "!" OBRUGATÓRIA
Console.Write($"{frase}");