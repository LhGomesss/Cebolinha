string comR;
string semR;
Console.Write("Oi, eu sou o cebolinha, fale algo: ");
comR = Console.ReadLine()!;
semR=comR.Replace('r','l').Replace('R','L');

Console.WriteLine($"Frase original:{comR}");
Console.WriteLine();
Console.WriteLine($"Flase do cebolinha:{semR}");