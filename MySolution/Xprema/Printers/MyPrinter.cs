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
      public List<string> Getallprinter()
      {
          List<string> ls = new List<string>();
          foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
          {
              ls.Add(printer);
          }
          return ls;
      }
      
    }

  
}
