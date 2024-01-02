using DesafioPOO.Models;

Nokia nokia = new Nokia("12344", "RM", "HSHAGH", "56 GB");
nokia.Ligar();
nokia.InstalarAplicativo("Zap");
nokia.ReceberLigacao();

Iphone iphone = new Iphone("15676776", "TYU", "hHJGHGJ", "234 GB");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();