using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises.DAOs
{
    public abstract class DAOCidades : DAO
    {
        public override string CarregaObj(Object obj)
        {
            return null;
        }

        public override string Salvar(Object obj)
        {
            Cidades oCidades = (Cidades)obj;
            string ok = "", sql = "";
            if (oCidades.Codigo == 0)
            {
                sql = "INSERT INTO cidades (cidade, estado_codigo) " +
                       "VALUES (@cidade, @estado_codigo)";

            }
            else
            {
                sql = "UPDATE cidades SET cidade = @cidade, estado_codigo = @estado_codigo WHERE codigo = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, new SqlConnection()))
            {
                cmd.Parameters.AddWithValue("@cidade", oCidades.Cidade);
                cmd.Parameters.AddWithValue("@estado_codigo", oCidades.EstadoCodigo);
                cmd.Parameters.AddWithValue("@codigo", oCidades.Codigo);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@IDENTITY";
                ok = cmd.ExecuteScalar().ToString();
            }
            return ok;
        }

        public override string CarregaTudo(Object obj)
        {
            return null;
        }
        public override string Excluir(Object obj)
        {
            Cidades oCidades = (Cidades)obj;
            string ok = "", sql = "";
            try
            {
                sql = "DELETE FROM cidades WHERE codigo = @codigo";
                using (SqlCommand cmd = new SqlCommand(sql, new SqlConnection()))
                {
                    cmd.Parameters.AddWithValue("@codigo", oCidades.Codigo);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    ok = "OK";
                }
            }
            catch (Exception ex)
            {
                ok = ex.Message;
            }
            return ok;
        }
        public override List<Object> Pesquisar(Object obj)
        {
            return null;
        }
    }
}
