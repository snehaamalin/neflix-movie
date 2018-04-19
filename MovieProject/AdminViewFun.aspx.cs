using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using Controller;

public partial class AdminViewFun : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string qry = "select * from fun";
            ForController obj = new ForController();
            DataTable data = obj.ControllerGetData(qry);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string fid = e.CommandArgument.ToString();
        string btn = ((LinkButton)e.CommandSource).Text;

        if (btn.Equals("Edit"))
        {
            Session["id"] = fid;
            Response.Redirect("AdminEditViewFun.aspx");

        }
        else
        {
            string qry = "delete from fun where fun_id=" + Convert.ToInt32(fid) + " ";
            ForController obj = new ForController();
            obj.controllerNonQuery(qry);
            lblmsg.Text = "Record Deleted successfully.";

            string qry1 = "select * from fun";
            ForController obj1 = new ForController();
            DataTable data = obj1.ControllerGetData(qry1);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
     
}