using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace CallTeleService
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             string js= CallService("http://www-dev.telephonics.com", "guestapi3.php");
             string jf=JValue.Parse(js).ToString(Formatting.Indented);
             divHolder.InnerHtml = jf;

            div1.InnerHtml = Regex.Replace(jf, @"\r\n?|\n","<br>");
        }
   

    private string CallService(string url, string rs)
    {
        var client = new RestClient();
        client.BaseUrl = new Uri("http://www-dev.telephonics.com");
        client.Authenticator = new HttpBasicAuthenticator("ContactUSEntry", @"X&W\L-[)5}p)wNTh");

        var request = new RestRequest(Method.GET);
        request.Resource = "guestapi3.php";
        request.AddHeader("X-Api-Token", "ehgyf2e648bf959dd4adb50844cat54j.t!8");

        IRestResponse response = client.Execute(request);
            string jf = response.Content;

        return jf;

    }
    }
  


}