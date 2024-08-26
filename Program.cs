using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia Android OS:");
Smartphone nokia = new Nokia(numero:"92391234", modelo: "Modelo B", imei: "999111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

 Console.WriteLine("IOS OS:");
 Smartphone iphone = new Iphone(numero:"45777", modelo: "Modelo A", imei: "111999", memoria: 64);
 iphone.Ligar();
 iphone.ReceberLigacao();
 iphone.InstalarAplicativo("Discord");