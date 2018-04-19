using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using Controller;

public partial class UserVideoVisualDisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		string id=Session["fun_id"].ToString();
		string q = "SELECT * FROM fun f where fun_id="+id;
        DataTable dt = new DataTable();
		dt = new ForController().ControllerGetData(q);
		foreach(DataRow row in dt.Rows)
        { 
          lbllng.Text = row["file_name"].ToString();
          lblname.Text = row["program_name"].ToString();
          lblrdate.Text = row["releaseDate"].ToString();
          lbllen.Text = row["length"].ToString();
		  video.Attributes["src"] = row["file_path"].ToString();
       }
        
        
    }
}