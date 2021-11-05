using Projeto.Task.Xml.Upgrade.EntidadeBase;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Projeto.Task.Xml.Upgrade {
  public static class ConverterXmlComLinkEmObjeto {
    public static FilmesLink ConverterXml(string xmlName) {
      FilmesLink objeto = null;
      if(string.IsNullOrEmpty(xmlName)) return objeto;
      try {
        using(var filestream = new XmlTextReader(xmlName)) {
          XmlSerializer serializer = new XmlSerializer(typeof(FilmesLink));
          objeto = (FilmesLink)serializer.Deserialize(filestream);
        }
        foreach(var filme in objeto.ListaDeFilmes) {
          XmlSerializer serializer = new XmlSerializer(typeof(Nota));
          using(var newXmlFile = new XmlTextReader(filme.PegarLink)) {
            filme.Nota = (Nota)serializer.Deserialize(newXmlFile);
          }
        }

      } catch(Exception ex) {
        Console.WriteLine($"ERRO! - {DateTime.Now} - Detalhamento: {ex.Message}");
      }
      return objeto;
    }
  }
}
