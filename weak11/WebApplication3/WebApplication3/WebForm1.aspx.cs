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

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }






        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
                string password = TextBox5.Text;
                string cheaked_password = TextBox6.Text;
                bool isAlphaNumeric = System.Text.RegularExpressions.Regex.IsMatch(password, @"^[a-zA-Z0-9]+$") && System.Text.RegularExpressions.Regex.IsMatch(cheaked_password, @"^[a-zA-Z0-9]+$");
                if (isAlphaNumeric && password == cheaked_password)
                {
                    // do something
                    string name = TextBox1.Text;
                    int age = Convert.ToInt32(TextBox2.Text);
                    //使用name和age进行后续操作
                    string gender = "";
                    if (RadioButtonList1.SelectedIndex == 0)
                    {
                        gender = "man";
                    }
                    else if (RadioButtonList1.SelectedIndex == 1)
                    {
                        gender = "woman";
                    }


                    string location = TextBox3.Text;
                    string birthday = TextBox7.Text;
                    string username = TextBox4.Text;

                    //在页面提示如下信息变量：
                    //姓名：name
                    //性别：gender
                    //年龄：age
                    //地区：location
                    //出生日期：birthday
                    //用户名：username
                    //密码：password
                    Response.Write("您的注册信息如下：<br/>");
                    Response.Write("姓名：" + name + "<br/>");
                    Response.Write("性别：" + gender + "<br/>");
                    Response.Write("年龄：" + age + "<br/>");
                    Response.Write("地区：" + location + "<br/>");
                    Response.Write("出生日期：" + birthday + "<br/>");
                    Response.Write("用户名：" + username + "<br/>");
                    Response.Write("密码：" + password + "<br/>");
                }
                else
                {
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    if (!isAlphaNumeric)
                    {
                        Response.Write("Username and password must only contain letters and numbers.");
                    }
                    else
                    {
                        Response.Write("Username and password do not match.");
                    }
                }
            

        }
    }
}