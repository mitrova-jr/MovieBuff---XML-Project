using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Models;
using System.Xml;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Check(string query)
        {
            string url = "http://www.omdbapi.com/?apikey=8ca5ac7f&t=";
            if(query == null) {
                return "{ \"success\": \"false\" }";
            }

            url += query;

            using (var client = new System.Net.Http.HttpClient()) {
                var response = client.GetAsync(url).Result;

                var content = response.Content;
                var rawString = content.ReadAsStringAsync().Result;
                return rawString;
            }
        }

        public void Submit(string first, string last, string movie)
        {
        if (!System.IO.File.Exists("library.xml"))
        {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.NewLineOnAttributes = true;
            using (XmlWriter xmlWriter = XmlWriter.Create("library.xml", xmlWriterSettings))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("List");

                xmlWriter.WriteStartElement("Person");
                xmlWriter.WriteElementString("FirstName", first);
                xmlWriter.WriteElementString("LastName", last);
                xmlWriter.WriteElementString("Movie", movie);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();
                xmlWriter.Close();
            }
        }
        else
        {
            XDocument xDocument = XDocument.Load("library.xml");
            XElement root= xDocument.Element("List");
            IEnumerable<XElement> rows = root.Descendants("Person");
            XElement firstRow= rows.First();
            firstRow.AddBeforeSelf(
                new XElement("Person",
                new XElement("FirstName", first),
                new XElement("LastName", last),
                new XElement("Movie", movie)));
            xDocument.Save("library.xml");
        }
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
