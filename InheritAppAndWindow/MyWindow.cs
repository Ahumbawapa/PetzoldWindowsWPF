/**
 * MyWindow.cs
 */
using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.InheritAppAndWindow
{
   public class MyWindow : Window
   {
      public MyWindow()
      {
         this.Title = "Inherit App & Window";
      }

      protected override void OnMouseDown(MouseButtonEventArgs e)
      {
         base.OnMouseDown(e);

         string strMessage = String.Format("Klick mit Taste {0} am Punkt ({1})"
                                          , e.ChangedButton
                                          , e.GetPosition(this));

         MessageBox.Show(strMessage, Title);
      }
   }
}
