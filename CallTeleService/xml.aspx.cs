using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.IO;

namespace CallTeleService
{
    public partial class xml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xml = CallService.Calls("http://www-dev.j2yk-7xbl.accessdomain.com", @"/guestapixml.php/85");
             formatxml2 (xml);
            div1.InnerText = PrettyXml(xml);
            // Response.Redirect("data.xml");
            // Xml1.DocumentSource = @"C:\Users\Chenj\Documents\Visual Studio 2015\Projects\CallTeleService\CallTeleService\bin/data.xml";
            // Xml1.DocumentContent =  xml;
            //  Xml1.DataBind();
            // div1.InnerHtml = PrettyXml(xml);
            /// test our service

        }
        void formatxml2 (string xml)
    {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            // Save the document to a file and auto-indent the output.
           
            using (XmlTextWriter writer = new XmlTextWriter(@"C:\Users\Chenj\Documents\Visual Studio 2015\Projects\CallTeleService\CallTeleService\data.xml", null))
            {
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
            }
            //return doc.ToString();
        }
        string FormatXml(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch (Exception)
            {
                return xml;
            }
        }
        static string PrettyXml(string xml)
        {
            var stringBuilder = new StringBuilder();

            var element = XElement.Parse(xml);

            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            settings.NewLineOnAttributes = true;

            using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
            {
                element.Save(xmlWriter);
            }

            return stringBuilder.ToString();
        }
    }
}