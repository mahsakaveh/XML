using System;
using System.Xml;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadConfig("C:\\Users\\Schulung\\Desktop\\XML\\sample.xml");
            // String URLString = "https://www.w3schools.com/xml/simple.xml";
            // String localURLString = "C:\\Users\\Schulung\\Desktop\\XML\\sample.xml";

            // XmlTextReader reader = new XmlTextReader (URLString);

            // while (reader.Read())
            // {
            //     switch (reader.NodeType) //node food masalan
            //     {
            //         case XmlNodeType.Element:
            //             Console.Write("<" + reader.Name);

            //             while (reader.MoveToNextAttribute())
            //                 Console.Write(" " + reader.Name + "='" + reader.Value + "'");
            //             Console.Write(">");
            //             Console.WriteLine(">");
            //             break;
            //         case XmlNodeType.Text:
            //             Console.WriteLine(reader.Value);
            //             break;
            //         case XmlNodeType.EndElement:
            //             Console.Write("</" + reader.Name);
            //             Console.WriteLine(">");
            //             break;
            //     } 
            // }

            // XmlDocument doc = new XmlDocument();
            // XmlTextReader reader = new XmlTextReader(localURLString);
            // reader.Read();

            // doc.Load(reader);

            // doc.Save(Console.Out)
           
        }

         public static void ReadConfig(string configFile)
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(configFile);

                // Datenstruktur füllen

                foreach (XmlNode node in xmlDocument.ChildNodes)
                {
                    Console.WriteLine(node.Value);
                    // "node" ansehen. Hat weitere ChildNodes.
                }
            }
    }
}