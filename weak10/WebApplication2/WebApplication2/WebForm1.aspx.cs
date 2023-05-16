using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "重庆师范大学")
            {
                HyperLink link = new HyperLink();
                link.Text = "重庆师范大学";
                link.NavigateUrl = "https://www.cqnu.edu.cn";
                Label3.Controls.Add(link);
            }
            else if(TextBox1.Text == "百度")
            {
                    HyperLink link = new HyperLink();
                    link.Text = "百度";
                    link.NavigateUrl = "https://baidu.com";
                    Label3.Controls.Add(link);
            }
            else if (TextBox1.Text == "新浪")
            {
                HyperLink link = new HyperLink();
                link.Text = "新浪";
                link.NavigateUrl = "https://www.sina.com.cn";
                Label3.Controls.Add(link);
            }
            else if (TextBox1.Text == "搜狐")
            {
                HyperLink link = new HyperLink();
                link.Text = "搜狐";
                link.NavigateUrl = "https://sohu.com";
                Label3.Controls.Add(link);
            }
        }
    }
}