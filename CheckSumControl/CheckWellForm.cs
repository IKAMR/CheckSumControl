using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CheckSumControl
{
    class CheckWellForm
    {

        public List<string> RunWellFormControl(string folder)
        {
            List<string> results = new List<string>();

            //string[] files = Directory.GetFiles(folder, "*.xml, *.xsd");

            var files = Directory.EnumerateFiles(folder , "*.*").Where(s => s.EndsWith(".xml") || s.EndsWith(".xsd")); 

            foreach (string file in files)
            {
                results.Add(file);

                string response = "";
                XmlReader xmlRd = new XmlTextReader(file);

                try
                {
                    while (xmlRd.Read())
                    {
                        response = "File is well formed";
                    }

                }
                catch (Exception e)
                {
                    response = "File is not well formed: " + e.Message;
                }

                results.Add(response);
                results.Add("");

            }
            return results;
        }
    }
}
