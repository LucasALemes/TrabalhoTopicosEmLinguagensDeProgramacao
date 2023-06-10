using System;

namespace Biblioteca.Model
{
    public class Livro
    {
        public int IdLivro { get; set; }
        public Editora Editora { get; set; }
        public string Titulo { get; set; }
        public int Paginas { get; set; }
        public decimal Preco { get; set; }
        public string Edicao { get; set; }
        public int Situacao { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime DataFinalizado { get; set; }
        public byte[] Imagem { get; set; }
        public Autor Autor { get; set; }
        public Genero Genero { get; set; }

        public Livro()
        {
            Editora = new Editora();
            Autor = new Autor();
            Genero = new Genero();
        }
    }
}
