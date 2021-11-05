using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.Task.Xml.EntidadeBase {

  [XmlRoot("filmes")]
  public class Filmes {
    [XmlElement("filme")]
    public List<Filme> ListaDeFilmes { get; set; }
  }

  public class Elenco {
    [XmlElement("atorAtriz")]
    public List<string> AtorAtriz { get; set; }

    [XmlElement("diretor")]
    public List<string> Diretor { get; set; }
  }


  public class Nota {
    [XmlElement("to")]
    public string Para { get; set; }

    [XmlElement("from")]
    public string Remetente { get; set; }

    [XmlElement("heading")]
    public string Titulo { get; set; }

    [XmlElement("body")]
    public string Mensagem { get; set; }
  }

  public class LinkHere {
    [XmlElement("note")]
    public Nota Nota { get; set; }
  }

  public class Filme {
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement("titulo")]
    public string Titulo { get; set; }

    [XmlElement("resumo")]
    public string Resumo { get; set; }

    [XmlElement("genero")]
    public List<string> Genero { get; set; }

    [XmlElement("elenco")]
    public Elenco Elenco { get; set; }

    [XmlElement("linkhere")]
    public LinkHere linkhere { get; set; }
  }

}
