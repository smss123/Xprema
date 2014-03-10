using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.General
{
  public   class Languge
    {
    public   enum SelectLanguge
      {
          Arabic,
          English
      }
    public static SelectLanguge SelectedLanguge { get; set; }
    }
}
