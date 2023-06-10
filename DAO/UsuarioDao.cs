using System.Collections.Generic;
using System.Linq;
using Biblioteca.Model;
using Dapper;

namespace Biblioteca.DAO
{
    public class UsuarioDao : Conexao
    {
        public Usuario Login(string usuario, string senha)
        {
            return conexao.Query<Usuario>("SELECT * FROM Usuarios where Nome = @usuario and senha = @senha",
                new
                {
                    @usuario = usuario, 
                    @senha = senha
                }).FirstOrDefault();
        }

        public void Adicionar(Usuario usuario)
        {
            conexao.Execute("INSERT INTO Usuarios (Nome, senha) VALUES (@usuario, @senha)", new
            {
                @usuario = usuario.Nome,
                @senha = usuario.Senha,
            });
        }

        public void Editar(Usuario usuario)
        {
            conexao.Execute("Update Usuarios set Nome = @usuario, senha = @senha where idUsuario = @id", new
            {
                @usuario = usuario.Nome,
                @senha = usuario.Senha,
                @id = usuario.ID
            });
        }

        public void Excluir(int id)
        {
            conexao.Execute("Delete from Usuarios where @idUsuario = @id", new
            {
                @id= id
            });
        }

        public List<Usuario> Listar(string termoPesquisa)
        {
            return conexao.Query<Usuario>("SELECT IdUsuario as ID, Nome FROM Usuarios where Nome like @termoPesquisa order by Nome",
                new { @termoPesquisa = "%" + termoPesquisa + "%" }).ToList();
        }

        public int QuantidadeDeUsuarios()
        {
            return conexao.Query<int>("SELECT count(*) FROM Usuarios").FirstOrDefault();
        }
    }
}
