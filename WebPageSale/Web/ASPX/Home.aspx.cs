using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Web.Masters;

namespace Web.ASPX
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var master = Master as Master_A;
            if (master != null)
            {
               var control = master.FindControl("Master_A_body") as HtmlGenericControl;
                master.SetHtmlElementClass(control," bg-red");
            }
        }
    }
}