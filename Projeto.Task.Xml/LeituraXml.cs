using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Projeto.Task.Xml {
  public static class LeituraXml {
    public static void LerXml(string xmlPathLocation) {
      using(XmlTextReader xmlReader = new XmlTextReader(xmlPathLocation)) {
        while(xmlReader.Read()) {
          if(xmlReader.NodeType.Equals(XmlNodeType.Element)) {
            Console.Write($"<{xmlReader.Name}");
            while(xmlReader.MoveToNextAttribute()) {
              Console.Write($"{xmlReader.Name} = '{xmlReader.Value}'");
            }
            Console.Write(">\n");
          }
          if(xmlReader.NodeType.Equals(XmlNodeType.Text)) {
            if(xmlReader.Value.Count() > 3 && xmlReader.Value.Contains("http")) {
              LerXml(xmlReader.Value);
            } else {
              Console.WriteLine(xmlReader.Value);
            }
          }
          if(xmlReader.NodeType.Equals(XmlNodeType.EndElement)) {
            Console.WriteLine($"</{xmlReader.Name}>");
          }
        }
      }
    }
  }
}
