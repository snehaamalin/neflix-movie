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
public partial class UserRegister : System.Web.UI.Page
{
    string qry;
    ForController obj;
    DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnreg_Click(object sender, EventArgs e)
    {
        
        string name = txtname.Text;
        string user = txtuser.Text;
        string pwd = txtpwd.Text;
        string add = txtadd.Text;
       
       
        string email = txtemail.Text;

 
        qry = "insert into registration values('"+user+"','" + name + "','" + add + "','" + email + "')";
        
        obj = new ForController();
        obj.controllerNonQuery(qry);

        qry = "insert into login values(null,'" + user + "','" + pwd + "',2)";
        obj = new ForController();
        obj.controllerNonQuery(qry);


        lblmsg.Text = "Sucessfully Register";
        txtname.Text = "";
        txtuser.Text = "";
        txtpwd.Text = "";
        txtadd.Text = "";
        
        txtemail.Text = "";
        
       
         
    }
}
