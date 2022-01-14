using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Sprint2
{

    public class RoomLoader
    {

        public XmlNodeList nodeList { get; set; }
        public XmlDocument doc { get; set; }
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0051 // Remove unused private members
      //  private Room room;
#pragma warning restore IDE0051 // Remove unused private members
#pragma warning restore IDE0044 // Add readonly modifier

        public RoomLoader(String fileName)
        {
            XmlReader reader;
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlUrlResolver resolver = new XmlUrlResolver();
            reader = XmlReader.Create(fileName, settings);
#pragma warning disable IDE0017 // Simplify object initialization
#pragma warning disable CA3075 // Insecure DTD processing in XML
            doc = new XmlDocument();
#pragma warning restore CA3075 // Insecure DTD processing in XML
#pragma warning restore IDE0017 // Simplify object initialization
#pragma warning disable CA3075 // Insecure DTD processing in XML
            doc.XmlResolver = resolver;
#pragma warning restore CA3075 // Insecure DTD processing in XML
             
                doc.Load(reader);
             
            reader.Close();

        }
    }
}
