using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nka = new Nokia(numero: "123456", modelo: "Modelo A", imei: "x890", memoria: 24);
nka.Ligar();
nka.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("Smartphone iPhone: ");
Smartphone iph = new Iphone(numero: "098976", modelo: "Modelo B", imei: "546l", memoria: 32);
iph.ReceberLigacao();
iph.InstalarAplicativo("Telegram");