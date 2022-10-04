using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testes Nokia:");
Nokia nokia = new Nokia(number: "123-456-789", model:"5.4", imei: "1111111111", storage: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Binance");

Console.WriteLine("Testes Iphone:");
Iphone iphone = new Iphone(number: "987-654-321", model: "11 Pro Max", imei: "2222222222", storage: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("GitHub");