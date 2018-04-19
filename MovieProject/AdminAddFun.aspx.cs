using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using Controller;

public partial class AdminAddFun : System.Web.UI.Page
{
    string qry;
    ForController obj;
    DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {
         if (!IsPostBack)
            bind();
         for (int i = 0; i <= 5; i++)
         {
             ddlhour.Items.Add(i.ToString());
         }

         for (int i = 0; i <= 60; i++)
         {
             ddlmin.Items.Add(i.ToString());
         }
         for (int i = 0; i <= 60; i++)
         {
             ddlsec.Items.Add(i.ToString());
         }
    }
    void bind()
    {
         


    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
    }

    protected void UploadBtn_Click(object sender, EventArgs e)
    {
        
       
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string fname = ddlpgm.SelectedItem.Text;
        string pgm = txtpgm.Text;
        string id = ddlpgm.SelectedItem.Value;
		//string lng=txtlng.Text;
		string rdate=txtrdate.Text;
        //string ln = txtleng.Text;
        string hour = ddlhour.SelectedItem.Text;
        string min = ddlmin.SelectedItem.Text;
        string sec = ddlsec.SelectedItem.Text;
        string time = hour + ":" + min + ":" + sec;


        string fPath = "";

        int st = 0;
        string fp = DateTime.Now.Ticks.ToString() + System.IO.Path.GetExtension(FileUpLoad1.FileName);
         
        
            if (FileUpLoad1.HasFile)
            {
                st = 1;
                fPath = "video/" + fp;
                FileUpLoad1.SaveAs(Server.MapPath("~/video/" + fp));
                lblmsg.Text = "File Uploaded: " + FileUpLoad1.FileName;

            }
            else
            {
                lblmsg.Text = "No File Uploaded.";
            }
      
        if (st == 1)
        {
            qry = "insert into fun values(null,'" + fname + "','" + pgm + "','" + id + "','" + time + "','" + fPath + "','"+rdate+"')";
            obj = new ForController();
            obj.controllerNonQuery(qry);
            lblmsg.Text = "Sucessfully uploaded...";
        }


       

        txtpgm.Text = "";
		txtrdate.Text="";

        ddlpgm.SelectedIndex = -1;
        ddlhour.SelectedIndex = -1;
        ddlmin.SelectedIndex = -1;
        ddlsec.SelectedIndex = -1;
        
    }
}