using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Controller;
public partial class NewLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    string qry;
    ForController obj;
    DataTable dt;

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        string user = txtuser.Text;
        string pwd = txtpwd.Text;


        qry = "select user_id,role from login where user_id='" + user + "' and password= '" + pwd + "'";
        obj = new ForController();
        dt = obj.ControllerGetData(qry);
        

        Session["user_id"] = user;
        if (dt.Rows.Count > 0)
        {
            string ses = dt.Rows[0][0].ToString();
            string role = dt.Rows[0][1].ToString();
            int roll = Convert.ToInt32(role);
            if (roll == 1)
            {
                Response.Redirect("AdminHome.aspx");
            }
            else if (roll == 2)
            {
                Response.Redirect("UserVideoView.aspx");
            }
        }
        else
        {
            lblmsg.Text = "Login error";
        }

    }
}
