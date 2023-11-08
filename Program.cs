using DesafioPOO.Models;

// IMPLEMENTADO

Nokia s1 = new Nokia("123456", "01X", "0101", 64);
Iphone s2 = new Iphone("654321", "02S", "0202", 128);

Console.WriteLine("Smartphone Nokia: ");
s1.Ligar();
s1.ReceberLigacao();
s1.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
s2.Ligar();
s2.ReceberLigacao();
s2.InstalarAplicativo("Instagram");
