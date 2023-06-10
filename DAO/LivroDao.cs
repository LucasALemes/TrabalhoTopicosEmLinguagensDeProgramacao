using Dapper;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Model;

namespace Biblioteca.DAO
{
    public class LivroDao : Conexao
    {
        public List<Livro> Listar(string termoPesquisa)
        {
            var livros = conexao.Query<Livro, Autor, Genero, Editora, Livro>(
                @"SELECT l.IdLivro as IdLivro, l.Titulo,l.Paginas,l.Preco,l.Edicao,l.Situacao,l.DataCompra,l.DataFinalizado,l.Imagem, 
a.IdAutor, a.Nome, g.IdGenero, g.Descricao, e.IdEditora, e.Nome
                  FROM Livros l
                  INNER JOIN Autores a ON l.IdAutor = a.IdAutor
                  INNER JOIN Generos g ON l.IdGenero = g.IdGenero
                  INNER JOIN Editoras e ON l.IdEditora = e.IdEditora
                  WHERE l.Titulo LIKE @termoPesquisa
                  ORDER BY l.Titulo",

                (livro, autor, genero, editora) =>
                {
                    livro.Autor = autor;
                    livro.Genero = genero;
                    livro.Editora = editora;
                    return livro;
                },

                new { termoPesquisa = "%" + termoPesquisa + "%" },

                splitOn: "IdAutor,IdGenero,IdEditora"
            ).ToList();

            return livros;
        }

        public void Adicionar(Livro livro)
        {
            conexao.Execute("INSERT INTO Livros (IdEditora, Titulo, Paginas, Preco, Edicao, Situacao, DataCompra, DataFinalizado, Imagem, IdAutor, IdGenero) VALUES (@idEditora,@titulo,@paginas,@preco,@edicao,@situacao,@dataCompra,@dataFinalizado,@imagem, @idAutor, @idGenero)", new
            {
                @idEditora = livro.Editora.IdEditora,
                @titulo = livro.Titulo,
                @paginas = livro.Paginas,
                @preco = livro.Preco,
                @edicao = livro.Edicao,
                @situacao = livro.Situacao,
                @dataCompra = livro.DataCompra,
                @dataFinalizado = livro.DataFinalizado, 
                @imagem = livro.Imagem,
                @idAutor = livro.Autor.IdAutor,
                @idGenero = livro.Genero.IdGenero
            });
        }

        public void Editar(Livro livro)
        {
            conexao.Execute("UPDATE Livros SET IdEditora=@idEditora, Titulo=@titulo, Paginas=@paginas, Preco=@preco, Edicao=@edicao, Situacao=@situacao, DataCompra=@dataCompra, DataFinalizado=@dataFinalizado, Imagem=@imagem,idAutor = @idAutor, IdGenero = @idGenero where IdLivro=@id", new
            {
                @id = livro.IdLivro,
                @idEditora = livro.Editora.IdEditora,
                @titulo = livro.Titulo,
                @paginas = livro.Paginas,
                @preco = livro.Preco,
                @edicao = livro.Edicao,
                @situacao = livro.Situacao,
                @dataCompra = livro.DataCompra,
                @dataFinalizado = livro.DataFinalizado,
                @imagem = livro.Imagem,
                @idAutor = livro.Autor.IdAutor,
                @idGenero = livro.Genero.IdGenero
            });
        }

        public void Excluir(int id)
        {
            conexao.Execute("DELETE FROM Livros WHERE IdLivro=@id", new
            {
                @id = id,
            });
        }
    }
}
