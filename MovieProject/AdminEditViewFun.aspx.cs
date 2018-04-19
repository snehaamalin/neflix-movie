using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using Controller;

public partial class AdminEditViewFun : System.Web.UI.Page
{
    ForController obj = new ForController();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            bind();
    }

    void bind()
    {
        string q = "select * from fun";
        DataTable dt = new DataTable();
        dt = obj.ControllerGetData(q);
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = ((Label)row.FindControl("Label1")).Text;
        string name = ((Label)row.FindControl("Label2")).Text;
        string pgname = ((TextBox)row.FindControl("TextBox1")).Text;
        string type = ((Label)row.FindControl("Label4")).Text;
		string rdate=((TextBox)row.FindControl("TextBox1r")).Text;
        string length = ((TextBox)row.FindControl("TextBox2")).Text;
        string q = "update fun set program_name='" + pgname + "',length='" + length + "',releaseDate='"+rdate+"' where fun_id='" + id + "' ";
        obj.controllerNonQuery(q);
        GridView1.EditIndex = -1;
        bind();


    }
}