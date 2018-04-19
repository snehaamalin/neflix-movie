using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using Controller;

public partial class Registration : System.Web.UI.Page
{
    string qry;
    ForController obj;
    DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnreg_Click(object sender, EventArgs e)
    {
        string adhar = txtadhar.Text;
        string name = txtname.Text;
        string user = txtuser.Text;
        string pwd = txtpwd.Text;
        string add = txtadd.Text;
        string dis = txtdist.Text;
        string pin = txtpin.Text;
        string ph = txtph.Text;
        string email = txtemail.Text;
       
        


        qry = "insert into registration values('" + adhar + "','" + name + "','" + add + "','" + ph + "','" + email + "','" + dis + "','" + pin + "')";
        //Response.Write(qry);
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
        txtph.Text = "";
        txtemail.Text = "";
        txtadhar.Text = "";   
        txtdist.Text = "";
        txtpin.Text = "";
         
    }
    protected void UploadBtn_Click(object sender, EventArgs e)
    {
         
    }
}