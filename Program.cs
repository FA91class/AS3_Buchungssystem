using System;
using AS3_Buchung.classes;
using AS3_Buchung.controller;
using AS3_Buchung.helper;

namespace AS3_Buchung
{
    class Program
    {
        static void Main(string[] args)
        {
            #region vars
            string command;
            char[] chars = { '*', ' ', '\'', '"', '#' };
            #endregion

            #region main
            DekoWorker.SetLogo();
            DekoWorker.SetSpacer();
            while (true)
            {
                DekoWorker.SetCommand();
                command = Console.ReadLine().ToLower();
                command = command.Trim(chars);
                switch (command)
                {
                    case "/exit":
                        Console.WriteLine();
                        return;
                    case "/help":
                        Console.WriteLine("\nCommands: ");
                        Console.WriteLine("         /artikel                 /führt die main Methode des Artikel Controlers aus");
                        Console.WriteLine("         /bestellung              /führt die main Methode des Bestellung Controlers aus");
                        Console.WriteLine("         /bestellposition         /führt die main Methode des Bestell Position Controlers aus");
                        Console.WriteLine("         /rechnung                /printet eine Rechnung in die Konsole");
                        Console.WriteLine("         /exit                    /beendet die ausführung des Programms");
                        Console.WriteLine("         /clear                   /leert die Console");
                        Console.WriteLine("         /help                    /öffnet die Command hilfe\n");
                        DekoWorker.SetSpacer();
                        break;
                    case "/artikel":
                        Console.Clear();
                        DekoWorker.SetLogo();
                        ArtikelController.Run();
                        DekoWorker.SetSpacer();
                        break;
                    case "/bestellung":
                        Console.Clear();
                        DekoWorker.SetLogo();
                        BestellungController.Run();
                        DekoWorker.SetSpacer();
                        break;
                    case "/bestellposition":
                        Console.Clear();
                        DekoWorker.SetLogo();
                        BestellPositionController.Run();
                        DekoWorker.SetSpacer();
                        break;
                    case "/rechnung":
                        Console.Clear();
                        DekoWorker.SetLogo();
                        var k = new KundenVerwaltung();
                        var d = new KonsolenDrucker();
                        foreach (var kunde in k.Kunden)
                        {
                            d.RechnungsAusgabe(kunde);
                        }                        
                        DekoWorker.SetSpacer();
                        break;
                    case "/clear":
                        Console.Clear();
                        DekoWorker.SetLogo();
                        Console.WriteLine();
                        DekoWorker.SetSpacer();
                        break;
                    default:
                        Console.WriteLine("Command Unknown!\n");
                        DekoWorker.SetSpacer();
                        break;
                }
            }
            #endregion
        }
    }
}
