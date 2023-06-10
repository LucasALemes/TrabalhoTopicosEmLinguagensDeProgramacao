using System.Data.SqlClient;

namespace Biblioteca.DAO
{
    public class Conexao
    {
        public SqlConnection conexao;
        public Conexao()
        {
            conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True;");
        }
    }
}
