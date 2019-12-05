using System;
using System.Web.UI;


namespace GMAC
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //string name = Request.QueryString["name"];
            //Response.Write("Hello " + name); // Noncompliant
            string name = Request.QueryString["name"];
            name = System.Web.Security.AntiXss.AntiXssEncoder.HtmlEncode(name, true);
            Response.Write("Hello " + name);

        }
    }
}