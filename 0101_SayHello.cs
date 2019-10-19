using System;
using System.Windows;

namespace Petzold.SayHello
{
   class SayHello
   {
      //Single-threaded-Apartment 
      [STAThread] //Laufzeitfehler bei fehlendem Attribut
      public static void Main()
      {
         Console.WriteLine("Programmstart");
         Window win = new Window();
         win.Title = "Say Hello";
         //win.Show();

         //Nur ein einziges Application-Objekt pro Programm!
         Application app = new Application();
         //app.Run();
         app.Run(win);

         Console.WriteLine("Programmende");
      }
   }
}

/**
 * Programm kann aus leerer Projektvorlage erstellt werden
 * Hinzufügen der Verweise
 * PresentationCore
 * PresentationFramework
 * System
 * WindowsBase
 * zwingend erforderlich
 * */
