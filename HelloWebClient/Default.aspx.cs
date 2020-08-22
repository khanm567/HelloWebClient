using HelloWebClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWebClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        
     

        protected void Button1_Click1(object sender, EventArgs e)
        {
            HelloServiceClient client = new HelloServiceClient("BasicHttpBinding_IHelloService");
            var message = client.GetMessage(TextBox1.Text);
            Label1.Text = message;
        }
    }
}