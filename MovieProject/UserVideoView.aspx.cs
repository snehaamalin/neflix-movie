using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using Controller;


public partial class UserVideoView : System.Web.UI.Page
{
    ForController obj = new ForController();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            bind();

    }

    void bind()
    {
        string q = "SELECT * FROM fun f;";
        DataTable dt = new DataTable();
        dt = obj.ControllerGetData(q);
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
   
    protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        string id = e.CommandArgument.ToString();
         

          
            Session["fun_id"] = id;
            Response.Redirect("UserVideoVisualDisplay.aspx");
        
    }
}