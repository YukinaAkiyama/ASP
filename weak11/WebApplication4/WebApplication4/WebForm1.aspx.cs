using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedIndex == 0)
            {
                HyperLink link = new HyperLink();
                link.Text = "大声唱";
                link.NavigateUrl = "https://www.kugou.com/mixsong/j6b5of2.html?fromsearch=%E5%A4%A7%E5%A3%B0%E5%94%B1";
                Label3.Controls.Add(link);
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                HyperLink link = new HyperLink();
                link.Text = "半岛铁盒";
                link.NavigateUrl = "https://www.kugou.com/mixsong/j32b066.html?fromsearch=%E5%8D%8A%E5%B2%9B%E9%93%81%E7%9B%92";
                Label3.Controls.Add(link);
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                HyperLink link = new HyperLink();
                link.Text = "烟花易冷";
                link.NavigateUrl = "https://www.kugou.com/mixsong/j2hixca.html?fromsearch=%E7%83%9F%E8%8A%B1%E6%98%93%E5%86%B7";
                Label3.Controls.Add(link);
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                HyperLink link = new HyperLink();
                link.Text = "下雨天";
                link.NavigateUrl = "https://www.kugou.com/mixsong/j7b5t92.html?fromsearch=%E4%B8%8B%E9%9B%A8%E5%A4%A9";
                Label3.Controls.Add(link);
            }            
        }

    }
}