﻿using System;
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



        /// <summary>
        /// Use this method to set or add classes to an Html element<para/>
        /// <example>
        /// Find and cast the element:<para/>
        /// var control = master.FindControl("Master_A_body") as HtmlGenericControl;<para/>
        /// Then use the method adding one space before the class you want to add:<para/>
        /// master.SetHtmlElementClass(control, " bg-rainbow");<para/>
        /// 
        /// </example>
        /// </summary>
        /// <param name="_control"></param>
        /// <param name="_class"></param>
        public void SetHtmlElementClass(HtmlGenericControl _control ,string _class)
        {
            _control.Attributes.Add("class", _control.Attributes["class"] + _class);
        }
    }
}