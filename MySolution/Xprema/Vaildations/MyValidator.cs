using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Xprema.Vaildations
{
   public  class MyValidator
    {
       private ErrorProvider Err;

       public MyValidator() {

           Err = new ErrorProvider();
       }
       public bool IsTextBoxValidateNormal(Control cn)
       {
           bool Stat=false;
           foreach (TextBox item in cn.Controls)
           {
               if (item is TextBox)
               {
                   if (item.Text=="" || item.Text == string.Empty)
                   {
                       if (General.Languge.SelectedLanguge==Xprema.General.Languge.SelectLanguge.English)
                       {
                           Err.SetError(item, "Empty....");
                           Stat = false;
                       }
                       else
                       {
                           Err.SetError(item, "السجل فارغ");
                           Stat = false;
                       }
                      
                   }
                   else
                   {
                       Err.Clear();
                   } 
               }
           }
           return Stat;
       }

    }
}
