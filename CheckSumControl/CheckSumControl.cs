using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace CheckSumControl
{
    class CheckSumControl
    {
        public List<string> RunChecksumControl(string folder, string xmlFileName)
        {

            string filename = Path.GetFileName(xmlFileName);

            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator nodes;

            List<string> results = new List<string>();

            docNav = new XPathDocument(xmlFileName);

            nav = docNav.CreateNavigator();

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(nav.NameTable);
            nsmgr.AddNamespace("a", "http://www.arkivverket.no/standarder/addml");
            nsmgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            string[] files = Directory.GetFiles(folder);

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                //string queryString = "//a:property/a:properties[a:property/a:value = '"+ fileName + "']/a:property/a:properties/a:property[@name = 'value']/a:value";
                string queryString = "//a:property[..//a:value[text() = '" + fileName + "'] and @name = 'checksum']//a:property[@name = 'value']/a:value";
                Console.WriteLine(queryString);
                results.Add(file);

                XPathNavigator node = nav.SelectSingleNode(queryString, nsmgr);

                string result = "";
                if (node != null)
                    result = node.InnerXml;
                results.Add(result);

                results.Add(GetChecksum(file));

                results.Add("");
            }

            return results;
        }

        private string GetChecksum(string filename)
        {
            FileStream filestream;
            SHA256 mySHA256 = SHA256Managed.Create();

            filestream = new FileStream(filename, FileMode.Open) { Position = 0 };

            byte[] hashValue = mySHA256.ComputeHash(filestream);

            string checksum = BitConverter.ToString(hashValue).Replace("-", String.Empty);

            filestream.Close();

            return checksum;
        }
    }
}
