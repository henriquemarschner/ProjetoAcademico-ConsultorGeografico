using ConsultaPaises.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            using (SqlConnection cnn = Banco.AbrirDB())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo = oPais.Codigo;

                    if (codigo == 0)
                    {
                        const string sql =
                            "INSERT INTO paises (pais, sigla, ddi, moeda) " +
                            "OUTPUT INSERTED.id " +
                            "VALUES (@pais, @sigla, @ddi, @moeda);";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oPais);
                            codigo = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                    else
                    {
                        const string sql =
                            "UPDATE paises SET pais = @pais, sigla = @sigla, ddi = @ddi, moeda = @moeda " +
                            "WHERE id = @codigo";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oPais);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;

                            if (cmd.ExecuteNonQuery() == 0)
                                throw new InvalidOperationException("País não encontrado");
                        }
                    }

                    tx.Commit();
                    oPais.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdicionarParametros(SqlCommand cmd, Paises oPais)
        {
            cmd.Parameters.Add("@pais", SqlDbType.VarChar,50).Value = oPais.Pais;
            cmd.Parameters.Add("@sigla", SqlDbType.VarChar,3).Value = oPais.Sigla;
            cmd.Parameters.Add("@ddi", SqlDbType.VarChar,5).Value = oPais.Ddi;
            cmd.Parameters.Add("@moeda", SqlDbType.VarChar,5).Value = oPais.Moeda;
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
            Paises oPais = (Paises)obj;
            string sql = "SELECT id, pais, sigla, ddi, moeda FROM paises";
            if (oPais.Pais == "")
                sql = "SELECT * FROM paises";
            else
                sql = "SELECT id, pais, sigla, ddi, moeda FROM paises WHERE pais LIKE @pesquisa";
            var lista = new List<Object>();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    if (oPais.Pais != "")
                        cmd.Parameters.AddWithValue("@pesquisa", oPais.Pais + "%");
                    using (SqlDataReader dr = cmd.ExecuteReader())

                {
                    while (dr.Read())
                    {
                        lista.Add(new Paises
                        {
                            Codigo = Convert.ToInt32(dr["id"]),
                            Pais = dr["pais"].ToString(),
                            Sigla = dr["sigla"].ToString(),
                            Ddi = dr["ddi"].ToString(),
                            Moeda = dr["moeda"].ToString()
                        });
                    }
                }
                }
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return lista;
        }

        public string CarregarObj(object obj)
        {
            Paises oPais = (Paises)obj;
            const string sql = "SELECT * FROM paises WHERE id = @codigo";

            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                using (var cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            oPais.Codigo = Convert.ToInt32(dr["id"]);
                            oPais.Pais = dr["pais"].ToString();
                            oPais.Sigla = dr["sigla"].ToString();
                            oPais.Ddi = dr["ddi"].ToString();
                            oPais.Moeda = dr["moeda"].ToString();
                        }
                    }
                }
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return null;
        }
    }
}
