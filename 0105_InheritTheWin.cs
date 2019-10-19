/**
 * InheritTheWin
 * Minimales Anwendungskonstrukt zur Anzeige eines Fensters
 * Anwendung wird nicht von Application abgeleitet, aber Hauptfenster
 */

using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.InheritTheWin
{
   class InheritTheWin : Window
   {
      [STAThread]
      public static void Main()
      {
         Application app = new Application();
         app.Run(new InheritTheWin());
      }

      //ctor InheritTheWin
      public InheritTheWin()
      {
         this.Title = "Inherit the Win";
         // Werte sind zu Start unbestimmt und bleiben es ohne Zuweisung auch!!


         //Gleitkommewerte möglich
         //this.Width = 100 * Math.PI;
         //this.Height = 100 * Math.PI;

         //Angaben werden in geräteunabhängigen Einheiten angegeben
         this.Width = 288;
         this.Height = 192;
      }

      protected override void OnActivated(EventArgs e)
      {
         base.OnActivated(e);

         String msg = String.Format("{0} {1}", this.ActualWidth, this.ActualHeight);

         Console.WriteLine(msg);
         Console.WriteLine("SystemParameters.PrimaryScreenWidth: {0}", SystemParameters.PrimaryScreenWidth);
         Console.WriteLine("SystemParameters.PrimaryScreenHeight: {0}", SystemParameters.PrimaryScreenHeight);


      }



   }
}