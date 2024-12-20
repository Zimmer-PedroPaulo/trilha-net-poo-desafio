using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "+5511234567890", modelo: "Nokia 701", imei: "9823692362359875", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine(nokia.Numero);


Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "+5511234567890", modelo: "Iphone 13", imei: "871386135587035701357", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine(iphone.Numero);