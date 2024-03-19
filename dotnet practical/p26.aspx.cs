using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dotnetsession
{
    public partial class prac26 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void click_me_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('hello :"+Txt1.Text+"')</script>");
        }
    }
}