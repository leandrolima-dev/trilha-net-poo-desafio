using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "(11)99999-9999", modelo: "Nokia 3210", imei: "123456789", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");