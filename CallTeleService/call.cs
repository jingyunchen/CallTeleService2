using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace CallTeleService
{
   public  class CallService{
        public static string Calls(string url, string rs)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(url);
            client.Authenticator = new HttpBasicAuthenticator("ContactUSEntry", @"X&W\L-[)5}p)wNTh");

            var request = new RestRequest(Method.GET);
            request.Resource = rs;
            request.AddHeader("X-Api-Token", "ehgyf2e648bf959dd4adb50844cat54j.t!8");

            IRestResponse response = client.Execute(request);
            string jf = response.Content;

            return jf;

        }
    }
    public class ContactUS
    {
        public String Title { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Org { get; set; }
        public String Phone { get; set; }
        public String Country { get; set; }
        public String Subject { get; set; }
        public String SecSubjext { get; set; }
        public String Commnet { get; set; }
        public String DateCreated { get; set; }

    }
}