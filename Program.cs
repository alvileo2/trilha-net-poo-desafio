using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1233444", modelo: "mod1", mei: "1223333333", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IpHone:");
Smartphone iPhone = new Iphone(numero: "1233444", modelo: "mod1", mei: "1223333333", memoria: 64);
iPhone.Ligar();
iPhone.InstalarAplicativo("Telegram");