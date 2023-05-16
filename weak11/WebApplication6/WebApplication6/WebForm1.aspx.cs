using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        //

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Panel2.Visible == true)
            {
                Panel2.Visible = false;
                Button1.Text = "更多>>";
            }
            else if (Panel2.Visible == false) {
                Panel2.Visible = true;
                Button1.Text = "更少<<";
            }
        }
    }
}