using Uni9.Aula03;

Televisao tvSala = new Televisao(67);

Console.WriteLine($"O tamanho da tv é: {tvSala.Tamanho}");

Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.AumentarVolume();
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.AumentarVolume();
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.DiminuirVolume();
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
