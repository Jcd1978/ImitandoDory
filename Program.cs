Console.Clear();
Console.WriteLine("I I I M I I I T A A A N D O O O  D O O O R Y Y Y\n");

Console.Write("Digite uma frase...: ");
string frase = Console.ReadLine()!;

string fraseEmBaleies = frase
    .Replace("a", "aaa")
    .Replace("A", "AAA")
    .Replace("e", "eee")
    .Replace("E", "EEE")
    .Replace("i", "iii")
    .Replace("I", "III")
    .Replace("o", "ooo")
    .Replace("O", "OOO")
    .Replace("u", "uuu")
    .Replace("U", "UUU")
;

Console.WriteLine($"\nEm baleiês:\n\n{fraseEmBaleies}");
