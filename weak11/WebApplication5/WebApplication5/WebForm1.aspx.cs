using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



//根据textbox1和textbox2中的数据来确定学生人数m和科目数n，生成一个gridview，将随机产生m行n列的学生成绩（0-100），将学生成绩动态显示在m*n的gridview中；还能将显示每门课程的最高分和最高分的序号。

        protected void Button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(TextBox1.Text);
            int n = Convert.ToInt32(TextBox2.Text);
            Random r = new Random();
            DataTable dt = new DataTable();
            for (int i = 0; i < n; i++)
            {
                dt.Columns.Add("科目" + (i + 1));
            }
            for (int i = 0; i < m; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < n; j++)
                {
                    dr[j] = r.Next(0, 101);
                }
                dt.Rows.Add(dr);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
            for (int i = 0; i < n; i++)
            {
                int max = 0;
                int index = 0;
                for (int j = 0; j < m; j++)
                {
                    int score = Convert.ToInt32(dt.Rows[j][i]);
                    if (score > max)
                    {
                        max = score;
                        index = j + 1;
                    }
                }
                Response.Write( "科目"+(i+1)+"最高分：" + max + " 序号：" + index +"<br/>");
            }
        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}