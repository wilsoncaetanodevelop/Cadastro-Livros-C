using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.entidades
{
    class Livros
    {

        int id;
        String nomeLivro;
        String nomeAutor;
        String titulo;
        DateTime anoPublicacao;
        int idEditora;

        public int Id { get; set; }
        public String NomeLivro { get; set ;}
        public String NomeAutor {get; set ;}
        public DateTime AnoPublicacao { get; set; }
        public String Titulo { get; set; }
        public int IdEditora { get => idEditora; set => idEditora = value; }
    }
}
