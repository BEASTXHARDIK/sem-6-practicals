using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p26
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Registration Done')</script>");
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Male.Checked || Female.Checked ||Mechanic.Checked)
            {
                args.IsValid = true;
            }
            else 
            {
                args.IsValid = false;
            }

        }
    }
}