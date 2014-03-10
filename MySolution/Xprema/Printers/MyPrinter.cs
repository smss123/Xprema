using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;

namespace Xprema.Printers
{
   public  class MyPrinter
    {
       public MyPrinter() { }

      public string GetDefaultPrinter()
       {
           PrinterSettings settings = new PrinterSettings();
           foreach (string printer in PrinterSettings.InstalledPrinters)
           {
               settings.PrinterName = printer;
               if (settings.IsDefaultPrinter)
                   return printer;
           }
           return string.Empty;
       }
    
      
    }

  
}
