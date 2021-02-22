//this class is used to serialize objects, write the objects to an xml file,
//add the stylesheet to the xml file, and launch a browser to display the data
//refer to the stylesheet to view/adjust how the data will be displayed
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

class SerializeAndDisplayInBrowser
{
    //constructor for serialization only
    /// <summary>
    /// XML data to file only
    /// </summary>
    /// <param name="objArray"></param>
    /// <param name="fileName"></param>
    public SerializeAndDisplayInBrowser(Object[] objArray, string fileName)
    {
        //call method to serialize the customer objects and write to xml file
        SerializeObjects(objArray, fileName);
                
    }

    //constructor for serialization and adding stylesheet
    /// <summary>
    /// XML data with stylesheet
    /// </summary>
    /// <param name="objArray"></param>
    /// <param name="fileName"></param>
    /// <param name="href"></param>
    public SerializeAndDisplayInBrowser(Object[] objArray, string fileName, string href)
    {
        //call method to serialize the customer objects and write to xml file
        SerializeObjects(objArray, fileName);

        //call method to add the stylesheet to the xml file
        if (href != String.Empty)
        {
            AddStyleSheet(fileName, href);
        }

    }

    //constructor for serialization, adding stylesheet, and launching browser
    /// <summary>
    /// XML and stylesheet, launch browser
    /// </summary>
    /// <param name="objArray"></param>
    /// <param name="fileName"></param>
    /// <param name="href"></param>
    /// <param name="browser"></param>
    /// <param name="xmlFile"></param>
    public SerializeAndDisplayInBrowser(Object[] objArray, string fileName, string href,
                                                    string browser, string xmlFile)
    {
        //call method to serialize the customer objects and write to xml file
        SerializeObjects(objArray, fileName);

        //call method to add the stylesheet to the xml file
        if (href != String.Empty)
        {
            AddStyleSheet(fileName, href);

            //call method to launch a web browser to display data  
            if (browser != String.Empty && xmlFile != String.Empty)
            {
                LaunchBrowser(browser, xmlFile);
            }
        }        

    }

    public static void SerializeObjects(Object[] objArray, string fileName)
    {
        //create an IO stream object for the output file, and an XML serializer
        //object that turns each object into XML format
        StreamWriter strWriter = new StreamWriter(fileName);
        XmlSerializer xmlSer = new XmlSerializer(objArray.GetType());
        
        //write objects out to file in XML format
        xmlSer.Serialize(strWriter, objArray);
        strWriter.Close();
    }

    public static void AddStyleSheet(string fileName, string href)
    {
        //add the stylesheet processing instruction to the .xml file
        XDocument doc = XDocument.Load(fileName);
        var proc = new XProcessingInstruction("xml-stylesheet",
                                    "type=\"text/xsl\"" + " href=\"" + href + "\"");
        doc.Root.AddBeforeSelf(proc);
        doc.Save(fileName);
    }
    
    public static void LaunchBrowser(string browser, string xmlFile)
    {
        //launch a web browser to display data            
        System.Diagnostics.Process.Start(@browser, @xmlFile);       
    }
}

