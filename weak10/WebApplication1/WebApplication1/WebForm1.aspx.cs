using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Attributes.Add("type", "password");
        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                //提示textbox1内容为空
                string message = "用户名为空";
                string script = "alert('" + message + "');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else if (string.IsNullOrEmpty(TextBox2.Text))
            {
                //提示textbox2内容为空
                string message = "密码为空";
                string script = "alert('" + message + "');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else{
                if (username != "abc")
                {
                    //弹窗提示用户名错误
                    string message = "用户名错误";
                    string script = "alert('" + message + "');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                }
                else if (password != "123")
                {
                    //弹窗提示密码错误
                    string message = "密码错误";
                    string script = "alert('" + message + "');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }

        }
    }
}