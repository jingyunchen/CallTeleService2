using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CallTeleService
{
    public partial class xml2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xml = CallService.Calls("http://www-dev.j2yk-7xbl.accessdomain.com", @"/guestapixml.php/85");
            XmlDataSource1.Data = xml;
            GridView1.DataSource = XmlDataSource1;
            GridView1.DataBind();
        }
    }
}