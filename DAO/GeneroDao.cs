using Dapper;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Model;

namespace Biblioteca.DAO
{
    public class GeneroDao : Conexao
    {
        public List<Genero> Listar(string termoPesquisa) => conexao.Query<Genero>
            ("SELECT * FROM Generos where Descricao like @termoPesquisa order by Descricao",
            new { @termoPesquisa = "%" + termoPesquisa + "%" }).ToList();

        public void Adicionar(Genero genero)
        {
            conexao.Execute("INSERT INTO Generos (descricao) VALUES (@descricao)", new
            {
                @descricao = genero.Descricao
            });
        }

        public void Editar(Genero genero)
        {
            conexao.Execute("UPDATE Generos SET descricao=@descricao where idGenero=@id", new
            {
                @id = genero.IdGenero,
                @descricao = genero.Descricao,
            });
        }

        public void Excluir(int id)
        {
            conexao.Execute("DELETE FROM Generos WHERE IdGenero=@id", new
            {
                @id = id,
            });
        }
    }
}
