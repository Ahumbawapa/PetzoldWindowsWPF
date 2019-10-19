//HandleAnEvent.cs

using System;
using System.Windows;
using System.Windows.Input;
/**
 * Benötigt zusätzlich Verweis auf Assembly System.Xaml 
 * für args.GetPosition
 */

namespace Petzold.HandleAnEvent
{
   class HandleAnEvent
   {
      [STAThread]
      public static void Main()
      {
         Application app = new Application();

         Window win = new Window();
         win.Title = "Handle An Event";
         win.MouseDown += WindowOnMouseDown;

         app.Run(win);
      }

      static void WindowOnMouseDown(object sender, MouseButtonEventArgs args )
      {
         Window win = sender as Window;
         //alternativ: Window win = Application.Current.MainWindow;
         string strMessage = string.Format("Klick mit Taste {0} am Punkt ({1})",
                                            args.ChangedButton, args.GetPosition(win));

         MessageBox.Show(strMessage, win.Title);
      }
   }
}