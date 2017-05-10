using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testRest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.WebServiceSetaClient client = new ServiceReference1.WebServiceSetaClient()) {
               this.Label1.Text = client.segunda(Convert.ToInt32(this.TextBox1.Text));
            }
            
        }
    }
}