// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
MailSender mailSender = new MailSender();
WhatsAppSender whatsSender = new WhatsAppSender();  
TelegramSender telegramSender = new TelegramSender();

Report report = new Report(telegramSender);
report.Send("abc");