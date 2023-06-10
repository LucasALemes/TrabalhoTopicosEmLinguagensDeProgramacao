using Biblioteca.Model;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.DAO
{
    public class AutorDao : Conexao
    {
        public List<Autor> Listar(string termoPesquisa)
        {
            return conexao.Query<Autor>("SELECT * FROM Autores where Nome like @termoPesquisa order by Nome",
                new {@termoPesquisa = "%"+termoPesquisa+"%"}).ToList();
        }

        public void Adicionar(Autor autor)
        {
            conexao.Execute("INSERT INTO Autores (Nome) VALUES (@nome)", new
            {
                @nome = autor.Nome
            });
        }

        public void Editar(Autor autor)
        {
            conexao.Execute("UPDATE Autores SET nome=@nome where idAutor=@id", new
            {
                @id = autor.IdAutor,
                @nome = autor.Nome,
            });
        }

        public void Excluir(int id)
        {
            conexao.Execute("DELETE FROM Autores WHERE IdAutor=@id", new
            {
                @id = id,
            });
        }
    }
}
