using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone - Nokia");
Nokia nokia = new Nokia(numero: "(11)99999-9999", modelo: "Nokia 3210", imei: "123456789", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("- WhatsApp,");

Console.WriteLine("\n");

Console.WriteLine("Smartphone - Iphone");
Iphone iphone = new Iphone(numero: "(21)99999-0000", modelo: "Iphone 13", imei: "987654321", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("- Telegram,");