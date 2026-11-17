using ConsultaPaises.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises.DAOs
{
    public abstract class DAOpaises : DAO
    {
        protected SqlConnection cnn;

        public DAOpaises()
        {
            cnn = Banco.AbrirDB();
        }
        public override string CarregaObj(Object obj)
        {
            return null;
        }

        public override string Salvar(Object obj)
        {
            Paises oPais = (Paises)obj;
            string ok = "", sql="";
            if (oPais.Codigo == 0)
            {
                sql = "INSERT INTO paises (pais, sigla, ddi, moeda) " +
                       "VALUES (@pais, @sigla, @ddi, @moeda)";

            }
            else
            {
                sql = "UPDATE paises SET pais = @pais, sigla = @sigla, ddi = @ddi, moeda = @moeda WHERE codigo = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, new SqlConnection()))
            {
                cmd.Parameters.AddWithValue("@pais", oPais.Pais);
                cmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@ddi", oPais.Ddi);
                cmd.Parameters.AddWithValue("@moeda", oPais.Moeda);
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
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
            Paises oPais = (Paises)obj;
            string ok = "", sql = "";
            try
            {
                sql = "DELETE FROM paises WHERE codigo = @codigo";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                    int rows = cmd.ExecuteNonQuery();
                    ok = rows > 0 ? "OK" : "Nenhum registro excluído";
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
