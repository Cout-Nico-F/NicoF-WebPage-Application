using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Web.Masters
{
    public partial class Master_A : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void SetHtmlElementClass(HtmlGenericControl _control ,string _class)
        {
            _control.Attributes.Add("class", _control.Attributes["class"] + _class);
        }
    }
}