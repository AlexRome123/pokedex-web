using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Web;
using System.Web.UI;

namespace negocio
{
    public static class Validacion
    {
        public static bool ValidaTxtVacio(object control)
        {
            if(control is TextBox text)
            {
                if(string.IsNullOrEmpty(text.Text))
                    return true; 
            }
            return false;
        }

    }
}
