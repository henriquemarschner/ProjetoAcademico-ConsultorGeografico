using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises.DAOs
{
    public abstract class DAOestados : DAO
    {
        public override string CarregaObj(Object obj)
        {
            return null;
        }

        public override string Salvar(Object obj)
        {
            Estados oEstado = (Estados)obj;
            string ok = "", sql = "";
            if (oEstado.Codigo == 0)
            {
                sql = "INSERT INTO estados (estado, sigla, pais_codigo) " +
                       "VALUES (@estado, @sigla, @pais_codigo)";

            }
            else
            {
                sql = "UPDATE estados SET estado = @estado, sigla = @sigla, pais_codigo = @pais_codigo WHERE codigo = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, new SqlConnection()))
            {
                cmd.Parameters.AddWithValue("@estado", oEstado.Estado);
                cmd.Parameters.AddWithValue("@sigla", oEstado.Sigla);
                cmd.Parameters.AddWithValue("@pais_codigo", oEstado.PaisCodigo);
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
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
            Estados oEstado = (Estados)obj;
            string ok = "", sql = "";
            try
            {
                sql = "DELETE FROM estados WHERE codigo = @codigo";
            }


        }
        public override List<Object> Pesquisar(Object obj)
        {
            return null;
        }
    }
}
