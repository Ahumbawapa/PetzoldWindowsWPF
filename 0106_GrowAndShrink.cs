/**
 * GrowAndShrink.cs
 */

using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.GrowAndShrink
{
   public class GrowAndShrink : Window
   {
      [STAThread]
      public static void Main()
      {
         Application app = new Application();
         app.Run(new GrowAndShrink());
      }

      public GrowAndShrink()
      {
         this.Title = "Grow & Shrink";
         this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
         this.Width = 192;
         this.Height = 192;
      }

      protected override void OnKeyDown(KeyEventArgs e)
      {
         base.OnKeyDown(e);

         if(e.Key == Key.Up)
         {
            this.Left -= 0.05 * Width;
            this.Top -= 0.05 * Height;
            this.Width *= 1.1;
            this.Height *= 1.1;
         }
         else if(e.Key == Key.Down)
         {
            this.Left += 0.05 * (this.Width /= 1.1);
            this.Top += 0.05 * (this.Height /= 1.1);
         }
      }
   }
      
}