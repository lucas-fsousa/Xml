using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Projeto.Task.Xml {
  public static class ConverterXmlEmObjeto {
    public static T ConverterXml<T>(string xmlName) {
      T objeto = default(T);
      if(string.IsNullOrEmpty(xmlName)) return objeto;
      try {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using(var filestream = new XmlTextReader(xmlName)) {
          objeto = (T) serializer.Deserialize(filestream);
        }
      } catch(Exception ex) {
        Console.WriteLine($"ERRO! - {DateTime.Now} - Detalhamento: {ex.Message}");
      }
      return objeto;
    }
  }
}
