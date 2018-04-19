using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewVideo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        video.Attributes["src"] = Session["fname"].ToString();
    }
}