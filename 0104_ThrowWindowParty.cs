/**
 * 0104_ThrowWindowParty.cs
 * Mehrere Fenster oeffnen
 */

using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.ThrowWindowParty
{
   class ThrowWindowParty : Application
   {
      [STAThread]
      public static void Main()
      {
         ThrowWindowParty app = new ThrowWindowParty();
         //app.ShutdownMode = ShutdownMode.OnMainWindowClose;
         app.Run();
      }

      protected override void OnStartup(StartupEventArgs e)
      {
         base.OnStartup(e);

         Window winMain = new Window();
         winMain.Title = "Hauptfenster";
         winMain.MouseDown += WindowOnMouseDown;
         winMain.Show();

         for(int i = 0; i < 2; i++)
         {
            Window win = new Window();
            win.Title = "Extrafenster Nr. " + (i + 1);
            win.ShowInTaskbar = false;
            win.Show();
            //Test: Anderes Hauptfenster zuweisen
            //MainWindow = win;

            win.Owner = winMain;
         }

         //Hauptfenster auf Konsole ausgeben
         Console.WriteLine("Hauptfenster: " + this.MainWindow.Title);

         Console.WriteLine("Anzahl geoeffneter Fenster: " + Windows.Count);
         for(int i = 0; i < this.Windows.Count; i++)
         {
            Console.WriteLine("#" + i+1 + ": " + this.Windows[i].Title);
         }


      }

      void WindowOnMouseDown(object sender, MouseButtonEventArgs args)
      {
         Window win = new Window();
         win.Title = "Modales Dialogfeld";
         win.ShowDialog();
      }
   }
}