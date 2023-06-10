using Dapper;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Model;

namespace Biblioteca.DAO
{
    public class EditoraDao : Conexao
    {
        public List<Editora> Listar(string termoPesquisa) => conexao.Query<Editora>("SELECT * FROM Editoras where Nome like @termoPesquisa order by Nome", new { @termoPesquisa = "%" + termoPesquisa + "%" }).ToList();

        public void Adicionar(Editora editora)
        {
            conexao.Execute("INSERT INTO Editoras (Nome) VALUES (@nome)", new
            {
                @nome = editora.Nome
            });
        }

        public void Editar(Editora editora)
        {
            conexao.Execute("UPDATE Editoras SET nome=@nome where idEditora=@id", new
            {
                @id = editora.IdEditora,
                @nome = editora.Nome,
            });
        }

        public void Excluir(int id)
        {
            conexao.Execute("DELETE FROM Editoras WHERE IdEditora=@id", new
            {
                @id = id,
            });
        }
    }
}
