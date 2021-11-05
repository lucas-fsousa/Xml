using System;
using Projeto.Task.Xml;
using Projeto.Task.Xml.EntidadeBase;
using Projeto.Task.Xml.Upgrade;
using Projeto.Task.Xml.Upgrade.EntidadeBase;

namespace Running {
  class Program {
    static void Main(string[] args) {
      //var rec = ExecutaLeituraXmlRetornaObjeto<Projeto.Task.Xml.Upgrade.EntidadeBase.Nota>(@"C:\Users\Lucas\source\repos\testes\codigo\Bibliotecas\XmlDefinitions\Arquivos\Note.xml");
      var a = ExecutaLeituraXmlComLinkRetornaObjeto(@"C:\Users\Lucas\source\repos\testes\codigo\Bibliotecas\XmlDefinitions\Arquivos\TestXml-Link.xml");
    }

    public static void ExecutarLeituraXml() {
      LeituraXml.LerXml("https://www.w3schools.com/xml/cd_catalog.xml");
    }

    public static T ExecutaLeituraXmlRetornaObjeto<T>(string xmlLocationPath) {
      return ConverterXmlEmObjeto.ConverterXml<T>(xmlLocationPath); 
    }

    public static FilmesLink ExecutaLeituraXmlComLinkRetornaObjeto(string xmlLocationPath) {
      return ConverterXmlComLinkEmObjeto.ConverterXml(xmlLocationPath);
    }
  }
}
