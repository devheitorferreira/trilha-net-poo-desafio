using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Instanciar um Nokia
Smartphone nokia = new Nokia("123456", "Nokia 3310", "111111111111111", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

// Instanciar um iPhone
Smartphone iphone = new Iphone("789012", "iPhone 13", "222222222222222", 128);
iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();