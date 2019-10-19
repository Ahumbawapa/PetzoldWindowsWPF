/**
 * InheritTheApp.cs

*/

using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.InheritTheApp
{
   class InheritTheApp : Application
   {
      [STAThread]
      public static void Main()
      {
         InheritTheApp app = new InheritTheApp();
         app.Run();
         
      }

      //Ereignishandler für Application.Startup überschreiben
      protected override void OnStartup(StartupEventArgs args)
      {
         base.OnStartup(args); //Basisklassenversion aufrufen
         Window win = new Window();
         win.Title = "Inherit the App";
         win.Show();
      }

      //Ereignishandler für Application.SessionEnding überschreiben
      protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
      {
         base.OnSessionEnding(e);

         //Grund fuer Programmende abfragen
         if (e.ReasonSessionEnding == ReasonSessionEnding.Logoff)
            Console.WriteLine("Logoff");
         else if (e.ReasonSessionEnding == ReasonSessionEnding.Shutdown)
            Console.WriteLine("Shutdown");

         MessageBoxResult result = MessageBox.Show("Wollen Sie ihre Daten speichern?"
                                                  , this.MainWindow.Title
                                                  , MessageBoxButton.YesNoCancel
                                                  , MessageBoxImage.Question
                                                  , MessageBoxResult.Yes);
         e.Cancel = (result == MessageBoxResult.Cancel);
      }


   }
}
